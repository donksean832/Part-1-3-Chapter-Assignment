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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.trackInput = new System.Windows.Forms.TrackBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.submit = new System.Windows.Forms.Button();
            this.Greetings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // enterName
            // 
            this.enterName.AutoSize = true;
            this.enterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.enterName.Location = new System.Drawing.Point(16, 29);
            this.enterName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(184, 20);
            this.enterName.TabIndex = 0;
            this.enterName.Text = "Please Enter Your Name";
            // 
            // enterAge
            // 
            this.enterAge.AutoSize = true;
            this.enterAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.enterAge.Location = new System.Drawing.Point(16, 90);
            this.enterAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterAge.Name = "enterAge";
            this.enterAge.Size = new System.Drawing.Size(171, 20);
            this.enterAge.TabIndex = 1;
            this.enterAge.Text = "Please Enter Your Age";
            // 
            // enterHeight
            // 
            this.enterHeight.AutoSize = true;
            this.enterHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.enterHeight.Location = new System.Drawing.Point(16, 147);
            this.enterHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterHeight.Name = "enterHeight";
            this.enterHeight.Size = new System.Drawing.Size(262, 40);
            this.enterHeight.TabIndex = 2;
            this.enterHeight.Text = "Please Enter Your Height in Meters \r\nWith Two Deciaml Places.";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(227, 29);
            this.nameInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(159, 20);
            this.nameInput.TabIndex = 3;
            // 
            // trackInput
            // 
            this.trackInput.Location = new System.Drawing.Point(205, 82);
            this.trackInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackInput.Maximum = 20;
            this.trackInput.Name = "trackInput";
            this.trackInput.Size = new System.Drawing.Size(181, 45);
            this.trackInput.TabIndex = 4;
            this.trackInput.Value = 10;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(280, 151);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(105, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.submit.Location = new System.Drawing.Point(303, 206);
            this.submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(82, 35);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Greetings
            // 
            this.Greetings.AutoSize = true;
            this.Greetings.Location = new System.Drawing.Point(88, 228);
            this.Greetings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Greetings.Name = "Greetings";
            this.Greetings.Size = new System.Drawing.Size(0, 13);
            this.Greetings.TabIndex = 7;
            // 
            // Chapter3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 268);
            this.Controls.Add(this.Greetings);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.trackInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.enterHeight);
            this.Controls.Add(this.enterAge);
            this.Controls.Add(this.enterName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Chapter3";
            this.Text = "b n";
            ((System.ComponentModel.ISupportInitialize)(this.trackInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterName;
        private System.Windows.Forms.Label enterAge;
        private System.Windows.Forms.Label enterHeight;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TrackBar trackInput;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label Greetings;
    }
}

