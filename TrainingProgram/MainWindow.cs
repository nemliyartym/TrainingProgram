using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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



        }

        private void TreeViewMusclesAndExercises_AfterSelect(object sender, TreeViewEventArgs e)
        { 
            if(e.Node.Parent != null)
            {
                WorkWithImages workWithImages = new WorkWithImages();
                workWithImages.RedFileFromDataBase(pictureBoxFromImages,Convert.ToInt32(e.Node.Tag));
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
