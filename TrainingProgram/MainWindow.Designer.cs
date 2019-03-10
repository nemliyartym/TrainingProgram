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
            this.pictureBoxFromImages = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonOther = new System.Windows.Forms.Button();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.buttonAddVideo = new System.Windows.Forms.Button();
            this.labelHeadExercises = new System.Windows.Forms.Label();
            this.richTextBoxDescriptionExercises = new System.Windows.Forms.RichTextBox();
            this.checkBoxDescription = new System.Windows.Forms.CheckBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonSaveDescription = new System.Windows.Forms.Button();
            this.contextMenuStripFromTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.переименоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFromImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.contextMenuStripFromTree.SuspendLayout();
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
            this.treeViewMusclesAndExercises.Location = new System.Drawing.Point(12, 62);
            this.treeViewMusclesAndExercises.Name = "treeViewMusclesAndExercises";
            this.treeViewMusclesAndExercises.Size = new System.Drawing.Size(403, 453);
            this.treeViewMusclesAndExercises.TabIndex = 2;
            this.treeViewMusclesAndExercises.Visible = false;
            this.treeViewMusclesAndExercises.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewMusclesAndExercises_NodeMouseClick);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(25, 13);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(67, 26);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "buttonBack";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
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
            // buttonOther
            // 
            this.buttonOther.Location = new System.Drawing.Point(491, 93);
            this.buttonOther.Name = "buttonOther";
            this.buttonOther.Size = new System.Drawing.Size(160, 231);
            this.buttonOther.TabIndex = 6;
            this.buttonOther.Text = "buttonOther";
            this.buttonOther.UseVisualStyleBackColor = true;
            this.buttonOther.Visible = false;
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
            // 
            // MainWindow
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(874, 540);
            this.Controls.Add(this.buttonSaveDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.checkBoxDescription);
            this.Controls.Add(this.labelHeadExercises);
            this.Controls.Add(this.buttonOther);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddTrainingProgram);
            this.Controls.Add(this.buttonSearchMusclesAndExercises);
            this.Controls.Add(this.treeViewMusclesAndExercises);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Controls.Add(this.buttonAddVideo);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.richTextBoxDescriptionExercises);
            this.Controls.Add(this.pictureBoxFromImages);
            this.Name = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFromImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.contextMenuStripFromTree.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonOther;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.Button buttonAddVideo;
        private System.Windows.Forms.Label labelHeadExercises;
        private System.Windows.Forms.RichTextBox richTextBoxDescriptionExercises;
        private System.Windows.Forms.CheckBox checkBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonSaveDescription;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFromTree;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem;
    }
}

