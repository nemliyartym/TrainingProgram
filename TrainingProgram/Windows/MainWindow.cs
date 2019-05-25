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
using System.Resources;

namespace TrainingProgram
{

    public partial class MainWindow : Form
    {
        private string currentStrDescriptionExercises;
        private int idCurrentDays;
        private int id = 0;
        private TreeNode treeNode = new TreeNode();

        private TreeNodeMouseClickEventArgs curretnNode;

        private ListView currentSelectedListView;


        public string[] nameColumnFromCoboBox = {"cPhc", "cPwc","weigth","pullUps","pushUp","run100m","squts","press"};

        #region Enum FromsInterface
        public enum CurrentPageMainWindow
        {
            pageMainWindow,
            pageViewingExercises,
            pageTrainigProgramm,
            pageAddTpForUser
        }
        public CurrentPageMainWindow currentPageMainWindow;
        #endregion

        WorkWithImages workWithImages = new WorkWithImages();
        WorkWithDataBase workWithDataBase = new WorkWithDataBase();
        AddTrainingProgram addTrainingProgram = new AddTrainingProgram();
        WorkWithTrainigProgram workWithTrainigProgram = new WorkWithTrainigProgram();
        AddTpForUser addTpForUser = new AddTpForUser();
        Condition condition = new Condition();
        WorkWithWidget workWithWidget = new WorkWithWidget();
        //public AddUserWindow addUserwindow = new AddUserWindow();

        public MainWindow()
        {
            InitializeComponent();
            Win32.AllocConsole();

            //addTrainingProgram.FillLisViewUsers(listViewUsers);


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

            listViewExercises.Cursor = Cursors.Hand;
            listViewMonday.Cursor = Cursors.Hand;
            listViewTuesday.Cursor = Cursors.Hand;
            listViewWednesday.Cursor = Cursors.Hand;
            listViewThursday.Cursor = Cursors.Hand;
            listViewFriday.Cursor = Cursors.Hand;
            listViewSaturday.Cursor = Cursors.Hand;
            listViewSunday.Cursor = Cursors.Hand;

            listViewMonday.MouseUp += listViewDays_MouseUp;
            listViewTuesday.MouseUp += listViewDays_MouseUp;
            listViewWednesday.MouseUp += listViewDays_MouseUp;
            listViewThursday.MouseUp += listViewDays_MouseUp;
            listViewFriday.MouseUp += listViewDays_MouseUp;
            listViewSaturday.MouseUp += listViewDays_MouseUp;
            listViewSunday.MouseUp += listViewDays_MouseUp;

            listViewMonday.DoubleClick += ListViewDays_DoubleClick;
            listViewTuesday.DoubleClick += ListViewDays_DoubleClick;
            listViewWednesday.DoubleClick += ListViewDays_DoubleClick;
            listViewThursday.DoubleClick += ListViewDays_DoubleClick;
            listViewFriday.DoubleClick += ListViewDays_DoubleClick;
            listViewSaturday.DoubleClick += ListViewDays_DoubleClick;
            listViewSunday.DoubleClick += ListViewDays_DoubleClick;

            workWithWidget.SetWatemarkTextBox(textBoxNameTp, textBoxNameTp.Tag.ToString());
        }


        //---------------INTEFACE-----------------------------
        public void PageMainWindow (bool isVisible)
        {
            buttonSearchMusclesAndExercises.Visible = isVisible;
            buttonAddTrainingProgram.Visible = isVisible;
            buttonAddTpForUser.Visible = isVisible;
            buttonBack.Visible = !isVisible;
            buttonAddUser.Visible = isVisible;
            buttonDelUser.Visible = isVisible;
            labelnameProgram.Visible = isVisible;
            pictureBoxIcon.Visible = isVisible;
        }
        private void PageViewingExercises (bool isVisible)
        {
            treeViewMusclesAndExercises.Visible = isVisible;
            buttonBack.Visible = isVisible;
            panelIcon.Visible = isVisible;
            panelHeadExercises.Visible = isVisible;
            WorkWithTree workWithTree = new WorkWithTree(treeViewMusclesAndExercises);
            workWithTree.FillTree();

            currentPageMainWindow = CurrentPageMainWindow.pageViewingExercises;
        }
        private void PageViewingExercisesOther (bool isVisible)
        {
            //buttonAddVideo.Visible = isVisible;
            buttonSaveDescription.Visible = isVisible;
            labelDescription.Visible = isVisible;
            checkBoxDescription.Visible = isVisible;
            buttonAddImage.Visible = isVisible;
            richTextBoxDescriptionExercises.Visible = isVisible;
            pictureBoxFromImages.Visible = isVisible;
            labelHeadExercises.Visible = isVisible;
        }

