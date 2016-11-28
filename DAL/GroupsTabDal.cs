using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DAL
{
    class GroupsTabDal : BaseDal
    {

        private const string JK_GROUP_SEQ = "JK_GROUP_SEQ";
        
        private const string SQL_INSERT_WORD_TO_GROUP = @"
        INSERT INTO word_in_group
        (group_id, text)
        VALUES
        (:ID, :WORD)";

        private const string SQL_INSERT_NEW_GROUP = @"
        INSERT INTO jk_group
        (group_id, text)
        VALUES
        (:ID, :NAME)";

        private const string sql_get_groups = @"
        SELECT * 
        FROM jk_group";

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



    }
}
