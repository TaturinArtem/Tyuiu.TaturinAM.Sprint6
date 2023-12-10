using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.TaturinAM.Sprint6.Task5.V21.Lib;
namespace Tyuiu.TaturinAM.Sprint6.Task5.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Sprint6\InPutFileTask5V21.txt";
        private void buttonHelp_ATM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы СМАРТб-23-1 Татурин Артем Максимович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_ATM_Click(object sender, EventArgs e)
        {
            dataGridViewResult_ATM.ColumnCount = 2;
            dataGridViewResult_ATM.Columns[0].Width = 20;
            dataGridViewResult_ATM.Columns[1].Width = 50;
            this.chartFunction_ATM.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_ATM.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction_ATM.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_ATM.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_ATM.Series[0].Points.AddXY(i, numsMass[i]);
            }


        }

        private void buttonOpenFile_ATM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void chartFunction_ATM_Click(object sender, EventArgs e)
        {

        }
    }
}
