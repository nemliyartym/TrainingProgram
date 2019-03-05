using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrainingProgram
{
    public partial class MainWindow : Form
    {


        public MainWindow()
        {
            InitializeComponent();
            Win32.AllocConsole();


            WorkWithTree workWithTree = new WorkWithTree(treeViewMusclesAndExercises);
            workWithTree.FillTree();
            treeViewMusclesAndExercises.AfterSelect += TreeViewMusclesAndExercises_AfterSelect;



            WorkWithImages workWithImages = new WorkWithImages();

            //workWithImages.SaveImageToDatbase(@"C: \Users\79374\Desktop\imagesFromDB\hot\19Кардио.jpg", "insert into ImagesFroMuscles values (@id, @imageName, @imageData)", 19);




        }

        private void TreeViewMusclesAndExercises_AfterSelect(object sender, TreeViewEventArgs e)
        { 
            if(e.Node.Parent != null)
            {
                WorkWithImages workWithImages = new WorkWithImages();
                string sqlSelect = "select i.imageData from ImagesForExercises i join Exercises e on e.idExercises = i.idExercises where e.idExercises = " + Convert.ToInt32(e.Node.Tag);

                byte[] imageData = workWithImages.RedImageFromDataBase(sqlSelect);
                if (imageData != null)
                    pictureBoxFromImages.Image = Image.FromStream(new MemoryStream(imageData));
                else pictureBoxFromImages.Image = null;
                      
            }

        }

        private void buttonSearchExercises_Click(object sender, EventArgs e)
        {
            treeViewMusclesAndExercises.Visible = true;
            buttonSearchMusclesAndExercises.Visible = false;
            buttonAddTrainingProgram.Visible = false;
            buttonBack.Visible = true;
            pictureBoxFromImages.Visible = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            treeViewMusclesAndExercises.Visible = false;
            buttonSearchMusclesAndExercises.Visible = true;
            buttonAddTrainingProgram.Visible = true;
            buttonBack.Visible = false;
            pictureBoxFromImages.Visible = false;
        }



    }
}
