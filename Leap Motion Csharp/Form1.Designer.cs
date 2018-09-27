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
            this.displayID = new System.Windows.Forms.Label();
            this.displayTimestamp = new System.Windows.Forms.Label();
            this.displayImages = new System.Windows.Forms.PictureBox();
            this.FHand = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Ring = new System.Windows.Forms.Label();
            this.Middle = new System.Windows.Forms.Label();
            this.Xpos = new System.Windows.Forms.MaskedTextBox();
            this.mag = new System.Windows.Forms.MaskedTextBox();
            this.Middle_val = new System.Windows.Forms.MaskedTextBox();
            this.displayFPS = new System.Windows.Forms.MaskedTextBox();
            this.Ring_val = new System.Windows.Forms.MaskedTextBox();
            this.Ang = new System.Windows.Forms.MaskedTextBox();
            this.Zpos = new System.Windows.Forms.MaskedTextBox();
            this.displayHandCount = new System.Windows.Forms.MaskedTextBox();
            this.Index = new System.Windows.Forms.Label();
            this.Thumb = new System.Windows.Forms.Label();
            this.Pinky = new System.Windows.Forms.Label();
            this.Index_val = new System.Windows.Forms.MaskedTextBox();
            this.Thumb_val = new System.Windows.Forms.MaskedTextBox();
            this.Pinky_val = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayImages)).BeginInit();
            this.SuspendLayout();
            // 
            // displayID
            // 
            this.displayID.AutoSize = true;
            this.displayID.Location = new System.Drawing.Point(12, 9);
            this.displayID.Name = "displayID";
            this.displayID.Size = new System.Drawing.Size(35, 13);
            this.displayID.TabIndex = 0;
            this.displayID.Text = "label1";
            // 
            // displayTimestamp
            // 
            this.displayTimestamp.AutoSize = true;
            this.displayTimestamp.Location = new System.Drawing.Point(111, 9);
            this.displayTimestamp.Name = "displayTimestamp";
            this.displayTimestamp.Size = new System.Drawing.Size(35, 13);
            this.displayTimestamp.TabIndex = 1;
            this.displayTimestamp.Text = "label2";
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
            this.FHand.Location = new System.Drawing.Point(4, 15);
            this.FHand.Name = "FHand";
            this.FHand.Size = new System.Drawing.Size(46, 17);
            this.FHand.TabIndex = 5;
            this.FHand.Text = "X-Pos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mag => Orgin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "FPS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "HandCount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Z-Pos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "tan(Z/X)";
            // 
            // Ring
            // 
            this.Ring.AutoSize = true;
            this.Ring.Location = new System.Drawing.Point(4, 312);
            this.Ring.Name = "Ring";
            this.Ring.Size = new System.Drawing.Size(42, 17);
            this.Ring.TabIndex = 11;
            this.Ring.Text = "RING";
            // 
            // Middle
            // 
            this.Middle.AutoSize = true;
            this.Middle.Location = new System.Drawing.Point(5, 281);
            this.Middle.Name = "Middle";
            this.Middle.Size = new System.Drawing.Size(59, 17);
            this.Middle.TabIndex = 12;
            this.Middle.Text = "МIDDLE";
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
            this.mag.Location = new System.Drawing.Point(98, 68);
            this.mag.Name = "mag";
            this.mag.Size = new System.Drawing.Size(78, 22);
            this.mag.TabIndex = 14;
            // 
            // Middle_val
            // 
            this.Middle_val.Location = new System.Drawing.Point(98, 281);
            this.Middle_val.Name = "Middle_val";
            this.Middle_val.Size = new System.Drawing.Size(78, 22);
            this.Middle_val.TabIndex = 15;
            // 
            // displayFPS
            // 
            this.displayFPS.Location = new System.Drawing.Point(98, 96);
            this.displayFPS.Name = "displayFPS";
            this.displayFPS.Size = new System.Drawing.Size(78, 22);
            this.displayFPS.TabIndex = 16;
            // 
            // Ring_val
            // 
            this.Ring_val.Location = new System.Drawing.Point(97, 309);
            this.Ring_val.Name = "Ring_val";
            this.Ring_val.Size = new System.Drawing.Size(78, 22);
            this.Ring_val.TabIndex = 17;
            // 
            // Ang
            // 
            this.Ang.Location = new System.Drawing.Point(98, 155);
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
            this.displayHandCount.Location = new System.Drawing.Point(97, 437);
            this.displayHandCount.Name = "displayHandCount";
            this.displayHandCount.Size = new System.Drawing.Size(78, 22);
            this.displayHandCount.TabIndex = 20;
            // 
            // Index
            // 
            this.Index.AutoSize = true;
            this.Index.Location = new System.Drawing.Point(4, 256);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(49, 17);
            this.Index.TabIndex = 21;
            this.Index.Text = "INDEX";
            // 
            // Thumb
            // 
            this.Thumb.AutoSize = true;
            this.Thumb.Location = new System.Drawing.Point(4, 227);
            this.Thumb.Name = "Thumb";
            this.Thumb.Size = new System.Drawing.Size(57, 17);
            this.Thumb.TabIndex = 22;
            this.Thumb.Text = "THUMB";
            // 
            // Pinky
            // 
            this.Pinky.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Pinky.AutoSize = true;
            this.Pinky.Location = new System.Drawing.Point(4, 337);
            this.Pinky.Name = "Pinky";
            this.Pinky.Size = new System.Drawing.Size(48, 17);
            this.Pinky.TabIndex = 23;
            this.Pinky.Text = "PINKY";
            // 
            // Index_val
            // 
            this.Index_val.Location = new System.Drawing.Point(98, 253);
            this.Index_val.Name = "Index_val";
            this.Index_val.Size = new System.Drawing.Size(78, 22);
            this.Index_val.TabIndex = 24;
            // 
            // Thumb_val
            // 
            this.Thumb_val.Location = new System.Drawing.Point(98, 224);
            this.Thumb_val.Name = "Thumb_val";
            this.Thumb_val.Size = new System.Drawing.Size(78, 22);
            this.Thumb_val.TabIndex = 25;
            // 
            // Pinky_val
            // 
            this.Pinky_val.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Pinky_val.Location = new System.Drawing.Point(97, 337);
            this.Pinky_val.Name = "Pinky_val";
            this.Pinky_val.Size = new System.Drawing.Size(78, 22);
            this.Pinky_val.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 547);
            this.Controls.Add(this.Pinky_val);
            this.Controls.Add(this.Thumb_val);
            this.Controls.Add(this.Index_val);
            this.Controls.Add(this.Pinky);
            this.Controls.Add(this.Thumb);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.displayHandCount);
            this.Controls.Add(this.Zpos);
            this.Controls.Add(this.Ang);
            this.Controls.Add(this.Ring_val);
            this.Controls.Add(this.displayFPS);
            this.Controls.Add(this.Middle_val);
            this.Controls.Add(this.mag);
            this.Controls.Add(this.Xpos);
            this.Controls.Add(this.Middle);
            this.Controls.Add(this.Ring);
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

        private System.Windows.Forms.Label displayID;
        private System.Windows.Forms.Label displayTimestamp;
        private System.Windows.Forms.PictureBox displayImages;
        private System.Windows.Forms.Label FHand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Ring;
        private System.Windows.Forms.Label Middle;
        private System.Windows.Forms.MaskedTextBox Xpos;
        private System.Windows.Forms.MaskedTextBox mag;
        private System.Windows.Forms.MaskedTextBox Middle_val;
        private System.Windows.Forms.MaskedTextBox displayFPS;
        private System.Windows.Forms.MaskedTextBox Ring_val;
        private System.Windows.Forms.MaskedTextBox Ang;
        private System.Windows.Forms.MaskedTextBox Zpos;
        private System.Windows.Forms.MaskedTextBox displayHandCount;
        private System.Windows.Forms.Label Index;
        private System.Windows.Forms.Label Thumb;
        private System.Windows.Forms.Label Pinky;
        private System.Windows.Forms.MaskedTextBox Index_val;
        private System.Windows.Forms.MaskedTextBox Thumb_val;
        private System.Windows.Forms.MaskedTextBox Pinky_val;
    }
}