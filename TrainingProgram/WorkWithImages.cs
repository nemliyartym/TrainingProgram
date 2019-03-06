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
        public void SaveImageToDatbase(string pathToImage, string pathToVideo, string sqlInsertInto, int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlInsertInto, sqlConnection);
                sqlCommand.Parameters.Add("@id", SqlDbType.Int);
                sqlCommand.Parameters.Add("@imageName", SqlDbType.NVarChar, 50);
                sqlCommand.Parameters.Add("@imageData", SqlDbType.Image, 4000000);
                sqlCommand.Parameters.Add("@videoName", SqlDbType.NVarChar, 50);
                sqlCommand.Parameters.Add("@videoData", SqlDbType.Image, 1000000000);

                string fileName = pathToImage.Substring(pathToImage.LastIndexOf('\\') + 1); //'имяфайла'.jpg
              
                byte[] imageData;
                using (System.IO.FileStream fileStream = new System.IO.FileStream(pathToImage, System.IO.FileMode.Open))
                {
                    imageData = new byte[fileStream.Length];
                    fileStream.Read(imageData, 0, imageData.Length);
                }

                string videoName = pathToVideo.Substring(pathToVideo.LastIndexOf('\\') + 1); //'имяфайла'.jpg

                byte[] videoData;
                using (System.IO.FileStream fileStream = new System.IO.FileStream(pathToVideo, System.IO.FileMode.Open))
                {
                    videoData = new byte[fileStream.Length];
                    fileStream.Read(videoData, 0, videoData.Length);
                }

                sqlCommand.Parameters["@id"].Value = id;
                sqlCommand.Parameters["@imageName"].Value = fileName;
                sqlCommand.Parameters["@imageData"].Value = imageData;
                sqlCommand.Parameters["@videoName"].Value = videoName;
                sqlCommand.Parameters["@videoData"].Value = videoData;

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
                     imageData = (byte[])reader.GetValue(0);
                }
                return imageData;
                    //pictureBox.Image = Image.FromStream(new MemoryStream(imageData));

            }
        }



    }
}
