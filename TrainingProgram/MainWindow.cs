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
        public string currentStrDescriptionExercises;
        public int id = 0;
        public TreeNode treeNode = new TreeNode();



        WorkWithImages workWithImages = new WorkWithImages();
        WorkWithDataBase workWithDatabas = new WorkWithDataBase();
        AddTrainingProgram addTrainingProgram = new AddTrainingProgram();

        public MainWindow()
        {
            InitializeComponent();
            Win32.AllocConsole();


            addTrainingProgram.FillLisViewUsers(listViewUsers);

            WorkWithTree workWithTree = new WorkWithTree(treeViewMusclesAndExercises);
            workWithTree.FillTree();

            treeViewMusclesAndExercises.AfterSelect += TreeViewMusclesAndExercises_AfterSelect;
            treeViewMusclesAndExercises.BeforeSelect += TreeViewMusclesAndExercises_BeforeSelect;

            //axWindowsMediaPlayer.URL = @"C:\Users\79374\Desktop\imagesFromDB\video\Lesha Svik - Sterva (Premera treka 2019) (MosCatalogue.net).mkv";
            //axWindowsMediaPlayer.uiMode = "mini";
            //axWindowsMediaPlayer.Ctlcontrols.stop();


            //workWithImages.Sa(@"C:\Users\79374\Desktop\imagesFromDB\video\2.jpg", @"C:\Users\79374\Desktop\imagesFromDB\video\22.mkv", "insert into ImagesForExercises values (@id, @imageName, @imageData, @videoName, @videoData)", 2);
            //workWithImages.SaveImageVideoToDatbase("ImagesForExercises", @"C:\Users\79374\Desktop\imagesFromDB\video\2.jpg", @"C:\Users\79374\Desktop\imagesFromDB\video\22.mkv", 3);

           // workWithImages.SaveImageVideoToDatbase("ImagesForExercises", null, @"C:\Users\79374\Desktop\imagesFromDB\video\22.mkv",4);
        }


        private void treeViewMusclesAndExercises_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                treeViewMusclesAndExercises.SelectedNode = e.Node;
                if (e.Node.Parent != null)
                {
                    contextMenuStripFromTree.Show(treeViewMusclesAndExercises, e.Location);
                }
            }
        }

        private void TreeViewMusclesAndExercises_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            //treeNode.BackColor = Color.White;
            if (e.Node.Parent != null)
            {
                //e.Node.BackColor = Color.FromArgb(0, 120, 215);
                //if(File.Exists(pathFromDeletFile))
                //    File.Delete(pathFromDeletFile);

                buttonSaveDescription.Enabled = false;
                labelHeadExercises.Text = e.Node.Text;
                buttonAddImage.Visible = true;
                buttonAddVideo.Visible = true;
                labelHeadExercises.Visible = true;
                pictureBoxFromImages.Visible = true;
                richTextBoxDescriptionExercises.Visible = true;
                labelDescription.Visible = true;
                checkBoxDescription.Visible = true;
                buttonSaveDescription.Visible = true;

                treeNode = e.Node;
                id = Convert.ToInt32(e.Node.Tag);

                //string[] discription = workWithDatabas.SelectFromDataBase("select description from Exercises where idExercises = " + Convert.ToInt32(e.Node.Tag));
                //if (discription[0] == null || discription[0] == "" || discription[0] == " ")
                //{
                //    richTextBoxDescriptionExercises.Text = "Информация пока отсуствует в бд";
                //    currentStrDescriptionExercises = "Информация пока отсуствует в бд";
                //}
                //else
                //{
                //    richTextBoxDescriptionExercises.Text = discription[0].ToString();
                //    currentStrDescriptionExercises = discription[0].ToString();
                //}

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

                //    string pathToFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), workWithImages.GetNameFile("VIDEO", Convert.ToInt32(treeNode.Tag)));

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
                buttonSaveDescription.Visible = false;
            }

        }

        private void TreeViewMusclesAndExercises_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
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
            labelDescription.Visible = false;
            axWindowsMediaPlayer.Visible = false;
            buttonAddVideo.Visible = false;
            buttonSaveDescription.Visible = false;
            richTextBoxDescriptionExercises.Visible = false;
            axWindowsMediaPlayer.Ctlcontrols.stop();            
        }

        private void buttonAddTrainingProgram_Click(object sender, EventArgs e)
        {
            //начальный интерфейс
            buttonSearchMusclesAndExercises.Visible = false;
            buttonAddTrainingProgram.Visible = false;
            buttonBack.Visible = false;
            listViewTrainingProgramm.Visible = true;
            listViewUsers.Visible = true;

            monthCalendar.Visible = true;
            buttonBackCalander.Visible = true;
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

            //if (File.Exists(pathFromDeletFile))
            //    File.Delete(pathFromDeletFile);

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

        private void richTextBoxDescriptionExercises_Leave(object sender, EventArgs e)
        {
            if(currentStrDescriptionExercises != richTextBoxDescriptionExercises.Text)
            {
                DialogResult result =  MessageBox.Show("Сохранить результат?", "Сохранение", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    workWithDatabas.UpdateDescriptionExercises(richTextBoxDescriptionExercises.Text, id);
                    currentStrDescriptionExercises = richTextBoxDescriptionExercises.Text;
                    this.Focus();
                    Console.WriteLine("Обновили дискрипт с id =" + id);

                }
                else if (result == DialogResult.No)
                    richTextBoxDescriptionExercises.Text = currentStrDescriptionExercises;
                else if (result == DialogResult.Cancel)
                    return;
            }
        }

        private void buttonSaveDescription_Click(object sender, EventArgs e)
        {
            if (currentStrDescriptionExercises != richTextBoxDescriptionExercises.Text)
            {
                DialogResult result = MessageBox.Show("Сохранить результат?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    workWithDatabas.UpdateDescriptionExercises(richTextBoxDescriptionExercises.Text, id);
                    currentStrDescriptionExercises = richTextBoxDescriptionExercises.Text;
                    this.Focus();
                    buttonSaveDescription.Enabled = false;
                    Console.WriteLine("Обновили дискрипт с id =" + id);

                }
                else if (result == DialogResult.No)
                    richTextBoxDescriptionExercises.Text = currentStrDescriptionExercises;
                else if (result == DialogResult.Cancel)
                    return;
            }
        }

        private void richTextBoxDescriptionExercises_TextChanged(object sender, EventArgs e)
        {
            if (currentStrDescriptionExercises != richTextBoxDescriptionExercises.Text)
            {
                buttonSaveDescription.Enabled = true;
            }
            else buttonSaveDescription.Enabled = false;
        }

        private void переименоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeNode.BeginEdit();       
        }

        private void treeViewMusclesAndExercises_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            MessageBox.Show(e.Node.Text);
            //if(treeNode.Text == "" || treeNode.Text == " ")
            //{
            //    MessageBox.Show("Поле не может быть пустым");
            //    переименоватьToolStripMenuItem_Click(sender, null);
            //}
            //string str = treeNode.Text;
            //workWithDatabas.UpdateNameExercises(e.Node.Text, Convert.ToInt32(e.Node.Tag));
        }

        private void treeViewMusclesAndExercises_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            MessageBox.Show(e.Node.Text);
        }



        private void buttonBackCalander_Click(object sender, EventArgs e)
        {
            monthCalendar.Visible = false;
            buttonAddTrainingProgram.Visible = true;
            buttonSearchMusclesAndExercises.Visible = true;
            buttonBackCalander.Visible = false;
            listViewTrainingProgramm.Visible = false;
            listViewUsers.Visible = false;
        }

        private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count > 0)
            {
                addTrainingProgram.FilllistViewTrainingProgramm(listViewTrainingProgramm, Convert.ToInt32(listViewUsers.SelectedItems[0].Text));
            }          
        }



        private void buttonNext_Click(object sender, EventArgs e)
        {
            addTrainingProgram.ButtonNext(labelDayWeek);
            listViewUsers_SelectedIndexChanged(sender, e);
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            addTrainingProgram.ButtonPre(labelDayWeek);
            listViewUsers_SelectedIndexChanged(sender, e);
        }
    }
}
