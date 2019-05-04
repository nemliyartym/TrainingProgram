using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

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
                        if (i == countRows) break;
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

        public int SelectExists(string sqlSelect)
        {
            int result;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlSelect, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
               
                if (sqlDataReader.HasRows)
                    result = 1;
                else result = 0;
                return result;
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

    class WorkWithUsers : WorkWithDataBase
    {
        public void InsertUser (string firstName, string lastName, string gender, DateTime dateOfBirth)
        {
            if (SelectExists("select idUsers from Users where exists (select * from Users where  firstName = '" + firstName + "' and lastName = '" + lastName + "' and dateOfBirth = '" + dateOfBirth + "')") == 1)
            {
                MessageBox.Show("Пользователь уже есть в БД!");
                Console.WriteLine("Пользователь уже есть в БД");
                return;
            }
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into Users values(@firstName,@lastName,@gender, @dateOfBirth)", sqlConnection);

                sqlCommand.Parameters.Add("@firstName", SqlDbType.VarChar, 50).Value = firstName;
                sqlCommand.Parameters.Add("@lastName", SqlDbType.VarChar, 50).Value = lastName;
                sqlCommand.Parameters.Add("@gender", SqlDbType.VarChar, 50).Value = gender;
                sqlCommand.Parameters.Add("@dateOfBirth", SqlDbType.Date, 50).Value = dateOfBirth;
                sqlCommand.ExecuteNonQuery();

                Console.WriteLine("insert into Users values("+ firstName + ","+ lastName + ","+gender+","+dateOfBirth+")");
            }         
        }

        public void InsertStatisticsUser (int idUsers,int puls, int pressureUp, int pressureDown, int growth, int weigth, int age, int pullUps, int pushUp, float run100m, int squts, int press, float cPhc, float cPwc)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into StatisticsUsers values(@idUsers,@puls,@pressureUp,@pressureDown,@growth,@weigth,@age,@pullUps,@pushUp,@run100m,@squts,@press,@cPhc,@cPwc,@dateTime)", sqlConnection);

                sqlCommand.Parameters.Add("@idUsers", SqlDbType.Int, Int32.MaxValue).Value = idUsers;
                sqlCommand.Parameters.Add("@puls", SqlDbType.Int, Int32.MaxValue).Value = puls;
                sqlCommand.Parameters.Add("@pressureUp", SqlDbType.Int, Int32.MaxValue).Value = pressureUp;
                sqlCommand.Parameters.Add("@pressureDown", SqlDbType.Int, Int32.MaxValue).Value = pressureDown;
                sqlCommand.Parameters.Add("@growth", SqlDbType.Int, Int32.MaxValue).Value = growth;
                sqlCommand.Parameters.Add("@weigth", SqlDbType.Int, Int32.MaxValue).Value = weigth;
                sqlCommand.Parameters.Add("@age", SqlDbType.Int, Int32.MaxValue).Value = age;
                sqlCommand.Parameters.Add("@pullUps", SqlDbType.Int, Int32.MaxValue).Value = pullUps;
                sqlCommand.Parameters.Add("@pushUp", SqlDbType.Int, Int32.MaxValue).Value = pushUp;
                sqlCommand.Parameters.Add("@run100m", SqlDbType.Float).Value = run100m;
                sqlCommand.Parameters.Add("@squts", SqlDbType.Int, Int32.MaxValue).Value = squts;
                sqlCommand.Parameters.Add("@press", SqlDbType.Int, Int32.MaxValue).Value = press;
                sqlCommand.Parameters.Add("@cPhc", SqlDbType.Float).Value = cPhc;
                sqlCommand.Parameters.Add("@cPwc", SqlDbType.Float).Value = cPwc;
                sqlCommand.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = DateTime.Now;
                sqlCommand.ExecuteNonQuery();
            }
        }
    }

    class WorkWithTrainigProgram : WorkWithDataBase
    {
        public void InsertTrainigProgram(int idUser, string nameTP, int durationTP, int lvlTP)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into TrainingProgram values(@idUser,@nameTP,@durationTP, @lvlTP)", sqlConnection);

                sqlCommand.Parameters.Add("@idUser", SqlDbType.Int, Int32.MaxValue).Value = idUser;
                sqlCommand.Parameters.Add("@nameTP", SqlDbType.VarChar, 50).Value = nameTP;
                sqlCommand.Parameters.Add("@durationTP", SqlDbType.Int, Int32.MaxValue).Value = durationTP;
                sqlCommand.Parameters.Add("@lvlTP", SqlDbType.Int, Int32.MaxValue).Value = lvlTP;
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void InsertExercisesForTrainigProgram(int idTrainingProgram, int idExercises, int idDaysWeek)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into ExercisesForTP values(@idTrainingProgram,@idExercises,@idDaysWeek)", sqlConnection);

                sqlCommand.Parameters.Add("@idTrainingProgram", SqlDbType.Int, Int32.MaxValue).Value = idTrainingProgram;
                sqlCommand.Parameters.Add("@idExercises", SqlDbType.Int, Int32.MaxValue).Value = idExercises;
                sqlCommand.Parameters.Add("@idDaysWeek", SqlDbType.Int, Int32.MaxValue).Value = idDaysWeek;
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void DeleteExercisesFromTrainigProgram(int idDelete)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("delete from ExercisesForTP where idExercisesFromTP =" + idDelete, sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
