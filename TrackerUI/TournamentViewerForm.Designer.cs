namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournmaneName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundDropbox = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.TeamTwo = new System.Windows.Forms.Label();
            this.teamOneScore = new System.Windows.Forms.Label();
            this.teamTwoScore = new System.Windows.Forms.Label();
            this.teamTwoScoreTextBox = new System.Windows.Forms.TextBox();
            this.teamOneScoreTextbox = new System.Windows.Forms.TextBox();
            this.versesLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.headerLabel.Location = new System.Drawing.Point(50, 28);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(148, 32);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
            // 
            // tournmaneName
            // 
            this.tournmaneName.AutoSize = true;
            this.tournmaneName.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.tournmaneName.Location = new System.Drawing.Point(204, 28);
            this.tournmaneName.Name = "tournmaneName";
            this.tournmaneName.Size = new System.Drawing.Size(101, 32);
            this.tournmaneName.TabIndex = 1;
            this.tournmaneName.Text = "<none>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(53, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Round";
            // 
            // roundDropbox
            // 
            this.roundDropbox.FormattingEnabled = true;
            this.roundDropbox.Location = new System.Drawing.Point(115, 117);
            this.roundDropbox.Name = "roundDropbox";
            this.roundDropbox.Size = new System.Drawing.Size(190, 21);
            this.roundDropbox.TabIndex = 3;
            // 
            // unplayedOnlyCheckBox
            // 
            this.unplayedOnlyCheckBox.AutoSize = true;
            this.unplayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.unplayedOnlyCheckBox.Location = new System.Drawing.Point(115, 171);
            this.unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            this.unplayedOnlyCheckBox.Size = new System.Drawing.Size(132, 25);
            this.unplayedOnlyCheckBox.TabIndex = 4;
            this.unplayedOnlyCheckBox.Text = "Unplayed Only";
            this.unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.Location = new System.Drawing.Point(56, 240);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(267, 158);
            this.matchupListBox.TabIndex = 5;
            this.matchupListBox.SelectedIndexChanged += new System.EventHandler(this.listboxLabel_SelectedIndexChanged);
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.teamOneName.Location = new System.Drawing.Point(397, 240);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(79, 21);
            this.teamOneName.TabIndex = 6;
            this.teamOneName.Text = "Team One";
            this.teamOneName.Click += new System.EventHandler(this.teamOneName_Click);
            // 
            // TeamTwo
            // 
            this.TeamTwo.AutoSize = true;
            this.TeamTwo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TeamTwo.Location = new System.Drawing.Point(396, 347);
            this.TeamTwo.Name = "TeamTwo";
            this.TeamTwo.Size = new System.Drawing.Size(78, 21);
            this.TeamTwo.TabIndex = 7;
            this.TeamTwo.Text = "Team Two";
            // 
            // teamOneScore
            // 
            this.teamOneScore.AutoSize = true;
            this.teamOneScore.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.teamOneScore.Location = new System.Drawing.Point(396, 275);
            this.teamOneScore.Name = "teamOneScore";
            this.teamOneScore.Size = new System.Drawing.Size(49, 21);
            this.teamOneScore.TabIndex = 8;
            this.teamOneScore.Text = "Score";
            // 
            // teamTwoScore
            // 
            this.teamTwoScore.AutoSize = true;
            this.teamTwoScore.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.teamTwoScore.Location = new System.Drawing.Point(397, 377);
            this.teamTwoScore.Name = "teamTwoScore";
            this.teamTwoScore.Size = new System.Drawing.Size(49, 21);
            this.teamTwoScore.TabIndex = 9;
            this.teamTwoScore.Text = "Score";
            // 
            // teamTwoScoreTextBox
            // 
            this.teamTwoScoreTextBox.Location = new System.Drawing.Point(466, 377);
            this.teamTwoScoreTextBox.Name = "teamTwoScoreTextBox";
            this.teamTwoScoreTextBox.Size = new System.Drawing.Size(100, 22);
            this.teamTwoScoreTextBox.TabIndex = 10;
            // 
            // teamOneScoreTextbox
            // 
            this.teamOneScoreTextbox.Location = new System.Drawing.Point(466, 274);
            this.teamOneScoreTextbox.Name = "teamOneScoreTextbox";
            this.teamOneScoreTextbox.Size = new System.Drawing.Size(100, 22);
            this.teamOneScoreTextbox.TabIndex = 11;
            // 
            // versesLabel
            // 
            this.versesLabel.AutoSize = true;
            this.versesLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.versesLabel.Location = new System.Drawing.Point(448, 315);
            this.versesLabel.Name = "versesLabel";
            this.versesLabel.Size = new System.Drawing.Size(41, 21);
            this.versesLabel.TabIndex = 12;
            this.versesLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.scoreButton.Location = new System.Drawing.Point(655, 307);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(98, 39);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(860, 459);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versesLabel);
            this.Controls.Add(this.teamOneScoreTextbox);
            this.Controls.Add(this.teamTwoScoreTextBox);
            this.Controls.Add(this.teamTwoScore);
            this.Controls.Add(this.teamOneScore);
            this.Controls.Add(this.TeamTwo);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCheckBox);
            this.Controls.Add(this.roundDropbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tournmaneName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournmaneName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox roundDropbox;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckBox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label TeamTwo;
        private System.Windows.Forms.Label teamOneScore;
        private System.Windows.Forms.Label teamTwoScore;
        private System.Windows.Forms.TextBox teamTwoScoreTextBox;
        private System.Windows.Forms.TextBox teamOneScoreTextbox;
        private System.Windows.Forms.Label versesLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

