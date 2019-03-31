using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingProgram.Class
{
    class AddTpForUser
    {
        WorkWithDataBase workWithDataBase = new WorkWithDataBase();
        public void FilllistBoxUsers(ListBox listBoxUsers)
        {
            int countRows = workWithDataBase.SelectCountFromDataBase("select count (idUsers) from Users");
            string[,] sqlSelect = workWithDataBase.SelectFromDataBase("select idUsers,firstName,lastName from Users",countRows);
            listBoxUsers.Items.Clear();
            for (int i=0; i< countRows;i++)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = sqlSelect[i, 2] + " " + sqlSelect[i, 1];
                listViewItem.Tag = sqlSelect[i, 0];
                listBoxUsers.Items.Add(listViewItem.Text);
            }
        }

    }
}
