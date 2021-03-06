﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingProgram.Windows;

namespace TrainingProgram.Class
{

    class AddTpForUser
    {
        WorkWithDataBase workWithDataBase = new WorkWithDataBase();
        // dataFromWindows = new DataFromWindows();

        public void FillComboBoxStatistic (ComboBox comboBox)
        {
            string[] nameItemColumn = {"Физические показатели",
                                       "Силовые показатели",
                                        "Вес",
                                        "Подтягивания",
                                        "Отжимания",
                                        "Бег",
                                        "Приседания",
                                        "Пресс"};
            comboBox.Items.Clear();
            for (int i=0; i < nameItemColumn.Length; i++)
            {
                comboBox.Items.Add(nameItemColumn[i]);
            }
            comboBox.SelectedIndex = 0;
        }

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

        public void FillListViewStatisticUser(ListView listViewUser)
        {
            int countRows = workWithDataBase.SelectCountFromDataBase("Select count (idUsers) from StatisticsUsers where idUsers =" + SelectUserWindow.idSelectedUser);
            string[,] sqlSelect = workWithDataBase.SelectFromDataBase("select idUsers,dateTime from StatisticsUsers where idUsers = " + SelectUserWindow.idSelectedUser + " order by dateTime", countRows);

            listViewUser.Items.Clear();
            for (int i = 0; i < countRows; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Convert.ToDateTime(sqlSelect[i, 1]).ToShortDateString();
                item.Tag = sqlSelect[i, 0];
                listViewUser.Items.Add(item);
            }
        }

