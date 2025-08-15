namespace LearningCenter
{
    partial class StudentsForm
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
            stdListBox = new ListBox();
            classSelect = new ComboBox();
            subLst = new ListBox();
            weakLst = new ListBox();
            teachNameLbl = new Label();
            teacherPhoneLbl = new Label();
            instructorNameLbl = new Label();
            instructorPhoneLbl = new Label();
            teachName = new Label();
            teachPhone = new Label();
            instructorName = new Label();
            instructorPhone = new Label();
            studentIdLbl = new Label();
            studentIdCh = new Label();
            TeachCmtBox = new TextBox();
            teachCmntLbl = new Label();
            stdLstLbl = new Label();
            subLstLbl = new Label();
            label1 = new Label();
            visitCntLbl = new Label();
            visitCnt = new Label();
            SuspendLayout();
            // 
            // stdListBox
            // 
            stdListBox.FormattingEnabled = true;
            stdListBox.ItemHeight = 15;
            stdListBox.Location = new Point(652, 56);
            stdListBox.Name = "stdListBox";
            stdListBox.Size = new Size(120, 259);
            stdListBox.TabIndex = 0;
            stdListBox.SelectedIndexChanged += stdListBox_SelectedIndexChanged;
            stdListBox.SelectedValueChanged += stdListBox_SelectedValueChanged;
            // 
            // classSelect
            // 
            classSelect.FormattingEnabled = true;
            classSelect.Items.AddRange(new object[] { "ט", "י", "יא", "יב" });
            classSelect.Location = new Point(630, 6);
            classSelect.Name = "classSelect";
            classSelect.Size = new Size(121, 23);
            classSelect.TabIndex = 1;
            classSelect.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // subLst
            // 
            subLst.FormattingEnabled = true;
            subLst.ItemHeight = 15;
            subLst.Location = new Point(497, 56);
            subLst.Name = "subLst";
            subLst.Size = new Size(120, 259);
            subLst.TabIndex = 2;
            subLst.SelectedValueChanged += subLst_SelectedValueChanged;
            // 
            // weakLst
            // 
            weakLst.FormattingEnabled = true;
            weakLst.ItemHeight = 15;
            weakLst.Location = new Point(340, 56);
            weakLst.Name = "weakLst";
            weakLst.Size = new Size(120, 259);
            weakLst.TabIndex = 3;
            // 
            // teachNameLbl
            // 
            teachNameLbl.AutoSize = true;
            teachNameLbl.Location = new Point(693, 371);
            teachNameLbl.Name = "teachNameLbl";
            teachNameLbl.Size = new Size(53, 15);
            teachNameLbl.TabIndex = 4;
            teachNameLbl.Text = "שם מורה";
            // 
            // teacherPhoneLbl
            // 
            teacherPhoneLbl.AutoSize = true;
            teacherPhoneLbl.Location = new Point(619, 406);
            teacherPhoneLbl.Name = "teacherPhoneLbl";
            teacherPhoneLbl.Size = new Size(36, 15);
            teacherPhoneLbl.TabIndex = 5;
            teacherPhoneLbl.Text = "טלפון";
            // 
            // instructorNameLbl
            // 
            instructorNameLbl.AutoSize = true;
            instructorNameLbl.Location = new Point(515, 371);
            instructorNameLbl.Name = "instructorNameLbl";
            instructorNameLbl.Size = new Size(58, 15);
            instructorNameLbl.TabIndex = 6;
            instructorNameLbl.Text = "שם מדריך";
            // 
            // instructorPhoneLbl
            // 
            instructorPhoneLbl.AutoSize = true;
            instructorPhoneLbl.Location = new Point(483, 406);
            instructorPhoneLbl.Name = "instructorPhoneLbl";
            instructorPhoneLbl.Size = new Size(70, 15);
            instructorPhoneLbl.TabIndex = 7;
            instructorPhoneLbl.Text = "טלפון מדריך";
            // 
            // teachName
            // 
            teachName.AutoSize = true;
            teachName.Location = new Point(631, 371);
            teachName.Name = "teachName";
            teachName.Size = new Size(24, 15);
            teachName.TabIndex = 8;
            teachName.Text = "שם";
            // 
            // teachPhone
            // 
            teachPhone.AutoSize = true;
            teachPhone.Location = new Point(681, 406);
            teachPhone.Name = "teachPhone";
            teachPhone.Size = new Size(65, 15);
            teachPhone.TabIndex = 9;
            teachPhone.Text = "טלפון מורה";
            // 
            // instructorName
            // 
            instructorName.AutoSize = true;
            instructorName.Location = new Point(438, 371);
            instructorName.Name = "instructorName";
            instructorName.Size = new Size(24, 15);
            instructorName.TabIndex = 10;
            instructorName.Text = "שם";
            // 
            // instructorPhone
            // 
            instructorPhone.AutoSize = true;
            instructorPhone.Location = new Point(424, 406);
            instructorPhone.Name = "instructorPhone";
            instructorPhone.Size = new Size(36, 15);
            instructorPhone.TabIndex = 11;
            instructorPhone.Text = "טלפון";
            // 
            // studentIdLbl
            // 
            studentIdLbl.AutoSize = true;
            studentIdLbl.Location = new Point(535, 9);
            studentIdLbl.Name = "studentIdLbl";
            studentIdLbl.Size = new Size(61, 15);
            studentIdLbl.TabIndex = 14;
            studentIdLbl.Text = "ת\"ז תלמיד";
            // 
            // studentIdCh
            // 
            studentIdCh.AutoSize = true;
            studentIdCh.Location = new Point(476, 9);
            studentIdCh.Name = "studentIdCh";
            studentIdCh.Size = new Size(25, 15);
            studentIdCh.TabIndex = 15;
            studentIdCh.Text = "ת\"ז";
            // 
            // TeachCmtBox
            // 
            TeachCmtBox.Location = new Point(12, 56);
            TeachCmtBox.Multiline = true;
            TeachCmtBox.Name = "TeachCmtBox";
            TeachCmtBox.RightToLeft = RightToLeft.Yes;
            TeachCmtBox.Size = new Size(277, 365);
            TeachCmtBox.TabIndex = 16;
            TeachCmtBox.TextAlign = HorizontalAlignment.Right;
            // 
            // teachCmntLbl
            // 
            teachCmntLbl.AutoSize = true;
            teachCmntLbl.Location = new Point(219, 35);
            teachCmntLbl.Name = "teachCmntLbl";
            teachCmntLbl.Size = new Size(70, 15);
            teachCmntLbl.TabIndex = 17;
            teachCmntLbl.Text = "הערות מורה";
            // 
            // stdLstLbl
            // 
            stdLstLbl.AutoSize = true;
            stdLstLbl.Location = new Point(719, 38);
            stdLstLbl.Name = "stdLstLbl";
            stdLstLbl.Size = new Size(51, 15);
            stdLstLbl.TabIndex = 20;
            stdLstLbl.Text = "תלמידים";
            // 
            // subLstLbl
            // 
            subLstLbl.AutoSize = true;
            subLstLbl.Location = new Point(529, 38);
            subLstLbl.Name = "subLstLbl";
            subLstLbl.Size = new Size(88, 15);
            subLstLbl.TabIndex = 21;
            subLstLbl.Text = "מקצועות שלומד";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 38);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 22;
            label1.Text = "מקצועות שחלש בהם";
            // 
            // visitCntLbl
            // 
            visitCntLbl.AutoSize = true;
            visitCntLbl.Location = new Point(308, 334);
            visitCntLbl.Name = "visitCntLbl";
            visitCntLbl.Size = new Size(109, 15);
            visitCntLbl.TabIndex = 23;
            visitCntLbl.Text = "מספר הגעות למרכז";
            // 
            // visitCnt
            // 
            visitCnt.AutoSize = true;
            visitCnt.Location = new Point(357, 359);
            visitCnt.Name = "visitCnt";
            visitCnt.Size = new Size(0, 15);
            visitCnt.TabIndex = 24;
            // 
            // StudentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(visitCnt);
            Controls.Add(visitCntLbl);
            Controls.Add(label1);
            Controls.Add(subLstLbl);
            Controls.Add(stdLstLbl);
            Controls.Add(teachCmntLbl);
            Controls.Add(TeachCmtBox);
            Controls.Add(studentIdCh);
            Controls.Add(studentIdLbl);
            Controls.Add(instructorPhone);
            Controls.Add(instructorName);
            Controls.Add(teachPhone);
            Controls.Add(teachName);
            Controls.Add(instructorPhoneLbl);
            Controls.Add(instructorNameLbl);
            Controls.Add(teacherPhoneLbl);
            Controls.Add(teachNameLbl);
            Controls.Add(weakLst);
            Controls.Add(subLst);
            Controls.Add(classSelect);
            Controls.Add(stdListBox);
            Name = "StudentsForm";
            Text = "StudentsForm";
            Load += StudentsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox stdListBox;
        private ComboBox classSelect;
        private ListBox subLst;
        private ListBox weakLst;
        private Label teachNameLbl;
        private Label teacherPhoneLbl;
        private Label instructorNameLbl;
        private Label instructorPhoneLbl;
        private Label teachName;
        private Label teachPhone;
        private Label instructorName;
        private Label instructorPhone;
        private Label studentIdLbl;
        private Label studentIdCh;
        private TextBox TeachCmtBox;
        private Label teachCmntLbl;
        private Label stdLstLbl;
        private Label subLstLbl;
        private Label label1;
        private Label visitCntLbl;
        private Label visitCnt;
    }
}