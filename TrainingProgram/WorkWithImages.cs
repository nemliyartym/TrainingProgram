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

    public class ImageStruct
    {
        public int id { get; private set; }
        public string imageName { get; private set; }
        public byte[] imageData { get; private set; }

        public ImageStruct(int id, string imageName, byte[] imageData)
        {
            this.id = id;
            this.imageName = imageName;
            this.imageData = imageData;
        }

    }



    class WorkWithImages
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Sport;Integrated Security=True";

        /// <summary>
        /// Сохраняет изображение в бд, кодировая в его байты (ПЕРЕПИСАТЬ!!!!!!!!!!!)
        /// </summary>
        public void SaveImageToDatbase(string pathToImage, string sqlInsertInto)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlInsertInto, sqlConnection);
                sqlCommand.Parameters.Add("@id", SqlDbType.Int);
                sqlCommand.Parameters.Add("@imageName", SqlDbType.NVarChar, 50);
                sqlCommand.Parameters.Add("@imageData", SqlDbType.Image, 2000000);

                string fileName = pathToImage.Substring(pathToImage.LastIndexOf('\\') + 1); //'имяфайла'.jpg

                byte[] imageData;
                using (System.IO.FileStream fileStream = new System.IO.FileStream(pathToImage, System.IO.FileMode.Open))
                {
                    imageData = new byte[fileStream.Length];
                    fileStream.Read(imageData, 0, imageData.Length);
                }

                sqlCommand.Parameters["@id"].Value = 2;
                sqlCommand.Parameters["@imageName"].Value = fileName;
                sqlCommand.Parameters["@imageData"].Value = imageData;

                sqlCommand.ExecuteNonQuery();
            }
        }


        /// <summary>
        /// Загуржает картинку из бд
        /// </summary>
        public void RedFileFromDataBase(PictureBox pictureBox , int idExercises)
        {
            List<ImageStruct> images = new List<ImageStruct>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select i.imageData from ImagesForExercises i join Exercises e on e.idExercises = i.idExercises where e.idExercises = " + idExercises, sqlConnection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                byte[] imageData = null;
                          
                while (reader.Read())
                {

                     imageData = (byte[])reader.GetValue(0);
                }
                if (imageData != null)
                    pictureBox.Image = Image.FromStream(new MemoryStream(imageData));
                else pictureBox.Image = null;

            }
        }



    }
}
