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
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(1, 44);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(801, 25);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "label1";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desision1
            // 
            this.desision1.Location = new System.Drawing.Point(12, 339);
            this.desision1.Name = "desision1";
            this.desision1.Size = new System.Drawing.Size(776, 29);
            this.desision1.TabIndex = 1;
            this.desision1.UseVisualStyleBackColor = true;
            this.desision1.Click += new System.EventHandler(this.desision1_Click);
            // 
            // desision2
            // 
            this.desision2.Location = new System.Drawing.Point(12, 374);
            this.desision2.Name = "desision2";
            this.desision2.Size = new System.Drawing.Size(776, 29);
            this.desision2.TabIndex = 2;
            this.desision2.UseVisualStyleBackColor = true;
            this.desision2.Click += new System.EventHandler(this.desision2_Click);
            // 
            // desision3
            // 
            this.desision3.Location = new System.Drawing.Point(12, 409);
            this.desision3.Name = "desision3";
            this.desision3.Size = new System.Drawing.Size(776, 29);
            this.desision3.TabIndex = 3;
            this.desision3.UseVisualStyleBackColor = true;
            this.desision3.Click += new System.EventHandler(this.desision3_Click);
            // 
            // guessTextLabel
            // 
            this.guessTextLabel.Location = new System.Drawing.Point(12, 306);
            this.guessTextLabel.Name = "guessTextLabel";
            this.guessTextLabel.Size = new System.Drawing.Size(776, 27);
            this.guessTextLabel.TabIndex = 4;
            this.guessTextLabel.Visible = false;
            this.guessTextLabel.TextChanged += new System.EventHandler(this.guessTextLabel_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guessTextLabel);
            this.Controls.Add(this.desision3);
            this.Controls.Add(this.desision2);
            this.Controls.Add(this.desision1);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label outputLabel;
        private Button desision1;
        private Button desision2;
        private Button desision3;
        private TextBox guessTextLabel;
    }
}