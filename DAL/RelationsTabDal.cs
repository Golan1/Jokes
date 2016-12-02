using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
namespace DAL
{
    public class RelationsTabDal : BaseDal
    {


        private const string JK_RELATION_SEQ = "JK_RELATION_SEQ";

        private const string SQL_INSERT_RElATION = @"
        INSERT INTO jk_relation
        (id, name)
        VALUES
        (:ID, :NAME)";

        private const string SQL_INSERT_TUPPLE_TO_RELATION = @"
        INSERT INTO tupple_in_relation
        (relation_id, word1, word2)
        VALUES
        (:ID, :WORD1, :WORD2)";

        private const string SQL_GET_RELATIONSS = @"
        SELECT * 
        FROM jk_relation";

        private const string SQL_GET_TUPPLES_IN_RELATION = @"
        SELECT word1 , word2
        FROM tupple_in_relation
        WHERE relation_id = :ID";

        public void saveNewRelation(string name)
        {
            using (var conn = CreateConnection())
            {
                var relationId = this.NextVal(JK_RELATION_SEQ, conn);

                var cmd = new OracleCommand(SQL_INSERT_RElATION, conn);

                cmd.Parameters.Add("ID", relationId);
                cmd.Parameters.Add("NAME", name);

                var returnVal = cmd.ExecuteNonQuery();

                if (returnVal != 1)
                {
                    throw new Exception("Failed to insert relation");

                }


            }
        }

        public void saveTuppleToRelation(string word1, string word2, int relationId)
        {
            using (var conn = CreateConnection())
            {
                var cmd = new OracleCommand(SQL_INSERT_TUPPLE_TO_RELATION, conn);

                cmd.Parameters.Add("ID", relationId);
                cmd.Parameters.Add("WORD1", word1);
                cmd.Parameters.Add("WORD2", word2);

                var returnVal = cmd.ExecuteNonQuery();

                if (returnVal != 1)
                {
                    throw new Exception("Failed to insert tupple");

                }


            }
        }

        public Dictionary<int, string> getRelations()
        {
            using (var conn = CreateConnection())
            {

                var cmd = new OracleCommand(SQL_GET_RELATIONSS, conn);
                cmd.CommandType = System.Data.CommandType.Text;


                OracleDataReader dr = cmd.ExecuteReader();
                Dictionary<int, string> relations = new Dictionary<int, string>();
                while (dr.Read())
                    relations.Add(int.Parse(dr["id"].ToString()), dr["name"].ToString());

                return relations;
            }
        }

        public List <Tuple<string,string>> getTupplesInRelation (int id)
        {
            using (var conn = CreateConnection())
            {

                var cmd = new OracleCommand(SQL_GET_TUPPLES_IN_RELATION, conn);
                cmd.Parameters.Add("ID", id);

                cmd.CommandType = System.Data.CommandType.Text;
                List < Tuple <string,string>> tupples = new List<Tuple<string,string>>();
                try
                {
                    OracleDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                        tupples.Add(new Tuple<string,string>( dr["word1"].ToString(), dr["word2"].ToString()));
                    return tupples;

                }
                catch (Exception exp)
                {
                    throw exp;
                }



            }
        }
    }
}
