
namespace Tyuiu.TaturinAM.Sprint6.Task2.V6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonDone_BAA = new System.Windows.Forms.Button();
            this.buttonHelp_BAA = new System.Windows.Forms.Button();
            this.groupBoxResult_BAA = new System.Windows.Forms.GroupBox();
            this.labelResult_BAA = new System.Windows.Forms.Label();
            this.dataGridViewResult_BAA = new System.Windows.Forms.DataGridView();
            this.ColumnX_BAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFx_BAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxData_BAA = new System.Windows.Forms.GroupBox();
            this.labelStopStep_BAA = new System.Windows.Forms.Label();
            this.labelStartStep_BAA = new System.Windows.Forms.Label();
            this.textBoxStopStep_BAA = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_BAA = new System.Windows.Forms.TextBox();
            this.groupBoxRead_BAA = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_BAA = new System.Windows.Forms.PictureBox();
            this.textBoxRead_BAA = new System.Windows.Forms.TextBox();
            this.chartResult_BAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxResult_BAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_BAA)).BeginInit();
            this.groupBoxData_BAA.SuspendLayout();
            this.groupBoxRead_BAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_BAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_BAA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_BAA
            // 
            this.buttonDone_BAA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_BAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_BAA.Location = new System.Drawing.Point(383, 259);
            this.buttonDone_BAA.Name = "buttonDone_BAA";
            this.buttonDone_BAA.Size = new System.Drawing.Size(154, 103);
            this.buttonDone_BAA.TabIndex = 9;
            this.buttonDone_BAA.Text = "Выполнить";
            this.buttonDone_BAA.UseVisualStyleBackColor = false;
            this.buttonDone_BAA.Click += new System.EventHandler(this.buttonDone_BAA_Click);
            // 
            // buttonHelp_BAA
            // 
            this.buttonHelp_BAA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonHelp_BAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_BAA.Location = new System.Drawing.Point(282, 259);
            this.buttonHelp_BAA.Name = "buttonHelp_BAA";
            this.buttonHelp_BAA.Size = new System.Drawing.Size(106, 103);
            this.buttonHelp_BAA.TabIndex = 8;
            this.buttonHelp_BAA.Text = "Справка";
            this.buttonHelp_BAA.UseVisualStyleBackColor = false;
            this.buttonHelp_BAA.Click += new System.EventHandler(this.buttonHelp_BAA_Click);
            // 
            // groupBoxResult_BAA
            // 
            this.groupBoxResult_BAA.Controls.Add(this.chartResult_BAA);
            this.groupBoxResult_BAA.Controls.Add(this.labelResult_BAA);
            this.groupBoxResult_BAA.Controls.Add(this.dataGridViewResult_BAA);
            this.groupBoxResult_BAA.Location = new System.Drawing.Point(532, 45);
            this.groupBoxResult_BAA.Name = "groupBoxResult_BAA";
            this.groupBoxResult_BAA.Size = new System.Drawing.Size(483, 318);
            this.groupBoxResult_BAA.TabIndex = 7;
            this.groupBoxResult_BAA.TabStop = false;
            this.groupBoxResult_BAA.Text = "Вывод данных";
            // 
            // labelResult_BAA
            // 
            this.labelResult_BAA.AutoSize = true;
            this.labelResult_BAA.Location = new System.Drawing.Point(6, 20);
            this.labelResult_BAA.Name = "labelResult_BAA";
            this.labelResult_BAA.Size = new System.Drawing.Size(59, 13);
            this.labelResult_BAA.TabIndex = 1;
            this.labelResult_BAA.Text = "Результат";
            // 
            // dataGridViewResult_BAA
            // 
            this.dataGridViewResult_BAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_BAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX_BAA,
            this.ColumnFx_BAA});
            this.dataGridViewResult_BAA.Location = new System.Drawing.Point(6, 36);
            this.dataGridViewResult_BAA.Name = "dataGridViewResult_BAA";
            this.dataGridViewResult_BAA.RowHeadersVisible = false;
            this.dataGridViewResult_BAA.Size = new System.Drawing.Size(124, 247);
            this.dataGridViewResult_BAA.TabIndex = 0;
            // 
            // ColumnX_BAA
            // 
            this.ColumnX_BAA.HeaderText = "X";
            this.ColumnX_BAA.Name = "ColumnX_BAA";
            this.ColumnX_BAA.ReadOnly = true;
            this.ColumnX_BAA.Width = 65;
            // 
            // ColumnFx_BAA
            // 
            this.ColumnFx_BAA.HeaderText = "F(X)";
            this.ColumnFx_BAA.Name = "ColumnFx_BAA";
            this.ColumnFx_BAA.ReadOnly = true;
            this.ColumnFx_BAA.Width = 65;
            // 
            // groupBoxData_BAA
            // 
            this.groupBoxData_BAA.Controls.Add(this.labelStopStep_BAA);
            this.groupBoxData_BAA.Controls.Add(this.labelStartStep_BAA);
            this.groupBoxData_BAA.Controls.Add(this.textBoxStopStep_BAA);
            this.groupBoxData_BAA.Controls.Add(this.textBoxStartStep_BAA);
            this.groupBoxData_BAA.Location = new System.Drawing.Point(0, 259);
            this.groupBoxData_BAA.Name = "groupBoxData_BAA";
            this.groupBoxData_BAA.Size = new System.Drawing.Size(287, 104);
            this.groupBoxData_BAA.TabIndex = 6;
            this.groupBoxData_BAA.TabStop = false;
            this.groupBoxData_BAA.Text = "Ввод данных";
            // 
            // labelStopStep_BAA
            // 
            this.labelStopStep_BAA.AutoSize = true;
            this.labelStopStep_BAA.Location = new System.Drawing.Point(150, 22);
            this.labelStopStep_BAA.Name = "labelStopStep_BAA";
            this.labelStopStep_BAA.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_BAA.TabIndex = 1;
            this.labelStopStep_BAA.Text = "Конец шага:";
            // 
            // labelStartStep_BAA
            // 
            this.labelStartStep_BAA.AutoSize = true;
            this.labelStartStep_BAA.Location = new System.Drawing.Point(7, 20);
            this.labelStartStep_BAA.Name = "labelStartStep_BAA";
            this.labelStartStep_BAA.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_BAA.TabIndex = 1;
            this.labelStartStep_BAA.Text = "Старт шага:";
            // 
            // textBoxStopStep_BAA
            // 
            this.textBoxStopStep_BAA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxStopStep_BAA.Location = new System.Drawing.Point(153, 38);
            this.textBoxStopStep_BAA.Name = "textBoxStopStep_BAA";
            this.textBoxStopStep_BAA.Size = new System.Drawing.Size(117, 20);
            this.textBoxStopStep_BAA.TabIndex = 0;
            this.textBoxStopStep_BAA.Text = "5";
            // 
            // textBoxStartStep_BAA
            // 
            this.textBoxStartStep_BAA.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxStartStep_BAA.Location = new System.Drawing.Point(7, 38);
            this.textBoxStartStep_BAA.Name = "textBoxStartStep_BAA";
            this.textBoxStartStep_BAA.Size = new System.Drawing.Size(123, 20);
            this.textBoxStartStep_BAA.TabIndex = 0;
            this.textBoxStartStep_BAA.Text = "-5";
            this.textBoxStartStep_BAA.TextChanged += new System.EventHandler(this.textBoxStartStep_BAA_TextChanged);
            // 
            // groupBoxRead_BAA
            // 
            this.groupBoxRead_BAA.Controls.Add(this.pictureBoxFormula_BAA);
            this.groupBoxRead_BAA.Controls.Add(this.textBoxRead_BAA);
            this.groupBoxRead_BAA.Location = new System.Drawing.Point(0, 45);
            this.groupBoxRead_BAA.Name = "groupBoxRead_BAA";
            this.groupBoxRead_BAA.Size = new System.Drawing.Size(537, 237);
            this.groupBoxRead_BAA.TabIndex = 5;
            this.groupBoxRead_BAA.TabStop = false;
            this.groupBoxRead_BAA.Text = "Условие";
            // 
            // pictureBoxFormula_BAA
            // 
            this.pictureBoxFormula_BAA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_BAA.Image")));
            this.pictureBoxFormula_BAA.Location = new System.Drawing.Point(7, 62);
            this.pictureBoxFormula_BAA.Name = "pictureBoxFormula_BAA";
            this.pictureBoxFormula_BAA.Size = new System.Drawing.Size(324, 40);
            this.pictureBoxFormula_BAA.TabIndex = 1;
            this.pictureBoxFormula_BAA.TabStop = false;
            // 
            // textBoxRead_BAA
            // 
            this.textBoxRead_BAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRead_BAA.Location = new System.Drawing.Point(7, 20);
            this.textBoxRead_BAA.Multiline = true;
            this.textBoxRead_BAA.Name = "textBoxRead_BAA";
            this.textBoxRead_BAA.ReadOnly = true;
            this.textBoxRead_BAA.Size = new System.Drawing.Size(371, 36);
            this.textBoxRead_BAA.TabIndex = 0;
            this.textBoxRead_BAA.Text = "Протабулировать функцию в заданном диапозоне [-5; 5].\r\nРезультат вывести в DataGr" +
    "idView и построить график функции.";
            // 
            // chartResult_BAA
            // 
            chartArea2.Name = "ChartArea1";
            this.chartResult_BAA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartResult_BAA.Legends.Add(legend2);
            this.chartResult_BAA.Location = new System.Drawing.Point(136, 36);
            this.chartResult_BAA.Name = "chartResult_BAA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartResult_BAA.Series.Add(series2);
            this.chartResult_BAA.Size = new System.Drawing.Size(336, 247);
            this.chartResult_BAA.TabIndex = 2;
            this.chartResult_BAA.Text = "chartResult_BAA";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 450);
            this.Controls.Add(this.buttonDone_BAA);
            this.Controls.Add(this.buttonHelp_BAA);
            this.Controls.Add(this.groupBoxResult_BAA);
            this.Controls.Add(this.groupBoxData_BAA);
            this.Controls.Add(this.groupBoxRead_BAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 6 | Татурин А. М.";
            this.groupBoxResult_BAA.ResumeLayout(false);
            this.groupBoxResult_BAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_BAA)).EndInit();
            this.groupBoxData_BAA.ResumeLayout(false);
            this.groupBoxData_BAA.PerformLayout();
            this.groupBoxRead_BAA.ResumeLayout(false);
            this.groupBoxRead_BAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_BAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_BAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_BAA;
        private System.Windows.Forms.Button buttonHelp_BAA;
        private System.Windows.Forms.GroupBox groupBoxResult_BAA;
        private System.Windows.Forms.Label labelResult_BAA;
        private System.Windows.Forms.DataGridView dataGridViewResult_BAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_BAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFx_BAA;
        private System.Windows.Forms.GroupBox groupBoxData_BAA;
        private System.Windows.Forms.Label labelStopStep_BAA;
        private System.Windows.Forms.Label labelStartStep_BAA;
        private System.Windows.Forms.TextBox textBoxStopStep_BAA;
        private System.Windows.Forms.TextBox textBoxStartStep_BAA;
        private System.Windows.Forms.GroupBox groupBoxRead_BAA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_BAA;
        private System.Windows.Forms.TextBox textBoxRead_BAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_BAA;
    }
}

