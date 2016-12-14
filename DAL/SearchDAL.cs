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
@"SELECT firsts.joke_id as joke_id, firsts.first_index as first_index, 
f.title as file_title, j.joke_index as joke_index, firsts.line_index as line_index, f.id as file_id
FROM (SELECT index_in_joke as first_index, joke_id, line_index
		FROM word_in_joke 
		WHERE text_for_search = '{0}') firsts
INNER JOIN joke j ON j.id = firsts.joke_id
INNER JOIN jk_file f ON f.id = j.file_id";

        const string SQL_SEARCH_TEXT_REST =
@"'{0}' = (SELECT text_for_search 
					FROM word_in_joke inner 
					WHERE inner.joke_id = firsts.joke_id 
					AND inner.index_in_joke = firsts.first_index + {1})";

        public IEnumerable<string> GetSearchHistory()
        {
            var adapter = new JokesDSTableAdapters.JK_SEARCH_HISTORYTableAdapter();
            var data = adapter.GetData();
            return data.AsEnumerable().Select(x => x.TEXT);
        }

        public JokesDS.SEARCH_RESULTDataTable GetSearchResults(string searchTextStrings)
        {
            using (var conn = CreateConnection())
            {
                var adapter = new OracleDataAdapter(new OracleCommand(BuildMultipleSearchCommands(searchTextStrings), conn));
                DS.SEARCH_RESULT.Clear();
                adapter.Fill(DS.SEARCH_RESULT);
            }

            return DS.SEARCH_RESULT;
        }
        
        private string BuildMultipleSearchCommands(string searchTextStrings)
        {
            var searchStrings = searchTextStrings.Split(new string[] { "||" }, StringSplitOptions.RemoveEmptyEntries);

            var totalSeachCommand = string.Join(" UNION ALL ", searchStrings.Select(x => BuildSearchCommand(x)));

            return totalSeachCommand;
            
        }

        private string BuildSearchCommand(string searchText)
        {
            // Escape '
            searchText = searchText.Replace("\'", "\'\'");

            // Re esacape ||
            searchText = searchText.Replace("\\|", "|");


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

                command = command.Remove(command.Length - 5);
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
