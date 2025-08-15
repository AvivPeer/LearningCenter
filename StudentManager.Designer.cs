namespace LearningCenter
{
    partial class StudentManager
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
            newStdButton = new Button();
            Save = new Button();
            stdIdTBox = new TextBox();
            idStdLbl = new Label();
            findStdBtn = new Button();
            nameLbl = new Label();
            nameTbox = new TextBox();
            stdPhoneLbl = new Label();
            phoneTBox = new TextBox();
            classLbl = new Label();
            clastTbox = new TextBox();
            classInfo = new Label();
            subLst = new ListBox();
            curSubLst = new ListBox();
            teachLst = new ListBox();
            curTeachLst = new ListBox();
            beforeLbl = new Label();
            afterLbl = new Label();
            addSubBtn = new Button();
            changeTeachBtn = new Button();
            removeSubBtn = new Button();
            statusSelection = new ListBox();
            visitLbl = new Label();
            visitCount = new TextBox();
            SuspendLayout();
            // 
            // newStdButton
            // 
            newStdButton.Location = new Point(20, 14);
            newStdButton.Name = "newStdButton";
            newStdButton.Size = new Size(104, 48);
            newStdButton.TabIndex = 0;
            newStdButton.Text = "צור תלמיד חדש";
            newStdButton.UseVisualStyleBackColor = true;
            newStdButton.Click += newStdButton_Click;
            // 
            // Save
            // 
            Save.Location = new Point(130, 14);
            Save.Name = "Save";
            Save.Size = new Size(79, 48);
            Save.TabIndex = 46;
            Save.Text = "שמור";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // stdIdTBox
            // 
            stdIdTBox.Location = new Point(602, 25);
            stdIdTBox.Name = "stdIdTBox";
            stdIdTBox.Size = new Size(100, 23);
            stdIdTBox.TabIndex = 47;
            // 
            // idStdLbl
            // 
            idStdLbl.AutoSize = true;
            idStdLbl.Location = new Point(718, 28);
            idStdLbl.Name = "idStdLbl";
            idStdLbl.Size = new Size(68, 15);
            idStdLbl.TabIndex = 48;
            idStdLbl.Text = "תעודת זהות";
            // 
            // findStdBtn
            // 
            findStdBtn.Location = new Point(517, 14);
            findStdBtn.Name = "findStdBtn";
            findStdBtn.Size = new Size(79, 48);
            findStdBtn.TabIndex = 49;
            findStdBtn.Text = "חפש תלמיד";
            findStdBtn.UseVisualStyleBackColor = true;
            findStdBtn.Click += findStdBtn_Click;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(718, 144);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(60, 15);
            nameLbl.TabIndex = 51;
            nameLbl.Text = "שם תלמיד";
            // 
            // nameTbox
            // 
            nameTbox.Location = new Point(602, 141);
            nameTbox.Name = "nameTbox";
            nameTbox.Size = new Size(100, 23);
            nameTbox.TabIndex = 50;
            // 
            // stdPhoneLbl
            // 
            stdPhoneLbl.AutoSize = true;
            stdPhoneLbl.Location = new Point(718, 173);
            stdPhoneLbl.Name = "stdPhoneLbl";
            stdPhoneLbl.Size = new Size(70, 15);
            stdPhoneLbl.TabIndex = 53;
            stdPhoneLbl.Text = "מספר טלפון";
            // 
            // phoneTBox
            // 
            phoneTBox.Location = new Point(602, 170);
            phoneTBox.Name = "phoneTBox";
            phoneTBox.Size = new Size(100, 23);
            phoneTBox.TabIndex = 52;
            // 
            // classLbl
            // 
            classLbl.AutoSize = true;
            classLbl.Location = new Point(718, 202);
            classLbl.Name = "classLbl";
            classLbl.Size = new Size(34, 15);
            classLbl.TabIndex = 55;
            classLbl.Text = "כיתה";
            // 
            // clastTbox
            // 
            clastTbox.Location = new Point(602, 199);
            clastTbox.Name = "clastTbox";
            clastTbox.Size = new Size(100, 23);
            clastTbox.TabIndex = 54;
            // 
            // classInfo
            // 
            classInfo.AutoSize = true;
            classInfo.Location = new Point(602, 249);
            classInfo.Name = "classInfo";
            classInfo.RightToLeft = RightToLeft.Yes;
            classInfo.Size = new Size(189, 15);
            classInfo.TabIndex = 58;
            classInfo.Text = "(10 - כיתה ט' , 11 כיתה י' וכן הלאה)";
            // 
            // subLst
            // 
            subLst.FormattingEnabled = true;
            subLst.ItemHeight = 15;
            subLst.Location = new Point(149, 144);
            subLst.Name = "subLst";
            subLst.Size = new Size(120, 94);
            subLst.TabIndex = 59;
            subLst.SelectedIndexChanged += subLst_SelectedIndexChanged;
            // 
            // curSubLst
            // 
            curSubLst.FormattingEnabled = true;
            curSubLst.ItemHeight = 15;
            curSubLst.Location = new Point(324, 144);
            curSubLst.Name = "curSubLst";
            curSubLst.Size = new Size(120, 94);
            curSubLst.TabIndex = 60;
            // 
            // teachLst
            // 
            teachLst.FormattingEnabled = true;
            teachLst.ItemHeight = 15;
            teachLst.Location = new Point(12, 144);
            teachLst.Name = "teachLst";
            teachLst.Size = new Size(120, 94);
            teachLst.TabIndex = 61;
            // 
            // curTeachLst
            // 
            curTeachLst.FormattingEnabled = true;
            curTeachLst.ItemHeight = 15;
            curTeachLst.Location = new Point(450, 144);
            curTeachLst.Name = "curTeachLst";
            curTeachLst.Size = new Size(120, 94);
            curTeachLst.TabIndex = 62;
            // 
            // beforeLbl
            // 
            beforeLbl.AutoSize = true;
            beforeLbl.Location = new Point(416, 100);
            beforeLbl.Name = "beforeLbl";
            beforeLbl.Size = new Size(58, 15);
            beforeLbl.TabIndex = 63;
            beforeLbl.Text = "מצב נוכחי";
            // 
            // afterLbl
            // 
            afterLbl.AutoSize = true;
            afterLbl.Location = new Point(32, 100);
            afterLbl.Name = "afterLbl";
            afterLbl.Size = new Size(177, 15);
            afterLbl.TabIndex = 64;
            afterLbl.Text = "החלפת מורה או הוספת מקצועות";
            // 
            // addSubBtn
            // 
            addSubBtn.Location = new Point(164, 344);
            addSubBtn.Name = "addSubBtn";
            addSubBtn.Size = new Size(79, 48);
            addSubBtn.TabIndex = 65;
            addSubBtn.Text = "הוסף מקצוע";
            addSubBtn.UseVisualStyleBackColor = true;
            addSubBtn.Click += addSubBtn_Click;
            // 
            // changeTeachBtn
            // 
            changeTeachBtn.Location = new Point(32, 244);
            changeTeachBtn.Name = "changeTeachBtn";
            changeTeachBtn.Size = new Size(79, 48);
            changeTeachBtn.TabIndex = 66;
            changeTeachBtn.Text = "החלף מורה";
            changeTeachBtn.UseVisualStyleBackColor = true;
            changeTeachBtn.Click += changeTeachBtn_Click;
            // 
            // removeSubBtn
            // 
            removeSubBtn.Location = new Point(344, 244);
            removeSubBtn.Name = "removeSubBtn";
            removeSubBtn.Size = new Size(79, 48);
            removeSubBtn.TabIndex = 67;
            removeSubBtn.Text = "הסר מקצוע";
            removeSubBtn.UseVisualStyleBackColor = true;
            removeSubBtn.Click += removeSubBtn_Click;
            // 
            // statusSelection
            // 
            statusSelection.FormattingEnabled = true;
            statusSelection.ItemHeight = 15;
            statusSelection.Items.AddRange(new object[] { "POOR", "GOOD", "GREAT", "EXCELLENT" });
            statusSelection.Location = new Point(149, 249);
            statusSelection.Name = "statusSelection";
            statusSelection.Size = new Size(120, 94);
            statusSelection.TabIndex = 69;
            // 
            // visitLbl
            // 
            visitLbl.AutoSize = true;
            visitLbl.Location = new Point(717, 328);
            visitLbl.Name = "visitLbl";
            visitLbl.Size = new Size(69, 15);
            visitLbl.TabIndex = 70;
            visitLbl.Text = "כמות הגעות";
            // 
            // visitCount
            // 
            visitCount.Location = new Point(611, 325);
            visitCount.Name = "visitCount";
            visitCount.Size = new Size(100, 23);
            visitCount.TabIndex = 71;
            // 
            // StudentManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(visitCount);
            Controls.Add(visitLbl);
            Controls.Add(statusSelection);
            Controls.Add(removeSubBtn);
            Controls.Add(changeTeachBtn);
            Controls.Add(addSubBtn);
            Controls.Add(afterLbl);
            Controls.Add(beforeLbl);
            Controls.Add(curTeachLst);
            Controls.Add(teachLst);
            Controls.Add(curSubLst);
            Controls.Add(subLst);
            Controls.Add(classInfo);
            Controls.Add(classLbl);
            Controls.Add(clastTbox);
            Controls.Add(stdPhoneLbl);
            Controls.Add(phoneTBox);
            Controls.Add(nameLbl);
            Controls.Add(nameTbox);
            Controls.Add(findStdBtn);
            Controls.Add(idStdLbl);
            Controls.Add(stdIdTBox);
            Controls.Add(Save);
            Controls.Add(newStdButton);
            Name = "StudentManager";
            Text = "StudentManager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button newStdButton;
        private Button Save;
        private TextBox stdIdTBox;
        private Label idStdLbl;
        private Button findStdBtn;
        private Label nameLbl;
        private TextBox nameTbox;
        private Label stdPhoneLbl;
        private TextBox phoneTBox;
        private Label classLbl;
        private TextBox clastTbox;
        private Label classInfo;
        private ListBox subLst;
        private ListBox curSubLst;
        private ListBox teachLst;
        private ListBox curTeachLst;
        private Label beforeLbl;
        private Label afterLbl;
        private Button addSubBtn;
        private Button changeTeachBtn;
        private Button removeSubBtn;
        private ListBox statusSelection;
        private Label visitLbl;
        private TextBox visitCount;
    }
}