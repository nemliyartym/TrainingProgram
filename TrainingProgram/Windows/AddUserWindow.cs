using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingProgram.Class;

namespace TrainingProgram.Windows
{
    public partial class AddUserWindow : Form
    {
        private enum CurrentPageAddUserWindow
        {
            pageAddUser,
            pagePulsPressure,
            pageGrowthWeight,
            pagePullupPushUp,
            pageSquatsRun100,
            pagePress
        }
        WorkWithDataBase workWithDataBase = new WorkWithDataBase();
        WorkWithUsers workWithUsers = new WorkWithUsers();
        AddTpForUser addTpForUser = new AddTpForUser();
        MainWindow mainWindow = new MainWindow();
        WorkWithWidget workWithWidget = new WorkWithWidget();
        Calculation calculation = new Calculation();
        CurrentPageAddUserWindow currentPageAddUserWindow = CurrentPageAddUserWindow.pageAddUser;

        /// <summary>
        /// ид выбранного пользователя в окне AddUserWindow
        /// </summary>
        public static int idSelectedUser;

        public static int puls;
        public static int pressureUp;
        public static int pressureDown;
        public static int age;
        public static int growth;
        public static int weight;
        public static int pushUp;
        public static int pullUps;
        public static int squats;
        public static int press;
        public static double run100;

        public AddUserWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void AddUserWindow_Load(object sender, EventArgs e)
        {
            comboBoxGender.SelectedIndex = 0;
            textBoxName.TextChanged += TextBox_TextChanged;
            textBoxSecondName.TextChanged += TextBox_TextChanged;
            PageAddUser(true);
            addTpForUser.FilllistViewUsers(listViewUser);

        }

