using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingProgram.Class
{
    class WorkWithWidget
    {

        public void SetWatemarkTextBox (TextBox textBox, string contains)
        {
            textBox.Text = contains;
            textBox.ForeColor = Color.Gray;
        }

        public  void DeleteWotemarktextBox (TextBox textBox)
        {
            if (textBox.Text == textBox.Tag.ToString() && textBox.ForeColor == Color.Gray)
            {
                textBox.Text = null;
                textBox.ForeColor = Color.Black;
            }
        }

        public void SetWatemarkComboBox (ComboBox comboBox, string contains)
        {
            comboBox.Text = contains;
            comboBox.ForeColor = Color.Gray;
        }

        public void DeleteWatemarkComboBox (ComboBox comboBox)
        {
            //comboBox.Items.RemoveAt(0);
            comboBox.ForeColor = Color.Black;
        }
    }
}
