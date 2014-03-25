namespace mit
{
    partial class SaveProject
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Project_Name = new System.Windows.Forms.TextBox();
            this.Save_Project = new System.Windows.Forms.Button();
            this.Cancel_ProjectSave = new System.Windows.Forms.Button();
            this.error_Label = new System.Windows.Forms.Label();
            this.Project_Location = new System.Windows.Forms.TextBox();
            this.Browse_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Solution_Name = new System.Windows.Forms.TextBox();
            this.checkBoxCreateDirectory = new System.Windows.Forms.CheckBox();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Give the Project Path";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // Project_Name
            // 
            this.Project_Name.Location = new System.Drawing.Point(117, 25);
            this.Project_Name.Name = "Project_Name";
            this.Project_Name.Size = new System.Drawing.Size(472, 20);
            this.Project_Name.TabIndex = 0;
            this.Project_Name.TextChanged += new System.EventHandler(this.Project_Name_TextChanged);
            // 
            // Save_Project
            // 
            this.Save_Project.Location = new System.Drawing.Point(117, 116);
            this.Save_Project.Name = "Save_Project";
            this.Save_Project.Size = new System.Drawing.Size(75, 23);
            this.Save_Project.TabIndex = 1;
            this.Save_Project.Text = "Save";
            this.Save_Project.UseVisualStyleBackColor = true;
            this.Save_Project.Click += new System.EventHandler(this.Save_Project_Click);
            // 
            // Cancel_ProjectSave
            // 
            this.Cancel_ProjectSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_ProjectSave.Location = new System.Drawing.Point(226, 116);
            this.Cancel_ProjectSave.Name = "Cancel_ProjectSave";
            this.Cancel_ProjectSave.Size = new System.Drawing.Size(75, 23);
            this.Cancel_ProjectSave.TabIndex = 2;
            this.Cancel_ProjectSave.Text = "Cancel";
            this.Cancel_ProjectSave.UseVisualStyleBackColor = true;
            this.Cancel_ProjectSave.Click += new System.EventHandler(this.Cancel_ProjectSave_Click);
            // 
            // error_Label
            // 
            this.error_Label.AutoSize = true;
            this.error_Label.ForeColor = System.Drawing.Color.Red;
            this.error_Label.Location = new System.Drawing.Point(22, 138);
            this.error_Label.Name = "error_Label";
            this.error_Label.Size = new System.Drawing.Size(16, 13);
            this.error_Label.TabIndex = 3;
            this.error_Label.Text = "...";
            // 
            // Project_Location
            // 
            this.Project_Location.Location = new System.Drawing.Point(117, 52);
            this.Project_Location.Name = "Project_Location";
            this.Project_Location.ReadOnly = true;
            this.Project_Location.Size = new System.Drawing.Size(472, 20);
            this.Project_Location.TabIndex = 4;
            // 
            // Browse_button
            // 
            this.Browse_button.Location = new System.Drawing.Point(595, 49);
            this.Browse_button.Name = "Browse_button";
            this.Browse_button.Size = new System.Drawing.Size(75, 23);
            this.Browse_button.TabIndex = 5;
            this.Browse_button.Text = "Browse...";
            this.Browse_button.UseVisualStyleBackColor = true;
            this.Browse_button.Click += new System.EventHandler(this.Browse_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Location:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Solution Name:";
            // 
            // Solution_Name
            // 
            this.Solution_Name.Location = new System.Drawing.Point(117, 77);
            this.Solution_Name.Name = "Solution_Name";
            this.Solution_Name.Size = new System.Drawing.Size(306, 20);
            this.Solution_Name.TabIndex = 10;
            this.Solution_Name.TextChanged += new System.EventHandler(this.Solution_Name_TextChanged);
            // 
            // checkBoxCreateDirectory
            // 
            this.checkBoxCreateDirectory.AutoSize = true;
            this.checkBoxCreateDirectory.Checked = true;
            this.checkBoxCreateDirectory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCreateDirectory.Location = new System.Drawing.Point(435, 80);
            this.checkBoxCreateDirectory.Name = "checkBoxCreateDirectory";
            this.checkBoxCreateDirectory.Size = new System.Drawing.Size(154, 17);
            this.checkBoxCreateDirectory.TabIndex = 11;
            this.checkBoxCreateDirectory.Text = "Create directory for solution";
            this.checkBoxCreateDirectory.UseVisualStyleBackColor = true;
            this.checkBoxCreateDirectory.CheckedChanged += new System.EventHandler(this.checkBoxCreateDirectory_CheckedChanged);
            // 
            // groupbox1
            // 
            this.groupbox1.AutoSize = true;
            this.groupbox1.Controls.Add(this.checkBoxCreateDirectory);
            this.groupbox1.Controls.Add(this.Solution_Name);
            this.groupbox1.Controls.Add(this.label3);
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Controls.Add(this.Browse_button);
            this.groupbox1.Controls.Add(this.Project_Location);
            this.groupbox1.Controls.Add(this.error_Label);
            this.groupbox1.Controls.Add(this.Cancel_ProjectSave);
            this.groupbox1.Controls.Add(this.Save_Project);
            this.groupbox1.Controls.Add(this.Project_Name);
            this.groupbox1.Location = new System.Drawing.Point(12, 12);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(678, 167);
            this.groupbox1.TabIndex = 0;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Enter the name of the project";
            // 
            // SaveProject
            // 
            this.AcceptButton = this.Save_Project;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_ProjectSave;
            this.ClientSize = new System.Drawing.Size(702, 193);
            this.Controls.Add(this.groupbox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveProject";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SaveProject";
            this.TopMost = true;
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox Project_Name;
        private System.Windows.Forms.Button Save_Project;
        private System.Windows.Forms.Button Cancel_ProjectSave;
        private System.Windows.Forms.Label error_Label;
        private System.Windows.Forms.TextBox Project_Location;
        private System.Windows.Forms.Button Browse_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Solution_Name;
        private System.Windows.Forms.CheckBox checkBoxCreateDirectory;
        private System.Windows.Forms.GroupBox groupbox1;
    }
}