namespace LearningCenter
{
    partial class TeacherManager
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
            afterLbl = new Label();
            beforeLbl = new Label();
            curStds = new ListBox();
            allStds = new ListBox();
            salaryTbox = new TextBox();
            stdPhoneLbl = new Label();
            phoneTBox = new TextBox();
            nameLbl = new Label();
            nameTbox = new TextBox();
            teachPhTBox = new TextBox();
            Save = new Button();
            newTeachButton = new Button();
            stdCmnt = new ListBox();
            newCmntBtn = new Button();
            removeCmtBtn = new Button();
            selStdLbl = new Label();
            removeStd = new Button();
            findTeacher = new Button();
            phoneLbl = new Label();
            salaryLbl = new Label();
            salaryInfo = new Label();
            addStd = new Button();
            newCmnt = new TextBox();
            SuspendLayout();
            // 
            // afterLbl
            // 
            afterLbl.AutoSize = true;
            afterLbl.Location = new Point(31, 122);
            afterLbl.Name = "afterLbl";
            afterLbl.Size = new Size(177, 15);
            afterLbl.TabIndex = 87;
            afterLbl.Text = "החלפת מורה או הוספת מקצועות";
            // 
            // beforeLbl
            // 
            beforeLbl.AutoSize = true;
            beforeLbl.Location = new Point(400, 122);
            beforeLbl.Name = "beforeLbl";
            beforeLbl.Size = new Size(58, 15);
            beforeLbl.TabIndex = 86;
            beforeLbl.Text = "מצב נוכחי";
            // 
            // curStds
            // 
            curStds.FormattingEnabled = true;
            curStds.ItemHeight = 15;
            curStds.Location = new Point(441, 163);
            curStds.Name = "curStds";
            curStds.Size = new Size(120, 94);
            curStds.TabIndex = 83;
            curStds.SelectedValueChanged += curStds_SelectedValueChanged;
            // 
            // allStds
            // 
            allStds.FormattingEnabled = true;
            allStds.ItemHeight = 15;
            allStds.Location = new Point(148, 166);
            allStds.Name = "allStds";
            allStds.Size = new Size(120, 94);
            allStds.TabIndex = 82;
            // 
            // salaryTbox
            // 
            salaryTbox.Location = new Point(601, 221);
            salaryTbox.Name = "salaryTbox";
            salaryTbox.Size = new Size(100, 23);
            salaryTbox.TabIndex = 79;
            // 
            // stdPhoneLbl
            // 
            stdPhoneLbl.AutoSize = true;
            stdPhoneLbl.Location = new Point(717, 195);
            stdPhoneLbl.Name = "stdPhoneLbl";
            stdPhoneLbl.Size = new Size(70, 15);
            stdPhoneLbl.TabIndex = 78;
            stdPhoneLbl.Text = "מספר טלפון";
            // 
            // phoneTBox
            // 
            phoneTBox.Location = new Point(601, 192);
            phoneTBox.Name = "phoneTBox";
            phoneTBox.Size = new Size(100, 23);
            phoneTBox.TabIndex = 77;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(717, 166);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(24, 15);
            nameLbl.TabIndex = 76;
            nameLbl.Text = "שם";
            // 
            // nameTbox
            // 
            nameTbox.Location = new Point(601, 163);
            nameTbox.Name = "nameTbox";
            nameTbox.Size = new Size(100, 23);
            nameTbox.TabIndex = 75;
            // 
            // teachPhTBox
            // 
            teachPhTBox.Location = new Point(601, 47);
            teachPhTBox.Name = "teachPhTBox";
            teachPhTBox.Size = new Size(100, 23);
            teachPhTBox.TabIndex = 72;
            // 
            // Save
            // 
            Save.Location = new Point(129, 36);
            Save.Name = "Save";
            Save.Size = new Size(79, 48);
            Save.TabIndex = 71;
            Save.Text = "שמור";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // newTeachButton
            // 
            newTeachButton.Location = new Point(19, 36);
            newTeachButton.Name = "newTeachButton";
            newTeachButton.Size = new Size(104, 48);
            newTeachButton.TabIndex = 70;
            newTeachButton.Text = "צור מורה חדש";
            newTeachButton.UseVisualStyleBackColor = true;
            newTeachButton.Click += newTeachButton_Click;
            // 
            // stdCmnt
            // 
            stdCmnt.FormattingEnabled = true;
            stdCmnt.ItemHeight = 15;
            stdCmnt.Location = new Point(315, 163);
            stdCmnt.Name = "stdCmnt";
            stdCmnt.Size = new Size(120, 94);
            stdCmnt.TabIndex = 91;
            // 
            // newCmntBtn
            // 
            newCmntBtn.Location = new Point(44, 266);
            newCmntBtn.Name = "newCmntBtn";
            newCmntBtn.Size = new Size(79, 48);
            newCmntBtn.TabIndex = 93;
            newCmntBtn.Text = "הוסף הערה לתלמיד";
            newCmntBtn.UseVisualStyleBackColor = true;
            newCmntBtn.Click += newCmntBtn_Click;
            // 
            // removeCmtBtn
            // 
            removeCmtBtn.Location = new Point(340, 263);
            removeCmtBtn.Name = "removeCmtBtn";
            removeCmtBtn.Size = new Size(79, 48);
            removeCmtBtn.TabIndex = 94;
            removeCmtBtn.Text = "הסר הערה";
            removeCmtBtn.UseVisualStyleBackColor = true;
            removeCmtBtn.Click += removeCmtBtn_Click;
            // 
            // selStdLbl
            // 
            selStdLbl.AutoSize = true;
            selStdLbl.Location = new Point(461, 145);
            selStdLbl.Name = "selStdLbl";
            selStdLbl.Size = new Size(77, 15);
            selStdLbl.TabIndex = 95;
            selStdLbl.Text = "בחירת תלמיד";
            // 
            // removeStd
            // 
            removeStd.Location = new Point(459, 263);
            removeStd.Name = "removeStd";
            removeStd.Size = new Size(79, 48);
            removeStd.TabIndex = 97;
            removeStd.Text = "הסר תלמיד";
            removeStd.UseVisualStyleBackColor = true;
            removeStd.Click += removeStd_Click;
            // 
            // findTeacher
            // 
            findTeacher.Location = new Point(504, 33);
            findTeacher.Name = "findTeacher";
            findTeacher.Size = new Size(79, 48);
            findTeacher.TabIndex = 98;
            findTeacher.Text = "חפש מורה";
            findTeacher.UseVisualStyleBackColor = true;
            findTeacher.Click += findTeachBtn_Click;
            // 
            // phoneLbl
            // 
            phoneLbl.AutoSize = true;
            phoneLbl.Location = new Point(707, 50);
            phoneLbl.Name = "phoneLbl";
            phoneLbl.Size = new Size(70, 15);
            phoneLbl.TabIndex = 99;
            phoneLbl.Text = "מספר טלפון";
            // 
            // salaryLbl
            // 
            salaryLbl.AutoSize = true;
            salaryLbl.Location = new Point(717, 229);
            salaryLbl.Name = "salaryLbl";
            salaryLbl.Size = new Size(30, 15);
            salaryLbl.TabIndex = 100;
            salaryLbl.Text = "שכר";
            // 
            // salaryInfo
            // 
            salaryInfo.AutoSize = true;
            salaryInfo.Location = new Point(605, 263);
            salaryInfo.Name = "salaryInfo";
            salaryInfo.Size = new Size(96, 15);
            salaryInfo.TabIndex = 101;
            salaryInfo.Text = "שכר לשעה בש\"ח";
            // 
            // addStd
            // 
            addStd.Location = new Point(159, 266);
            addStd.Name = "addStd";
            addStd.Size = new Size(79, 48);
            addStd.TabIndex = 102;
            addStd.Text = "הוסף תלמיד";
            addStd.UseVisualStyleBackColor = true;
            addStd.Click += addStd_Click;
            // 
            // newCmnt
            // 
            newCmnt.Location = new Point(31, 166);
            newCmnt.Name = "newCmnt";
            newCmnt.Size = new Size(100, 23);
            newCmnt.TabIndex = 103;
            // 
            // TeacherManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(newCmnt);
            Controls.Add(addStd);
            Controls.Add(salaryInfo);
            Controls.Add(salaryLbl);
            Controls.Add(phoneLbl);
            Controls.Add(findTeacher);
            Controls.Add(removeStd);
            Controls.Add(selStdLbl);
            Controls.Add(removeCmtBtn);
            Controls.Add(newCmntBtn);
            Controls.Add(stdCmnt);
            Controls.Add(afterLbl);
            Controls.Add(beforeLbl);
            Controls.Add(curStds);
            Controls.Add(allStds);
            Controls.Add(salaryTbox);
            Controls.Add(stdPhoneLbl);
            Controls.Add(phoneTBox);
            Controls.Add(nameLbl);
            Controls.Add(nameTbox);
            Controls.Add(teachPhTBox);
            Controls.Add(Save);
            Controls.Add(newTeachButton);
            Name = "TeacherManager";
            Text = "TeacherManager";
            Load += TeacherManager_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox statusSelection;
        private Button removeSubBtn;
        private Button changeTeachBtn;
        private Button addSubBtn;
        private Label afterLbl;
        private Label beforeLbl;
        private ListBox teachLst;
        private ListBox curStds;
        private ListBox allStds;
        private Label classInfo;
        private Label classLbl;
        private TextBox salaryTbox;
        private Label stdPhoneLbl;
        private TextBox phoneTBox;
        private Label nameLbl;
        private TextBox nameTbox;
        private Button findStdBtn;
        private Label idStdLbl;
        private TextBox teachPhTBox;
        private Button Save;
        private Button newTeachButton;
        private ListBox stdCmnt;
        private Button newCmntBtn;
        private Button removeCmtBtn;
        private Label selStdLbl;
        private Button removeStd;
        private Button findTeacher;
        private Label phoneLbl;
        private Label salaryLbl;
        private Label salaryInfo;
        private Button addStd;
        private TextBox newCmnt;
    }
}