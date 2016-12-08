using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SearchDal : BaseDal
    {
        const string SQL_INSERT_TO_HISTORY = "INSERT INTO jk_search_history (TEXT) VALUES (:TEXT)";

        const string SQL_SEARCH_TEXT_FIRST =
@"SELECT joke_id, first_index
FROM (SELECT index_in_joke as first_index, joke_id 
		FROM word_in_joke 
		WHERE word = '{0}') firsts";

        const string SQL_SEARCH_TEXT_REST =
@"'{0}' = (SELECT word 
					FROM word_in_joke inner 
					WHERE inner.joke_id = firsts.joke_id 
					AND inner.index_in_joke = firsts.first_index + {1})";

        public IEnumerable<string> GetSearchHistory()
        {
            JokesDSTableAdapters.JK_PHRASE_TABLETableAdapter adapter = new JokesDSTableAdapters.JK_PHRASE_TABLETableAdapter();
            var data = adapter.GetData();
            return data.AsEnumerable().Select<JokesDS.JK_PHRASE_TABLERow, string>(x => x.TEXT);
        }

        public JokesDS.SEARCH_RESULTDataTable GetSearchResults(string searchText)
        {
            using (var conn = CreateConnection())
            {
                JokesDS.SEARCH_RESULTDataTable x = new JokesDS.SEARCH_RESULTDataTable();

                var adapter = new OracleDataAdapter(new OracleCommand(BuildSearchCommand(searchText), conn));
                adapter.Fill(DS.SEARCH_RESULT);
            }
            return DS.SEARCH_RESULT;
        }

        private string BuildSearchCommand(string searchText)
        {
            string command = "";
            var words = searchText.Split(' ').Select(x => StripWord(x).ToUpper()).ToList();

            if (words.Count < 1)
            {
                throw new Exception("Error on striping words for search");
            }

            string first = words[0];

            command = string.Format(SQL_SEARCH_TEXT_FIRST, first);

            if (words.Count > 1)
            {
                command += " WHERE ";
                for (int i = 1; i < words.Count; i++)
                {
                    command += string.Format(SQL_SEARCH_TEXT_REST, words[i], i);
                    command += " AND ";
                }

                command.Remove(command.Length - 5);
            }

            return command;
        }

        public void AddToSearchHistory(string text)
        {
            using (var conn = CreateConnection())
            {
                var cmd = new OracleCommand(SQL_INSERT_TO_HISTORY, conn);
                cmd.Parameters.Add("TEXT", text);

                var returnVal = cmd.ExecuteNonQuery();

                if (returnVal != 1)
                {
                    throw new Exception("Failed to save into history");
                }
            }
        }
    }
}
