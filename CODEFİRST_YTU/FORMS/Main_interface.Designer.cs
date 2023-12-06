namespace CODEFİRST_YTU.FORMS
{
    partial class Main_interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_interface));
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.Label1 = new System.Windows.Forms.Label();
            this.Student_Entry = new System.Windows.Forms.Button();
            this.Academic_Entry = new System.Windows.Forms.Button();
            this.Student_register = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label1.Location = new System.Drawing.Point(13, 6);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(346, 106);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "YTU_Interface";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label1.UseWaitCursor = true;
            // 
            // Student_Entry
            // 
            this.Student_Entry.Location = new System.Drawing.Point(59, 100);
            this.Student_Entry.Name = "Student_Entry";
            this.Student_Entry.Size = new System.Drawing.Size(259, 44);
            this.Student_Entry.TabIndex = 1;
            this.Student_Entry.Text = "Student_Entry";
            this.Student_Entry.UseMnemonic = false;
            this.Student_Entry.UseVisualStyleBackColor = true;
            this.Student_Entry.UseWaitCursor = true;
            this.Student_Entry.Click += new System.EventHandler(this.Student_Entry_Click);
            // 
            // Academic_Entry
            // 
            this.Academic_Entry.Location = new System.Drawing.Point(59, 167);
            this.Academic_Entry.Name = "Academic_Entry";
            this.Academic_Entry.Size = new System.Drawing.Size(259, 44);
            this.Academic_Entry.TabIndex = 2;
            this.Academic_Entry.Text = "Academic_Entry";
            this.Academic_Entry.UseVisualStyleBackColor = true;
            this.Academic_Entry.UseWaitCursor = true;
            this.Academic_Entry.Click += new System.EventHandler(this.Academic_Entry_Click);
            // 
            // Student_register
            // 
            this.Student_register.AutoSize = true;
            this.Student_register.BackColor = System.Drawing.Color.White;
            this.Student_register.Location = new System.Drawing.Point(56, 227);
            this.Student_register.Name = "Student_register";
            this.Student_register.Size = new System.Drawing.Size(104, 16);
            this.Student_register.TabIndex = 3;
            this.Student_register.TabStop = true;
            this.Student_register.Text = "Student_register";
            this.Student_register.UseWaitCursor = true;
            this.Student_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Student_register_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(198, 227);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(120, 16);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Academic_register";
            this.linkLabel2.UseWaitCursor = true;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.Student_register);
            this.groupBox1.Controls.Add(this.Academic_Entry);
            this.groupBox1.Controls.Add(this.Student_Entry);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox1.Location = new System.Drawing.Point(377, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(402, 351);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseWaitCursor = true;
            // 
            // Main_interface
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1190, 562);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main_interface";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Student_Entry;
        private System.Windows.Forms.Button Academic_Entry;
        private System.Windows.Forms.LinkLabel Student_register;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}