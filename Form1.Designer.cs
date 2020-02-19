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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.submit = new System.Windows.Forms.Button();
            this.Greetings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // enterName
            // 
            this.enterName.AutoSize = true;
            this.enterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.enterName.Location = new System.Drawing.Point(22, 36);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(226, 25);
            this.enterName.TabIndex = 0;
            this.enterName.Text = "Please Enter Your Name";
            // 
            // enterAge
            // 
            this.enterAge.AutoSize = true;
            this.enterAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.enterAge.Location = new System.Drawing.Point(22, 111);
            this.enterAge.Name = "enterAge";
            this.enterAge.Size = new System.Drawing.Size(210, 25);
            this.enterAge.TabIndex = 1;
            this.enterAge.Text = "Please Enter Your Age";
            // 
            // enterHeight
            // 
            this.enterHeight.AutoSize = true;
            this.enterHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.enterHeight.Location = new System.Drawing.Point(22, 181);
            this.enterHeight.Name = "enterHeight";
            this.enterHeight.Size = new System.Drawing.Size(320, 50);
            this.enterHeight.TabIndex = 2;
            this.enterHeight.Text = "Please Enter Your Height in Meters \r\nWith Two Deciaml Places.";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(303, 36);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(211, 22);
            this.nameInput.TabIndex = 3;
            this.nameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(273, 101);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(241, 56);
            this.trackBar1.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(374, 186);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(140, 22);
            this.numericUpDown1.TabIndex = 5;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.submit.Location = new System.Drawing.Point(404, 253);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(110, 43);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Greetings
            // 
            this.Greetings.AutoSize = true;
            this.Greetings.Location = new System.Drawing.Point(118, 280);
            this.Greetings.Name = "Greetings";
            this.Greetings.Size = new System.Drawing.Size(19, 17);
            this.Greetings.TabIndex = 7;
            this.Greetings.Text = "hi";
            // 
            // Chapter3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 330);
            this.Controls.Add(this.Greetings);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.enterHeight);
            this.Controls.Add(this.enterAge);
            this.Controls.Add(this.enterName);
            this.Name = "Chapter3";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterName;
        private System.Windows.Forms.Label enterAge;
        private System.Windows.Forms.Label enterHeight;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label Greetings;
    }
}

