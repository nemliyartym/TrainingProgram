﻿namespace TrainingProgram
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelGrowth = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxGrowth = new System.Windows.Forms.TextBox();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonPrevPage = new System.Windows.Forms.Button();
            this.labelGender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelPuls = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.textBoxPuls = new System.Windows.Forms.TextBox();
            this.textBoxPressureUp = new System.Windows.Forms.TextBox();
            this.textBoxPressureDown = new System.Windows.Forms.TextBox();
            this.labelPressureOR = new System.Windows.Forms.Label();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelADsr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(77, 44);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(123, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(77, 70);
            this.textBoxSecondName.MaxLength = 50;
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(123, 20);
            this.textBoxSecondName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(32, 47);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя";
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Location = new System.Drawing.Point(15, 73);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(56, 13);
            this.labelSecondName.TabIndex = 3;
            this.labelSecondName.Text = "Фамилия";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(116, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(146, 13);
            this.labelHeader.TabIndex = 4;
            this.labelHeader.Text = "Добавление новго клиента";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(219, 71);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(46, 13);
            this.labelWeight.TabIndex = 5;
            this.labelWeight.Text = "Вес (кг)";
            // 
            // labelGrowth
            // 
            this.labelGrowth.AutoSize = true;
            this.labelGrowth.Location = new System.Drawing.Point(219, 97);
            this.labelGrowth.Name = "labelGrowth";
            this.labelGrowth.Size = new System.Drawing.Size(54, 13);
            this.labelGrowth.TabIndex = 6;
            this.labelGrowth.Text = "Рост (см)";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(276, 68);
            this.textBoxWeight.MaxLength = 3;
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(65, 20);
            this.textBoxWeight.TabIndex = 7;
            // 
            // textBoxGrowth
            // 
            this.textBoxGrowth.Location = new System.Drawing.Point(276, 94);
            this.textBoxGrowth.MaxLength = 3;
            this.textBoxGrowth.Name = "textBoxGrowth";
            this.textBoxGrowth.Size = new System.Drawing.Size(65, 20);
            this.textBoxGrowth.TabIndex = 8;
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Location = new System.Drawing.Point(286, 130);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(75, 23);
            this.buttonNextPage.TabIndex = 9;
            this.buttonNextPage.Text = "Next";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // buttonPrevPage
            // 
            this.buttonPrevPage.Location = new System.Drawing.Point(35, 130);
            this.buttonPrevPage.Name = "buttonPrevPage";
            this.buttonPrevPage.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevPage.TabIndex = 10;
            this.buttonPrevPage.Text = "Prev";
            this.buttonPrevPage.UseVisualStyleBackColor = true;
            this.buttonPrevPage.Visible = false;
            this.buttonPrevPage.Click += new System.EventHandler(this.buttonPrevPage_Click);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(18, 97);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(27, 13);
            this.labelGender.TabIndex = 12;
            this.labelGender.Text = "Пол";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Женский",
            "Мужской"});
            this.comboBoxGender.Location = new System.Drawing.Point(77, 97);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(123, 21);
            this.comboBoxGender.TabIndex = 13;
            // 
            // labelPuls
            // 
            this.labelPuls.AutoSize = true;
            this.labelPuls.Location = new System.Drawing.Point(18, 47);
            this.labelPuls.Name = "labelPuls";
            this.labelPuls.Size = new System.Drawing.Size(82, 13);
            this.labelPuls.TabIndex = 14;
            this.labelPuls.Text = "Пульс за 1мин";
            this.labelPuls.Visible = false;
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Location = new System.Drawing.Point(18, 73);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(82, 26);
            this.labelPressure.TabIndex = 15;
            this.labelPressure.Text = "Артериальное \r\nдавление";
            this.labelPressure.Visible = false;
            // 
            // textBoxPuls
            // 
            this.textBoxPuls.Location = new System.Drawing.Point(107, 44);
            this.textBoxPuls.MaxLength = 3;
            this.textBoxPuls.Name = "textBoxPuls";
            this.textBoxPuls.Size = new System.Drawing.Size(100, 20);
            this.textBoxPuls.TabIndex = 16;
            this.textBoxPuls.Visible = false;
            // 
            // textBoxPressureUp
            // 
            this.textBoxPressureUp.Location = new System.Drawing.Point(106, 73);
            this.textBoxPressureUp.MaxLength = 3;
            this.textBoxPressureUp.Name = "textBoxPressureUp";
            this.textBoxPressureUp.Size = new System.Drawing.Size(39, 20);
            this.textBoxPressureUp.TabIndex = 17;
            this.textBoxPressureUp.Visible = false;
            // 
            // textBoxPressureDown
            // 
            this.textBoxPressureDown.Location = new System.Drawing.Point(169, 73);
            this.textBoxPressureDown.MaxLength = 3;
            this.textBoxPressureDown.Name = "textBoxPressureDown";
            this.textBoxPressureDown.Size = new System.Drawing.Size(37, 20);
            this.textBoxPressureDown.TabIndex = 18;
            this.textBoxPressureDown.Visible = false;
            // 
            // labelPressureOR
            // 
            this.labelPressureOR.AutoSize = true;
            this.labelPressureOR.Location = new System.Drawing.Point(151, 76);
            this.labelPressureOR.Name = "labelPressureOR";
            this.labelPressureOR.Size = new System.Drawing.Size(12, 13);
            this.labelPressureOR.TabIndex = 19;
            this.labelPressureOR.Text = "/";
            this.labelPressureOR.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelPressureOR.Visible = false;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(205, 130);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(75, 23);
            this.buttonAddUser.TabIndex = 20;
            this.buttonAddUser.Text = "add";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Visible = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(220, 46);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(49, 13);
            this.labelAge.TabIndex = 21;
            this.labelAge.Text = "Возраст";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(275, 43);
            this.textBoxAge.MaxLength = 3;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(66, 20);
            this.textBoxAge.TabIndex = 22;
            // 
            // labelADsr
            // 
            this.labelADsr.AutoSize = true;
            this.labelADsr.Location = new System.Drawing.Point(240, 59);
            this.labelADsr.Name = "labelADsr";
            this.labelADsr.Size = new System.Drawing.Size(10, 13);
            this.labelADsr.TabIndex = 23;
            this.labelADsr.Text = " ";
            // 
            // AddUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 165);
            this.Controls.Add(this.labelADsr);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.labelPressure);
            this.Controls.Add(this.labelPuls);
            this.Controls.Add(this.labelPressureOR);
            this.Controls.Add(this.textBoxPressureDown);
            this.Controls.Add(this.textBoxPressureUp);
            this.Controls.Add(this.textBoxPuls);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.buttonPrevPage);
            this.Controls.Add(this.buttonNextPage);
            this.Controls.Add(this.textBoxGrowth);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.labelGrowth);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.labelSecondName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxSecondName);
            this.Controls.Add(this.textBoxName);
            this.Name = "AddUserWindow";
            this.Text = "AddUserWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelGrowth;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxGrowth;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Button buttonPrevPage;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelPuls;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.TextBox textBoxPuls;
        private System.Windows.Forms.TextBox textBoxPressureUp;
        private System.Windows.Forms.TextBox textBoxPressureDown;
        private System.Windows.Forms.Label labelPressureOR;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelADsr;
    }
}