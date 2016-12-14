using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    public class StatisticsTabDal: BaseDal
    {

        private const string SQL_MOST_COMM = @" 
        SELECT * FROM (SELECT COunt (*) as times, TEXT_FOR_SEARCH as text
        from WORD_IN_JOKE
        GROUP BY TEXT_FOR_SEARCH
        ORDER BY times DESC)
        WHERE ROWNUM =1";


        private const string SQL_AVG_WORDS_FILE = @"
        SELECT AVG(COUNT(*)) as wordsNum
        from WORD_IN_JOKE wij
        JOIN joke j  ON j.ID = wij.JOKE_ID
        JOIN jk_file  f ON j.FILE_ID = f.ID
        GROUP BY f.ID";
 

        private const string SQL_MAX_WORDS_FILE = @"
        SELECT COUNT(*) as wordsNum, f.ID as fileId
        from WORD_IN_JOKE wij
        JOIN joke j  ON j.ID = wij.JOKE_ID
        JOIN jk_file  f ON j.FILE_ID = f.ID
        GROUP BY f.ID
        ORDER BY  wordsNum DESC";

        private const string SQL_MIN_WORDS_FILE = @"
        SELECT COUNT(*) as wordsNum, f.ID as fileId
        from WORD_IN_JOKE wij
        JOIN joke j  ON j.ID = wij.JOKE_ID
        JOIN jk_file  f ON j.FILE_ID = f.ID
        GROUP BY f.ID
        ORDER BY  wordsNum";


        private const string SQL_AVG_WORDS_JOKE = @"
        SELECT AVG(COUNT(*)) as wordsNum
        from WORD_IN_JOKE wij
        JOIN joke j  ON j.ID = wij.JOKE_ID
        GROUP BY j.ID";



        private const string SQL_MAX_WORDS_JOKE = @"
        SELECT COUNT(*) as wordsNum, j.ID as jokeId
        from WORD_IN_JOKE wij
        JOIN joke j  ON j.ID = wij.JOKE_ID
        GROUP BY j.ID
        ORDER BY  wordsNum DESC";

        private const string SQL_MIN_WORDS_JOKE = @"
        SELECT COUNT(*) as wordsNum, j.ID as jokeId
        from WORD_IN_JOKE wij
        JOIN joke j  ON j.ID = wij.JOKE_ID
        GROUP BY j.ID
        ORDER BY  wordsNum";

        private const string SQL_SHORT_WORD = @"
        SELECT * from (SELECT  length(text) as textLength , text
        from WORD_IN_JOKE
        ORDER BY textLength)
        WHERE ROWNUM=1";

        private const string SQL_LONG_WORD = @"
        SELECT * from (SELECT  length(text) as textLength , text
        from WORD_IN_JOKE
        ORDER BY textLength DESC)
        WHERE ROWNUM=1";

        private const string SQL_AVG_WORD = @"
        SELECT  AVG(length(text)) as textLength
        from WORD_IN_JOKE";




        public Tuple<string, string> mostComm()
        {
            using (var conn = CreateConnection())
            {
                var cmd = new OracleCommand(SQL_MOST_COMM, conn);
                try
                {
                    OracleDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    return new Tuple<string, string>(dr["times"].ToString(), dr["text"].ToString());
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }
        }
        public Tuple<string, string> longestWord()
        {
            using (var conn = CreateConnection())
            {
                var cmd = new OracleCommand(SQL_LONG_WORD, conn);
                try
                {
                    OracleDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    return new Tuple<string, string>(dr["textLength"].ToString(), dr["text"].ToString());
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }
        }

        public Tuple<string, string> shortestWord()
        {
            using (var conn = CreateConnection())
            {
                var cmd = new OracleCommand(SQL_SHORT_WORD, conn);
                try
                {
                    OracleDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    return new Tuple<string, string>(dr["textLength"].ToString(), dr["text"].ToString());
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }
        }

        public string avg_word()
        {
            using (var conn = CreateConnection())
            {
                var cmd = new OracleCommand(SQL_AVG_WORD, conn);
                try
                {
                    OracleDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    return dr.GetInt32(0).ToString();
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }
        }

        public Tuple<string, string> max_words_joke()
        {
            using (var conn = CreateConnection())
            {
                var cmd = new OracleCommand(SQL_MAX_WORDS_JOKE, conn);
                try
                {
                    OracleDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    return new Tuple<string, string>(dr["wordsNum"].ToString(), dr["jokeId"].ToString());
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }
        }

        public Tuple<string, string> min_words_joke()
        {
            using (var conn = CreateConnection())
            {
                var cmd = new OracleCommand(SQL_MIN_WORDS_JOKE, conn);
                try
                {
                    OracleDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    return new Tuple<string, string>(dr["wordsNum"].ToString(), dr["jokeId"].ToString());
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }
        }

        public string avg_words_joke()
        {
            using (var conn = CreateConnection())
            {
                var cmd = new OracleCommand(SQL_AVG_WORDS_JOKE, conn);
                try
                {
                    OracleDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    return dr["wordsNum"].ToString();
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }
        }

        public  Tuple<string, string> max_words_file ()
        {
            using (var conn = CreateConnection())
            {
                var cmd = new OracleCommand(SQL_MAX_WORDS_FILE, conn);
                try
                {
                    OracleDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    return new Tuple<string, string>(dr["wordsNum"].ToString(), dr["fileId"].ToString());                  
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }
        }

        public Tuple<string, string> min_words_file()
        {
            using (var conn = CreateConnection())
            {
                var cmd = new OracleCommand(SQL_MIN_WORDS_FILE, conn);
                try
                {
                    OracleDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    return new Tuple<string, string>(dr["wordsNum"].ToString(), dr["fileId"].ToString());
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }
        }

        public  string avg_words_file()
        {
            using (var conn = CreateConnection())
            {
                var cmd = new OracleCommand(SQL_MIN_WORDS_FILE, conn);
                try
                {
                    OracleDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    return dr["wordsNum"].ToString();
                }
                catch (Exception exp)
                {
                    throw exp;
                }
            }
        }


    }
}
