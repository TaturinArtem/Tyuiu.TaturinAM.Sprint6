
namespace Tyuiu.TaturinAM.Sprint6.Task5.V21
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxOutPut_KMA = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_ATM = new System.Windows.Forms.DataGridView();
            this.buttonHelp_ATM = new System.Windows.Forms.Button();
            this.buttonOpenFile_ATM = new System.Windows.Forms.Button();
            this.buttonDone_ATM = new System.Windows.Forms.Button();
            this.groupBoxTask_KMA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ATM = new System.Windows.Forms.TextBox();
            this.chartFunction_ATM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxOutPut_KMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_ATM)).BeginInit();
            this.groupBoxTask_KMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ATM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOutPut_KMA
            // 
            this.groupBoxOutPut_KMA.Controls.Add(this.dataGridViewResult_ATM);
            this.groupBoxOutPut_KMA.Location = new System.Drawing.Point(18, 111);
            this.groupBoxOutPut_KMA.Name = "groupBoxOutPut_KMA";
            this.groupBoxOutPut_KMA.Size = new System.Drawing.Size(200, 327);
            this.groupBoxOutPut_KMA.TabIndex = 9;
            this.groupBoxOutPut_KMA.TabStop = false;
            this.groupBoxOutPut_KMA.Text = "Вывод данных";
            // 
            // dataGridViewResult_ATM
            // 
            this.dataGridViewResult_ATM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_ATM.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_ATM.Name = "dataGridViewResult_ATM";
            this.dataGridViewResult_ATM.Size = new System.Drawing.Size(191, 305);
            this.dataGridViewResult_ATM.TabIndex = 0;
            // 
            // buttonHelp_ATM
            // 
            this.buttonHelp_ATM.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_ATM.Location = new System.Drawing.Point(687, 28);
            this.buttonHelp_ATM.Name = "buttonHelp_ATM";
            this.buttonHelp_ATM.Size = new System.Drawing.Size(99, 68);
            this.buttonHelp_ATM.TabIndex = 8;
            this.buttonHelp_ATM.Text = "Справка";
            this.buttonHelp_ATM.UseVisualStyleBackColor = false;
            this.buttonHelp_ATM.Click += new System.EventHandler(this.buttonHelp_ATM_Click);
            // 
            // buttonOpenFile_ATM
            // 
            this.buttonOpenFile_ATM.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonOpenFile_ATM.Location = new System.Drawing.Point(582, 28);
            this.buttonOpenFile_ATM.Name = "buttonOpenFile_ATM";
            this.buttonOpenFile_ATM.Size = new System.Drawing.Size(99, 68);
            this.buttonOpenFile_ATM.TabIndex = 7;
            this.buttonOpenFile_ATM.Text = "Открыть файл";
            this.buttonOpenFile_ATM.UseVisualStyleBackColor = false;
            // 
            // buttonDone_ATM
            // 
            this.buttonDone_ATM.BackColor = System.Drawing.Color.Green;
            this.buttonDone_ATM.Location = new System.Drawing.Point(477, 28);
            this.buttonDone_ATM.Name = "buttonDone_ATM";
            this.buttonDone_ATM.Size = new System.Drawing.Size(99, 68);
            this.buttonDone_ATM.TabIndex = 6;
            this.buttonDone_ATM.Text = "Выполнить";
            this.buttonDone_ATM.UseVisualStyleBackColor = false;
            this.buttonDone_ATM.Click += new System.EventHandler(this.buttonDone_ATM_Click);
            // 
            // groupBoxTask_KMA
            // 
            this.groupBoxTask_KMA.Controls.Add(this.textBoxTask_ATM);
            this.groupBoxTask_KMA.Location = new System.Drawing.Point(15, 12);
            this.groupBoxTask_KMA.Name = "groupBoxTask_KMA";
            this.groupBoxTask_KMA.Size = new System.Drawing.Size(456, 93);
            this.groupBoxTask_KMA.TabIndex = 5;
            this.groupBoxTask_KMA.TabStop = false;
            this.groupBoxTask_KMA.Text = "Условие";
            // 
            // textBoxTask_ATM
            // 
            this.textBoxTask_ATM.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_ATM.Multiline = true;
            this.textBoxTask_ATM.Name = "textBoxTask_ATM";
            this.textBoxTask_ATM.ReadOnly = true;
            this.textBoxTask_ATM.Size = new System.Drawing.Size(447, 68);
            this.textBoxTask_ATM.TabIndex = 0;
            this.textBoxTask_ATM.Text = "Прочитать данные из файла InPutFileTask5V21.txt. Вывести в dataGridView. Дан спис" +
    "ок из 20 чисел. Вывести все числа кратные 3.";
            // 
            // chartFunction_ATM
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_ATM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_ATM.Legends.Add(legend1);
            this.chartFunction_ATM.Location = new System.Drawing.Point(276, 127);
            this.chartFunction_ATM.Name = "chartFunction_ATM";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_ATM.Series.Add(series1);
            this.chartFunction_ATM.Size = new System.Drawing.Size(483, 300);
            this.chartFunction_ATM.TabIndex = 1;
            this.chartFunction_ATM.Text = "chart1";
            this.chartFunction_ATM.Click += new System.EventHandler(this.chartFunction_ATM_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartFunction_ATM);
            this.Controls.Add(this.groupBoxOutPut_KMA);
            this.Controls.Add(this.buttonHelp_ATM);
            this.Controls.Add(this.buttonOpenFile_ATM);
            this.Controls.Add(this.buttonDone_ATM);
            this.Controls.Add(this.groupBoxTask_KMA);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBoxOutPut_KMA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_ATM)).EndInit();
            this.groupBoxTask_KMA.ResumeLayout(false);
            this.groupBoxTask_KMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ATM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOutPut_KMA;
        private System.Windows.Forms.DataGridView dataGridViewResult_ATM;
        private System.Windows.Forms.Button buttonHelp_ATM;
        private System.Windows.Forms.Button buttonOpenFile_ATM;
        private System.Windows.Forms.Button buttonDone_ATM;
        private System.Windows.Forms.GroupBox groupBoxTask_KMA;
        private System.Windows.Forms.TextBox textBoxTask_ATM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ATM;
    }
}

