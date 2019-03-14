using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace TrainingProgram
{
    class WorkWithTree
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Sport;Integrated Security=True";

        TreeView treeView;
        
        public WorkWithTree (TreeView treeView)
        {
            this.treeView = treeView;
        } 

        /// <summary>
        /// Заполняет дерево и рисует картинки
        /// </summary>
        public void FillTree ()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select m.idMuscles,m.muscles, im.imageData,im.imageName from Muscles m join ImagesFroMuscles im on m.idMuscles = im.idMuscles", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                List<int> idList = new List<int>();
                ImageList imageList = new ImageList();
                WorkWithImages workWithImages = new WorkWithImages();

                //treeView.ImageList = imageList;
                imageList.ImageSize = new Size(30, 30);

                while (sqlDataReader.Read())
                {
                    idList.Add(Int32.Parse(sqlDataReader[0].ToString()));
                    byte[] imageData = (byte[])sqlDataReader.GetValue(2);
                    if(imageData!= null)
                        imageList.Images.Add(sqlDataReader[3].ToString(), Image.FromStream(new MemoryStream(imageData)));
                    else imageList.Images.Add(sqlDataReader[3].ToString(), Image.FromStream(new MemoryStream(null)));
                    treeView.Nodes.Add(sqlDataReader[3].ToString(), sqlDataReader[1].ToString(), sqlDataReader[3].ToString()).Tag = sqlDataReader[0];
                }
                sqlDataReader.Close();
                sqlConnection.Close();
                idList.ForEach(selected);
            }
        }

        private int numbersRoot = 0;
        /// <summary>
        /// Наикдываем упраженния на каждую группы мышц используются в FillTree()
        /// </summary>
        private void selected(int id)
        {
            string sqlSelect = @"select e.idExercises, e.exercises from Exercises e join MusclesAndExercises me on e.idExercises = me.idExercises join Muscles m on m.idMuscles = me.idMuscles where m.idMuscles = " + id;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlSelect, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    treeView.Nodes[numbersRoot].Nodes.Add(null,sqlDataReader[1].ToString(),null).Tag = sqlDataReader[0];
                }
                sqlDataReader.Close();
                sqlConnection.Close();
            }
            numbersRoot++;

        }






    }
}
