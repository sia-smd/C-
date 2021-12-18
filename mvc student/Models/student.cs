using Microsoft.AspNetCore.Mvc;
using System;
using Dapper;
using System.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;

namespace student
{
    static class study
    {
       

        public static List<vm_student> select_st()
        {
            string conection = "Data source =.;initial catalog =sia;integrated security =true";

            using (SqlConnection db = new SqlConnection(conection))
            {
                
               var st=db.Query<vm_student>("SELECT * FROM dbo.student").ToList();
                
              return st;
            }
        }
    }
    class vm_student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
    }
}