        public void PageTrainigProgramm (bool isVisible)
        {

            //ОЛДЫ ТУТ 24.04.2019 реФАКторинг дизайна
            //listViewExercises.Visible = isVisible;
            //comboBoxMuscles.Visible = isVisible;
            //listViewTrainingProgramm.Visible = isVisible;
            //listViewUsers.Visible = isVisible;
            //buttonNext.Visible = isVisible;
            //buttonPrev.Visible = isVisible;
            //buttonBack.Visible = isVisible;
            //labelDayWeek.Visible = isVisible;

            panelUserBar.Visible = isVisible;
            panelTrainingProgram.Visible = isVisible;
            if (panelDaysTP.Visible == true)
                panelDaysTP.Visible = false;
            if (panelQuestCreateTP.Visible == true)
                panelQuestCreateTP.Visible = false;
            currentPageMainWindow = CurrentPageMainWindow.pageTrainigProgramm;

        }
        public void PageAddTpForUsers (bool isVisible)
        {
            panelAddTpForUser.Visible = isVisible;
            panelUserBar.Visible = isVisible;
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
            PageAddTpForUsers(true);
            currentPageMainWindow = CurrentPageMainWindow.pageAddTpForUser;
            SelectUserWindow selectUserWindow = new SelectUserWindow(this);
            selectUserWindow.StartPosition = FormStartPosition.CenterParent;
            selectUserWindow.ShowDialog();
        }

        private void buttonAddTrainingProgram_Click(object sender, EventArgs e)
        {
            PageMainWindow(false);
            PageTrainigProgramm(true);

            SelectUserWindow selectUserWindow = new SelectUserWindow(this);
            selectUserWindow.StartPosition = FormStartPosition.CenterParent;
            selectUserWindow.ShowDialog();

        }
        //---------------------------------------------------------------------------

        private void treeViewMusclesAndExercises_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeViewMusclesAndExercises.SelectedNode = e.Node;
                curretnNode = e;
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
                //buttonAddVideo.Visible = true;
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
                else
                {
                    pictureBoxFromImages.Image = Properties.Resources.nowPicture;
                }



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
                //buttonAddVideo.Visible = false;
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

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(curretnNode.Node.Tag.ToString());
        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(curretnNode.Node.Tag.ToString() + " " + curretnNode.Node.Parent.Tag.ToString());
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
            addTrainingProgram.FillListViewExrcises(listViewExercises, Convert.ToInt32((comboBoxMuscles.SelectedItem as ComboboxItem).Tag),AddTrainingProgram.pwCondition);
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

        private void listViewPatternsTP_DoubleClick(object sender, EventArgs e)
        {
            if (listViewPatternsTP.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listViewPatternsTP.Items.Count; i++)
                    listViewPatternsTP.Items[i].BackColor = Color.White;

                listViewPatternsTP.SelectedItems[0].BackColor = Color.FromArgb(51,144,255);
                string[,] sqlSelect = workWithDataBase.SelectFromDataBase("select * from PatternsTP where idpatternsTP = " + listViewPatternsTP.SelectedItems[0].Tag,1);

                workWithWidget.DeleteWotemarktextBox(textBoxNameTp);
                textBoxNameTp.Text = sqlSelect[0, 1];
                comboBoxDurationWeek.Text = sqlSelect[0, 2];
                comboBoxLvlTp.Text = condition.GetCondition(Convert.ToInt32(sqlSelect[0, 3]));
            }

        }

        ///////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////addUserWindowButtonClikc///////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////        

        private void SetCurrentCountTrainingDays ()
        {
            int[] trainingDyas = condition.GetCountTrainingDyas(condition.GetLvl(AddTrainingProgram.phCondition));
            Color color;
            if (trainingDyas[1] >= GetCurretCountDays())
                color = Color.Green;
            else if (trainingDyas[1] + 1 == GetCurretCountDays())
                color = Color.Orange;
            else
                color = Color.Red;

            labelCurrentnTrainingDays.ForeColor = color;
            labelNameCurrentTrainigDays.ForeColor = color;
            labelCurrentnTrainingDays.Text = GetCurretCountDays().ToString();
        }

