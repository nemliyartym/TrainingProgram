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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.buttonSearchMusclesAndExercises = new System.Windows.Forms.Button();
            this.buttonAddTrainingProgram = new System.Windows.Forms.Button();
            this.treeViewMusclesAndExercises = new System.Windows.Forms.TreeView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxFromImages = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFromImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
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
            this.buttonAddTrainingProgram.Location = new System.Drawing.Point(411, 316);
            this.buttonAddTrainingProgram.Name = "buttonAddTrainingProgram";
            this.buttonAddTrainingProgram.Size = new System.Drawing.Size(156, 231);
            this.buttonAddTrainingProgram.TabIndex = 1;
            this.buttonAddTrainingProgram.Text = "buttonAddTrainingProgram";
            this.buttonAddTrainingProgram.UseVisualStyleBackColor = true;
            this.buttonAddTrainingProgram.Click += new System.EventHandler(this.buttonAddTrainingProgram_Click);
            // 
            // treeViewMusclesAndExercises
            // 
            this.treeViewMusclesAndExercises.Location = new System.Drawing.Point(25, 62);
            this.treeViewMusclesAndExercises.Name = "treeViewMusclesAndExercises";
            this.treeViewMusclesAndExercises.Size = new System.Drawing.Size(304, 382);
            this.treeViewMusclesAndExercises.TabIndex = 2;
            this.treeViewMusclesAndExercises.Visible = false;
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
            this.pictureBoxFromImages.Location = new System.Drawing.Point(349, 62);
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
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(582, 62);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(173, 203);
            this.axWindowsMediaPlayer.TabIndex = 5;
            this.axWindowsMediaPlayer.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 460);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddTrainingProgram);
            this.Controls.Add(this.buttonSearchMusclesAndExercises);
            this.Controls.Add(this.treeViewMusclesAndExercises);
            this.Controls.Add(this.pictureBoxFromImages);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Name = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFromImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Button buttonSearchMusclesAndExercises;
        private System.Windows.Forms.Button buttonAddTrainingProgram;
        private System.Windows.Forms.TreeView treeViewMusclesAndExercises;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxFromImages;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
    }
}

