using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO;
using BLL = LotoStatistics.BusinessLogicLayer.BusinessLogicLayer;

namespace LotoStatistics {

    public partial class Form1: Form {
        
        public Form1() {

            //FileInfo fileInfo = new FileInfo("lotoistatistik.xlsx");
            //if (fileInfo.Exists)
            //    System.Diagnostics.Process.Start("lotoistatistik.xlsx");

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e) {

            BLL bll = new BLL();
            dataGrid.DataSource = bll.Get();
        }

        private void ballButton_Click(object sender, EventArgs e) {
            BLL bll = new BLL();
            dataGrid.DataSource = bll.GetBalls("TOP1");
            int sum=0;
            for (int i = 0; i < dataGrid.Rows.Count-1; i++)
			{
                sum += (int) dataGrid[1, i].Value;
			}
            dataGrid.Columns.Add("TOP1ratio", "TOP1%");
            for (int i = 0; i < dataGrid.Rows.Count-1; i++) {
                dataGrid["TOP" + 1 + "ratio", i].Value = Convert.ToDouble(dataGrid[2 - 1, i].Value) * 100 / sum;
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            MessageBox.Show(dataGrid.CurrentCell.RowIndex.ToString() + dataGrid.CurrentCell.ColumnIndex.ToString());
        }
    }
}
