namespace TrainingProgram.Windows
{
    partial class SelectUserWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewUser = new System.Windows.Forms.ListView();
            this.labelEnterUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewUser
            // 
            this.listViewUser.Location = new System.Drawing.Point(38, 68);
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.Size = new System.Drawing.Size(156, 175);
            this.listViewUser.TabIndex = 0;
            this.listViewUser.UseCompatibleStateImageBehavior = false;
            this.listViewUser.View = System.Windows.Forms.View.SmallIcon;
            this.listViewUser.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // labelEnterUser
            // 
            this.labelEnterUser.AutoSize = true;
            this.labelEnterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnterUser.Location = new System.Drawing.Point(57, 30);
            this.labelEnterUser.Name = "labelEnterUser";
            this.labelEnterUser.Size = new System.Drawing.Size(169, 16);
            this.labelEnterUser.TabIndex = 1;
            this.labelEnterUser.Text = "Выберите пользователя";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrainingProgram.Properties.Resources.muscleMan;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SelectUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 266);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelEnterUser);
            this.Controls.Add(this.listViewUser);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SelectUserWindow";
            this.Text = "SelectUserWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectUserWindow_FormClosing);
            this.Load += new System.EventHandler(this.SelectUserWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewUser;
        private System.Windows.Forms.Label labelEnterUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}