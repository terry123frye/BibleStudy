
namespace Bible2years
{
    partial class Form1
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
            this.lblReadToday = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblVersesToRead = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReadIndicator = new System.Windows.Forms.Label();
            this.btnEscape = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReadToday
            // 
            this.lblReadToday.AutoSize = true;
            this.lblReadToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadToday.Location = new System.Drawing.Point(85, 427);
            this.lblReadToday.Name = "lblReadToday";
            this.lblReadToday.Size = new System.Drawing.Size(235, 31);
            this.lblReadToday.TabIndex = 0;
            this.lblReadToday.Text = "Scripture reading :";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(71, 669);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(68, 484);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(104, 20);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "     Start Day: ";
            this.lblStart.Visible = false;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(70, 526);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(102, 20);
            this.lblCurrent.TabIndex = 3;
            this.lblCurrent.Text = "Current Day: ";
            this.lblCurrent.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(285, 669);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Previous";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(406, 669);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Next";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(527, 669);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 35);
            this.button4.TabIndex = 6;
            this.button4.Text = "Mark as Read";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblVersesToRead
            // 
            this.lblVersesToRead.AutoSize = true;
            this.lblVersesToRead.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersesToRead.Location = new System.Drawing.Point(319, 428);
            this.lblVersesToRead.MaximumSize = new System.Drawing.Size(330, 200);
            this.lblVersesToRead.MinimumSize = new System.Drawing.Size(330, 200);
            this.lblVersesToRead.Name = "lblVersesToRead";
            this.lblVersesToRead.Size = new System.Drawing.Size(330, 200);
            this.lblVersesToRead.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(68, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Daily Bible Reading on a 2 year plan";
            // 
            // lblReadIndicator
            // 
            this.lblReadIndicator.AutoSize = true;
            this.lblReadIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadIndicator.Location = new System.Drawing.Point(72, 577);
            this.lblReadIndicator.Name = "lblReadIndicator";
            this.lblReadIndicator.Size = new System.Drawing.Size(219, 20);
            this.lblReadIndicator.TabIndex = 11;
            this.lblReadIndicator.Text = "This reading was not done yet";
            // 
            // btnEscape
            // 
            this.btnEscape.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEscape.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscape.Location = new System.Drawing.Point(192, 669);
            this.btnEscape.Name = "btnEscape";
            this.btnEscape.Size = new System.Drawing.Size(87, 35);
            this.btnEscape.TabIndex = 12;
            this.btnEscape.Text = "ESC";
            this.btnEscape.UseVisualStyleBackColor = true;
            this.btnEscape.Click += new System.EventHandler(this.btnEscape_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(705, 724);
            this.Controls.Add(this.btnEscape);
            this.Controls.Add(this.lblReadIndicator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblVersesToRead);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblReadToday);
            this.Name = "Form1";
            this.Text = "Daily Bible Readings - 2 year plan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReadToday;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblVersesToRead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReadIndicator;
        private System.Windows.Forms.Button btnEscape;
    }
}

