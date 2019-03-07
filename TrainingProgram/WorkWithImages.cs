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
        /// Сохраняет изображение в бд, кодировая в его байты (ПЕРЕПИСАТЬ!!!!!!!!!!!)
        /// </summary>
        public void SaveImageVideoToDatbase(string naemTable,string pathToImage, string pathToVideo, int id)
        {
            string sqlInsertInto;
            if (RecordExists(id) == 1)
            {
                sqlInsertInto = "update "+ naemTable + " set idExercises=@id, imageName=@imageName, imageData=@imageData, videoName=@videoName, videoData=@videoData where idExercises = " + id;
            }
            else sqlInsertInto = "insert into " + naemTable + " values (@id, @imageName, @imageData, @videoName, @videoData)";


            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();                  
                SqlCommand sqlCommand = new SqlCommand(sqlInsertInto, sqlConnection);;
                sqlCommand.Parameters.Add("@id", SqlDbType.Int);
                sqlCommand.Parameters.Add("@imageName", SqlDbType.NVarChar, 50);
                sqlCommand.Parameters.Add("@imageData", SqlDbType.Image, 4000000);
                sqlCommand.Parameters.Add("@videoName", SqlDbType.NVarChar, 50);
                sqlCommand.Parameters.Add("@videoData", SqlDbType.Image, 1000000000);
                string fileName= null, videoName = null;
                byte[] imageData = null, videoData = null;

                if (pathToImage != null)
                {
                    fileName = pathToImage.Substring(pathToImage.LastIndexOf('\\') + 1);
                    using (System.IO.FileStream fileStream = new System.IO.FileStream(pathToImage, System.IO.FileMode.Open))
                    {
                        imageData = new byte[fileStream.Length];
                        fileStream.Read(imageData, 0, imageData.Length);
                    }
                    sqlCommand.Parameters["@imageName"].Value = fileName;
                    sqlCommand.Parameters["@imageData"].Value = imageData;
                }
                else
                {
                    sqlCommand.Parameters["@imageName"].Value = DBNull.Value;
                    sqlCommand.Parameters["@imageData"].Value = DBNull.Value; 
                }
                if (pathToVideo != null)
                {
                    videoName = pathToVideo.Substring(pathToVideo.LastIndexOf('\\') + 1);
                    using (System.IO.FileStream fileStream = new System.IO.FileStream(pathToVideo, System.IO.FileMode.Open))
                    {
                        videoData = new byte[fileStream.Length];
                        fileStream.Read(videoData, 0, videoData.Length);
                    }
                    sqlCommand.Parameters["@videoName"].Value = videoName;
                    sqlCommand.Parameters["@videoData"].Value = videoData;
                }
                else
                {
                    sqlCommand.Parameters["@videoName"].Value = DBNull.Value;
                    sqlCommand.Parameters["@videoData"].Value = DBNull.Value;
                }
                sqlCommand.Parameters["@id"].Value = id;
                sqlCommand.ExecuteNonQuery();
            }
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
