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
using Microsoft.DirectX.AudioVideoPlayback;
using AxWMPLib;
using System.Threading;

namespace TrainingProgram
{
    public partial class MainWindow : Form
    {
        public string pathFromDeletFile = null;
        public int id = 0;
        public TreeNode treeNode = new TreeNode();



        WorkWithImages workWithImages = new WorkWithImages();
        WorkWithDataBase workWithDatabas = new WorkWithDataBase();

        public MainWindow()
        {
            InitializeComponent();
            Win32.AllocConsole();

            WorkWithTree workWithTree = new WorkWithTree(treeViewMusclesAndExercises);
            workWithTree.FillTree();
            treeViewMusclesAndExercises.AfterSelect += TreeViewMusclesAndExercises_AfterSelect;


            //axWindowsMediaPlayer.URL = @"C:\Users\79374\Desktop\imagesFromDB\video\Lesha Svik - Sterva (Premera treka 2019) (MosCatalogue.net).mkv";
            //axWindowsMediaPlayer.uiMode = "mini";
            //axWindowsMediaPlayer.Ctlcontrols.stop();


            //workWithImages.Sa(@"C:\Users\79374\Desktop\imagesFromDB\video\2.jpg", @"C:\Users\79374\Desktop\imagesFromDB\video\22.mkv", "insert into ImagesForExercises values (@id, @imageName, @imageData, @videoName, @videoData)", 2);
            //workWithImages.SaveImageVideoToDatbase("ImagesForExercises", @"C:\Users\79374\Desktop\imagesFromDB\video\2.jpg", @"C:\Users\79374\Desktop\imagesFromDB\video\22.mkv", 3);

           // workWithImages.SaveImageVideoToDatbase("ImagesForExercises", null, @"C:\Users\79374\Desktop\imagesFromDB\video\22.mkv",4);


        }

        private void TreeViewMusclesAndExercises_AfterSelect(object sender, TreeViewEventArgs e)
        {       
            if (e.Node.Parent != null)
            {
                //if(File.Exists(pathFromDeletFile))
                //    File.Delete(pathFromDeletFile);

                labelHeadExercises.Text = e.Node.Text;
                buttonAddImage.Visible = true;
                buttonAddVideo.Visible = true;
                labelHeadExercises.Visible = true;
                pictureBoxFromImages.Visible = true;
                richTextBoxDescriptionExercises.Visible = true;
                labelDescription.Visible = true;
                checkBoxDescription.Visible = true;

                treeNode = e.Node;

                string[] discription = workWithDatabas.SelectFromDataBase("select description from Exercises where idExercises = " + Convert.ToInt32(e.Node.Tag));
                if (discription[0] == null)
                    richTextBoxDescriptionExercises.Text = "Информация пока отсуствует в бд";
                else richTextBoxDescriptionExercises.Text = discription[0].ToString();

                string sqlSelect = "select i.imageData from ImagesForExercises i join Exercises e on e.idExercises = i.idExercises where e.idExercises = " + Convert.ToInt32(e.Node.Tag);
                byte[] imageData = workWithImages.RedImageFromDataBase(sqlSelect);
                if (imageData != null)
                {
                    pictureBoxFromImages.Image = Image.FromStream(new MemoryStream(imageData));
                }
                else pictureBoxFromImages.Image = null;



                //sqlSelect = "select i.videoData from ImagesForExercises i join Exercises e on e.idExercises = i.idExercises where e.idExercises = " + Convert.ToInt32(e.Node.Tag);
                //byte[] videoData = workWithImages.RedImageFromDataBase(sqlSelect);

                //if (videoData != null)
                //{

                //    string  pathToFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), workWithImages.GetNameFile("VIDEO", Convert.ToInt32(treeNode.Tag)));
                    
                //    File.WriteAllBytes(pathToFile, videoData);

                //    axWindowsMediaPlayer.Visible = true;
                //    axWindowsMediaPlayer.URL = pathToFile;
                //    axWindowsMediaPlayer.newMedia(pathToFile);
                //    pathFromDeletFile = pathToFile;
                //    axWindowsMediaPlayer.Ctlcontrols.stop();
                    
                //}
                //else
                //{
                //    axWindowsMediaPlayer.Ctlcontrols.stop();
                //    axWindowsMediaPlayer.Visible = false;
                //}

            }
            else
            {
                buttonAddImage.Visible = false;
                buttonAddVideo.Visible = false;
                pictureBoxFromImages.Visible = false;
                axWindowsMediaPlayer.Visible = false;
                labelHeadExercises.Visible = false;
                labelDescription.Visible = false;
                checkBoxDescription.Visible = false;
                richTextBoxDescriptionExercises.Visible = false;
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
            buttonAddImage.Visible = false;
            pictureBoxFromImages.Visible = false;
            labelHeadExercises.Visible = false;       
            axWindowsMediaPlayer.Visible = false;
            buttonAddVideo.Visible = false;
            richTextBoxDescriptionExercises.Visible = false;
           axWindowsMediaPlayer.Ctlcontrols.stop();            
        }

        private void buttonAddTrainingProgram_Click(object sender, EventArgs e)
        {
            //начальный интерфейс
            buttonSearchMusclesAndExercises.Visible = true;
            buttonAddTrainingProgram.Visible = true;
            buttonBack.Visible = false;
        }





        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFilezDialog = new OpenFileDialog();
            openFilezDialog.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF ";//| All files(*.*) | *.*";

            if (openFilezDialog.ShowDialog() == DialogResult.Cancel)
                return;
            workWithImages.SaveImageToDatbase(openFilezDialog.FileName, Convert.ToInt32(treeNode.Tag));
            Console.WriteLine(openFilezDialog.FileName + "\n" +treeNode.Tag.ToString());

            string sqlSelect = "select i.imageData from ImagesForExercises i join Exercises e on e.idExercises = i.idExercises where e.idExercises = " + Convert.ToInt32(treeNode.Tag);

            byte[] imageData = workWithImages.RedImageFromDataBase(sqlSelect);
            if (imageData != null)
            {
                pictureBoxFromImages.Image = Image.FromStream(new MemoryStream(imageData));
            }

            pictureBoxFromImages.Visible = true;
           
        }





