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

            WorkWithTree workWithTree = new WorkWithTree(treeViewMusclesAndExercises);
            workWithTree.FillTree();

            pictureBoxFromImages.Image = Image.FromFile(@"C:\Users\79374\Desktop\foto\1.jpg");

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
