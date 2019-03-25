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

        protected string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Sport;Integrated Security=True";

        /// <summary>
        /// Делает sql запрос
        /// </summary>
        /// <returns>возвращает все значения, которые были указзанны в поле select</returns>
        /// 
        public string[,] SelectFromDataBase (string sqlSelect, int countRows)
        {
            string[,] result = null;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlSelect, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    result = new string[countRows, sqlDataReader.FieldCount];
                    int i = 0;
                    while (sqlDataReader.Read())
                    {
                        for (int j = 0; j < sqlDataReader.FieldCount; j++)
                        {
                            if (sqlDataReader.GetValue(j) != DBNull.Value)
                                result[i, j] = sqlDataReader.GetValue(j).ToString();
                            else result[i, j] = null;
                        }
                        i++;
                    }
                }
                
            }
            return result;
        }


        public int SelectCountFromDataBase (string sqlSelect)
        {
            int result = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlSelect, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        result = Convert.ToInt32(sqlDataReader.GetValue(0));
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

                sqlCommand.Parameters.Add("@description", SqlDbType.NVarChar, 2000).Value = newDescription;
                //sqlCommand.Parameters["@description"].Value = newDescription;
                sqlCommand.ExecuteNonQuery();
            }
        }


        public void UpdateNameExercises(string newExercises, int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("update Exercises set exercises = @exercises where idExercises = " + id, sqlConnection);

                sqlCommand.Parameters.Add("@exercises", SqlDbType.NVarChar, 2000).Value = newExercises;
                //sqlCommand.Parameters["@exercises"].Value = newExercises;
                sqlCommand.ExecuteNonQuery();
            }
        }

    }

    class WorkWithTrainigProgram : WorkWithDataBase
    {
        public void InsertExercisesInTrainigProgram(int idDaysWeek, int idExercises, int idUsers)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into TrainingProgram values(@idDaysWeek,@idExercises,@idUsers)",sqlConnection);

                sqlCommand.Parameters.Add("@idDaysWeek", SqlDbType.Int, Int32.MaxValue).Value = idDaysWeek + 1;
                sqlCommand.Parameters.Add("@idExercises", SqlDbType.Int, Int32.MaxValue).Value = idExercises;
                sqlCommand.Parameters.Add("@idUsers", SqlDbType.Int, Int32.MaxValue).Value = idUsers;
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void DeleteExercisesFromTrainigProgram(int idDelete)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("delete from TrainingProgram where idTrainingProgram =" + idDelete, sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
