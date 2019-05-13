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
            this.listViewUser = new System.Windows.Forms.ListView();
            this.labelListUser = new System.Windows.Forms.Label();
            this.tableLayoutPanelAddInfUser = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labeldate = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textBoxPressureUp = new System.Windows.Forms.TextBox();
            this.textBoxPuls = new System.Windows.Forms.TextBox();
            this.textBoxPressureDown = new System.Windows.Forms.TextBox();
            this.textBoxGrowth = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxPullUps = new System.Windows.Forms.TextBox();
            this.textBoxPushUps = new System.Windows.Forms.TextBox();
            this.textBoxSquts = new System.Windows.Forms.TextBox();
            this.textBoxRun100 = new System.Windows.Forms.TextBox();
            this.textBoxPress = new System.Windows.Forms.TextBox();
            this.pictureBoxSecond = new System.Windows.Forms.PictureBox();
            this.pictureBoxFirst = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelAddInfUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirst)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Имя";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Location = new System.Drawing.Point(3, 29);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(56, 13);
            this.labelSecondName.TabIndex = 2;
            this.labelSecondName.Text = "Фамилия";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(3, 56);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(27, 13);
            this.labelGender.TabIndex = 3;
            this.labelGender.Text = "Пол";
            // 
            // listViewUser
            // 
            this.listViewUser.Location = new System.Drawing.Point(12, 28);
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.Size = new System.Drawing.Size(153, 178);
            this.listViewUser.TabIndex = 11;
            this.listViewUser.UseCompatibleStateImageBehavior = false;
            this.listViewUser.View = System.Windows.Forms.View.SmallIcon;
            // 
            // labelListUser
            // 
            this.labelListUser.AutoSize = true;
            this.labelListUser.Location = new System.Drawing.Point(22, 12);
            this.labelListUser.Name = "labelListUser";
            this.labelListUser.Size = new System.Drawing.Size(124, 13);
            this.labelListUser.TabIndex = 12;
            this.labelListUser.Text = "Список пользователей";
            // 
            // tableLayoutPanelAddInfUser
            // 
            this.tableLayoutPanelAddInfUser.ColumnCount = 2;
            this.tableLayoutPanelAddInfUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanelAddInfUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanelAddInfUser.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanelAddInfUser.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanelAddInfUser.Controls.Add(this.labelSecondName, 0, 1);
            this.tableLayoutPanelAddInfUser.Controls.Add(this.textBoxSecondName, 1, 1);
            this.tableLayoutPanelAddInfUser.Controls.Add(this.dateTimePicker, 1, 3);
            this.tableLayoutPanelAddInfUser.Controls.Add(this.labelGender, 0, 2);
            this.tableLayoutPanelAddInfUser.Controls.Add(this.labeldate, 0, 3);
            this.tableLayoutPanelAddInfUser.Controls.Add(this.comboBoxGender, 1, 2);
            this.tableLayoutPanelAddInfUser.Location = new System.Drawing.Point(171, 49);
            this.tableLayoutPanelAddInfUser.Name = "tableLayoutPanelAddInfUser";
            this.tableLayoutPanelAddInfUser.RowCount = 4;
            this.tableLayoutPanelAddInfUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelAddInfUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelAddInfUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanelAddInfUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanelAddInfUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAddInfUser.Size = new System.Drawing.Size(196, 118);
            this.tableLayoutPanelAddInfUser.TabIndex = 13;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(70, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.Tag = "1111111111111";
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(70, 32);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSecondName.TabIndex = 5;
            this.textBoxSecondName.Tag = "222222222";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(70, 87);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(119, 20);
            this.dateTimePicker.TabIndex = 9;
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Location = new System.Drawing.Point(3, 84);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(57, 26);
            this.labeldate.TabIndex = 7;
            this.labeldate.Text = "Дата рождения";
            this.labeldate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.comboBoxGender.Location = new System.Drawing.Point(70, 59);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(99, 21);
            this.comboBoxGender.TabIndex = 8;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(12, 212);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 16;
            this.buttonPrev.Text = "Назад";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(228, 212);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(143, 23);
            this.buttonNext.TabIndex = 17;
            this.buttonNext.Text = "Дальше";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textBoxPressureUp
            // 
            this.textBoxPressureUp.Location = new System.Drawing.Point(220, 38);
            this.textBoxPressureUp.Name = "textBoxPressureUp";
            this.textBoxPressureUp.Size = new System.Drawing.Size(64, 20);
            this.textBoxPressureUp.TabIndex = 18;
            this.textBoxPressureUp.Tag = "pressuredown";
            // 
            // textBoxPuls
            // 
            this.textBoxPuls.Location = new System.Drawing.Point(28, 165);
            this.textBoxPuls.Name = "textBoxPuls";
            this.textBoxPuls.Size = new System.Drawing.Size(140, 20);
            this.textBoxPuls.TabIndex = 19;
            this.textBoxPuls.Tag = "Puls";
            // 
            // textBoxPressureDown
            // 
            this.textBoxPressureDown.Location = new System.Drawing.Point(296, 38);
            this.textBoxPressureDown.Name = "textBoxPressureDown";
            this.textBoxPressureDown.Size = new System.Drawing.Size(64, 20);
            this.textBoxPressureDown.TabIndex = 19;
            this.textBoxPressureDown.Tag = "pressureUp";
            // 
            // textBoxGrowth
            // 
            this.textBoxGrowth.Location = new System.Drawing.Point(28, 165);
            this.textBoxGrowth.Name = "textBoxGrowth";
            this.textBoxGrowth.Size = new System.Drawing.Size(140, 20);
            this.textBoxGrowth.TabIndex = 21;
            this.textBoxGrowth.Tag = "growth";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(220, 38);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(140, 20);
            this.textBoxWeight.TabIndex = 22;
            this.textBoxWeight.Tag = "weight";
            // 
            // textBoxPullUps
            // 
            this.textBoxPullUps.Location = new System.Drawing.Point(28, 165);
            this.textBoxPullUps.Name = "textBoxPullUps";
            this.textBoxPullUps.Size = new System.Drawing.Size(140, 20);
            this.textBoxPullUps.TabIndex = 23;
            this.textBoxPullUps.Tag = "pullups";
            // 
            // textBoxPushUps
            // 
            this.textBoxPushUps.Location = new System.Drawing.Point(220, 38);
            this.textBoxPushUps.Name = "textBoxPushUps";
            this.textBoxPushUps.Size = new System.Drawing.Size(140, 20);
            this.textBoxPushUps.TabIndex = 24;
            this.textBoxPushUps.Tag = "pushup";
            // 
            // textBoxSquts
            // 
            this.textBoxSquts.Location = new System.Drawing.Point(28, 165);
            this.textBoxSquts.Name = "textBoxSquts";
            this.textBoxSquts.Size = new System.Drawing.Size(140, 20);
            this.textBoxSquts.TabIndex = 25;
            this.textBoxSquts.Tag = "squts";
            // 
            // textBoxRun100
            // 
            this.textBoxRun100.Location = new System.Drawing.Point(220, 38);
            this.textBoxRun100.Name = "textBoxRun100";
            this.textBoxRun100.Size = new System.Drawing.Size(140, 20);
            this.textBoxRun100.TabIndex = 26;
            this.textBoxRun100.Tag = "run 100";
            // 
            // textBoxPress
            // 
            this.textBoxPress.Location = new System.Drawing.Point(28, 165);
            this.textBoxPress.Name = "textBoxPress";
            this.textBoxPress.Size = new System.Drawing.Size(140, 20);
            this.textBoxPress.TabIndex = 27;
            this.textBoxPress.Tag = "Press";
            // 
            // pictureBoxSecond
            // 
            this.pictureBoxSecond.Location = new System.Drawing.Point(220, 64);
            this.pictureBoxSecond.Name = "pictureBoxSecond";
            this.pictureBoxSecond.Size = new System.Drawing.Size(140, 140);
            this.pictureBoxSecond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSecond.TabIndex = 15;
            this.pictureBoxSecond.TabStop = false;
            // 
            // pictureBoxFirst
            // 
            this.pictureBoxFirst.Location = new System.Drawing.Point(28, 19);
            this.pictureBoxFirst.Name = "pictureBoxFirst";
            this.pictureBoxFirst.Size = new System.Drawing.Size(140, 140);
            this.pictureBoxFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFirst.TabIndex = 14;
            this.pictureBoxFirst.TabStop = false;
            // 
            // AddUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 245);
            this.Controls.Add(this.textBoxPress);
            this.Controls.Add(this.textBoxRun100);
            this.Controls.Add(this.textBoxSquts);
            this.Controls.Add(this.textBoxPushUps);
            this.Controls.Add(this.textBoxPullUps);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxGrowth);
            this.Controls.Add(this.textBoxPressureDown);
            this.Controls.Add(this.textBoxPuls);
            this.Controls.Add(this.textBoxPressureUp);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.pictureBoxSecond);
            this.Controls.Add(this.pictureBoxFirst);
            this.Controls.Add(this.tableLayoutPanelAddInfUser);
            this.Controls.Add(this.labelListUser);
            this.Controls.Add(this.listViewUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddUserWindow";
            this.Text = "AddUserWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddUserWindow_FormClosing);
            this.Load += new System.EventHandler(this.AddUserWindow_Load);
            this.tableLayoutPanelAddInfUser.ResumeLayout(false);
            this.tableLayoutPanelAddInfUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ListView listViewUser;
        private System.Windows.Forms.Label labelListUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAddInfUser;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        protected System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.PictureBox pictureBoxFirst;
        private System.Windows.Forms.PictureBox pictureBoxSecond;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxPressureUp;
        private System.Windows.Forms.TextBox textBoxPuls;
        private System.Windows.Forms.TextBox textBoxPressureDown;
        private System.Windows.Forms.TextBox textBoxGrowth;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxPullUps;
        private System.Windows.Forms.TextBox textBoxPushUps;
        private System.Windows.Forms.TextBox textBoxSquts;
        private System.Windows.Forms.TextBox textBoxRun100;
        private System.Windows.Forms.TextBox textBoxPress;
    }
}