        private void buttonAddVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFilezDialog = new OpenFileDialog();
            openFilezDialog.Filter = "Video Files(*.WMV; *.MP4; *.AVI; *.MOV; *.F4V; *.MKV; *.TS; *.3GP; *.GIF; *.MP3;)| *.WMV; *.MP4; *.AVI; *.MOV; *.F4V; *.MKV; *.TS; *.3GP; *.GIF; *.MP3;";//| All files(*.*) | *.*";

            if (openFilezDialog.ShowDialog() == DialogResult.Cancel)
                return;

            if (File.Exists(pathFromDeletFile))
                File.Delete(pathFromDeletFile);

            workWithImages.SaveVideoiToDatbase(openFilezDialog.FileName, Convert.ToInt32(treeNode.Tag));
            Console.WriteLine(openFilezDialog.FileName + "\n" + treeNode.Tag.ToString());

            string sqlSelect = "select i.videoData from ImagesForExercises i join Exercises e on e.idExercises = i.idExercises where e.idExercises = " + Convert.ToInt32(treeNode.Tag);

            byte[] videoData = workWithImages.RedImageFromDataBase(sqlSelect);

            //if (videoData != null)
            //{

            //    string pathToFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), workWithImages.GetNameFile("VIDEO", Convert.ToInt32(treeNode.Tag)));
            //    File.WriteAllBytes(pathToFile, videoData);

            //    File.WriteAllBytes(pathToFile, videoData);

            //    axWindowsMediaPlayer.Visible = true;
            //    axWindowsMediaPlayer.URL = pathToFile;
            //    pictureBoxFromImages.Visible = true;
            //    axWindowsMediaPlayer.Ctlcontrols.stop();
            //}


        }

        private void checkBoxDescription_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBoxDescriptionExercises.ReadOnly)
            {
                richTextBoxDescriptionExercises.ReadOnly = false;
                richTextBoxDescriptionExercises.BackColor = Color.White;
            }
            else
            {
                richTextBoxDescriptionExercises.ReadOnly = true;
                richTextBoxDescriptionExercises.BackColor = Color.FromArgb(240, 240, 240);
            }
            
        }
    }
}