        /// <summary>
        /// филим кобму со статой
        /// </summary>
        /// <param name="nameColumn">weight pullUps pushUp run100m squts press cPhc(физическое состояние) cPwc(силовые показатели)</param>
        public void PicterBoxLoad(PictureBox pictureBox, string nameColumn)
        {
            int countRows = workWithDataBase.SelectCountFromDataBase("Select count (idUsers) from StatisticsUsers where idUsers =" + SelectUserWindow.idSelectedUser);
            string[,] sqlSelectData = workWithDataBase.SelectFromDataBase("select dateTime," + nameColumn + " from StatisticsUsers where idUsers = " + SelectUserWindow.idSelectedUser + " order by dateTime", countRows);

            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Point[] arrayPoint = new Point[countRows];

                int lenghtOx = 780;
                int lenghtOy = 180;

                int offsetLenghtOx = lenghtOx - ((lenghtOx * 1) / 10);
                int offsetLenghtOy = lenghtOy - ((lenghtOy * 2)/ 10);

                graphics.Clear(Color.White);

                Pen pen = new Pen(Color.FromArgb(205,205,205), 1);
                pen = new Pen(Color.Black, 4);

                pen.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                graphics.DrawLine(pen,new Point(20,10), new Point(20, lenghtOy));
                graphics.DrawLine(pen, new Point(lenghtOx, lenghtOy), new Point(18, lenghtOy));

                pen = new Pen(Color.Black, 5);
                for (int i = 0; i < countRows; i++) 
                {                  
                    int Ox = 0;
                    
                    if(countRows  == 1)
                        Ox = lenghtOx / 2;
                    else if(countRows == 2)
                        Ox = (lenghtOx * (i + 1)) / (3);
                    else 
                    {
                        Ox = ((lenghtOx * (i + 1))/(countRows + 1 ));
                    //    if (i == 0)
                    //        Ox = lenghtOx - offsetLenghtOx;
                    //    else if (i == countRows - 1) 
                    //        Ox = offsetLenghtOx;
                    //    else
                    //    {
                    //        int currentDate = (int)(Convert.ToDateTime(sqlSelectData[i, 0]) - Convert.ToDateTime(sqlSelectData[0, 0])).TotalSeconds;
                    //        int maxDate = (int)(Convert.ToDateTime(sqlSelectData[sqlSelectData.GetLength(0) - 1, 0]) - Convert.ToDateTime(sqlSelectData[0, 0])).TotalSeconds;
                    //        int procentDate = ((currentDate * 100) / maxDate);
                    //        Ox = ((lenghtOx * procentDate) / 100);
                    //    }
                    }


                    graphics.DrawString(Convert.ToDateTime(sqlSelectData[i, 0]).ToShortDateString(), new Font("Arial", 11), Brushes.Black, Ox - 35, 185);           
                    pen = new Pen(Color.Black, 3);
                    arrayPoint[i].X = Ox;                
                }

                for (int i = 0; i < countRows; i++)
                {
                    int Oy = 0;
                    if (countRows == 1)
                        Oy = lenghtOy / 2;
                    else if (countRows == 2)
                    {
                        if (double.Parse(sqlSelectData[0, 1]) == double.Parse(sqlSelectData[1, 1]))
                            Oy = (lenghtOy) / 2;
                        else if (i == 0)
                        {
                            if (double.Parse(sqlSelectData[0, 1]) > double.Parse(sqlSelectData[1, 1]))
                                Oy = (lenghtOy * 1) / 3;
                            else Oy = (lenghtOy * 2) / 3;
                        }
                        else if (i == 1)
                        {
                            if(double.Parse(sqlSelectData[1, 1]) > double.Parse(sqlSelectData[0, 1]))
                                Oy = (lenghtOy * 1) / 3;
                            else Oy = (lenghtOy * 2) / 3;
                        }
                    }
                    else
                    {
                        int minColumn = SearchMinColumn(sqlSelectData);
                        int maxColumn = SearchMaxColumn(sqlSelectData);
                        if (i == minColumn)
                            Oy = lenghtOy + 20 - (lenghtOy - offsetLenghtOy);
                        else if (i == maxColumn)
                            Oy = lenghtOy - offsetLenghtOy - 20;
                        else
                        {
                            if (Convert.ToDouble(sqlSelectData[i, 1]) == Convert.ToDouble(sqlSelectData[minColumn, 1]))
                                Oy = lenghtOy + 20 - (lenghtOy - offsetLenghtOy);
                            else if(Convert.ToDouble(sqlSelectData[i, 1]) == Convert.ToDouble(sqlSelectData[maxColumn, 1]))
                                Oy = lenghtOy - offsetLenghtOy - 20;
                            else
                            {
                                double currentColumn = Convert.ToDouble(sqlSelectData[i, 1]) - Convert.ToDouble(sqlSelectData[minColumn, 1]);
                                double maxColum = Convert.ToDouble(sqlSelectData[maxColumn, 1]) - Convert.ToDouble(sqlSelectData[minColumn, 1]);
                                int procentColumn = Convert.ToInt32((currentColumn * 100) / maxColum);
                                Oy = lenghtOy - (((lenghtOy - 18) * procentColumn) / 100);
                            }
                        }
                    }
                    pen = new Pen(Color.Black, 3);
                  
                    arrayPoint[i].Y = Oy;
                    //pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    //graphics.DrawLine(pen, new Point(Ox +1,180), new Point(Ox + 1,Oy));
                    //graphics.DrawLine(pen, new Point(20, Oy), new Point(Ox, Oy));   
                }

                if(arrayPoint.Length == 1)
                {
                    graphics.Clear(Color.White);
                    graphics.DrawString("Стаитика появится только полсе внесения первой контрольной точки!", new Font("Arial", 10), Brushes.Black, pictureBox.Width/4,pictureBox.Height/3 );
                }
                else if (arrayPoint.Length >= 2)
                {
                   // graphics.DrawCurve(pen, arrayPoint);

                    for (int i=0; i<arrayPoint.Length;i++)
                    {
                        graphics.DrawRectangle(pen,arrayPoint[i].X, arrayPoint[i].Y, 3, lenghtOy - arrayPoint[i].Y);
                        graphics.DrawRectangle(pen, arrayPoint[i].X, arrayPoint[i].Y, 1, 1);

                        string[] modulo = sqlSelectData[i, 1].Split(',');
                        string result = sqlSelectData[i, 1];

                        if (modulo.Length >=2)
                        {
                            if (Convert.ToDouble(modulo[1]) == 0)
                                result = modulo[0];
                        }
                        graphics.DrawString(result, new Font("Arial", 11), Brushes.Black, arrayPoint[i].X + 5, arrayPoint[i].Y -2 );

                    }
                }


            }
            pictureBox.Image = bitmap;        
        }

        private int SearchMinColumn (string[,] columns)
        {
            double currentColumn = Convert.ToDouble(columns[0,1]);
            int _i = 0;
            for (int i=0; i<columns.GetLength(0);i++)
            {
                if (currentColumn > Convert.ToDouble(columns[i, 1]))
                {
                    currentColumn = Convert.ToDouble(columns[i, 1]);
                    _i = i;
                }
            }
            return _i;
        }

        private int SearchMaxColumn(string[,] columns)
        {
            double currentColumn = Convert.ToDouble(columns[0, 1]);
            int _i = 0;
            for (int i = 0; i < columns.GetLength(0); i++)
            {
                if (currentColumn < Convert.ToDouble(columns[i, 1]))
                {
                    currentColumn = Convert.ToDouble(columns[i, 1]);
                    _i = i;
                }
            }
            return _i;
        }
    }

}

