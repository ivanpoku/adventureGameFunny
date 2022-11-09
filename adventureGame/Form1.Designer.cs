namespace adventureGame
{
    partial class Form1
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.desision1 = new System.Windows.Forms.Button();
            this.desision2 = new System.Windows.Forms.Button();
            this.desision3 = new System.Windows.Forms.Button();
            this.guessTextLabel = new System.Windows.Forms.TextBox();
            this.playerHealth = new System.Windows.Forms.Label();
            this.dragonHealth = new System.Windows.Forms.Label();
            this.deathOrbLabel = new System.Windows.Forms.Label();
            this.backgroundLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(1, 33);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(701, 19);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "label1";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desision1
            // 
            this.desision1.Location = new System.Drawing.Point(10, 254);
            this.desision1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.desision1.Name = "desision1";
            this.desision1.Size = new System.Drawing.Size(679, 22);
            this.desision1.TabIndex = 1;
            this.desision1.UseVisualStyleBackColor = true;
            this.desision1.Click += new System.EventHandler(this.desision1_Click);
            // 
            // desision2
            // 
            this.desision2.Location = new System.Drawing.Point(10, 280);
            this.desision2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.desision2.Name = "desision2";
            this.desision2.Size = new System.Drawing.Size(679, 22);
            this.desision2.TabIndex = 2;
            this.desision2.UseVisualStyleBackColor = true;
            this.desision2.Click += new System.EventHandler(this.desision2_Click);
            // 
            // desision3
            // 
            this.desision3.Location = new System.Drawing.Point(10, 307);
            this.desision3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.desision3.Name = "desision3";
            this.desision3.Size = new System.Drawing.Size(679, 22);
            this.desision3.TabIndex = 3;
            this.desision3.UseVisualStyleBackColor = true;
            this.desision3.Click += new System.EventHandler(this.desision3_Click);
            // 
            // guessTextLabel
            // 
            this.guessTextLabel.Location = new System.Drawing.Point(10, 230);
            this.guessTextLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guessTextLabel.Name = "guessTextLabel";
            this.guessTextLabel.Size = new System.Drawing.Size(680, 23);
            this.guessTextLabel.TabIndex = 4;
            this.guessTextLabel.Visible = false;
            this.guessTextLabel.TextChanged += new System.EventHandler(this.guessTextLabel_TextChanged);
            // 
            // playerHealth
            // 
            this.playerHealth.Location = new System.Drawing.Point(20, 18);
            this.playerHealth.Name = "playerHealth";
            this.playerHealth.Size = new System.Drawing.Size(136, 19);
            this.playerHealth.TabIndex = 5;
            this.playerHealth.Text = "label1";
            this.playerHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dragonHealth
            // 
            this.dragonHealth.Location = new System.Drawing.Point(20, 58);
            this.dragonHealth.Name = "dragonHealth";
            this.dragonHealth.Size = new System.Drawing.Size(136, 19);
            this.dragonHealth.TabIndex = 6;
            this.dragonHealth.Text = "label1";
            this.dragonHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deathOrbLabel
            // 
            this.deathOrbLabel.Location = new System.Drawing.Point(554, 18);
            this.deathOrbLabel.Name = "deathOrbLabel";
            this.deathOrbLabel.Size = new System.Drawing.Size(136, 19);
            this.deathOrbLabel.TabIndex = 7;
            this.deathOrbLabel.Text = "Death Orb 1x";
            this.deathOrbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // backgroundLabel
            // 
            this.backgroundLabel.Location = new System.Drawing.Point(-13, -37);
            this.backgroundLabel.Name = "backgroundLabel";
            this.backgroundLabel.Size = new System.Drawing.Size(730, 388);
            this.backgroundLabel.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::adventureGame.Properties.Resources.page1;
            this.pictureBox1.Location = new System.Drawing.Point(191, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deathOrbLabel);
            this.Controls.Add(this.dragonHealth);
            this.Controls.Add(this.playerHealth);
            this.Controls.Add(this.guessTextLabel);
            this.Controls.Add(this.desision3);
            this.Controls.Add(this.desision2);
            this.Controls.Add(this.desision1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.backgroundLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label outputLabel;
        private Button desision1;
        private Button desision2;
        private Button desision3;
        private TextBox guessTextLabel;
        private Label playerHealth;
        private Label dragonHealth;
        private Label deathOrbLabel;
        private Label backgroundLabel;
        private PictureBox pictureBox1;
    }
}