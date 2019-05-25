namespace TrainingProgram.Windows
{
    partial class AddExercisesWindow
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
            this.listViewExercises = new System.Windows.Forms.ListView();
            this.buttonAddExercises = new System.Windows.Forms.Button();
            this.textBoxNameExercises = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxlvlDifficulty = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMuscles = new System.Windows.Forms.ComboBox();
            this.labelMuscles = new System.Windows.Forms.Label();
            this.labelExercises = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAddCouple = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewExercises
            // 
            this.listViewExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewExercises.Location = new System.Drawing.Point(187, 44);
            this.listViewExercises.Name = "listViewExercises";
            this.listViewExercises.Size = new System.Drawing.Size(189, 249);
            this.listViewExercises.TabIndex = 1;
            this.listViewExercises.UseCompatibleStateImageBehavior = false;
            this.listViewExercises.View = System.Windows.Forms.View.SmallIcon;
            this.listViewExercises.DoubleClick += new System.EventHandler(this.listViewExercises_DoubleClick);
            // 
            // buttonAddExercises
            // 
            this.buttonAddExercises.BackColor = System.Drawing.Color.LightBlue;
            this.buttonAddExercises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddExercises.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonAddExercises.Location = new System.Drawing.Point(27, 177);
            this.buttonAddExercises.Name = "buttonAddExercises";
            this.buttonAddExercises.Size = new System.Drawing.Size(131, 39);
            this.buttonAddExercises.TabIndex = 8;
            this.buttonAddExercises.Text = "Добавить упражнение";
            this.buttonAddExercises.UseVisualStyleBackColor = false;
            this.buttonAddExercises.Click += new System.EventHandler(this.buttonAddExercises_Click);
            // 
            // textBoxNameExercises
            // 
            this.textBoxNameExercises.Location = new System.Drawing.Point(27, 96);
            this.textBoxNameExercises.Name = "textBoxNameExercises";
            this.textBoxNameExercises.Size = new System.Drawing.Size(131, 20);
            this.textBoxNameExercises.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите название \r\nупражнения и уровень";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxlvlDifficulty
            // 
            this.comboBoxlvlDifficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxlvlDifficulty.FormattingEnabled = true;
            this.comboBoxlvlDifficulty.Items.AddRange(new object[] {
            "Низкий",
            "Ниже среднего",
            "Средний",
            "Выше среднего",
            "Высокий"});
            this.comboBoxlvlDifficulty.Location = new System.Drawing.Point(27, 130);
            this.comboBoxlvlDifficulty.Name = "comboBoxlvlDifficulty";
            this.comboBoxlvlDifficulty.Size = new System.Drawing.Size(131, 21);
            this.comboBoxlvlDifficulty.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(400, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Добавить упражнения\r\nк группам мышц";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxMuscles
            // 
            this.comboBoxMuscles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxMuscles.FormattingEnabled = true;
            this.comboBoxMuscles.Items.AddRange(new object[] {
            "Низкий",
            "Ниже среднего",
            "Средний",
            "Выше среднего",
            "Высокий"});
            this.comboBoxMuscles.Location = new System.Drawing.Point(403, 95);
            this.comboBoxMuscles.Name = "comboBoxMuscles";
            this.comboBoxMuscles.Size = new System.Drawing.Size(131, 21);
            this.comboBoxMuscles.TabIndex = 13;
            this.comboBoxMuscles.SelectedIndexChanged += new System.EventHandler(this.comboBoxMuscles_SelectedIndexChanged);
            // 
            // labelMuscles
            // 
            this.labelMuscles.AutoSize = true;
            this.labelMuscles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMuscles.Location = new System.Drawing.Point(400, 130);
            this.labelMuscles.Name = "labelMuscles";
            this.labelMuscles.Size = new System.Drawing.Size(142, 15);
            this.labelMuscles.TabIndex = 14;
            this.labelMuscles.Text = "Выберите группу мышц";
            this.labelMuscles.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelExercises
            // 
            this.labelExercises.AutoSize = true;
            this.labelExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExercises.Location = new System.Drawing.Point(400, 201);
            this.labelExercises.Name = "labelExercises";
            this.labelExercises.Size = new System.Drawing.Size(139, 30);
            this.labelExercises.TabIndex = 15;
            this.labelExercises.Text = "Выберите упражнение\r\n\r\n";
            this.labelExercises.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(215, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Список урпажнений";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::TrainingProgram.Properties.Resources.two_arow;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(444, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAddCouple
            // 
            this.buttonAddCouple.BackColor = System.Drawing.Color.LightBlue;
            this.buttonAddCouple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCouple.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCouple.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonAddCouple.Location = new System.Drawing.Point(403, 234);
            this.buttonAddCouple.Name = "buttonAddCouple";
            this.buttonAddCouple.Size = new System.Drawing.Size(131, 48);
            this.buttonAddCouple.TabIndex = 18;
            this.buttonAddCouple.Text = "Добавить пару";
            this.buttonAddCouple.UseVisualStyleBackColor = false;
            this.buttonAddCouple.Click += new System.EventHandler(this.buttonAddCouple_Click);
            // 
            // AddExercisesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(566, 299);
            this.Controls.Add(this.buttonAddCouple);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelExercises);
            this.Controls.Add(this.labelMuscles);
            this.Controls.Add(this.comboBoxMuscles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxlvlDifficulty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNameExercises);
            this.Controls.Add(this.buttonAddExercises);
            this.Controls.Add(this.listViewExercises);
            this.Name = "AddExercisesWindow";
            this.Text = "AddExercisesWindow";
            this.Load += new System.EventHandler(this.AddExercisesWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewExercises;
        private System.Windows.Forms.Button buttonAddExercises;
        private System.Windows.Forms.TextBox textBoxNameExercises;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxlvlDifficulty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMuscles;
        private System.Windows.Forms.Label labelMuscles;
        private System.Windows.Forms.Label labelExercises;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAddCouple;
    }
}