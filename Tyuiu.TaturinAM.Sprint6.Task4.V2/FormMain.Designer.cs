
namespace Tyuiu.TaturinAM.Sprint6.Task4.V2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.button_Spravka_ATM = new System.Windows.Forms.Button();
            this.button_Save_ATM = new System.Windows.Forms.Button();
            this.button_Done_ATM = new System.Windows.Forms.Button();
            this.groupBox_ATM = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_stop_ATM = new System.Windows.Forms.TextBox();
            this.textBox_start_ATM = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_ATM = new System.Windows.Forms.TextBox();
            this.chart_grafic_ATM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3.SuspendLayout();
            this.groupBox_ATM.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_grafic_ATM)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(400, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "График функции F(x)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_Result);
            this.groupBox3.Location = new System.Drawing.Point(30, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 339);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вывод";
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(6, 19);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Result.Size = new System.Drawing.Size(185, 314);
            this.textBox_Result.TabIndex = 0;
            // 
            // button_Spravka_ATM
            // 
            this.button_Spravka_ATM.BackColor = System.Drawing.Color.Cyan;
            this.button_Spravka_ATM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Spravka_ATM.Location = new System.Drawing.Point(706, 237);
            this.button_Spravka_ATM.Name = "button_Spravka_ATM";
            this.button_Spravka_ATM.Size = new System.Drawing.Size(75, 82);
            this.button_Spravka_ATM.TabIndex = 12;
            this.button_Spravka_ATM.Text = "Справка ";
            this.button_Spravka_ATM.UseVisualStyleBackColor = false;
            this.button_Spravka_ATM.Click += new System.EventHandler(this.button_Spravka_ATM_Click);
            // 
            // button_Save_ATM
            // 
            this.button_Save_ATM.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Save_ATM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Save_ATM.Location = new System.Drawing.Point(705, 128);
            this.button_Save_ATM.Name = "button_Save_ATM";
            this.button_Save_ATM.Size = new System.Drawing.Size(76, 82);
            this.button_Save_ATM.TabIndex = 11;
            this.button_Save_ATM.Text = "Сохранить";
            this.button_Save_ATM.UseVisualStyleBackColor = false;
            this.button_Save_ATM.Click += new System.EventHandler(this.button_Save_ATM_Click);
            // 
            // button_Done_ATM
            // 
            this.button_Done_ATM.BackColor = System.Drawing.Color.DarkGreen;
            this.button_Done_ATM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Done_ATM.Location = new System.Drawing.Point(705, 12);
            this.button_Done_ATM.Name = "button_Done_ATM";
            this.button_Done_ATM.Size = new System.Drawing.Size(75, 82);
            this.button_Done_ATM.TabIndex = 10;
            this.button_Done_ATM.Text = "Выполнить";
            this.button_Done_ATM.UseVisualStyleBackColor = false;
            this.button_Done_ATM.Click += new System.EventHandler(this.button_Done_ATM_Click);
            // 
            // groupBox_ATM
            // 
            this.groupBox_ATM.Controls.Add(this.label2);
            this.groupBox_ATM.Controls.Add(this.label1);
            this.groupBox_ATM.Controls.Add(this.textBox_stop_ATM);
            this.groupBox_ATM.Controls.Add(this.textBox_start_ATM);
            this.groupBox_ATM.Location = new System.Drawing.Point(413, 2);
            this.groupBox_ATM.Name = "groupBox_ATM";
            this.groupBox_ATM.Size = new System.Drawing.Size(269, 101);
            this.groupBox_ATM.TabIndex = 9;
            this.groupBox_ATM.TabStop = false;
            this.groupBox_ATM.Text = "Ввод данных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Конец шага";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Старт шага";
            // 
            // textBox_stop_ATM
            // 
            this.textBox_stop_ATM.Location = new System.Drawing.Point(154, 42);
            this.textBox_stop_ATM.Name = "textBox_stop_ATM";
            this.textBox_stop_ATM.Size = new System.Drawing.Size(100, 20);
            this.textBox_stop_ATM.TabIndex = 1;
            // 
            // textBox_start_ATM
            // 
            this.textBox_start_ATM.Location = new System.Drawing.Point(15, 42);
            this.textBox_start_ATM.Name = "textBox_start_ATM";
            this.textBox_start_ATM.Size = new System.Drawing.Size(100, 20);
            this.textBox_start_ATM.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_ATM);
            this.groupBox1.Location = new System.Drawing.Point(20, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 101);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие";
            // 
            // textBox_ATM
            // 
            this.textBox_ATM.Location = new System.Drawing.Point(10, 20);
            this.textBox_ATM.Multiline = true;
            this.textBox_ATM.Name = "textBox_ATM";
            this.textBox_ATM.ReadOnly = true;
            this.textBox_ATM.Size = new System.Drawing.Size(355, 71);
            this.textBox_ATM.TabIndex = 0;
            this.textBox_ATM.Text = resources.GetString("textBox_ATM.Text");
            // 
            // chart_grafic_ATM
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_grafic_ATM.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_grafic_ATM.Legends.Add(legend3);
            this.chart_grafic_ATM.Location = new System.Drawing.Point(275, 161);
            this.chart_grafic_ATM.Name = "chart_grafic_ATM";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_grafic_ATM.Series.Add(series3);
            this.chart_grafic_ATM.Size = new System.Drawing.Size(407, 239);
            this.chart_grafic_ATM.TabIndex = 4;
            this.chart_grafic_ATM.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart_grafic_ATM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_Spravka_ATM);
            this.Controls.Add(this.button_Save_ATM);
            this.Controls.Add(this.button_Done_ATM);
            this.Controls.Add(this.groupBox_ATM);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 4 | Вариант 2 | Татурин А.М.";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox_ATM.ResumeLayout(false);
            this.groupBox_ATM.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_grafic_ATM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button button_Spravka_ATM;
        private System.Windows.Forms.Button button_Save_ATM;
        private System.Windows.Forms.Button button_Done_ATM;
        private System.Windows.Forms.GroupBox groupBox_ATM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_stop_ATM;
        private System.Windows.Forms.TextBox textBox_start_ATM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_ATM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_grafic_ATM;
    }
}

