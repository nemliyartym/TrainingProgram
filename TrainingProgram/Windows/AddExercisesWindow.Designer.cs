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
            this.listViewUser = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewUser
            // 
            this.listViewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewUser.Location = new System.Drawing.Point(41, 48);
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.Size = new System.Drawing.Size(156, 186);
            this.listViewUser.TabIndex = 1;
            this.listViewUser.UseCompatibleStateImageBehavior = false;
            this.listViewUser.View = System.Windows.Forms.View.SmallIcon;
            // 
            // AddExercisesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 283);
            this.Controls.Add(this.listViewUser);
            this.Name = "AddExercisesWindow";
            this.Text = "AddExercisesWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewUser;
    }
}