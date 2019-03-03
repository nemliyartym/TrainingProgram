using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

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
        /// Заполняет дерево
        /// </summary>
        public void FillTree ()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from Muscles", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                List<int> idList = new List<int>();

                while (sqlDataReader.Read())
                {
                    idList.Add(Int32.Parse(sqlDataReader[0].ToString()));
                    treeView.Nodes.Add(sqlDataReader[1].ToString()).Tag = sqlDataReader[0];
                }
                sqlDataReader.Close();
                sqlConnection.Close();

                idList.ForEach(selected);
            }
        }

        public int numbersRoot = 0;
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
                    treeView.Nodes[numbersRoot].Nodes.Add(sqlDataReader[1].ToString()).Tag = sqlDataReader[0];
                }
                sqlDataReader.Close();
                sqlConnection.Close();
            }
            numbersRoot++;

        }



    }
}
