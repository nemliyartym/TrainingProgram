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
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Tag { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

    class AddTrainingProgram
    {
        WorkWithImages workWithImages = new WorkWithImages();
        WorkWithDataBase workWithDataBase = new WorkWithDataBase();
        WorkWithTrainigProgram workWithTrainigProgram = new WorkWithTrainigProgram();

        string[] daysWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        public int currentDaysWeek = 0;


        public void FillListViewExrcises(ListView listView,int idMuscles)
        {

            int countRows = workWithDataBase.SelectCountFromDataBase("select count(e.exercises) from MusclesAndExercises me join Muscles m on me.idMuscles = m.idMuscles join Exercises e on me.idExercises = e.idExercises where me.idMuscles =" + idMuscles);
            string[,] sqlSelect = workWithDataBase.SelectFromDataBase("select e.exercises, e.idExercises from MusclesAndExercises me join Muscles m on me.idMuscles = m.idMuscles join Exercises e on me.idExercises = e.idExercises where me.idMuscles =" + idMuscles, countRows);
            listView.Items.Clear();
            ImageList imageList = new ImageList();
            listView.LargeImageList = imageList;
            for(int i=0; i<countRows; i++)
            {
                ListViewItem lvItem = new ListViewItem();
                //byte[] imageData = workWithImages.RedImageFromDataBase("select imageData from ImagesForExercises where idExercises =" + sqlSelect[i,1]);
                //if(imageData != null)
                //    imageList.Images.Add(sqlSelect[i,1].ToString(),Image.FromStream(new MemoryStream(imageData)));
                //lvItem.ImageIndex = Convert.ToInt16(sqlSelect[i, 1]);
                lvItem.Text = sqlSelect[i, 0];
                lvItem.Tag = sqlSelect[i, 1];
                listView.Items.Add(lvItem);
            }
        }
        

        public void FillComboBoxMuscles (ComboBox comboBox)
        {
            int countRows = workWithDataBase.SelectCountFromDataBase("select count (*) from Muscles");
            string[,] sqlSelect = workWithDataBase.SelectFromDataBase("select * from Muscles",countRows);
            for (int i=0; i< countRows; i++)
            {
                ComboboxItem cbItem = new ComboboxItem();
                cbItem.Text = sqlSelect[i, 1];
                cbItem.Tag = sqlSelect[i, 0];
                comboBox.Items.Add(cbItem);
            }
            comboBox.SelectedIndex = 0;
        }


        public void ButtonNext (Label labelDayWeek)
        {
            if (++currentDaysWeek >= daysWeek.Length)
                currentDaysWeek = 0;
            labelDayWeek.Text = daysWeek[currentDaysWeek];
        }


        public void ButtonPre (Label labelDayWeek)
        {
            if (--currentDaysWeek < 0)
                currentDaysWeek = daysWeek.Length - 1;
            labelDayWeek.Text = daysWeek[currentDaysWeek];
        }


        public void FilllistViewTrainingProgramm(ListView listViewTrainingProgramm, int id)
        {
            int count = workWithDataBase.SelectCountFromDataBase("select count (e.exercises) from TrainingProgram tp join Users u on tp.idUsers = u.idUsers join  Exercises e on tp.idExercises = e.idExercises join DaysWeek dw on tp.idDaysWeek = dw.idDaysWeek where u.idUsers =" + id + "and dw.daysWeek = '" + daysWeek[currentDaysWeek] +"'");
            string[,] selectResult = workWithDataBase.SelectFromDataBase("select tp.idTrainingProgram,e.exercises from TrainingProgram tp join Users u on tp.idUsers = u.idUsers join  Exercises e on tp.idExercises = e.idExercises join DaysWeek dw on tp.idDaysWeek = dw.idDaysWeek where u.idUsers =" + id + "and dw.daysWeek = '" + daysWeek[currentDaysWeek] + "'", count);
            listViewTrainingProgramm.Items.Clear();
            for (int i = 0; i < count; i++)
            {
                ListViewItem item = new ListViewItem(selectResult[i, 1]);
                item.SubItems.Add(selectResult[i, 1]);
                item.Tag = selectResult[i, 0];
                listViewTrainingProgramm.Items.Add(item);
            }
        }

        public void FillLisViewUsers(ListView listView)
        {
            int counRows = workWithDataBase.SelectCountFromDataBase("select count (*) from Users");
            string[,] sqlSelectResult = workWithDataBase.SelectFromDataBase("select * from Users", counRows);

            for (int i = 0; i < counRows; i++)
            {
                ListViewItem item = new ListViewItem(sqlSelectResult[i, 0]);
                item.SubItems.Add(sqlSelectResult[i, 1]);
                item.SubItems.Add(sqlSelectResult[i, 2]).Tag = sqlSelectResult[i,0];
                listView.Items.Add(item);
            }
            
        }



    }
}
