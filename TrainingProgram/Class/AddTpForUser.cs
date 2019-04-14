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

        public void FilllistViewUsers( ListView listViewUser)
        {
            int countRows = workWithDataBase.SelectCountFromDataBase("select count (idUsers) from Users");
            string[,] sqlSelect = workWithDataBase.SelectFromDataBase("select idUsers,firstName,lastName from Users",countRows);

            listViewUser.Items.Clear();
            for(int i=0; i<countRows; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = sqlSelect[i, 1] + " " + sqlSelect[i, 2];
                item.Tag = sqlSelect[i, 0];
                listViewUser.Items.Add(item);
            }
        }
        
  

    }
}
