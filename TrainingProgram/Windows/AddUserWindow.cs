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
        WorkWithUsers workWithUsers = new WorkWithUsers();
        AddTpForUser addTpForUser = new AddTpForUser();

        public AddUserWindow()
        {
            InitializeComponent();

            addTpForUser.FilllistBoxUsers(listBoxUsers);

            comboBoxGender.SelectedIndex = 0;
            textBoxName.TextChanged += TextBox_TextChanged;
            textBoxSecondName.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text != String.Empty && textBoxSecondName.Text != String.Empty)
                buttonAddUser.Enabled = true;
            else buttonAddUser.Enabled = false;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            workWithUsers.InsertUser(textBoxName.Text,
                                        textBoxSecondName.Text,
                                        comboBoxGender.Text,
                                        dateTimePicker.Value.Date);
            textBoxName.Clear();
            textBoxSecondName.Clear();
            comboBoxGender.SelectedItem = 0;
            dateTimePicker.Value = DateTime.Now;
            addTpForUser.FilllistBoxUsers(listBoxUsers);
        }

        private void listBoxUsers_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItems.Count > 0)
            {
                MessageBox.Show(listBoxUsers.SelectedItem.ToString());
            }
        }
    }
}
