namespace Leap_Motion_Csharp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.displayImages = new System.Windows.Forms.PictureBox();
            this.FHand = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Xpos = new System.Windows.Forms.MaskedTextBox();
            this.mag = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.displayFPS = new System.Windows.Forms.MaskedTextBox();
            this.AppendText = new System.Windows.Forms.MaskedTextBox();
            this.Ang = new System.Windows.Forms.MaskedTextBox();
            this.Zpos = new System.Windows.Forms.MaskedTextBox();
            this.displayHandCount = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayImages)).BeginInit();
            this.SuspendLayout();
            // 
            // displayImages
            // 
            this.displayImages.Location = new System.Drawing.Point(203, 3);
            this.displayImages.Margin = new System.Windows.Forms.Padding(4);
            this.displayImages.Name = "displayImages";
            this.displayImages.Size = new System.Drawing.Size(690, 543);
            this.displayImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.displayImages.TabIndex = 4;
            this.displayImages.TabStop = false;
            // 
            // FHand
            // 
            this.FHand.AutoSize = true;
            this.FHand.Location = new System.Drawing.Point(0, 12);
            this.FHand.Name = "FHand";
            this.FHand.Size = new System.Drawing.Size(46, 17);
            this.FHand.TabIndex = 5;
            this.FHand.Text = "X-Pos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mag => Orgin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "FPS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "HandCount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Z-Pos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "tan(Z/X)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "ServoRing";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "ServoМiddle";
            // 
            // Xpos
            // 
            this.Xpos.Location = new System.Drawing.Point(98, 12);
            this.Xpos.Name = "Xpos";
            this.Xpos.Size = new System.Drawing.Size(78, 22);
            this.Xpos.TabIndex = 13;
            // 
            // mag
            // 
            this.mag.Location = new System.Drawing.Point(97, 68);
            this.mag.Name = "mag";
            this.mag.Size = new System.Drawing.Size(78, 22);
            this.mag.TabIndex = 14;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(98, 214);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(78, 22);
            this.maskedTextBox3.TabIndex = 15;
            // 
            // displayFPS
            // 
            this.displayFPS.Location = new System.Drawing.Point(98, 96);
            this.displayFPS.Name = "displayFPS";
            this.displayFPS.Size = new System.Drawing.Size(78, 22);
            this.displayFPS.TabIndex = 16;
            // 
            // AppendText
            // 
            this.AppendText.Location = new System.Drawing.Point(98, 186);
            this.AppendText.Name = "AppendText";
            this.AppendText.Size = new System.Drawing.Size(78, 22);
            this.AppendText.TabIndex = 17;
            // 
            // Ang
            // 
            this.Ang.Location = new System.Drawing.Point(97, 158);
            this.Ang.Name = "Ang";
            this.Ang.Size = new System.Drawing.Size(78, 22);
            this.Ang.TabIndex = 18;
            // 
            // Zpos
            // 
            this.Zpos.Location = new System.Drawing.Point(98, 40);
            this.Zpos.Name = "Zpos";
            this.Zpos.Size = new System.Drawing.Size(78, 22);
            this.Zpos.TabIndex = 19;
            // 
            // displayHandCount
            // 
            this.displayHandCount.Location = new System.Drawing.Point(97, 265);
            this.displayHandCount.Name = "displayHandCount";
            this.displayHandCount.Size = new System.Drawing.Size(78, 22);
            this.displayHandCount.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 547);
            this.Controls.Add(this.displayHandCount);
            this.Controls.Add(this.Zpos);
            this.Controls.Add(this.Ang);
            this.Controls.Add(this.AppendText);
            this.Controls.Add(this.displayFPS);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.mag);
            this.Controls.Add(this.Xpos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FHand);
            this.Controls.Add(this.displayImages);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Frame Data";
            ((System.ComponentModel.ISupportInitialize)(this.displayImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox displayImages;
        private System.Windows.Forms.Label FHand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox Xpos;
        private System.Windows.Forms.MaskedTextBox mag;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox displayFPS;
        private System.Windows.Forms.MaskedTextBox AppendText;
        private System.Windows.Forms.MaskedTextBox Ang;
        private System.Windows.Forms.MaskedTextBox Zpos;
        private System.Windows.Forms.MaskedTextBox displayHandCount;
    }
}