using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

using Oracle.ManagedDataAccess.Types;

namespace DAL
{
    public class GroupsTabDal : BaseDal
    {

        private const string JK_GROUP_SEQ = "JK_GROUP_SEQ";
        
        private const string SQL_INSERT_WORD_TO_GROUP = @"
        INSERT INTO word_in_group
        (group_id, text)
        VALUES
        (:ID, :WORD)";

        private const string SQL_INSERT_NEW_GROUP = @"
        INSERT INTO jk_group
        (id, name)
        VALUES
        (:ID, :NAME)";

        private const string SQL_GET_GROUPS = @"
        SELECT * 
        FROM jk_group";

        private const string SQL_GET_WORDS_IN_GROUP = @"
        SELECT text
        FROM word_in_group
        WHERE group_id = :ID";



        public void SaveNewGroup(string gropName)
        {
            using (var conn = CreateConnection())
            {
                var groupId = this.NextVal(JK_GROUP_SEQ,conn);

                var cmd = new OracleCommand(SQL_INSERT_NEW_GROUP, conn);

                cmd.Parameters.Add("ID", groupId);
                cmd.Parameters.Add("NAME", gropName);

                var returnVal = cmd.ExecuteNonQuery();

                if (returnVal != 1)
                {
                    throw new Exception("Failed to insert group");
               
                }
               

            }
        }

        public void SaveWordToGroup(int groupId , string word)
        {
            using (var conn = CreateConnection())
            {
               

                var cmd = new OracleCommand(SQL_INSERT_WORD_TO_GROUP, conn);

                cmd.Parameters.Add("ID", groupId);
                cmd.Parameters.Add("WORD", word);

                var returnVal = cmd.ExecuteNonQuery();

                if (returnVal != 1)
                {
                     throw new Exception("Failed to insert word");
               
                }
             

            }
        }

        public Dictionary<int,string> getGroups()
        {

            using (var conn = CreateConnection())
            {

                var cmd = new OracleCommand(SQL_GET_GROUPS, conn);
                cmd.CommandType = System.Data.CommandType.Text;


       //         var returnVal = cmd.ExecuteNonQuery();
                OracleDataReader dr = cmd.ExecuteReader();
                Dictionary<int, string> groups = new Dictionary<int, string>();
                while (dr.Read())
                    groups.Add(int.Parse(dr["id"].ToString()), dr["name"].ToString());

                return groups;
            }
        }

        public List<string> getWordsInGroup(int id)
        {

            using (var conn = CreateConnection())
            {
              
                var cmd = new OracleCommand(SQL_GET_WORDS_IN_GROUP, conn);
                cmd.Parameters.Add("ID", id);

                cmd.CommandType = System.Data.CommandType.Text;
                List<string> words = new List<string>();
                try
                {
                    OracleDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                        words.Add(dr["text"].ToString());
                    return words;

                }
                catch(Exception exp)
                {
                    throw exp;
                }
            

               
            }

         }
    }
}
