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
            this.displayFPS = new System.Windows.Forms.Label();
            this.displayHandCount = new System.Windows.Forms.Label();
            this.displayImages = new System.Windows.Forms.PictureBox();
            this.debugText = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.displayImages)).BeginInit();
            this.SuspendLayout();
            // 
            // displayID
            // 
            this.displayID.AutoSize = true;
            this.displayID.Location = new System.Drawing.Point(16, 11);
            this.displayID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayID.Name = "displayID";
            this.displayID.Size = new System.Drawing.Size(46, 17);
            this.displayID.TabIndex = 0;
            this.displayID.Text = "label1";
            // 
            // displayTimestamp
            // 
            this.displayTimestamp.AutoSize = true;
            this.displayTimestamp.Location = new System.Drawing.Point(148, 11);
            this.displayTimestamp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayTimestamp.Name = "displayTimestamp";
            this.displayTimestamp.Size = new System.Drawing.Size(46, 17);
            this.displayTimestamp.TabIndex = 1;
            this.displayTimestamp.Text = "label2";
            // 
            // displayFPS
            // 
            this.displayFPS.AutoSize = true;
            this.displayFPS.Location = new System.Drawing.Point(296, 11);
            this.displayFPS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayFPS.Name = "displayFPS";
            this.displayFPS.Size = new System.Drawing.Size(46, 17);
            this.displayFPS.TabIndex = 2;
            this.displayFPS.Text = "label3";
            // 
            // displayHandCount
            // 
            this.displayHandCount.AutoSize = true;
            this.displayHandCount.Location = new System.Drawing.Point(413, 11);
            this.displayHandCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayHandCount.Name = "displayHandCount";
            this.displayHandCount.Size = new System.Drawing.Size(46, 17);
            this.displayHandCount.TabIndex = 3;
            this.displayHandCount.Text = "label4";
            // 
            // displayImages
            // 
            this.displayImages.Location = new System.Drawing.Point(20, 31);
            this.displayImages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayImages.Name = "displayImages";
            this.displayImages.Size = new System.Drawing.Size(853, 591);
            this.displayImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.displayImages.TabIndex = 4;
            this.displayImages.TabStop = false;
            // 
            // debugText
            // 
            this.debugText.Location = new System.Drawing.Point(20, 629);
            this.debugText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.debugText.Name = "debugText";
            this.debugText.Size = new System.Drawing.Size(852, 202);
            this.debugText.TabIndex = 5;
            this.debugText.Text = "";
            //
            // FrameDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 853);
            this.Controls.Add(this.debugText);
            this.Controls.Add(this.displayImages);
            this.Controls.Add(this.displayHandCount);
            this.Controls.Add(this.displayFPS);
            this.Controls.Add(this.displayTimestamp);
            this.Controls.Add(this.displayID);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrameDataForm";
            this.Text = "Frame Data";
            ((System.ComponentModel.ISupportInitialize)(this.displayImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayID;
        private System.Windows.Forms.Label displayTimestamp;
        private System.Windows.Forms.Label displayFPS;
        private System.Windows.Forms.Label displayHandCount;
        private System.Windows.Forms.PictureBox displayImages;
        private System.Windows.Forms.RichTextBox debugText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}