        //---------------------INTERFACE-----------------------------
        #region INTERFACE PRIVATE VOID
        private void PageAddUser (bool isVisible)
        {
            labelListUser.Visible = isVisible;
            listViewUser.Visible = isVisible;
            tableLayoutPanelAddInfUser.Visible = isVisible;

            pictureBoxFirst.Visible = !isVisible;
            pictureBoxSecond.Visible = !isVisible;

            buttonNext.Visible = isVisible;
            buttonPrev.Visible = !isVisible;

            textBoxPuls.Visible = !isVisible;
            textBoxPressureUp.Visible = !isVisible;
            textBoxPressureDown.Visible = !isVisible;
            textBoxGrowth.Visible = !isVisible;
            textBoxWeight.Visible = !isVisible;
            textBoxPullUps.Visible = !isVisible;
            textBoxPushUps.Visible = !isVisible;
            textBoxSquts.Visible = !isVisible;
            textBoxRun100.Visible = !isVisible;
            textBoxPress.Visible = !isVisible;

            currentPageAddUserWindow = CurrentPageAddUserWindow.pageAddUser;
        }
        private void PagePulsPressure(bool isVisible)
        {
            pictureBoxFirst.Image = Properties.Resources.pulse;
            pictureBoxSecond.Image = Properties.Resources.pressure;

            pictureBoxFirst.Visible = isVisible;
            pictureBoxSecond.Visible = isVisible;

            buttonNext.Visible = isVisible;
            buttonPrev.Visible = isVisible;

            textBoxPuls.Visible = isVisible;
            textBoxPressureUp.Visible = isVisible;
            textBoxPressureDown.Visible = isVisible;
            textBoxGrowth.Visible = !isVisible;
            textBoxWeight.Visible = !isVisible;
            textBoxPullUps.Visible = !isVisible;
            textBoxPushUps.Visible = !isVisible;
            textBoxSquts.Visible = !isVisible;
            textBoxRun100.Visible = !isVisible;
            textBoxPress.Visible = !isVisible;

            //workWithWidget.SetWatemarkTextBox(textBoxPuls, "Введите пульс");
            //workWithWidget.SetWatemarkTextBox(textBoxPressureUp, "Введите давление");

            currentPageAddUserWindow = CurrentPageAddUserWindow.pagePulsPressure;
        }
        private void PageGrowthWeight(bool isVisible)
        {
            pictureBoxFirst.Image = Properties.Resources.growth;
            pictureBoxSecond.Image = Properties.Resources.weight;

            pictureBoxFirst.Visible = isVisible;
            pictureBoxSecond.Visible = isVisible;

            buttonNext.Visible = isVisible;
            buttonPrev.Visible = isVisible;

            textBoxPuls.Visible = !isVisible;
            textBoxPressureUp.Visible = !isVisible;
            textBoxPressureDown.Visible = !isVisible;
            textBoxGrowth.Visible = isVisible;
            textBoxWeight.Visible = isVisible;
            textBoxPullUps.Visible = !isVisible;
            textBoxPushUps.Visible = !isVisible;
            textBoxSquts.Visible = !isVisible;
            textBoxRun100.Visible = !isVisible;
            textBoxPress.Visible = !isVisible;

            //workWithWidget.SetWatemarkTextBox(textBoxPuls, "Введите рост");
            //workWithWidget.SetWatemarkTextBox(textBoxPressureUp, "Введите вес");

            currentPageAddUserWindow = CurrentPageAddUserWindow.pageGrowthWeight;
        }
        private void PagePullupPushUp(bool isVisible)
        {
            pictureBoxFirst.Image = Properties.Resources.pullups;
            pictureBoxSecond.Image = Properties.Resources.pushups;

            pictureBoxFirst.Visible = isVisible;
            pictureBoxSecond.Visible = isVisible;

            buttonNext.Visible = isVisible;
            buttonPrev.Visible = isVisible;

            textBoxPuls.Visible = !isVisible;
            textBoxPressureUp.Visible = !isVisible;
            textBoxPressureDown.Visible = !isVisible;
            textBoxGrowth.Visible = !isVisible;
            textBoxWeight.Visible = !isVisible;
            textBoxPullUps.Visible = isVisible;
            textBoxPushUps.Visible = isVisible;
            textBoxSquts.Visible = !isVisible;
            textBoxRun100.Visible = !isVisible;
            textBoxPress.Visible = !isVisible;

            //workWithWidget.SetWatemarkTextBox(textBoxPuls, "Введите кол-во подтягиваний");
            //workWithWidget.SetWatemarkTextBox(textBoxPressureUp, "Введите кол-во отжиманий");

            currentPageAddUserWindow = CurrentPageAddUserWindow.pagePullupPushUp;
        }
        private void PageSquatsRun100(bool isVisible)
        {
            pictureBoxFirst.Image = Properties.Resources.squts;
            pictureBoxSecond.Image = Properties.Resources.run100;

            pictureBoxFirst.Visible = isVisible;
            pictureBoxSecond.Visible = isVisible;

            buttonNext.Visible = isVisible;
            buttonPrev.Visible = isVisible;

            textBoxPuls.Visible = !isVisible;
            textBoxPressureUp.Visible = !isVisible;
            textBoxPressureDown.Visible = !isVisible;
            textBoxGrowth.Visible = !isVisible;
            textBoxWeight.Visible = !isVisible;
            textBoxPullUps.Visible = !isVisible;
            textBoxPushUps.Visible = !isVisible;
            textBoxSquts.Visible = isVisible;
            textBoxRun100.Visible = isVisible;
            textBoxPress.Visible = !isVisible;

            //workWithWidget.SetWatemarkTextBox(textBoxPuls, "Введите кол-во приседаний");
            //workWithWidget.SetWatemarkTextBox(textBoxPressureUp, "Введите время 100м");

            currentPageAddUserWindow = CurrentPageAddUserWindow.pageSquatsRun100;
        }
        private void PagePress(bool isVisible)
        {
            pictureBoxFirst.Image = Properties.Resources.pres;
            pictureBoxSecond.Image = null;

            pictureBoxFirst.Visible = isVisible;
            pictureBoxSecond.Visible = isVisible;

            buttonNext.Visible = isVisible;
            buttonPrev.Visible = isVisible;

            textBoxPuls.Visible = !isVisible;
            textBoxPressureUp.Visible = !isVisible;
            textBoxPressureDown.Visible = !isVisible;
            textBoxGrowth.Visible = !isVisible;
            textBoxWeight.Visible = !isVisible;
            textBoxPullUps.Visible = !isVisible;
            textBoxPushUps.Visible = !isVisible;
            textBoxSquts.Visible = !isVisible;
            textBoxRun100.Visible = !isVisible;
            textBoxPress.Visible = isVisible;

            //workWithWidget.SetWatemarkTextBox(textBoxPuls, "Введите кол-во подъемом туловища");

            currentPageAddUserWindow = CurrentPageAddUserWindow.pagePress;
        }
        #endregion
        #region INTEFACE MANAGMENT
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if(currentPageAddUserWindow == CurrentPageAddUserWindow.pageAddUser)
            {
                PageAddUser(false);
                PagePulsPressure(true);
            }
            else if (currentPageAddUserWindow == CurrentPageAddUserWindow.pagePulsPressure)
            {
                PageGrowthWeight(true);
            }
            else if (currentPageAddUserWindow == CurrentPageAddUserWindow.pageGrowthWeight)
            {
                PagePullupPushUp(true);
            }
            else if (currentPageAddUserWindow == CurrentPageAddUserWindow.pagePullupPushUp)
            {
                PageSquatsRun100(true);
            }
            else if (currentPageAddUserWindow == CurrentPageAddUserWindow.pageSquatsRun100)
            {
                PagePress(true);
                buttonNext.Text = "Добавить пользователя";
            }
            else if (currentPageAddUserWindow == CurrentPageAddUserWindow.pagePress)
            {
                workWithUsers.InsertUser(textBoxName.Text,
                                            textBoxSecondName.Text,
                                            comboBoxGender.Text,
                                            dateTimePicker.Value.Date);

                double CPwC = calculation.CalculationPowerCondictopn(int.Parse(textBoxPushUps.Text),
                                                          int.Parse(textBoxPullUps.Text),
                                                          int.Parse(textBoxSquts.Text),
                                                          int.Parse(textBoxPress.Text),
                                                          Convert.ToDouble(textBoxRun100.Text));

                int age = Convert.ToInt32(DateTime.Now.Year - dateTimePicker.Value.Date.Year);

                double CPhC = calculation.CalculationPhysicalCondition(int.Parse(textBoxPressureUp.Text),
                                                                int.Parse(textBoxPressureDown.Text),
                                                                age,
                                                                int.Parse(textBoxGrowth.Text),
                                                                int.Parse(textBoxWeight.Text),
                                                                int.Parse(textBoxPuls.Text));


                workWithUsers.InsertStatisticsUser(workWithDataBase.SelectCountFromDataBase("select * from Users where firstName = '" + textBoxName.Text + "' and lastName = '" + textBoxSecondName.Text + "' and gender = '" + comboBoxGender.Text + "'"),
                                                           int.Parse(textBoxPuls.Text),
                                                           int.Parse(textBoxPressureUp.Text),
                                                           int.Parse(textBoxPressureDown.Text),
                                                           int.Parse(textBoxGrowth.Text),
                                                           int.Parse(textBoxWeight.Text),
                                                           age,
                                                           int.Parse(textBoxPullUps.Text),
                                                           int.Parse(textBoxPushUps.Text),
                                                           (float)Convert.ToDouble(textBoxRun100.Text),
                                                           int.Parse(textBoxSquts.Text),
                                                           int.Parse(textBoxPullUps.Text),
                                                           (float)CPhC,
                                                           (float)CPwC);
                this.Close();
                mainWindow.FillInfAboutUser();
            }
        }
        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (currentPageAddUserWindow == CurrentPageAddUserWindow.pageAddUser)
            {

            }
            else if (currentPageAddUserWindow == CurrentPageAddUserWindow.pagePulsPressure)
            {
                PagePulsPressure(false);
                PageAddUser(true);
                buttonNext.Visible = true;
            }
            else if (currentPageAddUserWindow == CurrentPageAddUserWindow.pageGrowthWeight)
            {
                PagePulsPressure(true);
            }
            else if (currentPageAddUserWindow == CurrentPageAddUserWindow.pagePullupPushUp)
            {
                PageGrowthWeight(true);
            }
            else if (currentPageAddUserWindow == CurrentPageAddUserWindow.pageSquatsRun100)
            {
                PagePullupPushUp(true);
            }
            else if (currentPageAddUserWindow == CurrentPageAddUserWindow.pagePress)
            {
                PageSquatsRun100(true);
                buttonNext.Text = "Дальше";
            }
        }
        #endregion
        //-----------------------------------------------------------

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text != String.Empty && textBoxSecondName.Text != String.Empty)
                buttonNext.Enabled = true;
            else buttonNext.Enabled = false;
        }

        //private void TextBox_Enter(object sender, EventArgs e)
        //{
        //    workWithWidget.DeleteWotemarktextBox((TextBox)sender);
        //}

        //private void TextBox_Leave(object sender, EventArgs e)
        //{
        //    TextBox textBox = (TextBox)sender;
        //    if (textBox.Text == string.Empty)
        //    {
        //        if (currentPageAddUserWindow == CurrentPageAddUserWindow.pagePulsPressure)
        //        {
        //           if(textBox == textBoxFirst) workWithWidget.SetWatemarkTextBox(textBoxFirst, "Введите пульс");
        //           else if(textBox == textBoxSecond) workWithWidget.SetWatemarkTextBox(textBoxSecond, "Введите давление");
        //        }
        //        else if (currentPageAddUserWindow == CurrentPageAddUserWindow.pageGrowthWeight)
        //        {
        //            if (textBox == textBoxFirst) workWithWidget.SetWatemarkTextBox(textBoxFirst, "Введите рос");
        //            else if (textBox == textBoxSecond) workWithWidget.SetWatemarkTextBox(textBoxSecond, "Введите вес");
        //        }
        //        else if (currentPageAddUserWindow == CurrentPageAddUserWindow.pagePullupPushUp)
        //        {                 
        //            if (textBox == textBoxFirst) workWithWidget.SetWatemarkTextBox(textBoxFirst, "Введите кол-во подтягиваний");
        //            else if (textBox == textBoxSecond) workWithWidget.SetWatemarkTextBox(textBoxSecond, "Введите кол-во отжиманий");

        //        }
        //        else if (currentPageAddUserWindow == CurrentPageAddUserWindow.pageSquatsRun100)
        //        {
        //            if (textBox == textBoxFirst) workWithWidget.SetWatemarkTextBox(textBoxFirst, "Введите кол-во приседаний");
        //            else if (textBox == textBoxSecond) workWithWidget.SetWatemarkTextBox(textBoxSecond, "Введите время 100м");

        //        }
        //        else if (currentPageAddUserWindow == CurrentPageAddUserWindow.pagePress)
        //        {
        //            if (textBox == textBoxFirst) workWithWidget.SetWatemarkTextBox(textBoxFirst, "Введите кол-во подъемом туловища");
        //        }
        //    }
                
        //}


        private void listViewUser_DoubleClick(object sender, EventArgs e)
        {
            if (listViewUser.SelectedItems.Count > 0)
            {
                //MessageBox.Show(Convert.ToInt32(listViewUser.SelectedItems[0].Tag).ToString());
                idSelectedUser = Convert.ToInt32(listViewUser.SelectedItems[0].Tag);

                //int countStatisticUsres = workWithDataBase.SelectCountFromDataBase("select count(*) from StatisticsUsers where idUsers =" + idSelectedUser);
                //if (countStatisticUsres == 0)
                //{
                //    MessageBox.Show("У пользователя " + listViewUser.SelectedItems[0].Text + ". \n Нужно заполнить п");
                //    return;
                //}

                mainWindow.FillInfAboutUser();           
                this.Close();
            }
        }

    }
}
