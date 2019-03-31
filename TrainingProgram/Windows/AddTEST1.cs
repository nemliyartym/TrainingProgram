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

namespace TrainingProgram
{
    public partial class AddTEST1 : Form
    {
        private enum CurrentPage 
        {
            Page1,
            Page2,
            Page3
        }
        private CurrentPage page = CurrentPage.Page1;

        Calculation calculation = new Calculation();
        WorkWithDataBase workWithDataBase = new WorkWithDataBase();
        WorkWithUsers workWithStatisticsUser = new WorkWithUsers();

        public AddTEST1()
        {
            InitializeComponent();

            Page1(true);
            buttonNextPage.Visible = true;
            Page2(false);
            Page3(false);

            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxWeight.KeyPress += TextBox_KeyPress;
            textBoxGrowth.KeyPress += TextBox_KeyPress;
            textBoxPressureUp.KeyPress += TextBox_KeyPress;
            textBoxPressureDown.KeyPress += TextBox_KeyPress;
            textBoxPuls.KeyPress += TextBox_KeyPress;
            textBoxAge.KeyPress += TextBox_KeyPress;

            textBoxPress.KeyPress += TextBox_KeyPress;
            textBoxPullUps.KeyPress += TextBox_KeyPress;
            textBoxPushUps.KeyPress += TextBox_KeyPress;
            textBoxRun100m.KeyPress += TextBoxRun100m_KeyPress;
            textBoxSquats.KeyPress += TextBox_KeyPress;

            textBoxPressureDown.TextChanged += TextBoxPressure_TextChanged;
            textBoxPressureUp.TextChanged += TextBoxPressure_TextChanged;

            //textBoxGrowth.LostFocus += TextBox_LostFocus;

        }



        private void Page1(bool isVisible)
        {
            textBoxAge.Visible = isVisible;
            textBoxName.Visible = isVisible;
            textBoxSecondName.Visible = isVisible;
            textBoxWeight.Visible = isVisible;
            textBoxGrowth.Visible = isVisible;
            comboBoxGender.Visible = isVisible;

            labelName.Visible = isVisible;
            labelSecondName.Visible = isVisible;
            labelGender.Visible = isVisible;
            labelWeight.Visible = isVisible;
            labelGrowth.Visible = isVisible;
            labelAge.Visible = isVisible;
        }

        private void Page2(bool isVisible)
        {
            labelPuls.Visible = isVisible;
            labelPressure.Visible = isVisible;
            labelPressureOR.Visible = isVisible;
            labelADsr.Visible = isVisible;

            textBoxPressureUp.Visible = isVisible;
            textBoxPressureDown.Visible = isVisible;
            textBoxPuls.Visible = isVisible;
        }

        private void Page3(bool isVisible)
        {
            textBoxPress.Visible = isVisible;
            textBoxPullUps.Visible = isVisible;
            textBoxPushUps.Visible = isVisible;
            textBoxRun100m.Visible = isVisible;
            textBoxSquats.Visible = isVisible;

            labelPress.Visible = isVisible;
            labelPullUps.Visible = isVisible;
            labelPushUps.Visible = isVisible;
            labelRun100m.Visible = isVisible;
            labelSquats.Visible = isVisible;
        }

        private void AddUserWindowClose ()
        {
            this.Close();
            textBoxPushUps.Text = null;
            textBoxPullUps.Text = null;
            textBoxSquats.Text = null;
            textBoxPress.Text = null;
            textBoxRun100m.Text = null;
            textBoxPressureUp.Text = null;
            textBoxPressureDown.Text = null;
            textBoxAge.Text = null;
            textBoxGrowth.Text = null;
            textBoxWeight.Text = null;
            textBoxPuls.Text = null;
            textBoxName.Text = null;
            textBoxSecondName.Text = null;
            Page1(true);
            Page2(false);
            Page3(false);
            buttonNextPage.Visible = true;
            page = CurrentPage.Page1;

        }

        //СОБЫТИЯ--------------------------------------------------------------

