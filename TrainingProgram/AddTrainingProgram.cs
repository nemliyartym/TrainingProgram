using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrainingProgram
{
    class AddTrainingProgram
    {
        WorkWithDataBase workWithDatabas = new WorkWithDataBase();

        string[] daysWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        int currentDaysWeek = 0;



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
            int count = workWithDatabas.SelectCountFromDataBase("select count (e.exercises) from TrainingProgram tp join Users u on tp.idUsers = u.idUsers join  Exercises e on tp.idExercises = e.idExercises join DaysWeek dw on tp.idDaysWeek = dw.idDaysWeek where u.idUsers =" + id + "and dw.daysWeek = '" + daysWeek[currentDaysWeek] +"'");
            string[,] selectResult = workWithDatabas.SelectFromDataBase("select e.exercises from TrainingProgram tp join Users u on tp.idUsers = u.idUsers join  Exercises e on tp.idExercises = e.idExercises join DaysWeek dw on tp.idDaysWeek = dw.idDaysWeek where u.idUsers =" + id + "and dw.daysWeek = '" + daysWeek[currentDaysWeek] + "'", count);
            listViewTrainingProgramm.Items.Clear();

            for (int i = 0; i < count; i++)
            {
                ListViewItem item = new ListViewItem(selectResult[i, 0]);
                listViewTrainingProgramm.Items.Add(item);
            }
        }

    public void FillLisViewUsers(ListView listView)
        {
            WorkWithDataBase workWithDataBase = new WorkWithDataBase();
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
