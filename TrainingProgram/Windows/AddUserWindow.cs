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
        MainWindow mainWindow = new MainWindow();
        /// <summary>
        /// ид выбранного пользователя в окне AddUserWindow
        /// </summary>
        public static int idSelectedUser;

        public AddUserWindow(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
            addTpForUser.FilllistViewUsers(listViewUser);

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
            addTpForUser.FilllistViewUsers(listViewUser);
        }

        private void listViewUser_DoubleClick(object sender, EventArgs e)
        {
            if (listViewUser.SelectedItems.Count > 0)
            {
                //MessageBox.Show(Convert.ToInt32(listViewUser.SelectedItems[0].Tag).ToString());
                idSelectedUser = Convert.ToInt32(listViewUser.SelectedItems[0].Tag);
                mainWindow.FillInfAboutUser();           
                this.Close();
            }
        }
    }
}
