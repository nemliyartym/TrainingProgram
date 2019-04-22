namespace TrainingProgram
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.buttonSearchMusclesAndExercises = new System.Windows.Forms.Button();
            this.buttonAddTrainingProgram = new System.Windows.Forms.Button();
            this.treeViewMusclesAndExercises = new System.Windows.Forms.TreeView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.buttonAddVideo = new System.Windows.Forms.Button();
            this.labelHeadExercises = new System.Windows.Forms.Label();
            this.richTextBoxDescriptionExercises = new System.Windows.Forms.RichTextBox();
            this.checkBoxDescription = new System.Windows.Forms.CheckBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonSaveDescription = new System.Windows.Forms.Button();
            this.contextMenuStripFromTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.переименоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewTrainingProgramm = new System.Windows.Forms.ListView();
            this.Exercises = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelDayWeek = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.listViewExercises = new System.Windows.Forms.ListView();
            this.comboBoxMuscles = new System.Windows.Forms.ComboBox();
            this.contextMenuStripDelRename = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.переименоватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddNewUser = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelDateofBirth = new System.Windows.Forms.Label();
            this.tableLayoutPanelInfAboutUser = new System.Windows.Forms.TableLayoutPanel();
            this.labelDateofBirthUser = new System.Windows.Forms.Label();
            this.labelSecondNameUser = new System.Windows.Forms.Label();
            this.labelNameUser = new System.Windows.Forms.Label();
            this.labelGenderUser = new System.Windows.Forms.Label();
            this.panelAddTpForUser = new System.Windows.Forms.Panel();
            this.panelStatistic = new System.Windows.Forms.Panel();
            this.labelStaticName = new System.Windows.Forms.Label();
            this.comboBoxSelectStatistic = new System.Windows.Forms.ComboBox();
            this.pictureBoxStatistic = new System.Windows.Forms.PictureBox();
            this.buttonShowStatistic = new System.Windows.Forms.Button();
            this.labelCountdownDays = new System.Windows.Forms.Label();
            this.labelcPhc = new System.Windows.Forms.Label();
            this.labelcPwc = new System.Windows.Forms.Label();
            this.pictureBoxcPhc = new System.Windows.Forms.PictureBox();
            this.labelcPhcLabel = new System.Windows.Forms.Label();
            this.pictureBoxcPwc = new System.Windows.Forms.PictureBox();
            this.buttonAddControlPoint = new System.Windows.Forms.Button();
            this.labelcPwcLabel = new System.Windows.Forms.Label();
            this.buttonAddTpForUser = new System.Windows.Forms.Button();
            this.pictureBoxFromImages = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.contextMenuStripFromTree.SuspendLayout();
            this.contextMenuStripDelRename.SuspendLayout();
            this.tableLayoutPanelInfAboutUser.SuspendLayout();
            this.panelAddTpForUser.SuspendLayout();
            this.panelStatistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcPhc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcPwc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFromImages)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearchMusclesAndExercises
            // 
            this.buttonSearchMusclesAndExercises.Location = new System.Drawing.Point(131, 93);
            this.buttonSearchMusclesAndExercises.Name = "buttonSearchMusclesAndExercises";
            this.buttonSearchMusclesAndExercises.Size = new System.Drawing.Size(161, 231);
            this.buttonSearchMusclesAndExercises.TabIndex = 0;
            this.buttonSearchMusclesAndExercises.Text = "buttonSearchExercises";
            this.buttonSearchMusclesAndExercises.UseVisualStyleBackColor = true;
            this.buttonSearchMusclesAndExercises.Click += new System.EventHandler(this.buttonSearchExercises_Click);
            // 
            // buttonAddTrainingProgram
            // 
            this.buttonAddTrainingProgram.Location = new System.Drawing.Point(311, 93);
            this.buttonAddTrainingProgram.Name = "buttonAddTrainingProgram";
            this.buttonAddTrainingProgram.Size = new System.Drawing.Size(156, 231);
            this.buttonAddTrainingProgram.TabIndex = 1;
            this.buttonAddTrainingProgram.Text = "buttonAddTrainingProgram";
            this.buttonAddTrainingProgram.UseVisualStyleBackColor = true;
            this.buttonAddTrainingProgram.Click += new System.EventHandler(this.buttonAddTrainingProgram_Click);
            // 
            // treeViewMusclesAndExercises
            // 
            this.treeViewMusclesAndExercises.LabelEdit = true;
            this.treeViewMusclesAndExercises.Location = new System.Drawing.Point(12, 62);
            this.treeViewMusclesAndExercises.Name = "treeViewMusclesAndExercises";
            this.treeViewMusclesAndExercises.Size = new System.Drawing.Size(403, 453);
            this.treeViewMusclesAndExercises.TabIndex = 2;
            this.treeViewMusclesAndExercises.Visible = false;
            this.treeViewMusclesAndExercises.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeViewMusclesAndExercises_BeforeLabelEdit);
            this.treeViewMusclesAndExercises.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeViewMusclesAndExercises_AfterLabelEdit);
            this.treeViewMusclesAndExercises.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewMusclesAndExercises_NodeMouseClick);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(131, 9);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(67, 26);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "buttonBack";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(653, 121);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(173, 203);
            this.axWindowsMediaPlayer.TabIndex = 5;
            this.axWindowsMediaPlayer.Visible = false;
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Location = new System.Drawing.Point(421, 91);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(131, 23);
            this.buttonAddImage.TabIndex = 7;
            this.buttonAddImage.Text = "buttonAddImage";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Visible = false;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // buttonAddVideo
            // 
            this.buttonAddVideo.Location = new System.Drawing.Point(653, 93);
            this.buttonAddVideo.Name = "buttonAddVideo";
            this.buttonAddVideo.Size = new System.Drawing.Size(122, 24);
            this.buttonAddVideo.TabIndex = 8;
            this.buttonAddVideo.Text = "buttonAddVideo";
            this.buttonAddVideo.UseVisualStyleBackColor = true;
            this.buttonAddVideo.Visible = false;
            this.buttonAddVideo.Click += new System.EventHandler(this.buttonAddVideo_Click);
            // 
            // labelHeadExercises
            // 
            this.labelHeadExercises.AutoSize = true;
            this.labelHeadExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeadExercises.Location = new System.Drawing.Point(431, 53);
            this.labelHeadExercises.Name = "labelHeadExercises";
            this.labelHeadExercises.Size = new System.Drawing.Size(0, 24);
            this.labelHeadExercises.TabIndex = 9;
            // 
            // richTextBoxDescriptionExercises
            // 
            this.richTextBoxDescriptionExercises.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBoxDescriptionExercises.Location = new System.Drawing.Point(435, 355);
            this.richTextBoxDescriptionExercises.MaxLength = 2000;
            this.richTextBoxDescriptionExercises.Name = "richTextBoxDescriptionExercises";
            this.richTextBoxDescriptionExercises.ReadOnly = true;
            this.richTextBoxDescriptionExercises.Size = new System.Drawing.Size(391, 137);
            this.richTextBoxDescriptionExercises.TabIndex = 10;
            this.richTextBoxDescriptionExercises.Text = "";
            this.richTextBoxDescriptionExercises.Visible = false;
            this.richTextBoxDescriptionExercises.TextChanged += new System.EventHandler(this.richTextBoxDescriptionExercises_TextChanged);
            this.richTextBoxDescriptionExercises.Leave += new System.EventHandler(this.richTextBoxDescriptionExercises_Leave);
            // 
            // checkBoxDescription
            // 
            this.checkBoxDescription.AutoSize = true;
            this.checkBoxDescription.Location = new System.Drawing.Point(435, 498);
            this.checkBoxDescription.Name = "checkBoxDescription";
            this.checkBoxDescription.Size = new System.Drawing.Size(173, 17);
            this.checkBoxDescription.TabIndex = 11;
            this.checkBoxDescription.Text = "Хотите изменить описание? ";
            this.checkBoxDescription.UseVisualStyleBackColor = true;
            this.checkBoxDescription.Visible = false;
            this.checkBoxDescription.CheckedChanged += new System.EventHandler(this.checkBoxDescription_CheckedChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(432, 339);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(57, 13);
            this.labelDescription.TabIndex = 12;
            this.labelDescription.Text = "Описание";
            this.labelDescription.Visible = false;
            // 
            // buttonSaveDescription
            // 
            this.buttonSaveDescription.Enabled = false;
            this.buttonSaveDescription.Location = new System.Drawing.Point(751, 329);
            this.buttonSaveDescription.Name = "buttonSaveDescription";
            this.buttonSaveDescription.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveDescription.TabIndex = 13;
            this.buttonSaveDescription.Text = "buttonSaveDescription";
            this.buttonSaveDescription.UseVisualStyleBackColor = true;
            this.buttonSaveDescription.Visible = false;
            this.buttonSaveDescription.Click += new System.EventHandler(this.buttonSaveDescription_Click);
            // 
            // contextMenuStripFromTree
            // 
            this.contextMenuStripFromTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переименоватьToolStripMenuItem});
            this.contextMenuStripFromTree.Name = "contextMenuStripFromTree";
            this.contextMenuStripFromTree.Size = new System.Drawing.Size(162, 26);
            // 
            // переименоватьToolStripMenuItem
            // 
            this.переименоватьToolStripMenuItem.Name = "переименоватьToolStripMenuItem";
            this.переименоватьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.переименоватьToolStripMenuItem.Text = "Переименовать";
            this.переименоватьToolStripMenuItem.Click += new System.EventHandler(this.переименоватьToolStripMenuItem_Click);
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.FirstName,
            this.LastName});
            this.listViewUsers.FullRowSelect = true;
            this.listViewUsers.GridLines = true;
            this.listViewUsers.Location = new System.Drawing.Point(42, 53);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(263, 190);
            this.listViewUsers.TabIndex = 19;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            this.listViewUsers.Visible = false;
            this.listViewUsers.SelectedIndexChanged += new System.EventHandler(this.listViewUsers_SelectedIndexChanged);
            // 
            // Number
            // 
            this.Number.Text = "";
            this.Number.Width = 0;
            // 
            // FirstName
            // 
            this.FirstName.Text = "FirstName";
            this.FirstName.Width = 93;
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            this.LastName.Width = 113;
            // 
            // listViewTrainingProgramm
            // 
            this.listViewTrainingProgramm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Exercises});
            this.listViewTrainingProgramm.Location = new System.Drawing.Point(421, 120);
            this.listViewTrainingProgramm.Name = "listViewTrainingProgramm";
            this.listViewTrainingProgramm.Size = new System.Drawing.Size(218, 229);
            this.listViewTrainingProgramm.TabIndex = 20;
            this.listViewTrainingProgramm.UseCompatibleStateImageBehavior = false;
            this.listViewTrainingProgramm.View = System.Windows.Forms.View.Details;
            this.listViewTrainingProgramm.Visible = false;
            this.listViewTrainingProgramm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewTrainingProgramm_MouseClick);
            // 
            // Exercises
            // 
            this.Exercises.Text = "Упражнения";
            this.Exercises.Width = 160;
            // 
            // labelDayWeek
            // 
            this.labelDayWeek.AutoSize = true;
            this.labelDayWeek.Location = new System.Drawing.Point(495, 68);
            this.labelDayWeek.Name = "labelDayWeek";
            this.labelDayWeek.Size = new System.Drawing.Size(75, 13);
            this.labelDayWeek.TabIndex = 21;
            this.labelDayWeek.Text = "Понедельник";
            this.labelDayWeek.Visible = false;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(576, 64);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 22;
            this.buttonNext.Text = "->";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Visible = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(414, 63);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 23;
            this.buttonPrev.Text = "<-";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Visible = false;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // listViewExercises
            // 
            this.listViewExercises.Location = new System.Drawing.Point(646, 125);
            this.listViewExercises.Name = "listViewExercises";
            this.listViewExercises.Size = new System.Drawing.Size(216, 224);
            this.listViewExercises.TabIndex = 24;
            this.listViewExercises.UseCompatibleStateImageBehavior = false;
            this.listViewExercises.View = System.Windows.Forms.View.SmallIcon;
            this.listViewExercises.Visible = false;
            this.listViewExercises.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewExercises_MouseDoubleClick);
            // 
            // comboBoxMuscles
            // 
            this.comboBoxMuscles.FormattingEnabled = true;
            this.comboBoxMuscles.Location = new System.Drawing.Point(646, 101);
            this.comboBoxMuscles.Name = "comboBoxMuscles";
            this.comboBoxMuscles.Size = new System.Drawing.Size(216, 21);
            this.comboBoxMuscles.TabIndex = 25;
            this.comboBoxMuscles.Visible = false;
            this.comboBoxMuscles.SelectedIndexChanged += new System.EventHandler(this.comboBoxMuscles_SelectedIndexChanged);
            // 
            // contextMenuStripDelRename
            // 
            this.contextMenuStripDelRename.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переименоватьToolStripMenuItem1,
            this.удалитьToolStripMenuItem});
            this.contextMenuStripDelRename.Name = "contextMenuStripAddDelRename";
            this.contextMenuStripDelRename.Size = new System.Drawing.Size(162, 48);
            // 
            // переименоватьToolStripMenuItem1
            // 
            this.переименоватьToolStripMenuItem1.Name = "переименоватьToolStripMenuItem1";
            this.переименоватьToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.переименоватьToolStripMenuItem1.Text = "Переименовать";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // buttonAddNewUser
            // 
            this.buttonAddNewUser.Location = new System.Drawing.Point(682, 397);
            this.buttonAddNewUser.Name = "buttonAddNewUser";
            this.buttonAddNewUser.Size = new System.Drawing.Size(180, 55);
            this.buttonAddNewUser.TabIndex = 26;
            this.buttonAddNewUser.Text = "buttonAddNewUser";
            this.buttonAddNewUser.UseVisualStyleBackColor = true;
            this.buttonAddNewUser.Visible = false;
            this.buttonAddNewUser.Click += new System.EventHandler(this.buttonAddNewUser_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(383, 22);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 27;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 20);
            this.labelName.TabIndex = 29;
            this.labelName.Text = "Имя:";
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondName.Location = new System.Drawing.Point(3, 30);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(85, 20);
            this.labelSecondName.TabIndex = 30;
            this.labelSecondName.Text = "Фамилия:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGender.Location = new System.Drawing.Point(3, 60);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(44, 20);
            this.labelGender.TabIndex = 31;
            this.labelGender.Text = "Пол:";
            // 
            // labelDateofBirth
            // 
            this.labelDateofBirth.AutoSize = true;
            this.labelDateofBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateofBirth.Location = new System.Drawing.Point(3, 90);
            this.labelDateofBirth.Name = "labelDateofBirth";
            this.labelDateofBirth.Size = new System.Drawing.Size(89, 30);
            this.labelDateofBirth.TabIndex = 32;
            this.labelDateofBirth.Text = "Дата рождения:";
            // 
            // tableLayoutPanelInfAboutUser
            // 
            this.tableLayoutPanelInfAboutUser.ColumnCount = 2;
            this.tableLayoutPanelInfAboutUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInfAboutUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInfAboutUser.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanelInfAboutUser.Controls.Add(this.labelDateofBirthUser, 1, 3);
            this.tableLayoutPanelInfAboutUser.Controls.Add(this.labelSecondNameUser, 1, 1);
            this.tableLayoutPanelInfAboutUser.Controls.Add(this.labelGender, 0, 2);
            this.tableLayoutPanelInfAboutUser.Controls.Add(this.labelSecondName, 0, 1);
            this.tableLayoutPanelInfAboutUser.Controls.Add(this.labelNameUser, 1, 0);
            this.tableLayoutPanelInfAboutUser.Controls.Add(this.labelDateofBirth, 0, 3);
            this.tableLayoutPanelInfAboutUser.Controls.Add(this.labelGenderUser, 1, 2);
            this.tableLayoutPanelInfAboutUser.Location = new System.Drawing.Point(19, 11);
            this.tableLayoutPanelInfAboutUser.Name = "tableLayoutPanelInfAboutUser";
            this.tableLayoutPanelInfAboutUser.RowCount = 4;
            this.tableLayoutPanelInfAboutUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInfAboutUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInfAboutUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInfAboutUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInfAboutUser.Size = new System.Drawing.Size(224, 120);
            this.tableLayoutPanelInfAboutUser.TabIndex = 33;
            // 
            // labelDateofBirthUser
            // 
            this.labelDateofBirthUser.AutoSize = true;
            this.labelDateofBirthUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateofBirthUser.Location = new System.Drawing.Point(115, 90);
            this.labelDateofBirthUser.Name = "labelDateofBirthUser";
            this.labelDateofBirthUser.Size = new System.Drawing.Size(0, 20);
            this.labelDateofBirthUser.TabIndex = 36;
            // 
            // labelSecondNameUser
            // 
            this.labelSecondNameUser.AutoSize = true;
            this.labelSecondNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondNameUser.Location = new System.Drawing.Point(115, 30);
            this.labelSecondNameUser.Name = "labelSecondNameUser";
            this.labelSecondNameUser.Size = new System.Drawing.Size(0, 20);
            this.labelSecondNameUser.TabIndex = 34;
            // 
            // labelNameUser
            // 
            this.labelNameUser.AutoSize = true;
            this.labelNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameUser.Location = new System.Drawing.Point(115, 0);
            this.labelNameUser.Name = "labelNameUser";
            this.labelNameUser.Size = new System.Drawing.Size(0, 20);
            this.labelNameUser.TabIndex = 33;
            // 
            // labelGenderUser
            // 
            this.labelGenderUser.AutoSize = true;
            this.labelGenderUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenderUser.Location = new System.Drawing.Point(115, 60);
            this.labelGenderUser.Name = "labelGenderUser";
            this.labelGenderUser.Size = new System.Drawing.Size(0, 20);
            this.labelGenderUser.TabIndex = 35;
            // 
            // panelAddTpForUser
            // 
            this.panelAddTpForUser.Controls.Add(this.groupBox1);
            this.panelAddTpForUser.Controls.Add(this.panelStatistic);
            this.panelAddTpForUser.Controls.Add(this.buttonShowStatistic);
            this.panelAddTpForUser.Controls.Add(this.labelCountdownDays);
            this.panelAddTpForUser.Controls.Add(this.labelcPhc);
            this.panelAddTpForUser.Controls.Add(this.labelcPwc);
            this.panelAddTpForUser.Controls.Add(this.pictureBoxcPhc);
            this.panelAddTpForUser.Controls.Add(this.labelcPhcLabel);
            this.panelAddTpForUser.Controls.Add(this.pictureBoxcPwc);
            this.panelAddTpForUser.Controls.Add(this.buttonAddControlPoint);
            this.panelAddTpForUser.Controls.Add(this.labelcPwcLabel);
            this.panelAddTpForUser.Controls.Add(this.tableLayoutPanelInfAboutUser);
            this.panelAddTpForUser.Location = new System.Drawing.Point(23, 42);
            this.panelAddTpForUser.Name = "panelAddTpForUser";
            this.panelAddTpForUser.Size = new System.Drawing.Size(839, 473);
            this.panelAddTpForUser.TabIndex = 34;
            this.panelAddTpForUser.Visible = false;
            // 
            // panelStatistic
            // 
            this.panelStatistic.Controls.Add(this.labelStaticName);
            this.panelStatistic.Controls.Add(this.comboBoxSelectStatistic);
            this.panelStatistic.Controls.Add(this.pictureBoxStatistic);
            this.panelStatistic.Location = new System.Drawing.Point(0, 222);
            this.panelStatistic.Name = "panelStatistic";
            this.panelStatistic.Size = new System.Drawing.Size(839, 248);
            this.panelStatistic.TabIndex = 50;
            this.panelStatistic.Visible = false;
            // 
            // labelStaticName
            // 
            this.labelStaticName.AutoSize = true;
            this.labelStaticName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStaticName.Location = new System.Drawing.Point(12, 3);
            this.labelStaticName.Name = "labelStaticName";
            this.labelStaticName.Size = new System.Drawing.Size(109, 20);
            this.labelStaticName.TabIndex = 35;
            this.labelStaticName.Text = "Статистика";
            // 
            // comboBoxSelectStatistic
            // 
            this.comboBoxSelectStatistic.FormattingEnabled = true;
            this.comboBoxSelectStatistic.Location = new System.Drawing.Point(127, 3);
            this.comboBoxSelectStatistic.Name = "comboBoxSelectStatistic";
            this.comboBoxSelectStatistic.Size = new System.Drawing.Size(150, 21);
            this.comboBoxSelectStatistic.TabIndex = 36;
            this.comboBoxSelectStatistic.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectStatistic_SelectedIndexChanged);
            // 
            // pictureBoxStatistic
            // 
            this.pictureBoxStatistic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxStatistic.Location = new System.Drawing.Point(7, 26);
            this.pictureBoxStatistic.Name = "pictureBoxStatistic";
            this.pictureBoxStatistic.Size = new System.Drawing.Size(819, 219);
            this.pictureBoxStatistic.TabIndex = 34;
            this.pictureBoxStatistic.TabStop = false;
            // 
            // buttonShowStatistic
            // 
            this.buttonShowStatistic.Location = new System.Drawing.Point(3, 199);
            this.buttonShowStatistic.Name = "buttonShowStatistic";
            this.buttonShowStatistic.Size = new System.Drawing.Size(144, 23);
            this.buttonShowStatistic.TabIndex = 49;
            this.buttonShowStatistic.UseVisualStyleBackColor = true;
            this.buttonShowStatistic.Click += new System.EventHandler(this.buttonShowStatistic_Click);
            // 
            // labelCountdownDays
            // 
            this.labelCountdownDays.AutoSize = true;
            this.labelCountdownDays.Location = new System.Drawing.Point(627, 152);
            this.labelCountdownDays.Name = "labelCountdownDays";
            this.labelCountdownDays.Size = new System.Drawing.Size(171, 13);
            this.labelCountdownDays.TabIndex = 48;
            this.labelCountdownDays.Text = "Дней до добавления новой КТ:  ";
            // 
            // labelcPhc
            // 
            this.labelcPhc.AutoSize = true;
            this.labelcPhc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcPhc.Location = new System.Drawing.Point(490, 28);
            this.labelcPhc.Name = "labelcPhc";
            this.labelcPhc.Size = new System.Drawing.Size(122, 17);
            this.labelcPhc.TabIndex = 47;
            this.labelcPhc.Text = "реззультат физы";
            // 
            // labelcPwc
            // 
            this.labelcPwc.AutoSize = true;
            this.labelcPwc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcPwc.Location = new System.Drawing.Point(267, 28);
            this.labelcPwc.Name = "labelcPwc";
            this.labelcPwc.Size = new System.Drawing.Size(112, 17);
            this.labelcPwc.TabIndex = 46;
            this.labelcPwc.Text = "результат силы";
            // 
            // pictureBoxcPhc
            // 
            this.pictureBoxcPhc.Image = global::TrainingProgram.Properties.Resources.middle;
            this.pictureBoxcPhc.Location = new System.Drawing.Point(659, 9);
            this.pictureBoxcPhc.Name = "pictureBoxcPhc";
            this.pictureBoxcPhc.Size = new System.Drawing.Size(38, 36);
            this.pictureBoxcPhc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxcPhc.TabIndex = 45;
            this.pictureBoxcPhc.TabStop = false;
            // 
            // labelcPhcLabel
            // 
            this.labelcPhcLabel.AutoSize = true;
            this.labelcPhcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcPhcLabel.Location = new System.Drawing.Point(490, 9);
            this.labelcPhcLabel.Name = "labelcPhcLabel";
            this.labelcPhcLabel.Size = new System.Drawing.Size(163, 17);
            this.labelcPhcLabel.TabIndex = 39;
            this.labelcPhcLabel.Text = "Физическое состояние";
            // 
            // pictureBoxcPwc
            // 
            this.pictureBoxcPwc.Image = global::TrainingProgram.Properties.Resources.up;
            this.pictureBoxcPwc.Location = new System.Drawing.Point(420, 11);
            this.pictureBoxcPwc.Name = "pictureBoxcPwc";
            this.pictureBoxcPwc.Size = new System.Drawing.Size(41, 36);
            this.pictureBoxcPwc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxcPwc.TabIndex = 41;
            this.pictureBoxcPwc.TabStop = false;
            // 
            // buttonAddControlPoint
            // 
            this.buttonAddControlPoint.Location = new System.Drawing.Point(630, 168);
            this.buttonAddControlPoint.Name = "buttonAddControlPoint";
            this.buttonAddControlPoint.Size = new System.Drawing.Size(196, 23);
            this.buttonAddControlPoint.TabIndex = 37;
            this.buttonAddControlPoint.Text = "Добавить контрольную точку";
            this.buttonAddControlPoint.UseVisualStyleBackColor = true;
            this.buttonAddControlPoint.Click += new System.EventHandler(this.buttonAddControlPoint_Click);
            // 
            // labelcPwcLabel
            // 
            this.labelcPwcLabel.AutoSize = true;
            this.labelcPwcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcPwcLabel.Location = new System.Drawing.Point(267, 9);
            this.labelcPwcLabel.Name = "labelcPwcLabel";
            this.labelcPwcLabel.Size = new System.Drawing.Size(147, 17);
            this.labelcPwcLabel.TabIndex = 38;
            this.labelcPwcLabel.Text = "Силовые показатели";
            // 
            // buttonAddTpForUser
            // 
            this.buttonAddTpForUser.BackgroundImage = global::TrainingProgram.Properties.Resources.statistic;
            this.buttonAddTpForUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAddTpForUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAddTpForUser.Location = new System.Drawing.Point(491, 93);
            this.buttonAddTpForUser.Name = "buttonAddTpForUser";
            this.buttonAddTpForUser.Size = new System.Drawing.Size(160, 231);
            this.buttonAddTpForUser.TabIndex = 6;
            this.buttonAddTpForUser.UseVisualStyleBackColor = true;
            this.buttonAddTpForUser.Click += new System.EventHandler(this.buttonAddTpForUser_Click);
            // 
            // pictureBoxFromImages
            // 
            this.pictureBoxFromImages.Location = new System.Drawing.Point(421, 121);
            this.pictureBoxFromImages.Name = "pictureBoxFromImages";
            this.pictureBoxFromImages.Size = new System.Drawing.Size(218, 203);
            this.pictureBoxFromImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFromImages.TabIndex = 4;
            this.pictureBoxFromImages.TabStop = false;
            this.pictureBoxFromImages.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(308, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 126);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // MainWindow
            // 
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(883, 529);
            this.Controls.Add(this.panelAddTpForUser);
            this.Controls.Add(this.buttonAddNewUser);
            this.Controls.Add(this.label);
            this.Controls.Add(this.checkBoxDescription);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBoxMuscles);
            this.Controls.Add(this.listViewExercises);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelDayWeek);
            this.Controls.Add(this.listViewTrainingProgramm);
            this.Controls.Add(this.listViewUsers);
            this.Controls.Add(this.buttonSaveDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelHeadExercises);
            this.Controls.Add(this.buttonAddTrainingProgram);
            this.Controls.Add(this.buttonSearchMusclesAndExercises);
            this.Controls.Add(this.treeViewMusclesAndExercises);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Controls.Add(this.buttonAddVideo);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.richTextBoxDescriptionExercises);
            this.Controls.Add(this.pictureBoxFromImages);
            this.Controls.Add(this.buttonAddTpForUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.contextMenuStripFromTree.ResumeLayout(false);
            this.contextMenuStripDelRename.ResumeLayout(false);
            this.tableLayoutPanelInfAboutUser.ResumeLayout(false);
            this.tableLayoutPanelInfAboutUser.PerformLayout();
            this.panelAddTpForUser.ResumeLayout(false);
            this.panelAddTpForUser.PerformLayout();
            this.panelStatistic.ResumeLayout(false);
            this.panelStatistic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcPhc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcPwc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFromImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button buttonSearchMusclesAndExercises;
        private System.Windows.Forms.Button buttonAddTrainingProgram;
        private System.Windows.Forms.TreeView treeViewMusclesAndExercises;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxFromImages;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.Button buttonAddTpForUser;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.Button buttonAddVideo;
        private System.Windows.Forms.Label labelHeadExercises;
        private System.Windows.Forms.RichTextBox richTextBoxDescriptionExercises;
        private System.Windows.Forms.CheckBox checkBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonSaveDescription;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFromTree;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ListView listViewTrainingProgramm;
        private System.Windows.Forms.ColumnHeader Exercises;
        private System.Windows.Forms.Label labelDayWeek;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.ListView listViewExercises;
        private System.Windows.Forms.ComboBox comboBoxMuscles;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDelRename;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Button buttonAddNewUser;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelDateofBirth;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInfAboutUser;
        private System.Windows.Forms.Label labelSecondNameUser;
        private System.Windows.Forms.Label labelNameUser;
        private System.Windows.Forms.Label labelDateofBirthUser;
        private System.Windows.Forms.Label labelGenderUser;
        private System.Windows.Forms.Panel panelAddTpForUser;
        public System.Windows.Forms.PictureBox pictureBoxStatistic;
        public System.Windows.Forms.ComboBox comboBoxSelectStatistic;
        private System.Windows.Forms.Label labelStaticName;
        private System.Windows.Forms.Button buttonAddControlPoint;
        private System.Windows.Forms.Label labelcPhcLabel;
        private System.Windows.Forms.Label labelcPwcLabel;
        private System.Windows.Forms.PictureBox pictureBoxcPwc;
        private System.Windows.Forms.PictureBox pictureBoxcPhc;
        private System.Windows.Forms.Label labelcPhc;
        private System.Windows.Forms.Label labelcPwc;
        private System.Windows.Forms.Label labelCountdownDays;
        private System.Windows.Forms.Button buttonShowStatistic;
        private System.Windows.Forms.Panel panelStatistic;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

