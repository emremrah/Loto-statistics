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

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e) {
            comboBox1.SelectedIndex = 0;
            BLL bll = new BLL();
            dataGrid.DataSource = bll.Get();
        }

        private void ballButton_Click(object sender, EventArgs e) {
            BLL bll = new BLL();
            dataGrid.Columns.Clear();

            //Get selected balls statistics
            dataGrid.DataSource = bll.GetBalls(comboBox1.SelectedItem.ToString());
            
            //Calculate total amount of draw for one ball
            int sum=0;
            for (int i = 0; i < dataGrid.Rows.Count - 1; i++) {
                sum += (int) dataGrid[dataGrid.Columns[comboBox1.SelectedItem.ToString() + "SAYI"].Index, i].Value;
            }

            //Add a new column with a name that depending on ball
            dataGrid.Columns.Add(comboBox1.SelectedItem.ToString() + "ratio", comboBox1.SelectedItem.ToString() + "%");
            //Add the show ratios for each number on the ball
            for (int i = 0; i < dataGrid.Rows.Count - 1; i++) {
                dataGrid[comboBox1.SelectedItem.ToString() + "ratio", i].Value = (Convert.ToDouble(dataGrid[dataGrid.Columns[comboBox1.SelectedItem.ToString() + "ratio"].Index - 1, i].Value) * 100 / sum).ToString("N3");
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        }
    }
}
