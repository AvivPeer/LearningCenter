namespace LearningCenter
{
    partial class MainMenu
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
            stdFormBtn = new Button();
            stdEditButton = new Button();
            teachersManageBtn = new Button();
            StatisticsBtn = new Button();
            headLine = new Label();
            SuspendLayout();
            // 
            // stdFormBtn
            // 
            stdFormBtn.Location = new Point(567, 347);
            stdFormBtn.Name = "stdFormBtn";
            stdFormBtn.Size = new Size(120, 23);
            stdFormBtn.TabIndex = 0;
            stdFormBtn.Text = "נתוני תלמיד";
            stdFormBtn.UseVisualStyleBackColor = true;
            stdFormBtn.Click += stdFormBtn_Click;
            // 
            // stdEditButton
            // 
            stdEditButton.Location = new Point(407, 347);
            stdEditButton.Name = "stdEditButton";
            stdEditButton.Size = new Size(120, 23);
            stdEditButton.TabIndex = 1;
            stdEditButton.Text = "ניהול תלמידים";
            stdEditButton.UseVisualStyleBackColor = true;
            stdEditButton.Click += stdEditButton_Click;
            // 
            // teachersManageBtn
            // 
            teachersManageBtn.Location = new Point(250, 347);
            teachersManageBtn.Name = "teachersManageBtn";
            teachersManageBtn.Size = new Size(120, 23);
            teachersManageBtn.TabIndex = 2;
            teachersManageBtn.Text = "ניהול מורים";
            teachersManageBtn.UseVisualStyleBackColor = true;
            teachersManageBtn.Click += teachersManageBtn_Click;
            // 
            // StatisticsBtn
            // 
            StatisticsBtn.Location = new Point(98, 347);
            StatisticsBtn.Name = "StatisticsBtn";
            StatisticsBtn.Size = new Size(120, 23);
            StatisticsBtn.TabIndex = 3;
            StatisticsBtn.Text = "סטטיסטיקות";
            StatisticsBtn.UseVisualStyleBackColor = true;
            StatisticsBtn.Click += StatisticsBtn_Click;
            // 
            // headLine
            // 
            headLine.AutoSize = true;
            headLine.Location = new Point(324, 144);
            headLine.Name = "headLine";
            headLine.Size = new Size(138, 15);
            headLine.TabIndex = 4;
            headLine.Text = "מערכת ניהול מרכז למידה";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(headLine);
            Controls.Add(StatisticsBtn);
            Controls.Add(teachersManageBtn);
            Controls.Add(stdEditButton);
            Controls.Add(stdFormBtn);
            Name = "MainMenu";
            Text = "Main Menu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button stdFormBtn;
        private Button stdEditButton;
        private Button teachersManageBtn;
        private Button StatisticsBtn;
        private Label headLine;
    }
}
