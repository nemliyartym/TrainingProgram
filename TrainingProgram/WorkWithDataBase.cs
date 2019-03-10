using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TrainingProgram
{
    class WorkWithDataBase
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Sport;Integrated Security=True";

        /// <summary>
        /// Делает sql запрос
        /// </summary>
        /// <returns>возвращает все значения, которые были указзанны в поле select</returns>
        public string[] SelectFromDataBase (string sqlSelect)
        {
            string[] result = null;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlSelect, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                result = new string[sqlDataReader.FieldCount];

                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        for (int i = 0; i < sqlDataReader.FieldCount; i++)
                        {
                            if (sqlDataReader.GetValue(i) != DBNull.Value)
                                result[i] = sqlDataReader.GetValue(i).ToString();
                            else result[i] = null;
                        }
                    }
                }
                
            }

                return result;
        }


        public void UpdateDescriptionExercises (string newDescription, int id)
        {           
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("update Exercises set description = @description where idExercises = " + id, sqlConnection);

                sqlCommand.Parameters.Add("@description", SqlDbType.NVarChar, 2000);
                sqlCommand.Parameters["@description"].Value = newDescription;
                sqlCommand.ExecuteNonQuery();
            }
        }
  

    }
}
