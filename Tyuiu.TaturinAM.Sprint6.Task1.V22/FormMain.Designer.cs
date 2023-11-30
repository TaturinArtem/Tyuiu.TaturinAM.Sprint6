
namespace Tyuiu.TaturinAM.Sprint6.Task1.V22
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonDone_SME = new System.Windows.Forms.Button();
            this.buttonHelp_SME = new System.Windows.Forms.Button();
            this.groupBoxData_SME = new System.Windows.Forms.GroupBox();
            this.labelStop_SME = new System.Windows.Forms.Label();
            this.labelStart_SME = new System.Windows.Forms.Label();
            this.textBoxStopStep_SME = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_SME = new System.Windows.Forms.TextBox();
            this.groupBoxResult_SME = new System.Windows.Forms.GroupBox();
            this.labelResult_SME = new System.Windows.Forms.Label();
            this.textBoxResult_SME = new System.Windows.Forms.TextBox();
            this.groupBoxCondition_SME = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxTask_SME = new System.Windows.Forms.TextBox();
            this.groupBoxData_SME.SuspendLayout();
            this.groupBoxResult_SME.SuspendLayout();
            this.groupBoxCondition_SME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_SME
            // 
            this.buttonDone_SME.BackColor = System.Drawing.Color.Yellow;
            this.buttonDone_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_SME.Location = new System.Drawing.Point(396, 320);
            this.buttonDone_SME.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDone_SME.Name = "buttonDone_SME";
            this.buttonDone_SME.Size = new System.Drawing.Size(130, 78);
            this.buttonDone_SME.TabIndex = 9;
            this.buttonDone_SME.Text = "Выполнить";
            this.buttonDone_SME.UseVisualStyleBackColor = false;
            this.buttonDone_SME.Click += new System.EventHandler(this.buttonDone_SME_Click);
            // 
            // buttonHelp_SME
            // 
            this.buttonHelp_SME.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHelp_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_SME.Location = new System.Drawing.Point(311, 320);
            this.buttonHelp_SME.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHelp_SME.Name = "buttonHelp_SME";
            this.buttonHelp_SME.Size = new System.Drawing.Size(80, 78);
            this.buttonHelp_SME.TabIndex = 8;
            this.buttonHelp_SME.Text = "?";
            this.buttonHelp_SME.UseVisualStyleBackColor = false;
            this.buttonHelp_SME.Click += new System.EventHandler(this.buttonHelp_SME_Click);
            // 
            // groupBoxData_SME
            // 
            this.groupBoxData_SME.Controls.Add(this.labelStop_SME);
            this.groupBoxData_SME.Controls.Add(this.labelStart_SME);
            this.groupBoxData_SME.Controls.Add(this.textBoxStopStep_SME);
            this.groupBoxData_SME.Controls.Add(this.textBoxStartStep_SME);
            this.groupBoxData_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxData_SME.Location = new System.Drawing.Point(3, 320);
            this.groupBoxData_SME.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxData_SME.Name = "groupBoxData_SME";
            this.groupBoxData_SME.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxData_SME.Size = new System.Drawing.Size(304, 78);
            this.groupBoxData_SME.TabIndex = 7;
            this.groupBoxData_SME.TabStop = false;
            this.groupBoxData_SME.Text = "Ввод данных";
            // 
            // labelStop_SME
            // 
            this.labelStop_SME.AutoSize = true;
            this.labelStop_SME.Location = new System.Drawing.Point(156, 27);
            this.labelStop_SME.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStop_SME.Name = "labelStop_SME";
            this.labelStop_SME.Size = new System.Drawing.Size(89, 17);
            this.labelStop_SME.TabIndex = 1;
            this.labelStop_SME.Text = "Конец шага:";
            // 
            // labelStart_SME
            // 
            this.labelStart_SME.AutoSize = true;
            this.labelStart_SME.Location = new System.Drawing.Point(4, 25);
            this.labelStart_SME.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStart_SME.Name = "labelStart_SME";
            this.labelStart_SME.Size = new System.Drawing.Size(87, 17);
            this.labelStart_SME.TabIndex = 1;
            this.labelStart_SME.Text = "Старт шага:";
            // 
            // textBoxStopStep_SME
            // 
            this.textBoxStopStep_SME.Location = new System.Drawing.Point(156, 44);
            this.textBoxStopStep_SME.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStopStep_SME.Name = "textBoxStopStep_SME";
            this.textBoxStopStep_SME.Size = new System.Drawing.Size(144, 23);
            this.textBoxStopStep_SME.TabIndex = 0;
            // 
            // textBoxStartStep_SME
            // 
            this.textBoxStartStep_SME.Location = new System.Drawing.Point(4, 44);
            this.textBoxStartStep_SME.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStartStep_SME.Name = "textBoxStartStep_SME";
            this.textBoxStartStep_SME.Size = new System.Drawing.Size(148, 23);
            this.textBoxStartStep_SME.TabIndex = 0;
            // 
            // groupBoxResult_SME
            // 
            this.groupBoxResult_SME.Controls.Add(this.labelResult_SME);
            this.groupBoxResult_SME.Controls.Add(this.textBoxResult_SME);
            this.groupBoxResult_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_SME.Location = new System.Drawing.Point(531, 52);
            this.groupBoxResult_SME.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxResult_SME.Name = "groupBoxResult_SME";
            this.groupBoxResult_SME.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxResult_SME.Size = new System.Drawing.Size(267, 346);
            this.groupBoxResult_SME.TabIndex = 6;
            this.groupBoxResult_SME.TabStop = false;
            this.groupBoxResult_SME.Text = "Вывод данных";
            // 
            // labelResult_SME
            // 
            this.labelResult_SME.AutoSize = true;
            this.labelResult_SME.Location = new System.Drawing.Point(5, 22);
            this.labelResult_SME.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult_SME.Name = "labelResult_SME";
            this.labelResult_SME.Size = new System.Drawing.Size(80, 17);
            this.labelResult_SME.TabIndex = 1;
            this.labelResult_SME.Text = "Результат:";
            // 
            // textBoxResult_SME
            // 
            this.textBoxResult_SME.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult_SME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_SME.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_SME.Location = new System.Drawing.Point(5, 41);
            this.textBoxResult_SME.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResult_SME.Multiline = true;
            this.textBoxResult_SME.Name = "textBoxResult_SME";
            this.textBoxResult_SME.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SME.Size = new System.Drawing.Size(257, 300);
            this.textBoxResult_SME.TabIndex = 0;
            // 
            // groupBoxCondition_SME
            // 
            this.groupBoxCondition_SME.Controls.Add(this.pictureBox1);
            this.groupBoxCondition_SME.Controls.Add(this.textBoxTask_SME);
            this.groupBoxCondition_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_SME.Location = new System.Drawing.Point(3, 52);
            this.groupBoxCondition_SME.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxCondition_SME.Name = "groupBoxCondition_SME";
            this.groupBoxCondition_SME.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxCondition_SME.Size = new System.Drawing.Size(524, 263);
            this.groupBoxCondition_SME.TabIndex = 5;
            this.groupBoxCondition_SME.TabStop = false;
            this.groupBoxCondition_SME.Text = "Условие";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxTask_SME
            // 
            this.textBoxTask_SME.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_SME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_SME.Location = new System.Drawing.Point(4, 21);
            this.textBoxTask_SME.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTask_SME.Multiline = true;
            this.textBoxTask_SME.Name = "textBoxTask_SME";
            this.textBoxTask_SME.Size = new System.Drawing.Size(493, 222);
            this.textBoxTask_SME.TabIndex = 0;
            this.textBoxTask_SME.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы." +
    "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDone_SME);
            this.Controls.Add(this.buttonHelp_SME);
            this.Controls.Add(this.groupBoxData_SME);
            this.Controls.Add(this.groupBoxResult_SME);
            this.Controls.Add(this.groupBoxCondition_SME);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 22 | Татурин А.М.";
            this.groupBoxData_SME.ResumeLayout(false);
            this.groupBoxData_SME.PerformLayout();
            this.groupBoxResult_SME.ResumeLayout(false);
            this.groupBoxResult_SME.PerformLayout();
            this.groupBoxCondition_SME.ResumeLayout(false);
            this.groupBoxCondition_SME.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_SME;
        private System.Windows.Forms.Button buttonHelp_SME;
        private System.Windows.Forms.GroupBox groupBoxData_SME;
        private System.Windows.Forms.Label labelStop_SME;
        private System.Windows.Forms.Label labelStart_SME;
        private System.Windows.Forms.TextBox textBoxStopStep_SME;
        private System.Windows.Forms.TextBox textBoxStartStep_SME;
        private System.Windows.Forms.GroupBox groupBoxResult_SME;
        private System.Windows.Forms.Label labelResult_SME;
        private System.Windows.Forms.TextBox textBoxResult_SME;
        private System.Windows.Forms.GroupBox groupBoxCondition_SME;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxTask_SME;
    }
}

