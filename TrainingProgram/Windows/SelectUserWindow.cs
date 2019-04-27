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
using static TrainingProgram.MainWindow;

namespace TrainingProgram.Windows
{
    public partial class SelectUserWindow : Form
    {

        MainWindow mainWindow = new MainWindow();
        AddTpForUser addTpForUser = new AddTpForUser();

        public static int idSelectedUser;
        private bool isSelected = false;

        public SelectUserWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void SelectUserWindow_Load(object sender, EventArgs e)
        {
            listViewUser.Cursor = Cursors.Hand;
            addTpForUser.FilllistViewUsers(listViewUser);
        }
        private void SelectUserWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSelected)
            {
                mainWindow.PageMainWindow(true);
                mainWindow.PageAddTpForUsers(false);
                mainWindow.PageTrainigProgramm(false);
            }
        }


        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listViewUser.SelectedItems.Count > 0)
            {
                isSelected = true;
                idSelectedUser = Convert.ToInt32(listViewUser.SelectedItems[0].Tag);
                //запускаем окно статистики
                mainWindow.FillUserBar();
                this.Close();
            }
        }



    }
}
