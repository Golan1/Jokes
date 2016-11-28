using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class RelationsTabDal : BaseDal
    {




        private const string SQL_INSERT_RElATION = @"
        INSERT INTO relation
        (name, word1 , word2)
        VALUES
        (:NAME, :WORD1, :WORD2)";




    
        
    }
}
