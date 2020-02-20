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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.trackInput = new System.Windows.Forms.TrackBar();
            this.IblUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblGreetings = new System.Windows.Forms.Label();
            this.lblAgeGuide = new System.Windows.Forms.Label();
            this.IblGreetings2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IblUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(21, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(226, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Please Enter Your Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAge.Location = new System.Drawing.Point(21, 111);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(210, 25);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Please Enter Your Age";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHeight.Location = new System.Drawing.Point(21, 181);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(320, 50);
            this.lblHeight.TabIndex = 2;
            this.lblHeight.Text = "Please Enter Your Height in Meters \r\nWith Two Deciaml Places.";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(303, 36);
            this.nameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(230, 22);
            this.nameInput.TabIndex = 3;
            // 
            // trackInput
            // 
            this.trackInput.Location = new System.Drawing.Point(273, 101);
            this.trackInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackInput.Maximum = 60;
            this.trackInput.Name = "trackInput";
            this.trackInput.Size = new System.Drawing.Size(260, 56);
            this.trackInput.TabIndex = 4;
            this.trackInput.Value = 10;
            this.trackInput.Scroll += new System.EventHandler(this.trackInput_Scroll);
            // 
            // IblUpDown
            // 
            this.IblUpDown.DecimalPlaces = 2;
            this.IblUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.IblUpDown.Location = new System.Drawing.Point(373, 186);
            this.IblUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IblUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IblUpDown.Name = "IblUpDown";
            this.IblUpDown.Size = new System.Drawing.Size(160, 22);
            this.IblUpDown.TabIndex = 5;
            this.IblUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSubmit.Location = new System.Drawing.Point(476, 254);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(109, 43);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGreetings
            // 
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblGreetings.Location = new System.Drawing.Point(22, 254);
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(0, 17);
            this.lblGreetings.TabIndex = 7;
            // 
            // lblAgeGuide
            // 
            this.lblAgeGuide.AutoSize = true;
            this.lblAgeGuide.Location = new System.Drawing.Point(568, 111);
            this.lblAgeGuide.Name = "lblAgeGuide";
            this.lblAgeGuide.Size = new System.Drawing.Size(0, 17);
            this.lblAgeGuide.TabIndex = 8;
            // 
            // IblGreetings2
            // 
            this.IblGreetings2.AutoSize = true;
            this.IblGreetings2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.IblGreetings2.Location = new System.Drawing.Point(22, 291);
            this.IblGreetings2.Name = "IblGreetings2";
            this.IblGreetings2.Size = new System.Drawing.Size(0, 17);
            this.IblGreetings2.TabIndex = 9;
            // 
            // Chapter3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 330);
            this.Controls.Add(this.IblGreetings2);
            this.Controls.Add(this.lblAgeGuide);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.IblUpDown);
            this.Controls.Add(this.trackInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Chapter3";
            this.Text = "b n";
            this.Load += new System.EventHandler(this.Chapter3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IblUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TrackBar trackInput;
        private System.Windows.Forms.NumericUpDown IblUpDown;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.Label lblAgeGuide;
        private System.Windows.Forms.Label IblGreetings2;
    }
}