        private int GetCurretCountDays ()
        {
            int count = 0;
            if (listViewMonday.Items.Count != 0)
                count++;
            if (listViewTuesday.Items.Count != 0)
                count++;
            if (listViewWednesday.Items.Count != 0)
                count++;
            if (listViewThursday.Items.Count != 0)
                count++;
            if (listViewFriday.Items.Count != 0)
                count++;
            if (listViewSaturday.Items.Count != 0)
                count++;
            if (listViewSunday.Items.Count != 0)
                count++;
            return count;
        }

        public void FillUserBar ()
        {                          
            string[,] sqlResultUser = workWithDataBase.SelectFromDataBase("select * from Users where idUsers =" + SelectUserWindow.idSelectedUser, 1);
            //string[,] sqlResultStatisticMax = workWithDataBase.SelectFromDataBase("select * from StatisticsUsers where dateTime = (select max (dateTime) from StatisticsUsers where idUsers =" + SelectUserWindow.idSelectedUser + ") and idUsers =" + SelectUserWindow.idSelectedUser, 1);         
            int countRows = workWithDataBase.SelectCountFromDataBase("Select count (idUsers) from StatisticsUsers where idUsers =" + SelectUserWindow.idSelectedUser);
            string[,] sqlSelectDate = workWithDataBase.SelectFromDataBase("select * from StatisticsUsers where idUsers = " + SelectUserWindow.idSelectedUser + " order by dateTime", countRows);

            labelNameUser.Text = sqlResultUser[0,1];
            labelSecondNameUser.Text = sqlResultUser[0, 2];
            labelGenderUser.Text = sqlResultUser[0, 3];
            labelDateofBirthUser.Text = Convert.ToDateTime(sqlResultUser[0, 4]).ToShortDateString();

            AddTrainingProgram.pwCondition = condition.GetConditionMan(Convert.ToDouble(sqlSelectDate[countRows - 1, 13]), sqlResultUser[0, 3]);
            AddTrainingProgram.phCondition = condition.GetConditionMan(Convert.ToDouble(sqlSelectDate[countRows - 1, 12]), sqlResultUser[0, 3]);


            labelcPhc.Text = AddTrainingProgram.phCondition + " " + sqlSelectDate[countRows - 1, 12];
            labelcPwc.Text = AddTrainingProgram.pwCondition + " " + sqlSelectDate[countRows - 1, 13];
            labelPuls.Text = sqlSelectDate[countRows - 1, 1] + " удраво/минуту";
            labelPressure.Text = sqlSelectDate[countRows - 1, 2] + "/" + sqlSelectDate[countRows - 1, 3] + " мм рт.ст.";
            labelGrowth.Text = sqlSelectDate[countRows - 1, 4] + " см";
            labelWeight.Text = sqlSelectDate[countRows - 1, 5] + " кг";

            labelPullUps.Text = sqlSelectDate[countRows - 1, 7];
            labelPushUps.Text = sqlSelectDate[countRows - 1, 8];
            labelRun100m.Text = sqlSelectDate[countRows - 1, 9];
            labelSquts.Text = sqlSelectDate[countRows - 1, 10];
            labelPres.Text = sqlSelectDate[countRows - 1, 11];


            if (countRows >= 2)
            {
                if (Convert.ToDouble(sqlSelectDate[countRows - 1, 12]) == Convert.ToDouble(sqlSelectDate[countRows - 2, 12]))
                {
                    pictureBoxcPhc.Image = Properties.Resources.middle;
                    labelcPhc.ForeColor = Color.Blue;
                }
                else if (Convert.ToDouble(sqlSelectDate[countRows - 1, 12]) > Convert.ToDouble(sqlSelectDate[countRows - 2, 12]))
                {
                    pictureBoxcPhc.Image = Properties.Resources.up;
                    labelcPhc.ForeColor = Color.Green;
                }
                else if (Convert.ToDouble(sqlSelectDate[countRows - 1, 12]) < Convert.ToDouble(sqlSelectDate[countRows - 2, 12]))
                {
                    pictureBoxcPhc.Image = Properties.Resources.down;
                    labelcPhc.ForeColor = Color.Red;
                }


                if (Convert.ToDouble(sqlSelectDate[countRows - 1, 13]) == Convert.ToDouble(sqlSelectDate[countRows - 2, 13]))
                {
                    pictureBoxcPwc.Image = Properties.Resources.middle;
                    labelcPwc.ForeColor = Color.Blue;
                }
                else if (Convert.ToDouble(sqlSelectDate[countRows - 1, 13]) > Convert.ToDouble(sqlSelectDate[countRows - 2, 13]))
                {
                    pictureBoxcPwc.Image = Properties.Resources.up;
                    labelcPwc.ForeColor = Color.Green;
                }
                else if (Convert.ToDouble(sqlSelectDate[countRows - 1, 13]) < Convert.ToDouble(sqlSelectDate[countRows - 2, 13]))
                {
                    pictureBoxcPwc.Image = Properties.Resources.down;
                    labelcPwc.ForeColor = Color.Red;
                }
            }
            else
            {
                pictureBoxcPhc.Image = Properties.Resources.middle;
                pictureBoxcPwc.Image = Properties.Resources.middle;
                labelcPhc.ForeColor = Color.Blue;
                labelcPwc.ForeColor = Color.Blue;
            }

          
            if(currentPageMainWindow == CurrentPageMainWindow.pageTrainigProgramm)
            {
                addTrainingProgram.FillComboBoxMuscles(comboBoxMuscles);

                if (workWithDataBase.SelectCountFromDataBase("select * from TrainingProgram where idUser =" + SelectUserWindow.idSelectedUser) == 0)
                {
                    panelQuestCreateTP.Visible = true;
                    addTrainingProgram.FillListViewPatternsTP(listViewPatternsTP, AddTrainingProgram.pwCondition);

                }
                else
                {
                    panelDaysTP.Visible = true;

                    addTrainingProgram.FillListViewDaysTp(listViewMonday, AddTrainingProgram.daysWeek[0], AddTrainingProgram.pwCondition,SelectUserWindow.idSelectedUser);
                    addTrainingProgram.FillListViewDaysTp(listViewTuesday, AddTrainingProgram.daysWeek[1], AddTrainingProgram.pwCondition,SelectUserWindow.idSelectedUser);
                    addTrainingProgram.FillListViewDaysTp(listViewWednesday, AddTrainingProgram.daysWeek[2], AddTrainingProgram.pwCondition, SelectUserWindow.idSelectedUser);
                    addTrainingProgram.FillListViewDaysTp(listViewThursday, AddTrainingProgram.daysWeek[3], AddTrainingProgram.pwCondition, SelectUserWindow.idSelectedUser);
                    addTrainingProgram.FillListViewDaysTp(listViewFriday, AddTrainingProgram.daysWeek[4], AddTrainingProgram.pwCondition, SelectUserWindow.idSelectedUser);
                    addTrainingProgram.FillListViewDaysTp(listViewSaturday, AddTrainingProgram.daysWeek[5], AddTrainingProgram.pwCondition, SelectUserWindow.idSelectedUser);
                    addTrainingProgram.FillListViewDaysTp(listViewSunday, AddTrainingProgram.daysWeek[6], AddTrainingProgram.pwCondition, SelectUserWindow.idSelectedUser);

                    int[] trainingDyas = condition.GetCountTrainingDyas(condition.GetLvl(AddTrainingProgram.phCondition));
                    labelCountTrainingDays.Text = trainingDyas[0] + "-" + trainingDyas[1];
                    SetCurrentCountTrainingDays();
                }


                //addTrainingProgram.FillListViewExrcises(listView1,,3);
            }

            else if(currentPageMainWindow == CurrentPageMainWindow.pageAddTpForUser)
            {
                addTpForUser.FillComboBoxStatistic(comboBoxSelectStatistic);
                addTpForUser.PicterBoxLoad(pictureBoxStatistic, nameColumnFromCoboBox[comboBoxSelectStatistic.SelectedIndex]);

                int countDownDyas = 14 - (int)(DateTime.Now - Convert.ToDateTime(sqlSelectDate[countRows - 1, 14])).TotalDays;
                if (countDownDyas >= 1)
                {
                    labelCountdownDays.Text = "Дата  добавления новой КТ: " + (DateTime.Now.AddDays(countDownDyas)).ToShortDateString();
                }
                else labelCountdownDays.Text = "Необходимо добавить новыую КТ!";
            }
        }

