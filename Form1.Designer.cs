namespace Part_1_3_Chapter_Assignment
{
    partial class Chapter3
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
            this.enterName = new System.Windows.Forms.Label();
            this.enterAge = new System.Windows.Forms.Label();
            this.enterHeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterName
            // 
            this.enterName.AutoSize = true;
            this.enterName.Location = new System.Drawing.Point(57, 36);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(164, 17);
            this.enterName.TabIndex = 0;
            this.enterName.Text = "Please Enter Your Name";
            // 
            // enterAge
            // 
            this.enterAge.AutoSize = true;
            this.enterAge.Location = new System.Drawing.Point(57, 111);
            this.enterAge.Name = "enterAge";
            this.enterAge.Size = new System.Drawing.Size(152, 17);
            this.enterAge.TabIndex = 1;
            this.enterAge.Text = "Please Enter Your Age";
            // 
            // enterHeight
            // 
            this.enterHeight.AutoSize = true;
            this.enterHeight.Location = new System.Drawing.Point(57, 183);
            this.enterHeight.Name = "enterHeight";
            this.enterHeight.Size = new System.Drawing.Size(396, 17);
            this.enterHeight.TabIndex = 2;
            this.enterHeight.Text = "Please Enter Your Height in Meters With Two Deciaml Places.";
            // 
            // Chapter3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enterHeight);
            this.Controls.Add(this.enterAge);
            this.Controls.Add(this.enterName);
            this.Name = "Chapter3";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterName;
        private System.Windows.Forms.Label enterAge;
        private System.Windows.Forms.Label enterHeight;
    }
}

