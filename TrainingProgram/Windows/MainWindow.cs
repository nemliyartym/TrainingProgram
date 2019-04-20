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
using System.Threading;
using TrainingProgram.Class;
using TrainingProgram.Windows;

namespace TrainingProgram
{

    public partial class MainWindow : Form
    {
        private string currentStrDescriptionExercises;
        private int id = 0;
        private TreeNode treeNode = new TreeNode();

        public string[] nameColumnFromCoboBox = {"cPhc", "cPwc"};

        #region Enum FromsInterface
        private enum CurrentPageMainWindow
        {
            pageMainWindow,
            pageViewingExercises,
            pageTrainigProgramm,
            pageAddTpForUser
        }
        CurrentPageMainWindow currentPageMainWindow;
        #endregion

        WorkWithImages workWithImages = new WorkWithImages();
        WorkWithDataBase workWithDataBase = new WorkWithDataBase();
        AddTrainingProgram addTrainingProgram = new AddTrainingProgram();
        WorkWithTrainigProgram workWithTrainigProgram = new WorkWithTrainigProgram();
        AddTpForUser addTpForUser = new AddTpForUser();
        //public AddUserWindow addUserwindow = new AddUserWindow();

        public MainWindow()
        {
            InitializeComponent();
            Win32.AllocConsole();

            addTrainingProgram.FillLisViewUsers(listViewUsers);
            addTrainingProgram.FillComboBoxMuscles(comboBoxMuscles);

            WorkWithTree workWithTree = new WorkWithTree(treeViewMusclesAndExercises);
            workWithTree.FillTree();

            treeViewMusclesAndExercises.BeforeSelect += TreeViewMusclesAndExercises_BeforeSelect;

            //axWindowsMediaPlayer.URL = @"C:\Users\79374\Desktop\imagesFromDB\video\Lesha Svik - Sterva (Premera treka 2019) (MosCatalogue.net).mkv";
            //axWindowsMediaPlayer.uiMode = "mini";
            //axWindowsMediaPlayer.Ctlcontrols.stop();


            //workWithImages.Sa(@"C:\Users\79374\Desktop\imagesFromDB\video\2.jpg", @"C:\Users\79374\Desktop\imagesFromDB\video\22.mkv", "insert into ImagesForExercises values (@id, @imageName, @imageData, @videoName, @videoData)", 2);
            //workWithImages.SaveImageVideoToDatbase("ImagesForExercises", @"C:\Users\79374\Desktop\imagesFromDB\video\2.jpg", @"C:\Users\79374\Desktop\imagesFromDB\video\22.mkv", 3);

            // workWithImages.SaveImageVideoToDatbase("ImagesForExercises", null, @"C:\Users\79374\Desktop\imagesFromDB\video\22.mkv",4);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
                    
        }

        //---------------INTEFACE-----------------------------
        private void PageMainWindow (bool isVisible)
        {
            buttonSearchMusclesAndExercises.Visible = isVisible;
            buttonAddTrainingProgram.Visible = isVisible;
            buttonAddTpForUser.Visible = isVisible;
            buttonBack.Visible = !isVisible;
        }
        private void PageViewingExercises (bool isVisible)
        {
            treeViewMusclesAndExercises.Visible = isVisible;
            buttonBack.Visible = isVisible;
            currentPageMainWindow = CurrentPageMainWindow.pageViewingExercises;
        }
        private void PageViewingExercisesOther (bool isVisible)
        {
            buttonAddVideo.Visible = isVisible;
            buttonSaveDescription.Visible = isVisible;
            labelDescription.Visible = isVisible;
            checkBoxDescription.Visible = isVisible;
            buttonAddImage.Visible = isVisible;
            richTextBoxDescriptionExercises.Visible = isVisible;
            pictureBoxFromImages.Visible = isVisible;
            labelHeadExercises.Visible = isVisible;
        }
        private void PageTrainigProgramm (bool isVisible)
        {
            listViewExercises.Visible = isVisible;
            comboBoxMuscles.Visible = isVisible;
            listViewTrainingProgramm.Visible = isVisible;
            listViewUsers.Visible = isVisible;
            buttonNext.Visible = isVisible;
            buttonPrev.Visible = isVisible;
            buttonBack.Visible = isVisible;
            labelDayWeek.Visible = isVisible;
            currentPageMainWindow = CurrentPageMainWindow.pageTrainigProgramm;
        }
        private void PageAddTpForUsers (bool isVisible)
        {
            //tableLayoutPanelInfAboutUser.Visible = isVisible;
            panelAddTpForUser.Visible = isVisible;
            currentPageMainWindow = CurrentPageMainWindow.pageAddTpForUser;
        }
        //------------------------INTEFACEMANAGMENT----------------------------------
        private void buttonSearchExercises_Click(object sender, EventArgs e)
        {
            PageMainWindow(false);
            PageViewingExercises(true);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            PageMainWindow(true);
            if (currentPageMainWindow == CurrentPageMainWindow.pageTrainigProgramm)
            {
                PageTrainigProgramm(false);
            }
            else if (currentPageMainWindow == CurrentPageMainWindow.pageViewingExercises)
            {
                PageViewingExercises(false);
                PageViewingExercisesOther(false);
            }
            else if(currentPageMainWindow == CurrentPageMainWindow.pageAddTpForUser)
            {
                PageAddTpForUsers(false);
            }
        }
        //------------------------------------------------------------------------
        private void buttonAddTpForUser_Click(object sender, EventArgs e)
        {
            PageMainWindow(false);

            AddUserWindow addUserWndow = new AddUserWindow(this);
            addUserWndow.StartPosition = FormStartPosition.CenterParent;
            addUserWndow.ShowDialog();
        }

