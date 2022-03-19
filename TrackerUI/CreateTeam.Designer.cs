namespace TrackerUI
{
    partial class CreateTeam
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
            this.teamMemberValue = new System.Windows.Forms.TextBox();
            this.teamMemberLabel = new System.Windows.Forms.Label();
            this.createTeamHeaderLabel = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.selectTeamMemberDropdown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupbox = new System.Windows.Forms.GroupBox();
            this.teamMemberListbox = new System.Windows.Forms.ListBox();
            this.deleteSelectedTeamMemberButton = new System.Windows.Forms.Button();
            this.newMemberFirstNameLabel = new System.Windows.Forms.Label();
            this.newMemberFirstNameValue = new System.Windows.Forms.TextBox();
            this.newMemberLastNameValue = new System.Windows.Forms.TextBox();
            this.newMemberLastNameLabel = new System.Windows.Forms.Label();
            this.newMemberEmailValue = new System.Windows.Forms.TextBox();
            this.newMemberEmail = new System.Windows.Forms.Label();
            this.newMemberCellphoneValue = new System.Windows.Forms.TextBox();
            this.newMemberCellphoneLabel = new System.Windows.Forms.Label();
            this.createNewMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addNewMemberGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamMemberValue
            // 
            this.teamMemberValue.Location = new System.Drawing.Point(30, 100);
            this.teamMemberValue.Name = "teamMemberValue";
            this.teamMemberValue.Size = new System.Drawing.Size(264, 20);
            this.teamMemberValue.TabIndex = 7;
            this.teamMemberValue.TextChanged += new System.EventHandler(this.tournamentNameTextbox_TextChanged);
            // 
            // teamMemberLabel
            // 
            this.teamMemberLabel.AutoSize = true;
            this.teamMemberLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamMemberLabel.Location = new System.Drawing.Point(33, 77);
            this.teamMemberLabel.Name = "teamMemberLabel";
            this.teamMemberLabel.Size = new System.Drawing.Size(90, 21);
            this.teamMemberLabel.TabIndex = 6;
            this.teamMemberLabel.Text = "Team Name";
            this.teamMemberLabel.Click += new System.EventHandler(this.tournamentNameLabel_Click);
            // 
            // createTeamHeaderLabel
            // 
            this.createTeamHeaderLabel.AutoSize = true;
            this.createTeamHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamHeaderLabel.Location = new System.Drawing.Point(30, 23);
            this.createTeamHeaderLabel.Name = "createTeamHeaderLabel";
            this.createTeamHeaderLabel.Size = new System.Drawing.Size(187, 40);
            this.createTeamHeaderLabel.TabIndex = 5;
            this.createTeamHeaderLabel.Text = "Create Team";
            this.createTeamHeaderLabel.Click += new System.EventHandler(this.createTournamentHeaderLabel_Click);
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(227, 151);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(0, 13);
            this.createNewTeamLink.TabIndex = 11;
            // 
            // selectTeamMemberDropdown
            // 
            this.selectTeamMemberDropdown.FormattingEnabled = true;
            this.selectTeamMemberDropdown.Location = new System.Drawing.Point(26, 147);
            this.selectTeamMemberDropdown.Name = "selectTeamMemberDropdown";
            this.selectTeamMemberDropdown.Size = new System.Drawing.Size(264, 21);
            this.selectTeamMemberDropdown.TabIndex = 10;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(33, 123);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(150, 21);
            this.selectTeamMemberLabel.TabIndex = 9;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(62, 186);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(180, 34);
            this.addMemberButton.TabIndex = 12;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // addNewMemberGroupbox
            // 
            this.addNewMemberGroupbox.Controls.Add(this.createNewMemberButton);
            this.addNewMemberGroupbox.Controls.Add(this.newMemberCellphoneValue);
            this.addNewMemberGroupbox.Controls.Add(this.newMemberCellphoneLabel);
            this.addNewMemberGroupbox.Controls.Add(this.newMemberEmailValue);
            this.addNewMemberGroupbox.Controls.Add(this.newMemberEmail);
            this.addNewMemberGroupbox.Controls.Add(this.newMemberLastNameValue);
            this.addNewMemberGroupbox.Controls.Add(this.newMemberLastNameLabel);
            this.addNewMemberGroupbox.Controls.Add(this.newMemberFirstNameValue);
            this.addNewMemberGroupbox.Controls.Add(this.newMemberFirstNameLabel);
            this.addNewMemberGroupbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewMemberGroupbox.Location = new System.Drawing.Point(26, 243);
            this.addNewMemberGroupbox.Name = "addNewMemberGroupbox";
            this.addNewMemberGroupbox.Size = new System.Drawing.Size(264, 279);
            this.addNewMemberGroupbox.TabIndex = 13;
            this.addNewMemberGroupbox.TabStop = false;
            this.addNewMemberGroupbox.Text = "Add New Member";
            // 
            // teamMemberListbox
            // 
            this.teamMemberListbox.FormattingEnabled = true;
            this.teamMemberListbox.Location = new System.Drawing.Point(365, 100);
            this.teamMemberListbox.Name = "teamMemberListbox";
            this.teamMemberListbox.Size = new System.Drawing.Size(277, 290);
            this.teamMemberListbox.TabIndex = 14;
            // 
            // deleteSelectedTeamMemberButton
            // 
            this.deleteSelectedTeamMemberButton.Location = new System.Drawing.Point(686, 186);
            this.deleteSelectedTeamMemberButton.Name = "deleteSelectedTeamMemberButton";
            this.deleteSelectedTeamMemberButton.Size = new System.Drawing.Size(102, 50);
            this.deleteSelectedTeamMemberButton.TabIndex = 15;
            this.deleteSelectedTeamMemberButton.Text = "Delete Selected";
            this.deleteSelectedTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // newMemberFirstNameLabel
            // 
            this.newMemberFirstNameLabel.AutoSize = true;
            this.newMemberFirstNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMemberFirstNameLabel.Location = new System.Drawing.Point(6, 29);
            this.newMemberFirstNameLabel.Name = "newMemberFirstNameLabel";
            this.newMemberFirstNameLabel.Size = new System.Drawing.Size(88, 21);
            this.newMemberFirstNameLabel.TabIndex = 17;
            this.newMemberFirstNameLabel.Text = "First Name:";
            this.newMemberFirstNameLabel.Click += new System.EventHandler(this.newMemberFirstNameLabel_Click);
            // 
            // newMemberFirstNameValue
            // 
            this.newMemberFirstNameValue.Location = new System.Drawing.Point(100, 29);
            this.newMemberFirstNameValue.Name = "newMemberFirstNameValue";
            this.newMemberFirstNameValue.Size = new System.Drawing.Size(158, 29);
            this.newMemberFirstNameValue.TabIndex = 16;
            this.newMemberFirstNameValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // newMemberLastNameValue
            // 
            this.newMemberLastNameValue.Location = new System.Drawing.Point(100, 79);
            this.newMemberLastNameValue.Name = "newMemberLastNameValue";
            this.newMemberLastNameValue.Size = new System.Drawing.Size(158, 29);
            this.newMemberLastNameValue.TabIndex = 18;
            this.newMemberLastNameValue.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // newMemberLastNameLabel
            // 
            this.newMemberLastNameLabel.AutoSize = true;
            this.newMemberLastNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMemberLastNameLabel.Location = new System.Drawing.Point(6, 79);
            this.newMemberLastNameLabel.Name = "newMemberLastNameLabel";
            this.newMemberLastNameLabel.Size = new System.Drawing.Size(86, 21);
            this.newMemberLastNameLabel.TabIndex = 19;
            this.newMemberLastNameLabel.Text = "Last Name:";
            this.newMemberLastNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // newMemberEmailValue
            // 
            this.newMemberEmailValue.Location = new System.Drawing.Point(100, 129);
            this.newMemberEmailValue.Name = "newMemberEmailValue";
            this.newMemberEmailValue.Size = new System.Drawing.Size(158, 29);
            this.newMemberEmailValue.TabIndex = 20;
            // 
            // newMemberEmail
            // 
            this.newMemberEmail.AutoSize = true;
            this.newMemberEmail.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMemberEmail.Location = new System.Drawing.Point(6, 129);
            this.newMemberEmail.Name = "newMemberEmail";
            this.newMemberEmail.Size = new System.Drawing.Size(51, 21);
            this.newMemberEmail.TabIndex = 21;
            this.newMemberEmail.Text = "Email:";
            this.newMemberEmail.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // newMemberCellphoneValue
            // 
            this.newMemberCellphoneValue.Location = new System.Drawing.Point(100, 176);
            this.newMemberCellphoneValue.Name = "newMemberCellphoneValue";
            this.newMemberCellphoneValue.Size = new System.Drawing.Size(158, 29);
            this.newMemberCellphoneValue.TabIndex = 22;
            this.newMemberCellphoneValue.TextChanged += new System.EventHandler(this.newMemberCellphoneValue_TextChanged);
            // 
            // newMemberCellphoneLabel
            // 
            this.newMemberCellphoneLabel.AutoSize = true;
            this.newMemberCellphoneLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMemberCellphoneLabel.Location = new System.Drawing.Point(6, 179);
            this.newMemberCellphoneLabel.Name = "newMemberCellphoneLabel";
            this.newMemberCellphoneLabel.Size = new System.Drawing.Size(84, 21);
            this.newMemberCellphoneLabel.TabIndex = 23;
            this.newMemberCellphoneLabel.Text = "Cellphone:";
            // 
            // createNewMemberButton
            // 
            this.createNewMemberButton.Location = new System.Drawing.Point(36, 240);
            this.createNewMemberButton.Name = "createNewMemberButton";
            this.createNewMemberButton.Size = new System.Drawing.Size(180, 33);
            this.createNewMemberButton.TabIndex = 16;
            this.createNewMemberButton.Text = "Create Member";
            this.createNewMemberButton.UseVisualStyleBackColor = true;
            this.createNewMemberButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // createTeamButton
            // 
            this.createTeamButton.Location = new System.Drawing.Point(365, 422);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(277, 94);
            this.createTeamButton.TabIndex = 16;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 611);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedTeamMemberButton);
            this.Controls.Add(this.teamMemberListbox);
            this.Controls.Add(this.addNewMemberGroupbox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamMemberDropdown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamMemberValue);
            this.Controls.Add(this.teamMemberLabel);
            this.Controls.Add(this.createTeamHeaderLabel);
            this.Name = "CreateTeam";
            this.Text = "CreateTeam";
            this.addNewMemberGroupbox.ResumeLayout(false);
            this.addNewMemberGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamMemberValue;
        private System.Windows.Forms.Label teamMemberLabel;
        private System.Windows.Forms.Label createTeamHeaderLabel;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.ComboBox selectTeamMemberDropdown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.GroupBox addNewMemberGroupbox;
        private System.Windows.Forms.ListBox teamMemberListbox;
        private System.Windows.Forms.Button deleteSelectedTeamMemberButton;
        private System.Windows.Forms.TextBox newMemberLastNameValue;
        private System.Windows.Forms.Label newMemberLastNameLabel;
        private System.Windows.Forms.TextBox newMemberFirstNameValue;
        private System.Windows.Forms.Label newMemberFirstNameLabel;
        private System.Windows.Forms.TextBox newMemberEmailValue;
        private System.Windows.Forms.Label newMemberEmail;
        private System.Windows.Forms.Button createNewMemberButton;
        private System.Windows.Forms.TextBox newMemberCellphoneValue;
        private System.Windows.Forms.Label newMemberCellphoneLabel;
        private System.Windows.Forms.Button createTeamButton;
    }
}