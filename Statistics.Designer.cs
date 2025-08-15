namespace LearningCenter
{
    partial class Statistics
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
            ninLst = new ListBox();
            tenLst = new ListBox();
            elevLst = new ListBox();
            twelLst = new ListBox();
            subTBox = new ListBox();
            subLbl = new Label();
            ninLbl = new Label();
            tenLbl = new Label();
            elevLbl = new Label();
            twelLbl = new Label();
            freqStdLbl = new Label();
            freqVisitCount = new Label();
            visitNamesLst = new ListBox();
            countLbl = new Label();
            SuspendLayout();
            // 
            // ninLst
            // 
            ninLst.FormattingEnabled = true;
            ninLst.ItemHeight = 15;
            ninLst.Location = new Point(600, 194);
            ninLst.Name = "ninLst";
            ninLst.Size = new Size(120, 244);
            ninLst.TabIndex = 0;
            // 
            // tenLst
            // 
            tenLst.FormattingEnabled = true;
            tenLst.ItemHeight = 15;
            tenLst.Location = new Point(432, 194);
            tenLst.Name = "tenLst";
            tenLst.Size = new Size(120, 244);
            tenLst.TabIndex = 1;
            // 
            // elevLst
            // 
            elevLst.FormattingEnabled = true;
            elevLst.ItemHeight = 15;
            elevLst.Location = new Point(247, 194);
            elevLst.Name = "elevLst";
            elevLst.Size = new Size(120, 244);
            elevLst.TabIndex = 2;
            // 
            // twelLst
            // 
            twelLst.FormattingEnabled = true;
            twelLst.ItemHeight = 15;
            twelLst.Location = new Point(75, 194);
            twelLst.Name = "twelLst";
            twelLst.Size = new Size(120, 244);
            twelLst.TabIndex = 3;
            // 
            // subTBox
            // 
            subTBox.FormattingEnabled = true;
            subTBox.ItemHeight = 15;
            subTBox.Location = new Point(614, 12);
            subTBox.Name = "subTBox";
            subTBox.RightToLeft = RightToLeft.Yes;
            subTBox.Size = new Size(128, 139);
            subTBox.TabIndex = 6;
            subTBox.SelectedValueChanged += classLst_SelectedValueChanged;
            // 
            // subLbl
            // 
            subLbl.AutoSize = true;
            subLbl.Location = new Point(748, 21);
            subLbl.Name = "subLbl";
            subLbl.Size = new Size(40, 15);
            subLbl.TabIndex = 7;
            subLbl.Text = "מקצוע";
            // 
            // ninLbl
            // 
            ninLbl.AutoSize = true;
            ninLbl.Location = new Point(680, 176);
            ninLbl.Name = "ninLbl";
            ninLbl.Size = new Size(15, 15);
            ninLbl.TabIndex = 8;
            ninLbl.Text = "ט";
            // 
            // tenLbl
            // 
            tenLbl.AutoSize = true;
            tenLbl.Location = new Point(512, 176);
            tenLbl.Name = "tenLbl";
            tenLbl.Size = new Size(10, 15);
            tenLbl.TabIndex = 9;
            tenLbl.Text = "י";
            // 
            // elevLbl
            // 
            elevLbl.AutoSize = true;
            elevLbl.Location = new Point(338, 176);
            elevLbl.Name = "elevLbl";
            elevLbl.Size = new Size(18, 15);
            elevLbl.TabIndex = 10;
            elevLbl.Text = "יא";
            // 
            // twelLbl
            // 
            twelLbl.AutoSize = true;
            twelLbl.Location = new Point(155, 176);
            twelLbl.Name = "twelLbl";
            twelLbl.Size = new Size(17, 15);
            twelLbl.TabIndex = 11;
            twelLbl.Text = "יב";
            // 
            // freqStdLbl
            // 
            freqStdLbl.AutoSize = true;
            freqStdLbl.Location = new Point(139, 9);
            freqStdLbl.Name = "freqStdLbl";
            freqStdLbl.Size = new Size(83, 15);
            freqStdLbl.TabIndex = 12;
            freqStdLbl.Text = "המגיע המתמיד";
            // 
            // freqVisitCount
            // 
            freqVisitCount.AutoSize = true;
            freqVisitCount.Location = new Point(22, 80);
            freqVisitCount.Name = "freqVisitCount";
            freqVisitCount.Size = new Size(34, 15);
            freqVisitCount.TabIndex = 14;
            freqVisitCount.Text = "כמות";
            // 
            // visitNamesLst
            // 
            visitNamesLst.FormattingEnabled = true;
            visitNamesLst.ItemHeight = 15;
            visitNamesLst.Location = new Point(62, 27);
            visitNamesLst.Name = "visitNamesLst";
            visitNamesLst.Size = new Size(259, 124);
            visitNamesLst.TabIndex = 15;
            // 
            // countLbl
            // 
            countLbl.AutoSize = true;
            countLbl.Location = new Point(22, 65);
            countLbl.Name = "countLbl";
            countLbl.Size = new Size(34, 15);
            countLbl.TabIndex = 16;
            countLbl.Text = "כמות";
            // 
            // Statistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(countLbl);
            Controls.Add(visitNamesLst);
            Controls.Add(freqVisitCount);
            Controls.Add(freqStdLbl);
            Controls.Add(twelLbl);
            Controls.Add(elevLbl);
            Controls.Add(tenLbl);
            Controls.Add(ninLbl);
            Controls.Add(subLbl);
            Controls.Add(subTBox);
            Controls.Add(twelLst);
            Controls.Add(elevLst);
            Controls.Add(tenLst);
            Controls.Add(ninLst);
            Name = "Statistics";
            Text = "Statistics";
            Load += Statistics_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ninLst;
        private ListBox tenLst;
        private ListBox elevLst;
        private ListBox twelLst;
        private ListBox subTBox;
        private Label subLbl;
        private Label ninLbl;
        private Label tenLbl;
        private Label elevLbl;
        private Label twelLbl;
        private Label freqStdLbl;
        private Label freqVisitCount;
        private ListBox visitNamesLst;
        private Label countLbl;
    }
}