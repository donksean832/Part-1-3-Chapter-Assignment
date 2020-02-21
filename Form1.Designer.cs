namespace Part_1_3_Chapter_Assignment
{
    partial class frmChapter3
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.trkInput = new System.Windows.Forms.TrackBar();
            this.IblUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblGreetings = new System.Windows.Forms.Label();
            this.lblAgeGuide = new System.Windows.Forms.Label();
            this.IblGreetings2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkInput)).BeginInit();
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(303, 36);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 22);
            this.txtName.TabIndex = 3;
            // 
            // trkInput
            // 
            this.trkInput.Location = new System.Drawing.Point(273, 101);
            this.trkInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trkInput.Maximum = 60;
            this.trkInput.Name = "trkInput";
            this.trkInput.Size = new System.Drawing.Size(260, 56);
            this.trkInput.TabIndex = 4;
            this.trkInput.Value = 10;
            this.trkInput.Scroll += new System.EventHandler(this.trackInput_Scroll);
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
            this.IblUpDown.Maximum = new decimal(new int[] {
            272,
            0,
            0,
            131072});
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
            // frmChapter3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 330);
            this.Controls.Add(this.IblGreetings2);
            this.Controls.Add(this.lblAgeGuide);
            this.Controls.Add(this.lblGreetings);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.IblUpDown);
            this.Controls.Add(this.trkInput);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmChapter3";
            this.Text = "Age and Height Forum";
            this.Load += new System.EventHandler(this.Chapter3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IblUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TrackBar trkInput;
        private System.Windows.Forms.NumericUpDown IblUpDown;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblGreetings;
        private System.Windows.Forms.Label lblAgeGuide;
        private System.Windows.Forms.Label IblGreetings2;
    }
}

