namespace TrackerUI
{
    partial class TourrnamentDashboardForm
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
            this.tournmentHeaderLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentValue = new System.Windows.Forms.ComboBox();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournmentHeaderLabel
            // 
            this.tournmentHeaderLabel.AutoSize = true;
            this.tournmentHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.tournmentHeaderLabel.Location = new System.Drawing.Point(258, 42);
            this.tournmentHeaderLabel.Name = "tournmentHeaderLabel";
            this.tournmentHeaderLabel.Size = new System.Drawing.Size(330, 41);
            this.tournmentHeaderLabel.TabIndex = 0;
            this.tournmentHeaderLabel.Text = "Tournament Dashboard";
            this.tournmentHeaderLabel.Click += new System.EventHandler(this.tournmentHeaderLabel_Click);
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(132, 123);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(289, 32);
            this.loadExistingTournamentLabel.TabIndex = 1;
            this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadExistingTournamentValue
            // 
            this.loadExistingTournamentValue.FormattingEnabled = true;
            this.loadExistingTournamentValue.Location = new System.Drawing.Point(427, 120);
            this.loadExistingTournamentValue.Name = "loadExistingTournamentValue";
            this.loadExistingTournamentValue.Size = new System.Drawing.Size(270, 40);
            this.loadExistingTournamentValue.TabIndex = 2;
            this.loadExistingTournamentValue.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.Location = new System.Drawing.Point(301, 222);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(181, 47);
            this.loadTournamentButton.TabIndex = 3;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            this.loadTournamentButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.Location = new System.Drawing.Point(301, 315);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(181, 75);
            this.createTournamentButton.TabIndex = 4;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TourrnamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.loadExistingTournamentValue);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.tournmentHeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TourrnamentDashboardForm";
            this.Text = "Tourrnament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournmentHeaderLabel;
        private System.Windows.Forms.Label loadExistingTournamentLabel;
        private System.Windows.Forms.ComboBox loadExistingTournamentValue;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}