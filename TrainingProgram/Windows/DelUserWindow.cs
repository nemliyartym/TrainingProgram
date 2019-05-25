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
    public partial class DelUserWindow : Form
    {

        MainWindow mainWindow = new MainWindow();
        AddTpForUser addTpForUser = new AddTpForUser();
        WorkWithUsers workWithUsers = new WorkWithUsers();

        public DelUserWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void DelUserWindow_Load(object sender, EventArgs e)
        {
            listViewUser.Cursor = Cursors.Hand;
            addTpForUser.FilllistViewUsers(listViewUser);
        }

        private void buttonDelUser_Click(object sender, EventArgs e)
        {
            if (listViewUser.SelectedItems.Count != 0)
            {
                workWithUsers.DelUser(Convert.ToInt32(listViewUser.SelectedItems[0].Tag));
                addTpForUser.FilllistViewUsers(listViewUser);
            }
        }
    }
}
