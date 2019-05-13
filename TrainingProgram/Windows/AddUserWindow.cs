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
        private bool isSelected = false;



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

            textBoxPuls.Enter += TextBox_MouseEnter;
            textBoxPressureUp.Enter += TextBox_MouseEnter;
            textBoxPressureDown.Enter += TextBox_MouseEnter;
            textBoxGrowth.Enter += TextBox_MouseEnter;
            textBoxWeight.Enter += TextBox_MouseEnter;
            textBoxPushUps.Enter += TextBox_MouseEnter;
            textBoxPullUps.Enter += TextBox_MouseEnter;
            textBoxRun100.Enter += TextBox_MouseEnter;
            textBoxSquts.Enter += TextBox_MouseEnter;
            textBoxPress.Enter += TextBox_MouseEnter;

            //workWithWidget.SetWatemarkTextBox(textBoxPuls, "Введите пульс");

            PageAddUser(true);
            addTpForUser.FilllistViewUsers(listViewUser);
        }

        private void TextBox_MouseEnter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            ToolTip tt = new ToolTip();
            tt.SetToolTip(tb,tb.Tag.ToString());
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

                string[,] sqtResult = workWithDataBase.SelectFromDataBase("select * from Users where firstName = '" + textBoxName.Text + "' and lastName = '" + textBoxSecondName.Text + "' and gender = '" + comboBoxGender.Text + "' and dateOfBirth='" + dateTimePicker.Value.Date + "'", 1);
                idSelectedUser = Convert.ToInt32(sqtResult[0, 0]);

                double CPwC = calculation.CalculationPowerCondition(int.Parse(textBoxPushUps.Text),
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

                workWithUsers.InsertStatisticsUser(idSelectedUser,
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
                isSelected = true;
                this.Close();
                mainWindow.FillUserBar();
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
    

        private void AddUserWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!isSelected)
            {                             
                mainWindow.PageMainWindow(true);
                mainWindow.PageAddTpForUsers(false);
            }
        }
    }
}
