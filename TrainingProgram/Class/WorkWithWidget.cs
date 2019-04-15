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
        public void DeleteWotemarktextBox (TextBox textBox)
        {
            textBox.Text = null;
            textBox.ForeColor = Color.Black;
        }

    }
}
