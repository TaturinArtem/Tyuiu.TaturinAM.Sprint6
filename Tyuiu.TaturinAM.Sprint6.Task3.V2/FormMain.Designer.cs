﻿
namespace Tyuiu.TaturinAM.Sprint6.Task3.V2
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDone_BAA = new System.Windows.Forms.Button();
            this.buttonHelp_BAA = new System.Windows.Forms.Button();
            this.groupBoxResult_BAA = new System.Windows.Forms.GroupBox();
            this.labelResult_BAA = new System.Windows.Forms.Label();
            this.dataGridViewMatrix_BAA = new System.Windows.Forms.DataGridView();
            this.groupBoxRead_BAA = new System.Windows.Forms.GroupBox();
            this.textBoxRead_BAA = new System.Windows.Forms.TextBox();
            this.groupBoxResult_BAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_BAA)).BeginInit();
            this.groupBoxRead_BAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone_BAA
            // 
            this.buttonDone_BAA.Location = new System.Drawing.Point(437, 190);
            this.buttonDone_BAA.Name = "buttonDone_BAA";
            this.buttonDone_BAA.Size = new System.Drawing.Size(146, 31);
            this.buttonDone_BAA.TabIndex = 7;
            this.buttonDone_BAA.Text = "Выполнить";
            this.buttonDone_BAA.UseVisualStyleBackColor = true;
            this.buttonDone_BAA.Click += new System.EventHandler(this.buttonDone_BAA_Click);
            // 
            // buttonHelp_BAA
            // 
            this.buttonHelp_BAA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonHelp_BAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_BAA.Location = new System.Drawing.Point(362, 190);
            this.buttonHelp_BAA.Name = "buttonHelp_BAA";
            this.buttonHelp_BAA.Size = new System.Drawing.Size(69, 31);
            this.buttonHelp_BAA.TabIndex = 6;
            this.buttonHelp_BAA.Text = "?";
            this.buttonHelp_BAA.UseVisualStyleBackColor = true;
            this.buttonHelp_BAA.Click += new System.EventHandler(this.buttonHelp_BAA_Click);
            // 
            // groupBoxResult_BAA
            // 
            this.groupBoxResult_BAA.Controls.Add(this.labelResult_BAA);
            this.groupBoxResult_BAA.Controls.Add(this.dataGridViewMatrix_BAA);
            this.groupBoxResult_BAA.Location = new System.Drawing.Point(362, 13);
            this.groupBoxResult_BAA.Name = "groupBoxResult_BAA";
            this.groupBoxResult_BAA.Size = new System.Drawing.Size(227, 171);
            this.groupBoxResult_BAA.TabIndex = 5;
            this.groupBoxResult_BAA.TabStop = false;
            this.groupBoxResult_BAA.Text = "Вывод данных:";
            // 
            // labelResult_BAA
            // 
            this.labelResult_BAA.AutoSize = true;
            this.labelResult_BAA.Location = new System.Drawing.Point(7, 20);
            this.labelResult_BAA.Name = "labelResult_BAA";
            this.labelResult_BAA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_BAA.TabIndex = 2;
            this.labelResult_BAA.Text = "Результат:";
            // 
            // dataGridViewMatrix_BAA
            // 
            this.dataGridViewMatrix_BAA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewMatrix_BAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_BAA.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_BAA.Location = new System.Drawing.Point(6, 39);
            this.dataGridViewMatrix_BAA.Name = "dataGridViewMatrix_BAA";
            this.dataGridViewMatrix_BAA.RowHeadersVisible = false;
            this.dataGridViewMatrix_BAA.Size = new System.Drawing.Size(215, 126);
            this.dataGridViewMatrix_BAA.TabIndex = 1;
            // 
            // groupBoxRead_BAA
            // 
            this.groupBoxRead_BAA.Controls.Add(this.textBoxRead_BAA);
            this.groupBoxRead_BAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRead_BAA.Name = "groupBoxRead_BAA";
            this.groupBoxRead_BAA.Size = new System.Drawing.Size(344, 209);
            this.groupBoxRead_BAA.TabIndex = 4;
            this.groupBoxRead_BAA.TabStop = false;
            this.groupBoxRead_BAA.Text = "Условие";
            // 
            // textBoxRead_BAA
            // 
            this.textBoxRead_BAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRead_BAA.Location = new System.Drawing.Point(7, 20);
            this.textBoxRead_BAA.Multiline = true;
            this.textBoxRead_BAA.Name = "textBoxRead_BAA";
            this.textBoxRead_BAA.ReadOnly = true;
            this.textBoxRead_BAA.Size = new System.Drawing.Size(267, 162);
            this.textBoxRead_BAA.TabIndex = 0;
            this.textBoxRead_BAA.Text = "Дан массив 5 на 5 элементов. \r\n-12  -4 -20   5  -5\r\n   2  15   1 -20   7\r\n 15 -15" +
    "   2  11   5\r\n-19  -9  16   0   1\r\n 17  16   5  12  -8\r\nЗаменить четные значения" +
    " в первой строке на 0.";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 239);
            this.Controls.Add(this.buttonDone_BAA);
            this.Controls.Add(this.buttonHelp_BAA);
            this.Controls.Add(this.groupBoxResult_BAA);
            this.Controls.Add(this.groupBoxRead_BAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 2 | Татурин А. М. ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxResult_BAA.ResumeLayout(false);
            this.groupBoxResult_BAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_BAA)).EndInit();
            this.groupBoxRead_BAA.ResumeLayout(false);
            this.groupBoxRead_BAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_BAA;
        private System.Windows.Forms.Button buttonHelp_BAA;
        private System.Windows.Forms.GroupBox groupBoxResult_BAA;
        private System.Windows.Forms.Label labelResult_BAA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_BAA;
        private System.Windows.Forms.GroupBox groupBoxRead_BAA;
        private System.Windows.Forms.TextBox textBoxRead_BAA;
    }
}

