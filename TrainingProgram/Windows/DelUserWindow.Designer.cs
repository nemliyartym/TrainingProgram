namespace TrainingProgram.Windows
{
    partial class DelUserWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelUserWindow));
            this.labelEnterUser = new System.Windows.Forms.Label();
            this.listViewUser = new System.Windows.Forms.ListView();
            this.buttonDelUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEnterUser
            // 
            this.labelEnterUser.AutoSize = true;
            this.labelEnterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnterUser.Location = new System.Drawing.Point(55, 30);
            this.labelEnterUser.Name = "labelEnterUser";
            this.labelEnterUser.Size = new System.Drawing.Size(169, 16);
            this.labelEnterUser.TabIndex = 4;
            this.labelEnterUser.Text = "Выберите пользователя";
            // 
            // listViewUser
            // 
            this.listViewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewUser.Location = new System.Drawing.Point(36, 68);
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.Size = new System.Drawing.Size(156, 143);
            this.listViewUser.TabIndex = 3;
            this.listViewUser.UseCompatibleStateImageBehavior = false;
            this.listViewUser.View = System.Windows.Forms.View.SmallIcon;
            // 
            // buttonDelUser
            // 
            this.buttonDelUser.BackColor = System.Drawing.Color.LightBlue;
            this.buttonDelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelUser.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonDelUser.Location = new System.Drawing.Point(58, 229);
            this.buttonDelUser.Name = "buttonDelUser";
            this.buttonDelUser.Size = new System.Drawing.Size(105, 25);
            this.buttonDelUser.TabIndex = 6;
            this.buttonDelUser.Text = "Удалить";
            this.buttonDelUser.UseVisualStyleBackColor = false;
            this.buttonDelUser.Click += new System.EventHandler(this.buttonDelUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // DelUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(225, 266);
            this.Controls.Add(this.buttonDelUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelEnterUser);
            this.Controls.Add(this.listViewUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DelUserWindow";
            this.Text = "Удаление спортсменов";
            this.Load += new System.EventHandler(this.DelUserWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelEnterUser;
        private System.Windows.Forms.ListView listViewUser;
        private System.Windows.Forms.Button buttonDelUser;
    }
}