        private void comboBoxSelectStatistic_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelNameStatistic.Text = "Статистика (" + comboBoxSelectStatistic.SelectedItem.ToString() + ")";
            addTpForUser.PicterBoxLoad(pictureBoxStatistic, nameColumnFromCoboBox[comboBoxSelectStatistic.SelectedIndex]);
        }

        private void buttonAddControlPoint_Click(object sender, EventArgs e)
        {
            AddControlPoint addControlPoint = new AddControlPoint(this);
            addControlPoint.StartPosition = FormStartPosition.CenterParent;
            addControlPoint.ShowDialog();
        }

        private void buttonShowStatistic_Click(object sender, EventArgs e)
        {
            if (panelStatistic.Visible == false)
                panelStatistic.Visible = true;
            else panelStatistic.Visible = false;
        }

        private void ListViewDays_DoubleClick(object sender, EventArgs e)
        {
            ListView listView = (ListView)sender;
            if(listView.SelectedItems.Count >0)
            {
                //MessageBox.Show(listView.SelectedItems[0].Tag.ToString());
                workWithTrainigProgram.DeleteExercisesFromTrainigProgram(Convert.ToInt32(listView.SelectedItems[0].Tag));
                addTrainingProgram.FillListViewDaysTp(listView, AddTrainingProgram.daysWeek[idCurrentDays - 1], AddTrainingProgram.pwCondition, SelectUserWindow.idSelectedUser);

                if (listView.Items.Count == 0)
                    SetCurrentCountTrainingDays();
            }
        }

        private void listViewDays_MouseUp(object sender, MouseEventArgs e)
        {
            ListView lv = (ListView)sender;
            if (lv == listViewMonday)
                idCurrentDays = 1;
            else if (lv == listViewTuesday)
                idCurrentDays = 2;
            else if (lv == listViewWednesday)
                idCurrentDays = 3;
            else if (lv == listViewThursday)
                idCurrentDays = 4;
            else if (lv == listViewFriday)
                idCurrentDays = 5;
            else if (lv == listViewSaturday)
                idCurrentDays = 6;
            else if (lv == listViewSunday)
                idCurrentDays = 7; 


            listViewMonday.BackColor = Color.White;
            listViewTuesday.BackColor = Color.White;
            listViewWednesday.BackColor = Color.White;
            listViewThursday.BackColor = Color.White;
            listViewFriday.BackColor = Color.White;
            listViewSaturday.BackColor = Color.White;
            listViewSunday.BackColor = Color.White;

            currentSelectedListView = (ListView)sender;
            currentSelectedListView.BackColor = Color.LightBlue;
   
            
        }

        private void textBoxNameTp_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxNameTp.Text == string.Empty || textBoxNameTp.Text == textBoxNameTp.Tag.ToString()) 
                && comboBoxDurationWeek.SelectedItem == null
                && comboBoxLvlTp.SelectedItem == null)
                buttonCreateTp.Enabled = false;
            else buttonCreateTp.Enabled = true;
        }

        private void textBoxNameTp_Enter(object sender, EventArgs e)
        {
            workWithWidget.DeleteWotemarktextBox((TextBox)sender);
        }

        private void textBoxNameTp_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if(tb.Text == string.Empty)
            {
                workWithWidget.SetWatemarkTextBox(tb, tb.Tag.ToString());
            }
        }

        private void buttonCreateTp_Click(object sender, EventArgs e)
        {
            workWithTrainigProgram.InsertTrainigProgram(SelectUserWindow.idSelectedUser, textBoxNameTp.Text, Convert.ToInt32(comboBoxDurationWeek.Text), condition.GetLvl(comboBoxLvlTp.Text));
            string[,] sqlSelect = workWithDataBase.SelectFromDataBase("select idTrainingProgram from TrainingProgram where idUser = " + SelectUserWindow.idSelectedUser ,1);

            for (int i = 0; i < listViewPatternsTP.Items.Count; i++)
            {
                if (listViewPatternsTP.Items[i].BackColor == Color.FromArgb(51, 144, 255))
                {
                    int countRowsPatternsTp = workWithDataBase.SelectCountFromDataBase("select count(idpatternsTP) from ExercisesForPatternsTP where idPatternsTP =" + listViewPatternsTP.Items[i].Tag);
                    string[,] sqlSelectPatternsTp = workWithDataBase.SelectFromDataBase("select * from ExercisesForPatternsTP where idPatternsTP =" + listViewPatternsTP.Items[i].Tag, countRowsPatternsTp);

                    for (int j = 0; j < countRowsPatternsTp; j++)
                    {
                        workWithTrainigProgram.InsertExercisesForTrainigProgram(Convert.ToInt32(sqlSelect[0, 0]), Convert.ToInt32(sqlSelectPatternsTp[j, 2]), Convert.ToInt32(sqlSelectPatternsTp[j, 3]));
                    }
                    break;
                }
            }


            addTrainingProgram.FillListViewDaysTp(listViewMonday, AddTrainingProgram.daysWeek[0], AddTrainingProgram.pwCondition, SelectUserWindow.idSelectedUser);
            addTrainingProgram.FillListViewDaysTp(listViewTuesday, AddTrainingProgram.daysWeek[1], AddTrainingProgram.pwCondition, SelectUserWindow.idSelectedUser);
            addTrainingProgram.FillListViewDaysTp(listViewWednesday, AddTrainingProgram.daysWeek[2], AddTrainingProgram.pwCondition, SelectUserWindow.idSelectedUser);
            addTrainingProgram.FillListViewDaysTp(listViewThursday, AddTrainingProgram.daysWeek[3], AddTrainingProgram.pwCondition, SelectUserWindow.idSelectedUser);
            addTrainingProgram.FillListViewDaysTp(listViewFriday, AddTrainingProgram.daysWeek[4], AddTrainingProgram.pwCondition, SelectUserWindow.idSelectedUser);
            addTrainingProgram.FillListViewDaysTp(listViewSaturday, AddTrainingProgram.daysWeek[5], AddTrainingProgram.pwCondition, SelectUserWindow.idSelectedUser);
            addTrainingProgram.FillListViewDaysTp(listViewSunday, AddTrainingProgram.daysWeek[6], AddTrainingProgram.pwCondition, SelectUserWindow.idSelectedUser);




            panelQuestCreateTP.Visible = false;
            panelDaysTP.Visible = true;
        }

        private void listViewExercises_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewExercises.SelectedItems.Count > 0)
            {
                if (currentSelectedListView != null)
                {
                    if (listViewExercises.SelectedItems[0].ForeColor == Color.Red)
                    {
                        DialogResult result =  MessageBox.Show("Данное упражнение не соотвествует уровню подготовки пользователя \n Все равно добавить его?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                        if(result == DialogResult.No || result == DialogResult.Cancel)
                            return;
                    }

                    string[,] sqlSelect = workWithDataBase.SelectFromDataBase("select * from TrainingProgram where idUser = " + SelectUserWindow.idSelectedUser, 1);
                    if (workWithDataBase.SelectExists("select * from ExercisesForTP where idExercises = "+ listViewExercises.SelectedItems[0].Tag + "and idTrainingProgram ="+ Convert.ToInt32(sqlSelect[0, 0]) + "and idDaysWeek =" + idCurrentDays) == 1)
                    {
                        DialogResult result = MessageBox.Show("Данное упражнение уже добавленно \n Все равно добавить его?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                        if (result == DialogResult.No || result == DialogResult.Cancel)
                            return; 
                    }


                   
                    workWithTrainigProgram.InsertExercisesForTrainigProgram(Convert.ToInt32(sqlSelect[0, 0]), Convert.ToInt32(listViewExercises.SelectedItems[0].Tag), idCurrentDays);
                    addTrainingProgram.FillListViewDaysTp(currentSelectedListView, AddTrainingProgram.daysWeek[idCurrentDays - 1], AddTrainingProgram.pwCondition, SelectUserWindow.idSelectedUser);

                    SetCurrentCountTrainingDays();
                }
            }
            

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            AddUserWindow addUserWindow = new AddUserWindow(this);
            addUserWindow.StartPosition = FormStartPosition.CenterParent;
            addUserWindow.ShowDialog();
        }

        private void buttonDelUser_Click(object sender, EventArgs e)
        {
            DelUserWindow delUserWindow = new DelUserWindow(this);
            delUserWindow.StartPosition = FormStartPosition.CenterParent;
            delUserWindow.ShowDialog();
        }

        private void buttonAddExercises_Click(object sender, EventArgs e)
        {
            AddExercisesWindow addExercisesWindow = new AddExercisesWindow(this);
            addExercisesWindow.StartPosition = FormStartPosition.CenterParent;
            addExercisesWindow.ShowDialog();
        }
    }
}
