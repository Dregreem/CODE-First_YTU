namespace CODEFİRST_YTU.FORMS
{
    partial class Course_interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Course_interface));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_course_class = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_course_student_tc = new System.Windows.Forms.TextBox();
            this.enter_system = new System.Windows.Forms.Button();
            this.List_courses = new System.Windows.Forms.Button();
            this.add_courses = new System.Windows.Forms.Button();
            this.list_my_courses = new System.Windows.Forms.Button();
            this.Listviewcourses = new System.Windows.Forms.ListView();
            this.Class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name_of_the_class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number_of_the_classes_weekly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number_of_application_weekly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number_of_the_lab_weekly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreditScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AktsScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course_Student_Interface";
            // 
            // txt_course_class
            // 
            this.txt_course_class.Location = new System.Drawing.Point(125, 90);
            this.txt_course_class.Name = "txt_course_class";
            this.txt_course_class.Size = new System.Drawing.Size(141, 22);
            this.txt_course_class.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(20, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC";
            // 
            // txt_course_student_tc
            // 
            this.txt_course_student_tc.Location = new System.Drawing.Point(125, 152);
            this.txt_course_student_tc.Name = "txt_course_student_tc";
            this.txt_course_student_tc.Size = new System.Drawing.Size(141, 22);
            this.txt_course_student_tc.TabIndex = 3;
            // 
            // enter_system
            // 
            this.enter_system.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_system.Location = new System.Drawing.Point(26, 199);
            this.enter_system.Name = "enter_system";
            this.enter_system.Size = new System.Drawing.Size(240, 43);
            this.enter_system.TabIndex = 5;
            this.enter_system.Text = "Enter the System";
            this.enter_system.UseVisualStyleBackColor = true;
            this.enter_system.Click += new System.EventHandler(this.enter_system_Click);
            // 
            // List_courses
            // 
            this.List_courses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_courses.Location = new System.Drawing.Point(26, 257);
            this.List_courses.Name = "List_courses";
            this.List_courses.Size = new System.Drawing.Size(240, 43);
            this.List_courses.TabIndex = 6;
            this.List_courses.Text = "List Courses";
            this.List_courses.UseVisualStyleBackColor = true;
            this.List_courses.Click += new System.EventHandler(this.List_courses_Click);
            // 
            // add_courses
            // 
            this.add_courses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_courses.Location = new System.Drawing.Point(26, 317);
            this.add_courses.Name = "add_courses";
            this.add_courses.Size = new System.Drawing.Size(240, 43);
            this.add_courses.TabIndex = 7;
            this.add_courses.Text = "Add Course";
            this.add_courses.UseVisualStyleBackColor = true;
            this.add_courses.UseWaitCursor = true;
            this.add_courses.Click += new System.EventHandler(this.add_courses_Click);
            // 
            // list_my_courses
            // 
            this.list_my_courses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_my_courses.Location = new System.Drawing.Point(26, 376);
            this.list_my_courses.Name = "list_my_courses";
            this.list_my_courses.Size = new System.Drawing.Size(240, 43);
            this.list_my_courses.TabIndex = 8;
            this.list_my_courses.Text = "List My Courses";
            this.list_my_courses.UseVisualStyleBackColor = true;
            this.list_my_courses.UseWaitCursor = true;
            // 
            // Listviewcourses
            // 
            this.Listviewcourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Class,
            this.name_of_the_class,
            this.Type,
            this.Number_of_the_classes_weekly,
            this.Number_of_application_weekly,
            this.Number_of_the_lab_weekly,
            this.CreditScore,
            this.AktsScore,
            this.Code});
            this.Listviewcourses.HideSelection = false;
            this.Listviewcourses.Location = new System.Drawing.Point(323, 120);
            this.Listviewcourses.Name = "Listviewcourses";
            this.Listviewcourses.Size = new System.Drawing.Size(748, 299);
            this.Listviewcourses.TabIndex = 9;
            this.Listviewcourses.UseCompatibleStateImageBehavior = false;
            this.Listviewcourses.View = System.Windows.Forms.View.Details;
            // 
            // Class
            // 
            this.Class.DisplayIndex = 6;
            this.Class.Text = "Class";
            this.Class.Width = 50;
            // 
            // name_of_the_class
            // 
            this.name_of_the_class.Text = "Name of the Class";
            this.name_of_the_class.Width = 129;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 64;
            // 
            // Number_of_the_classes_weekly
            // 
            this.Number_of_the_classes_weekly.Text = "Number_of_the_classes_weekly";
            this.Number_of_the_classes_weekly.Width = 74;
            // 
            // Number_of_application_weekly
            // 
            this.Number_of_application_weekly.Text = "Number_of_the_application_weekly";
            this.Number_of_application_weekly.Width = 80;
            // 
            // Number_of_the_lab_weekly
            // 
            this.Number_of_the_lab_weekly.Text = "Number_of_the_lab_weekly";
            this.Number_of_the_lab_weekly.Width = 88;
            // 
            // CreditScore
            // 
            this.CreditScore.DisplayIndex = 7;
            this.CreditScore.Text = "CreditScore";
            this.CreditScore.Width = 93;
            // 
            // AktsScore
            // 
            this.AktsScore.DisplayIndex = 8;
            this.AktsScore.Text = "AktsScore";
            this.AktsScore.Width = 109;
            // 
            // Code
            // 
            this.Code.DisplayIndex = 0;
            this.Code.Text = "Code";
            this.Code.Width = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Location = new System.Drawing.Point(318, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(587, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Please first enter the system and to choose classes click and add it";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Listviewcourses);
            this.panel1.Controls.Add(this.list_my_courses);
            this.panel1.Controls.Add(this.add_courses);
            this.panel1.Controls.Add(this.List_courses);
            this.panel1.Controls.Add(this.enter_system);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_course_student_tc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_course_class);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(41, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 461);
            this.panel1.TabIndex = 11;
            // 
            // Course_interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1156, 566);
            this.Controls.Add(this.panel1);
            this.Name = "Course_interface";
            this.Text = "Course_interface";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_course_class;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_course_student_tc;
        private System.Windows.Forms.Button enter_system;
        private System.Windows.Forms.Button List_courses;
        private System.Windows.Forms.Button add_courses;
        private System.Windows.Forms.Button list_my_courses;
        private System.Windows.Forms.ListView Listviewcourses;
        private System.Windows.Forms.ColumnHeader Class;
        private System.Windows.Forms.ColumnHeader name_of_the_class;
        private System.Windows.Forms.ColumnHeader Number_of_the_classes_weekly;
        private System.Windows.Forms.ColumnHeader Number_of_application_weekly;
        private System.Windows.Forms.ColumnHeader Number_of_the_lab_weekly;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader CreditScore;
        private System.Windows.Forms.ColumnHeader AktsScore;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}