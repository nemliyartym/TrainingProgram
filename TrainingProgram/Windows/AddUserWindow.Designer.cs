namespace TrainingProgram.Windows
{
    partial class AddUserWindow
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.labeldate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.listViewUser = new System.Windows.Forms.ListView();
            this.lableListUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(190, 49);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Имя";
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Location = new System.Drawing.Point(171, 80);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(56, 13);
            this.labelSecondName.TabIndex = 2;
            this.labelSecondName.Text = "Фамилия";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(192, 109);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(27, 13);
            this.labelGender.TabIndex = 3;
            this.labelGender.Text = "Пол";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(234, 46);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(234, 77);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSecondName.TabIndex = 5;
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Location = new System.Drawing.Point(214, 144);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(86, 13);
            this.labeldate.TabIndex = 7;
            this.labeldate.Text = "Дата рождения";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(204, 160);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(119, 20);
            this.dateTimePicker.TabIndex = 9;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxGender.Location = new System.Drawing.Point(235, 106);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(99, 21);
            this.comboBoxGender.TabIndex = 8;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Enabled = false;
            this.buttonAddUser.Location = new System.Drawing.Point(217, 196);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(83, 23);
            this.buttonAddUser.TabIndex = 10;
            this.buttonAddUser.Text = "Добавить пользователя";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // listViewUser
            // 
            this.listViewUser.Location = new System.Drawing.Point(12, 49);
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.Size = new System.Drawing.Size(153, 178);
            this.listViewUser.TabIndex = 11;
            this.listViewUser.UseCompatibleStateImageBehavior = false;
            this.listViewUser.View = System.Windows.Forms.View.SmallIcon;
            this.listViewUser.DoubleClick += new System.EventHandler(this.listViewUser_DoubleClick);
            // 
            // lableListUser
            // 
            this.lableListUser.AutoSize = true;
            this.lableListUser.Location = new System.Drawing.Point(27, 23);
            this.lableListUser.Name = "lableListUser";
            this.lableListUser.Size = new System.Drawing.Size(124, 13);
            this.lableListUser.TabIndex = 12;
            this.lableListUser.Text = "Список пользователей";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrainingProgram.Properties.Resources.pulse;
            this.pictureBox1.Location = new System.Drawing.Point(48, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // AddUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 239);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lableListUser);
            this.Controls.Add(this.listViewUser);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelSecondName);
            this.Controls.Add(this.labelName);
            this.Name = "AddUserWindow";
            this.Text = "AddUserWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        protected System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.ListView listViewUser;
        private System.Windows.Forms.Label lableListUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}