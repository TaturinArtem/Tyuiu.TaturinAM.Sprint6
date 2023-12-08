
namespace Tyuiu.TaturinAM.Sprint6.Task6.V19
{
    partial class FormAbout
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonOK_PKR = new System.Windows.Forms.Button();
            this.labelInfo_PKR = new System.Windows.Forms.Label();
            this.pictureBoxAvatar_PKR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PKR)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // buttonOK_PKR
            // 
            this.buttonOK_PKR.Location = new System.Drawing.Point(363, 108);
            this.buttonOK_PKR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK_PKR.Name = "buttonOK_PKR";
            this.buttonOK_PKR.Size = new System.Drawing.Size(66, 27);
            this.buttonOK_PKR.TabIndex = 5;
            this.buttonOK_PKR.Text = "OK";
            this.buttonOK_PKR.UseVisualStyleBackColor = true;
            // 
            // labelInfo_PKR
            // 
            this.labelInfo_PKR.AutoSize = true;
            this.labelInfo_PKR.Location = new System.Drawing.Point(153, 9);
            this.labelInfo_PKR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo_PKR.Name = "labelInfo_PKR";
            this.labelInfo_PKR.Size = new System.Drawing.Size(264, 91);
            this.labelInfo_PKR.TabIndex = 4;
            this.labelInfo_PKR.Text = resources.GetString("labelInfo_PKR.Text");
            // 
            // pictureBoxAvatar_PKR
            // 
            this.pictureBoxAvatar_PKR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_PKR.Image")));
            this.pictureBoxAvatar_PKR.InitialImage = null;
            this.pictureBoxAvatar_PKR.Location = new System.Drawing.Point(9, 10);
            this.pictureBoxAvatar_PKR.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxAvatar_PKR.Name = "pictureBoxAvatar_PKR";
            this.pictureBoxAvatar_PKR.Size = new System.Drawing.Size(143, 119);
            this.pictureBoxAvatar_PKR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_PKR.TabIndex = 3;
            this.pictureBoxAvatar_PKR.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 149);
            this.Controls.Add(this.buttonOK_PKR);
            this.Controls.Add(this.labelInfo_PKR);
            this.Controls.Add(this.pictureBoxAvatar_PKR);
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PKR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button buttonOK_PKR;
        private System.Windows.Forms.Label labelInfo_PKR;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_PKR;
    }
}