namespace TrackerUI
{
    partial class createPrizeForm
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
            this.createPrizeHeaderLabel = new System.Windows.Forms.Label();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.prizeAmountValue = new System.Windows.Forms.TextBox();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.vsLabel = new System.Windows.Forms.Label();
            this.prizePercentageValue = new System.Windows.Forms.TextBox();
            this.prizePercentLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createPrizeHeaderLabel
            // 
            this.createPrizeHeaderLabel.AutoSize = true;
            this.createPrizeHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPrizeHeaderLabel.Location = new System.Drawing.Point(38, 31);
            this.createPrizeHeaderLabel.Name = "createPrizeHeaderLabel";
            this.createPrizeHeaderLabel.Size = new System.Drawing.Size(169, 40);
            this.createPrizeHeaderLabel.TabIndex = 0;
            this.createPrizeHeaderLabel.Text = "Create Prize";
            this.createPrizeHeaderLabel.Click += new System.EventHandler(this.createPrizeHeaderLabel_Click);
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.Location = new System.Drawing.Point(43, 136);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(135, 25);
            this.placeNumberLabel.TabIndex = 1;
            this.placeNumberLabel.Text = "Place Number:";
            // 
            // placeNumberValue
            // 
            this.placeNumberValue.Location = new System.Drawing.Point(184, 133);
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Size = new System.Drawing.Size(178, 33);
            this.placeNumberValue.TabIndex = 2;
            // 
            // placeNameValue
            // 
            this.placeNameValue.Location = new System.Drawing.Point(184, 196);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(178, 33);
            this.placeNameValue.TabIndex = 4;
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Location = new System.Drawing.Point(43, 199);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(116, 25);
            this.placeNameLabel.TabIndex = 3;
            this.placeNameLabel.Text = "Place Name:";
            // 
            // prizeAmountValue
            // 
            this.prizeAmountValue.Location = new System.Drawing.Point(184, 253);
            this.prizeAmountValue.Name = "prizeAmountValue";
            this.prizeAmountValue.Size = new System.Drawing.Size(178, 33);
            this.prizeAmountValue.TabIndex = 6;
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.Location = new System.Drawing.Point(43, 256);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(130, 25);
            this.prizeAmountLabel.TabIndex = 5;
            this.prizeAmountLabel.Text = "Prize Amount:";
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.Location = new System.Drawing.Point(395, 256);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(50, 25);
            this.vsLabel.TabIndex = 7;
            this.vsLabel.Text = "-VS-";
            // 
            // prizePercentageValue
            // 
            this.prizePercentageValue.Location = new System.Drawing.Point(634, 253);
            this.prizePercentageValue.Name = "prizePercentageValue";
            this.prizePercentageValue.Size = new System.Drawing.Size(178, 33);
            this.prizePercentageValue.TabIndex = 9;
            // 
            // prizePercentLabel
            // 
            this.prizePercentLabel.AutoSize = true;
            this.prizePercentLabel.Location = new System.Drawing.Point(471, 256);
            this.prizePercentLabel.Name = "prizePercentLabel";
            this.prizePercentLabel.Size = new System.Drawing.Size(157, 25);
            this.prizePercentLabel.TabIndex = 8;
            this.prizePercentLabel.Text = "Prize Percentage:";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.Location = new System.Drawing.Point(340, 348);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(165, 62);
            this.createPrizeButton.TabIndex = 10;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.prizePercentageValue);
            this.Controls.Add(this.prizePercentLabel);
            this.Controls.Add(this.vsLabel);
            this.Controls.Add(this.prizeAmountValue);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.createPrizeHeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "createPrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createPrizeHeaderLabel;
        private System.Windows.Forms.Label placeNumberLabel;
        private System.Windows.Forms.TextBox placeNumberValue;
        private System.Windows.Forms.TextBox placeNameValue;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.TextBox prizeAmountValue;
        private System.Windows.Forms.Label prizeAmountLabel;
        private System.Windows.Forms.Label vsLabel;
        private System.Windows.Forms.TextBox prizePercentageValue;
        private System.Windows.Forms.Label prizePercentLabel;
        private System.Windows.Forms.Button createPrizeButton;
    }
}