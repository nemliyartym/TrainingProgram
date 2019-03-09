using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace TrainingProgram
{

    class WorkWithImages
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Sport;Integrated Security=True";

        /// <summary>
        /// Сохраняет изображение в бд, кодировая в его байты 
        /// </summary>
        public void SaveImageToDatbase(string pathToImage, int id)
        {
            string sqlInsertInto;
            string fileName = null;
            byte[] imageData = null;

            if (RecordExists(id) == 1)
            {
                sqlInsertInto = "update ImagesForExercises set imageName=@imageName, imageData=@imageData where idExercises = " + id;
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlInsertInto, sqlConnection);
                    sqlCommand.Parameters.Add("@imageName", SqlDbType.NVarChar, 50);
                    sqlCommand.Parameters.Add("@imageData", SqlDbType.Image, 4000000);

                    fileName = pathToImage.Substring(pathToImage.LastIndexOf('\\') + 1);
                    using (System.IO.FileStream fileStream = new System.IO.FileStream(pathToImage, System.IO.FileMode.Open))
                    {
                        imageData = new byte[fileStream.Length];
                        fileStream.Read(imageData, 0, imageData.Length);
                    }
                    sqlCommand.Parameters["@imageName"].Value = fileName;
                    sqlCommand.Parameters["@imageData"].Value = imageData;
                    sqlCommand.ExecuteNonQuery();
                    return;
                }
            }
            else
            {
                sqlInsertInto = "insert into ImagesForExercises values (@id, @imageName, @imageData, @videoName, @videoData)";

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlInsertInto, sqlConnection); ;
                    sqlCommand.Parameters.Add("@id", SqlDbType.Int);
                    sqlCommand.Parameters.Add("@imageName", SqlDbType.NVarChar, 50);
                    sqlCommand.Parameters.Add("@imageData", SqlDbType.Image, 4000000);
                    sqlCommand.Parameters.Add("@videoName", SqlDbType.NVarChar, 50);
                    sqlCommand.Parameters.Add("@videoData", SqlDbType.Image, 1000000000);

                    fileName = pathToImage.Substring(pathToImage.LastIndexOf('\\') + 1);
                    using (System.IO.FileStream fileStream = new System.IO.FileStream(pathToImage, System.IO.FileMode.Open))
                    {
                        imageData = new byte[fileStream.Length];
                        fileStream.Read(imageData, 0, imageData.Length);
                    }
                    sqlCommand.Parameters["@id"].Value = id;
                    sqlCommand.Parameters["@imageName"].Value = fileName;
                    sqlCommand.Parameters["@imageData"].Value = imageData;
                    sqlCommand.Parameters["@videoName"].Value = DBNull.Value;
                    sqlCommand.Parameters["@videoData"].Value = DBNull.Value;
                    sqlCommand.ExecuteNonQuery();
                    return;
                }

            }      
        }

        /// <summary>
        /// Сохраняет видео в бд, кодировая в его байты 
        /// </summary>
        public void SaveVideoiToDatbase (string pathToVideo, int id)
        {
            string sqlInsertInto;
            string fileName = null;
            byte[] videoData = null;

            if (RecordExists(id) == 1)
            {
                sqlInsertInto = "update ImagesForExercises set videoName=@videoName, videoData=@videoData where idExercises = " + id;
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlInsertInto, sqlConnection); ;
                    sqlCommand.Parameters.Add("@videoName", SqlDbType.NVarChar, 50);
                    sqlCommand.Parameters.Add("@videoData", SqlDbType.Image, 4000000);

                    fileName = pathToVideo.Substring(pathToVideo.LastIndexOf('\\') + 1);
                    using (System.IO.FileStream fileStream = new System.IO.FileStream(pathToVideo, System.IO.FileMode.Open))
                    {
                        videoData = new byte[fileStream.Length];
                        fileStream.Read(videoData, 0, videoData.Length);
                    }
                    sqlCommand.Parameters["@videoName"].Value = fileName;
                    sqlCommand.Parameters["@videoData"].Value = videoData;
                    sqlCommand.ExecuteNonQuery();
                    return;
                }
            }
            else
            {
                sqlInsertInto = "insert into ImagesForExercises values (@id, @imageName, @imageData, @videoName, @videoData)";

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(sqlInsertInto, sqlConnection); ;
                    sqlCommand.Parameters.Add("@id", SqlDbType.Int);
                    sqlCommand.Parameters.Add("@imageName", SqlDbType.NVarChar, 50);
                    sqlCommand.Parameters.Add("@imageData", SqlDbType.Image, 4000000);
                    sqlCommand.Parameters.Add("@videoName", SqlDbType.NVarChar, 50);
                    sqlCommand.Parameters.Add("@videoData", SqlDbType.Image, 1000000000);

                    fileName = pathToVideo.Substring(pathToVideo.LastIndexOf('\\') + 1);
                    using (System.IO.FileStream fileStream = new System.IO.FileStream(pathToVideo, System.IO.FileMode.Open))
                    {
                        videoData = new byte[fileStream.Length];
                        fileStream.Read(videoData, 0, videoData.Length);
                    }
                    sqlCommand.Parameters["@id"].Value = id;
                    sqlCommand.Parameters["@imageName"].Value = DBNull.Value; 
                    sqlCommand.Parameters["@imageData"].Value = DBNull.Value;
                    sqlCommand.Parameters["@videoName"].Value = fileName;
                    sqlCommand.Parameters["@videoData"].Value = videoData;
                    sqlCommand.ExecuteNonQuery();
                    return;
                }

            }

        }

        /// <summary>
        /// Получайет имя файла
        /// </summary>
        /// <param name="check">передать IMAGE или VIDEO</param>
        /// <returns></returns>
        public string GetNameFile (string  check, int id)
        {
            string sqlSelect = null;
            string result = null;

            switch(check)
            {
                case "IMAGE":
                        sqlSelect = "select imageName from ImagesForExercises where idExercises = " + id;
                        break;
                case "VIDEO":
                        sqlSelect = "select videoName from ImagesForExercises where idExercises = " + id;
                        break;
            }

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlSelect, sqlConnection);
                SqlDataReader SqlDataread = sqlCommand.ExecuteReader();

                while (SqlDataread.Read())
                {
                    if (SqlDataread.GetValue(0) != DBNull.Value)
                        result = SqlDataread.GetValue(0).ToString();
                }
            }

            return result;
        }


        /// <summary>
        /// Загуржает картинку из бд
        /// </summary>
        public byte[] RedImageFromDataBase(string sqlSelect)
        {
            
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                
                SqlCommand sqlCommand = new SqlCommand(sqlSelect, sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                byte[] imageData = null;
                          
                while (reader.Read())
                {
                    if(reader.GetValue(0) != DBNull.Value)
                        imageData = (byte[])reader.GetValue(0);
                }
                return imageData;
                    //pictureBox.Image = Image.FromStream(new MemoryStream(imageData));

            }
        }


        private int RecordExists(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string sqlSelect = "select cast (case when exists(select * from ImagesForExercises where ImagesForExercises.idExercises = " + id + ") then 1 else 0 end as bit) as Result;";
                SqlCommand sqlCommand = new SqlCommand(sqlSelect, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                sqlDataReader.Read();
                int isResult = Convert.ToInt32(sqlDataReader.GetValue(0));
                //sqlDataReader.Read();\
                Console.WriteLine(isResult);
                return isResult;

            }
        }

    }
}
