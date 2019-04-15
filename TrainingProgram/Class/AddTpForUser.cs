using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingProgram.Class
{

    class AddTpForUser
    {
        WorkWithDataBase workWithDataBase = new WorkWithDataBase();
         
        public void FilllistViewUsers(ListView listViewUser)
        {
            int countRows = workWithDataBase.SelectCountFromDataBase("select count (idUsers) from Users");
            string[,] sqlSelect = workWithDataBase.SelectFromDataBase("select idUsers,firstName,lastName from Users", countRows);

            listViewUser.Items.Clear();
            for (int i = 0; i < countRows; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = sqlSelect[i, 1] + " " + sqlSelect[i, 2];
                item.Tag = sqlSelect[i, 0];
                listViewUser.Items.Add(item);
            }
        }

        /// <summary>
        /// Рисуем сектку
        /// </summary>
        public void PicterBoxLoad(PictureBox pictureBox)
        {
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.White);

                Pen pen = new Pen(Color.Gray, 1);
                for (int i = 0; i < 9; i++)
                {
                    graphics.DrawLine(pen, new Point((pictureBox.Width / 10 * (i + 1)), 0), new Point((pictureBox.Width / 10 * (i + 1)), pictureBox.Height));
                    graphics.DrawLine(pen, new Point(0, (pictureBox.Height / 10 * (i + 1))), new Point(pictureBox.Width, (pictureBox.Height / 10 * (i + 1))));
                }
            }


            pictureBox.Image = bitmap;
        }
    }

}

