namespace randomSandwichGenerator
{
    partial class menuForm
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
            this.introLabel = new System.Windows.Forms.Label();
            this.subIntroLabel = new System.Windows.Forms.Label();
            this.SandwichOne = new System.Windows.Forms.Label();
            this.SandwichTwo = new System.Windows.Forms.Label();
            this.SandwichThree = new System.Windows.Forms.Label();
            this.SandwichFour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // introLabel
            // 
            this.introLabel.AutoSize = true;
            this.introLabel.Font = new System.Drawing.Font("Segoe Script", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.introLabel.Location = new System.Drawing.Point(251, 9);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(206, 25);
            this.introLabel.TabIndex = 0;
            this.introLabel.Text = "Welcome to Sloppy Joe\'s!";
            this.introLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // subIntroLabel
            // 
            this.subIntroLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subIntroLabel.AutoEllipsis = true;
            this.subIntroLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subIntroLabel.Location = new System.Drawing.Point(56, 34);
            this.subIntroLabel.Name = "subIntroLabel";
            this.subIntroLabel.Size = new System.Drawing.Size(594, 74);
            this.subIntroLabel.TabIndex = 1;
            this.subIntroLabel.Text = "We\'ve got a ton of meat, a whole lotta bread, and more condiments than you can sh" +
    "ake a stick at. But what we dont have is a set menu. Each day our sandwiches gen" +
    "erated randomly. Here\'s today\'s choice:";
            this.subIntroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.subIntroLabel.Click += new System.EventHandler(this.subIntroLabel_Click);
            // 
            // SandwichOne
            // 
            this.SandwichOne.AutoSize = true;
            this.SandwichOne.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SandwichOne.Location = new System.Drawing.Point(47, 126);
            this.SandwichOne.Name = "SandwichOne";
            this.SandwichOne.Size = new System.Drawing.Size(29, 20);
            this.SandwichOne.TabIndex = 2;
            this.SandwichOne.Text = "#1";
            // 
            // SandwichTwo
            // 
            this.SandwichTwo.AutoSize = true;
            this.SandwichTwo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SandwichTwo.Location = new System.Drawing.Point(47, 162);
            this.SandwichTwo.Name = "SandwichTwo";
            this.SandwichTwo.Size = new System.Drawing.Size(29, 20);
            this.SandwichTwo.TabIndex = 3;
            this.SandwichTwo.Text = "#2";
            // 
            // SandwichThree
            // 
            this.SandwichThree.AutoSize = true;
            this.SandwichThree.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SandwichThree.Location = new System.Drawing.Point(47, 196);
            this.SandwichThree.Name = "SandwichThree";
            this.SandwichThree.Size = new System.Drawing.Size(29, 20);
            this.SandwichThree.TabIndex = 4;
            this.SandwichThree.Text = "#3";
            // 
            // SandwichFour
            // 
            this.SandwichFour.AutoSize = true;
            this.SandwichFour.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SandwichFour.Location = new System.Drawing.Point(47, 232);
            this.SandwichFour.Name = "SandwichFour";
            this.SandwichFour.Size = new System.Drawing.Size(29, 20);
            this.SandwichFour.TabIndex = 5;
            this.SandwichFour.Text = "#4";
            // 
            // menuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(731, 291);
            this.Controls.Add(this.SandwichFour);
            this.Controls.Add(this.SandwichThree);
            this.Controls.Add(this.SandwichTwo);
            this.Controls.Add(this.SandwichOne);
            this.Controls.Add(this.subIntroLabel);
            this.Controls.Add(this.introLabel);
            this.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "menuForm";
            this.Text = "Sloppy Joe\'s House of Sandwiches";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label introLabel;
        private System.Windows.Forms.Label subIntroLabel;
        private System.Windows.Forms.Label SandwichOne;
        private System.Windows.Forms.Label SandwichTwo;
        private System.Windows.Forms.Label SandwichThree;
        private System.Windows.Forms.Label SandwichFour;
    }
}

