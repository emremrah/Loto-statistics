using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotoStatistics {
    public partial class Drawn: Form
    {
        private int[,] drawn;
        public Drawn(int[,] drawn) {
            InitializeComponent();
            this.drawn = drawn;
        }

        private void Drawn_Load(object sender, EventArgs e) {
            drawnDataGrid.Columns.Add("BALL1", "TOP1");
            drawnDataGrid.Columns.Add("BALL2", "TOP2");
            drawnDataGrid.Columns.Add("BALL3", "TOP3");
            drawnDataGrid.Columns.Add("BALL4", "TOP4");
            drawnDataGrid.Columns.Add("BALL5", "TOP5");
            drawnDataGrid.Columns.Add("BALL6", "TOP6");
            drawnDataGrid.Rows.Add(count : 8);

            for (int i = 0; i < drawn.GetLength(1); i++)
            {
                for (int j = 0; j < drawn.GetLength(0); j++)
                {
                    drawnDataGrid[j, i].Value = drawn[j,i];
                }
            }
        }
    }
}
