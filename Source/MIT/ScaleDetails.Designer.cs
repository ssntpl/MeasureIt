namespace mit
{
    partial class ScaleDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScaleDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.unit_combobox = new System.Windows.Forms.ComboBox();
            this.real_length1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Scalevalue_ok = new System.Windows.Forms.Button();
            this.Scalevalue_cancel = new System.Windows.Forms.Button();
            this.pixel_length = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.real_length2 = new System.Windows.Forms.TextBox();
            this.error_Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.real_length2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.unit_combobox);
            this.panel1.Controls.Add(this.real_length1);
            this.panel1.Controls.Add(this.label2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // unit_combobox
            // 
            this.unit_combobox.DisplayMember = "1";
            this.unit_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unit_combobox.FormattingEnabled = true;
            this.unit_combobox.Items.AddRange(new object[] {
            resources.GetString("unit_combobox.Items"),
            resources.GetString("unit_combobox.Items1"),
            resources.GetString("unit_combobox.Items2"),
            resources.GetString("unit_combobox.Items3")});
            resources.ApplyResources(this.unit_combobox, "unit_combobox");
            this.unit_combobox.Name = "unit_combobox";
            this.unit_combobox.Tag = "";
            // 
            // real_length1
            // 
            resources.ApplyResources(this.real_length1, "real_length1");
            this.real_length1.Name = "real_length1";
            this.real_length1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.real_length_KeyDown);
            this.real_length1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.real_length_KeyPress);
            this.real_length1.Enter += new System.EventHandler(this.textBox2_Enter);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Scalevalue_ok
            // 
            resources.ApplyResources(this.Scalevalue_ok, "Scalevalue_ok");
            this.Scalevalue_ok.Name = "Scalevalue_ok";
            this.Scalevalue_ok.UseVisualStyleBackColor = true;
            this.Scalevalue_ok.Click += new System.EventHandler(this.Scalevalue_ok_Click);
            // 
            // Scalevalue_cancel
            // 
            resources.ApplyResources(this.Scalevalue_cancel, "Scalevalue_cancel");
            this.Scalevalue_cancel.Name = "Scalevalue_cancel";
            this.Scalevalue_cancel.UseVisualStyleBackColor = true;
            this.Scalevalue_cancel.Click += new System.EventHandler(this.Scalevalue_cancel_Click);
            // 
            // pixel_length
            // 
            resources.ApplyResources(this.pixel_length, "pixel_length");
            this.pixel_length.Name = "pixel_length";
            this.pixel_length.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // real_length2
            // 
            resources.ApplyResources(this.real_length2, "real_length2");
            this.real_length2.Name = "real_length2";
            this.real_length2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.real_length_KeyDown);
            this.real_length2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.real_length_KeyPress);
            this.real_length2.Enter += new System.EventHandler(this.textBox2_Enter);
            // 
            // error_Label
            // 
            resources.ApplyResources(this.error_Label, "error_Label");
            this.error_Label.ForeColor = System.Drawing.Color.Red;
            this.error_Label.Name = "error_Label";
            // 
            // ScaleDetails
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.error_Label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pixel_length);
            this.Controls.Add(this.Scalevalue_cancel);
            this.Controls.Add(this.Scalevalue_ok);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScaleDetails";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Scalevalue_ok;
        private System.Windows.Forms.Button Scalevalue_cancel;
        private System.Windows.Forms.TextBox pixel_length;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox unit_combobox;
        private System.Windows.Forms.TextBox real_length1;
        private System.Windows.Forms.Label label3;

        #region//form level boolean

        private bool nonNumPressed = false;
        #endregion
        private System.Windows.Forms.TextBox real_length2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label error_Label;
    }
   
}