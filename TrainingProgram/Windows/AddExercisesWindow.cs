using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingProgram.Windows
{
    public partial class AddExercisesWindow : Form
    {
        MainWindow mainWindow = new MainWindow();

        WorkWithExercises workWithExercises = new WorkWithExercises();
        

        public AddExercisesWindow(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
            FillComboBoxMuscles();
        }

        private void AddExercisesWindow_Load(object sender, EventArgs e)
        {
            listExercisesFill();
            comboBoxlvlDifficulty.SelectedIndex = 2;
        }

        private void listExercisesFill ()
        {
            int countRows = workWithExercises.SelectCountFromDataBase("select count (idExercises) from Exercises");
            string[,] sqlSelect = workWithExercises.SelectFromDataBase("select idExercises,exercises from Exercises order by exercises", countRows);

            listViewExercises.Items.Clear();
            for (int i = 0; i < countRows; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = sqlSelect[i, 1];
                item.Tag = sqlSelect[i, 0];
                listViewExercises.Items.Add(item);
            }
        }

        private void buttonAddExercises_Click(object sender, EventArgs e)
        {
            if (workWithExercises.SelectExists("select idExercises from Exercises where exercises ='" + textBoxNameExercises.Text + "'") == 0)
            {
                workWithExercises.InserExercises(textBoxNameExercises.Text,comboBoxlvlDifficulty.SelectedIndex + 1);
                listExercisesFill();
            }
            else MessageBox.Show("Такое упражнение уже есть в базе");
            
        }

        public void FillComboBoxMuscles()
        {
            int countRows = workWithExercises.SelectCountFromDataBase("select count (*) from Muscles");
            string[,] sqlSelect = workWithExercises.SelectFromDataBase("select * from Muscles", countRows);
            comboBoxMuscles.Items.Clear();
            for (int i = 0; i < countRows; i++)
            {
                ComboboxItem cbItem = new ComboboxItem();
                cbItem.Text = sqlSelect[i, 1];
                cbItem.Tag = sqlSelect[i, 0];
                comboBoxMuscles.Items.Add(cbItem);
            }
            comboBoxMuscles.SelectedIndex = 0;
        }

        private void comboBoxMuscles_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelMuscles.Text = comboBoxMuscles.SelectedItem.ToString();
        }

        private void listViewExercises_DoubleClick(object sender, EventArgs e)
        {
            if (listViewExercises.SelectedItems.Count > 0)
            {
                labelExercises.Text = listViewExercises.SelectedItems[0].Text;
            }
        }

        private void buttonAddCouple_Click(object sender, EventArgs e)
        {
            if (listViewExercises.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите упражнение из списка!");
                return;
            }

            if (workWithExercises.SelectExists("select idMusclesAndExercises from MusclesAndExercises where idMuscles =" + (comboBoxMuscles.SelectedIndex + 1) + " and idExercises = " + Convert.ToInt32(listViewExercises.SelectedItems[0].Tag)) == 0)
            {
                workWithExercises.InserExercisesandMuscles(comboBoxMuscles.SelectedIndex + 1, Convert.ToInt32(listViewExercises.SelectedItems[0].Tag));
                WorkWithTree workWithTree = new WorkWithTree(mainWindow.treeViewMusclesAndExercises);
                workWithTree.FillTree();
                MessageBox.Show("Запись добавлена!");
            }
            else MessageBox.Show("Данная записьуже есть в базе!");

        }
    }
}