        private void TextBoxRun100m_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == (char)Keys.Back || e.KeyChar.ToString() == ",")
                e.Handled = false;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;     
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            if (page == CurrentPage.Page1)
            {
                Page1(false);
                Page2(true);
                Page3(false);
                page = CurrentPage.Page2;
                labelHeader.Text = "Физические показатели";
                buttonPrevPage.Visible = true;
                buttonNextPage.Visible = true;
            }
            else if (page == CurrentPage.Page2)
            {
                Page1(false);
                Page2(false);
                Page3(true);
                page = CurrentPage.Page3;
                labelHeader.Text = "Силовые показатели";
                buttonPrevPage.Visible = true;
                buttonNextPage.Visible = false;
            }

        }

        private void buttonPrevPage_Click(object sender, EventArgs e)
        {
            if(page == CurrentPage.Page2)
            {
                Page1(true);
                Page2(false);
                Page3(false);
                page = CurrentPage.Page1;
                labelHeader.Text = "Добавление пользователя";
                buttonPrevPage.Visible = false;
                buttonNextPage.Visible = true;
            }
            if (page == CurrentPage.Page3)
            {
                Page1(false);
                Page2(true);
                Page3(false);
                page = CurrentPage.Page2;              
                labelHeader.Text = "Физические показатели";
                buttonPrevPage.Visible = true;
                buttonNextPage.Visible = true;
            }
        }

        private void TextBoxPressure_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxPressureDown.Text) && !string.IsNullOrEmpty(textBoxPressureUp.Text))
            {
                labelADsr.Text = "АДср = " + (int.Parse(textBoxPressureDown.Text) + ((int.Parse(textBoxPressureUp.Text) - int.Parse(textBoxPressureDown.Text)) / 3));
            }
        }
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPushUps.Text) ||
                string.IsNullOrEmpty(textBoxPullUps.Text) ||
                string.IsNullOrEmpty(textBoxSquats.Text) ||
                string.IsNullOrEmpty(textBoxPress.Text) ||
                string.IsNullOrEmpty(textBoxRun100m.Text))
            {
                MessageBox.Show("Заполните все поля на странице:(Силовые показатели)");
                return;
            }
            if (string.IsNullOrEmpty(textBoxPressureUp.Text) ||
               string.IsNullOrEmpty(textBoxPressureDown.Text) ||
               string.IsNullOrEmpty(textBoxAge.Text) ||
               string.IsNullOrEmpty(textBoxGrowth.Text) ||
               string.IsNullOrEmpty(textBoxWeight.Text) ||
               string.IsNullOrEmpty(textBoxPuls.Text))
            {
                MessageBox.Show("Заполните все поля на странице:(Физические показатели)");
                return;
            }


            double CPwC = calculation.CalculationPowerCondictopn(int.Parse(textBoxPushUps.Text),
                                                            int.Parse(textBoxPullUps.Text),
                                                            int.Parse(textBoxSquats.Text),
                                                            int.Parse(textBoxPress.Text),
                                                            Convert.ToDouble(textBoxRun100m.Text));
            double CPhC = calculation.CalculationPhysicalCondition(int.Parse(textBoxPressureUp.Text),
                                                            int.Parse(textBoxPressureDown.Text),
                                                            int.Parse(textBoxAge.Text),
                                                            int.Parse(textBoxGrowth.Text),
                                                            int.Parse(textBoxWeight.Text),
                                                            int.Parse(textBoxPuls.Text));

            //workWithStatisticsUser.InsertUser(textBoxName.Text, textBoxSecondName.Text, comboBoxGender.Text);

            workWithStatisticsUser.InsertStatisticsUser(workWithDataBase.SelectCountFromDataBase("select * from Users where firstName = '" + textBoxName.Text + "' and lastName = '" + textBoxSecondName.Text + "' and gender = '" + comboBoxGender.Text + "'"),
                                                            int.Parse(textBoxPuls.Text),
                                                            int.Parse(textBoxPressureUp.Text),
                                                            int.Parse(textBoxPressureDown.Text),
                                                            int.Parse(textBoxGrowth.Text),
                                                            int.Parse(textBoxWeight.Text),
                                                            int.Parse(textBoxAge.Text),
                                                            int.Parse(textBoxPullUps.Text),
                                                            int.Parse(textBoxPushUps.Text),
                                                            (float)Convert.ToDouble(textBoxRun100m.Text),
                                                            int.Parse(textBoxSquats.Text),
                                                            int.Parse(textBoxPullUps.Text),
                                                            (float)CPhC,
                                                            (float)CPwC);
            AddUserWindowClose();
        }
        //---------------------------------------------------------------------


    }
}
