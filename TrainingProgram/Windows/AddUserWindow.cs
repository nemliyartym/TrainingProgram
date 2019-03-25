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
    public partial class AddUserWindow : Form
    {
        enum Page 
        {
            Page1,
            Page2,
            Page3
        }
        private Page page = Page.Page1;

        Calculation calculation = new Calculation();

        public AddUserWindow()
        {
            InitializeComponent();

            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxWeight.KeyPress += TextBox_KeyPress;
            textBoxGrowth.KeyPress += TextBox_KeyPress;
            textBoxPressureUp.KeyPress += TextBox_KeyPress;
            textBoxPressureDown.KeyPress += TextBox_KeyPress;
            textBoxPuls.KeyPress += TextBox_KeyPress;
            textBoxAge.KeyPress += TextBox_KeyPress;

            textBoxPressureDown.TextChanged += TextBoxPressure_TextChanged;
            textBoxPressureUp.TextChanged += TextBoxPressure_TextChanged;

            //textBoxGrowth.LostFocus += TextBox_LostFocus;

        }

        private void TextBoxPressure_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxPressureDown.Text) && !string.IsNullOrEmpty(textBoxPressureUp.Text))
            {
                labelADsr.Text = "АДср = " + (int.Parse(textBoxPressureDown.Text)+((int.Parse(textBoxPressureUp.Text) - int.Parse(textBoxPressureDown.Text))/3));
            }
        }

        //СОБЫТИЯ--------------------------------------------------------------

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;         
        }

        private void Page1 (bool isVisible)
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

        private void Page2 (bool isVisible)
        {
            labelPuls.Visible = isVisible;
            labelPressure.Visible = isVisible;
            labelPressureOR.Visible = isVisible;
            textBoxPressureUp.Visible = isVisible;
            textBoxPressureDown.Visible = isVisible;
            textBoxPuls.Visible = isVisible;
            buttonPrevPage.Visible = isVisible;
            labelADsr.Visible = isVisible;
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            if (page == Page.Page1)
            {
                Page2(true);
                Page1(false);
                page = Page.Page2;           
            }
        }

        private void buttonPrevPage_Click(object sender, EventArgs e)
        {
            if(page == Page.Page2)
            {
                Page2(false);
                Page1(true);
                page = Page.Page1;
            }

        }
        //---------------------------------------------------------------------

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
          double db =  calculation.CalculationPhysicalCondition(int.Parse(textBoxPressureUp.Text),
                                                        int.Parse(textBoxPressureDown.Text),
                                                        int.Parse(textBoxAge.Text),
                                                        int.Parse(textBoxGrowth.Text),
                                                        int.Parse(textBoxWeight.Text),
                                                        int.Parse(textBoxPuls.Text));
        }
    }
}
