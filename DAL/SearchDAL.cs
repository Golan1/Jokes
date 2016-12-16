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
@"SELECT /*+ LEADING(wij) */
wij.joke_id as joke_id, wij.index_in_joke as first_index, 
f.title as file_title, j.joke_index as joke_index, wij.line_index as line_index, f.id as file_id, '{1}' as SEARCH_TEXT
FROM word_in_joke wij 
INNER JOIN joke j ON j.id = wij.joke_id
INNER JOIN jk_file f ON f.id = j.file_id
WHERE wij.text_for_search = '{0}'";

        const string SQL_SEARCH_TEXT_REST =
@" EXISTS (SELECT 0
		   FROM word_in_joke inner 
		   WHERE inner.joke_id = wij.joke_id 
		   AND inner.index_in_joke = wij.index_in_joke + {1}
           AND inner.text_for_search = '{0}')";

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
            var words = searchText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(x => StripWord(x).ToUpper()).ToList();

            if (words.Count < 1)
            {
                throw new Exception("Error on striping words for search");
            }

            string first = words[0];

            command = string.Format(SQL_SEARCH_TEXT_FIRST, first, string.Join(" ", words));

            if (words.Count > 1)
            {
                for (int i = 1; i < words.Count; i++)
                {
                    command += "\nAND ";
                    command += string.Format(SQL_SEARCH_TEXT_REST, words[i], i);
                }
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
