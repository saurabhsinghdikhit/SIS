
namespace StudentInformationSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.cmbAge = new System.Windows.Forms.ComboBox();
            this.rdGenderMale = new System.Windows.Forms.RadioButton();
            this.rdGenderFemale = new System.Windows.Forms.RadioButton();
            this.cmbDegree = new System.Windows.Forms.ComboBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.lblTotalMarks = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.btnCheckGrade = new System.Windows.Forms.Button();
            this.lblScoredGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblSubjects = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(327, 59);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(120, 23);
            this.txtStudentId.TabIndex = 0;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(327, 91);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(120, 23);
            this.txtStudentName.TabIndex = 1;
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Location = new System.Drawing.Point(327, 203);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.Size = new System.Drawing.Size(121, 23);
            this.txtTotalMarks.TabIndex = 2;
            this.txtTotalMarks.TextChanged += new System.EventHandler(this.txtTotalMarks_TextChanged);
            this.txtTotalMarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalMarks_KeyPress);
            // 
            // cmbAge
            // 
            this.cmbAge.FormattingEnabled = true;
            this.cmbAge.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbAge.Location = new System.Drawing.Point(327, 120);
            this.cmbAge.Name = "cmbAge";
            this.cmbAge.Size = new System.Drawing.Size(121, 23);
            this.cmbAge.TabIndex = 3;
            // 
            // rdGenderMale
            // 
            this.rdGenderMale.AutoSize = true;
            this.rdGenderMale.Location = new System.Drawing.Point(327, 149);
            this.rdGenderMale.Name = "rdGenderMale";
            this.rdGenderMale.Size = new System.Drawing.Size(51, 19);
            this.rdGenderMale.TabIndex = 4;
            this.rdGenderMale.TabStop = true;
            this.rdGenderMale.Text = "Male";
            this.rdGenderMale.UseVisualStyleBackColor = true;
            // 
            // rdGenderFemale
            // 
            this.rdGenderFemale.AutoSize = true;
            this.rdGenderFemale.Location = new System.Drawing.Point(384, 149);
            this.rdGenderFemale.Name = "rdGenderFemale";
            this.rdGenderFemale.Size = new System.Drawing.Size(63, 19);
            this.rdGenderFemale.TabIndex = 5;
            this.rdGenderFemale.TabStop = true;
            this.rdGenderFemale.Text = "Female";
            this.rdGenderFemale.UseVisualStyleBackColor = true;
            // 
            // cmbDegree
            // 
            this.cmbDegree.FormattingEnabled = true;
            this.cmbDegree.Items.AddRange(new object[] {
            "BCA",
            "MCA",
            "BBA",
            "MBA",
            "BSC",
            "MSC",
            "BCOM",
            "MCOM"});
            this.cmbDegree.Location = new System.Drawing.Point(327, 174);
            this.cmbDegree.Name = "cmbDegree";
            this.cmbDegree.Size = new System.Drawing.Size(121, 23);
            this.cmbDegree.TabIndex = 7;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(327, 235);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(121, 23);
            this.txtAverage.TabIndex = 8;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(221, 59);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(61, 15);
            this.lblStudentId.TabIndex = 9;
            this.lblStudentId.Text = "Student Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(221, 91);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(221, 120);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(28, 15);
            this.lblAge.TabIndex = 11;
            this.lblAge.Text = "Age";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(221, 153);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 15);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Location = new System.Drawing.Point(221, 177);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(44, 15);
            this.lblDegree.TabIndex = 13;
            this.lblDegree.Text = "Degree";
            // 
            // lblTotalMarks
            // 
            this.lblTotalMarks.AutoSize = true;
            this.lblTotalMarks.Location = new System.Drawing.Point(215, 206);
            this.lblTotalMarks.Name = "lblTotalMarks";
            this.lblTotalMarks.Size = new System.Drawing.Size(106, 15);
            this.lblTotalMarks.TabIndex = 14;
            this.lblTotalMarks.Text = "Total Marks Scored";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(221, 238);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(50, 15);
            this.lblAverage.TabIndex = 15;
            this.lblAverage.Text = "Average";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(221, 301);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(65, 15);
            this.lblGrade.TabIndex = 16;
            this.lblGrade.Text = "Your Grade";
            // 
            // btnCheckGrade
            // 
            this.btnCheckGrade.Location = new System.Drawing.Point(328, 264);
            this.btnCheckGrade.Name = "btnCheckGrade";
            this.btnCheckGrade.Size = new System.Drawing.Size(120, 23);
            this.btnCheckGrade.TabIndex = 17;
            this.btnCheckGrade.Text = "Check Grade";
            this.btnCheckGrade.UseVisualStyleBackColor = true;
            this.btnCheckGrade.Click += new System.EventHandler(this.btnCheckGrade_Click);
            // 
            // lblScoredGrade
            // 
            this.lblScoredGrade.AutoSize = true;
            this.lblScoredGrade.Location = new System.Drawing.Point(327, 327);
            this.lblScoredGrade.Name = "lblScoredGrade";
            this.lblScoredGrade.Size = new System.Drawing.Size(0, 15);
            this.lblScoredGrade.TabIndex = 18;
            // 
            // txtGrade
            // 
            this.txtGrade.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGrade.Location = new System.Drawing.Point(328, 293);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.Size = new System.Drawing.Size(121, 27);
            this.txtGrade.TabIndex = 21;
            // 
            // lblSubjects
            // 
            this.lblSubjects.AutoSize = true;
            this.lblSubjects.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubjects.ForeColor = System.Drawing.Color.Red;
            this.lblSubjects.Location = new System.Drawing.Point(464, 206);
            this.lblSubjects.Name = "lblSubjects";
            this.lblSubjects.Size = new System.Drawing.Size(115, 15);
            this.lblSubjects.TabIndex = 22;
            this.lblSubjects.Text = "Total Subjects are 5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Student Information System";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSubjects);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblScoredGrade);
            this.Controls.Add(this.btnCheckGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblTotalMarks);
            this.Controls.Add(this.lblDegree);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.cmbDegree);
            this.Controls.Add(this.rdGenderFemale);
            this.Controls.Add(this.rdGenderMale);
            this.Controls.Add(this.cmbAge);
            this.Controls.Add(this.txtTotalMarks);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.ComboBox cmbAge;
        private System.Windows.Forms.RadioButton rdGenderMale;
        private System.Windows.Forms.RadioButton rdGenderFemale;
        private System.Windows.Forms.ComboBox cmbDegree;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label lblTotalMarks;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button btnCheckGrade;
        private System.Windows.Forms.Label lblScoredGrade;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblSubjects;
        private System.Windows.Forms.Label label1;
    }
}

