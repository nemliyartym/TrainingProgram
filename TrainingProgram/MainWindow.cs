using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using AxWMPLib;

namespace TrainingProgram
{
    public partial class MainWindow : Form
    {
        public bool boooo = true;


        public MainWindow()
        {
            InitializeComponent();
            Win32.AllocConsole();

           

            WorkWithTree workWithTree = new WorkWithTree(treeViewMusclesAndExercises);
            workWithTree.FillTree();
            treeViewMusclesAndExercises.AfterSelect += TreeViewMusclesAndExercises_AfterSelect;

            //axWindowsMediaPlayer.URL = @"C:\Users\79374\Desktop\imagesFromDB\video\Lesha Svik - Sterva (Premera treka 2019) (MosCatalogue.net).mkv";
            axWindowsMediaPlayer.uiMode = "mini";
            axWindowsMediaPlayer.Ctlcontrols.stop(); 
            

            //WorkWithImages workWithImages = new WorkWithImages();
            //workWithImages.SaveImageToDatbase(@"C:\Users\79374\Desktop\imagesFromDB\video\2.jpg", @"C:\Users\79374\Desktop\imagesFromDB\video\22.mkv", "insert into ImagesForExercises values (@id, @imageName, @imageData, @videoName, @videoData)", 2);


        }

        private void TreeViewMusclesAndExercises_AfterSelect(object sender, TreeViewEventArgs e)
        { 
            if(e.Node.Parent != null)
            {
                WorkWithImages workWithImages = new WorkWithImages();
                string sqlSelect = "select i.imageData from ImagesForExercises i join Exercises e on e.idExercises = i.idExercises where e.idExercises = " + Convert.ToInt32(e.Node.Tag);

                byte[] imageData = workWithImages.RedImageFromDataBase(sqlSelect);
                if (imageData != null)
                {
                    pictureBoxFromImages.Image = Image.FromStream(new MemoryStream(imageData));                
                }
                else pictureBoxFromImages.Image = null;

                sqlSelect = "select i.videoData from ImagesForExercises i join Exercises e on e.idExercises = i.idExercises where e.idExercises = " + Convert.ToInt32(e.Node.Tag);
                byte[] videoData = workWithImages.RedImageFromDataBase(sqlSelect);
                if (videoData != null)
                {
                    string pathToFile;
                    //if (File.Exists(pathToFile))
                    //{
                    //    axWindowsMediaPlayer.Ctlcontrols.stop();
                    //    File.Delete(pathToFile);
                    //    //File.Create(pathToFile);
                    //    Console.WriteLine("delete suces!");
                    //}

                    if (boooo)
                    {
                        pathToFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Video.avi");
                        boooo = false;
                    }
                    else
                    {
                        pathToFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Video1.avi");
                        boooo = true;
                    }

                    File.WriteAllBytes(pathToFile, videoData);

                    axWindowsMediaPlayer.Visible = true;
                    axWindowsMediaPlayer.URL = pathToFile;
                    axWindowsMediaPlayer.Ctlcontrols.stop();
                }
                else
                {
                    axWindowsMediaPlayer.Ctlcontrols.stop();
                    axWindowsMediaPlayer.Visible = false;
                }

            }

        }

        private void buttonSearchExercises_Click(object sender, EventArgs e)
        {
            //начальный интерфейс
            buttonSearchMusclesAndExercises.Visible = false;
            buttonAddTrainingProgram.Visible = false;
            buttonBack.Visible = true;

            //параметры окна
            //this.AutoScroll = true;

            //элементы для окна просмотра упражнений
            treeViewMusclesAndExercises.Visible = true;
            pictureBoxFromImages.Visible = true;
            axWindowsMediaPlayer.Visible = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //начальный интерфейс
            buttonSearchMusclesAndExercises.Visible = true;
            buttonAddTrainingProgram.Visible = true;
            buttonBack.Visible = false;

            //параметры окна
            //this.AutoScroll = false;

            //скрываем мусор
            treeViewMusclesAndExercises.Visible = false;
            pictureBoxFromImages.Visible = false;
            axWindowsMediaPlayer.Visible = false;
            axWindowsMediaPlayer.Ctlcontrols.stop();
        }

        private void buttonAddTrainingProgram_Click(object sender, EventArgs e)
        {
            //начальный интерфейс
            buttonSearchMusclesAndExercises.Visible = true;
            buttonAddTrainingProgram.Visible = true;
            buttonBack.Visible = false;
        }
    }
}