        private void buttonAddTrainingProgram_Click(object sender, EventArgs e)
        {
            PageMainWindow(false);
            PageTrainigProgramm(true);
        }
        //---------------------------------------------------------------------------

        private void treeViewMusclesAndExercises_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
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
                int countRows = workWithDataBase.SelectCountFromDataBase("select count (*) from Exercises where idExercises = " + Convert.ToInt32(e.Node.Tag));
                string[,] discription = workWithDataBase.SelectFromDataBase("select description from Exercises where idExercises = " + Convert.ToInt32(e.Node.Tag), countRows);
                if (discription[0, 0] == null || discription[0, 0] == "" || discription[0, 0] == " ")
                {
                    richTextBoxDescriptionExercises.Text = "Информация пока отсуствует в бд";
                    currentStrDescriptionExercises = "Информация пока отсуствует в бд";
                }
                else
                {
                    richTextBoxDescriptionExercises.Text = discription[0, 0].ToString();
                    currentStrDescriptionExercises = discription[0, 0].ToString();
                }

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

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFilezDialog = new OpenFileDialog();
            openFilezDialog.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF ";//| All files(*.*) | *.*";

            if (openFilezDialog.ShowDialog() == DialogResult.Cancel)
                return;
            workWithImages.SaveImageToDatbase(openFilezDialog.FileName, Convert.ToInt32(treeNode.Tag));
            Console.WriteLine(openFilezDialog.FileName + "\n" + treeNode.Tag.ToString());

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
            if (currentStrDescriptionExercises != richTextBoxDescriptionExercises.Text)
            {
                DialogResult result = MessageBox.Show("Сохранить результат?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    workWithDataBase.UpdateDescriptionExercises(richTextBoxDescriptionExercises.Text, id);
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
                    workWithDataBase.UpdateDescriptionExercises(richTextBoxDescriptionExercises.Text, id);
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
            buttonAddTrainingProgram.Visible = true;
            buttonSearchMusclesAndExercises.Visible = true;

            listViewExercises.Visible = false;
            listViewTrainingProgramm.Visible = false;
            listViewUsers.Visible = false;
            buttonNext.Visible = false;
            buttonPrev.Visible = false;
            labelDayWeek.Visible = false;
            comboBoxMuscles.Visible = false;

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

        private void comboBoxMuscles_SelectedIndexChanged(object sender, EventArgs e)
        {
            addTrainingProgram.FillListViewExrcises(listViewExercises, Convert.ToInt32((comboBoxMuscles.SelectedItem as ComboboxItem).Tag));
        }

        private void listViewExercises_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewExercises.SelectedItems.Count > 0)
            {
                workWithTrainigProgram.InsertExercisesInTrainigProgram(addTrainingProgram.currentDaysWeek,
                    Convert.ToInt32(listViewExercises.SelectedItems[0].Tag),
                    Convert.ToInt32(listViewUsers.SelectedItems[0].Text));
                addTrainingProgram.FilllistViewTrainingProgramm(listViewTrainingProgramm, Convert.ToInt32(listViewUsers.SelectedItems[0].Text));

            }
        }

        private void listViewTrainingProgramm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listViewTrainingProgramm.SelectedItems.Count > 0)
                {
                    contextMenuStripDelRename.Show(listViewTrainingProgramm,e.Location);
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewTrainingProgramm.SelectedItems.Count > 0)
            {
                workWithTrainigProgram.DeleteExercisesFromTrainigProgram(Convert.ToInt32( listViewTrainingProgramm.SelectedItems[0].Tag));
                addTrainingProgram.FilllistViewTrainingProgramm(listViewTrainingProgramm, Convert.ToInt32(listViewUsers.SelectedItems[0].Text));
            }
        }

        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {
            //addUserWinodw.StartPosition = FormStartPosition.CenterParent;
            //addUserWinodw.ShowDialog();
            
        }

       

    ///////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////addUserWindowButtonClikc///////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////

        public void FillInfAboutUser ()
        {
           
            PageAddTpForUsers(true);

            string[,] sqlResult = workWithDataBase.SelectFromDataBase("select * from Users where idUsers =" + AddUserWindow.idSelectedUser, 1);
            labelNameUser.Text = sqlResult[0,1];
            labelSecondNameUser.Text = sqlResult[0, 2];
            labelGenderUser.Text = sqlResult[0, 3];
            labelDateofBirthUser.Text = sqlResult[0, 4];

            addTpForUser.FillComboBoxStatistic(comboBoxSelectStatistic);
            //addTpForUser.PicterBoxLoad(pictureBoxStatistic,nameColumnFromCoboBox[comboBoxSelectStatistic.SelectedIndex]);        
        }

        private void comboBoxSelectStatistic_SelectedIndexChanged(object sender, EventArgs e)
        {
            addTpForUser.PicterBoxLoad(pictureBoxStatistic, nameColumnFromCoboBox[comboBoxSelectStatistic.SelectedIndex]);
        }

        private void buttonAddControlPoint_Click(object sender, EventArgs e)
        {
            AddControlPoint addControlPoint = new AddControlPoint(this);
            addControlPoint.StartPosition = FormStartPosition.CenterParent;
            addControlPoint.ShowDialog();
        }


    }
}
