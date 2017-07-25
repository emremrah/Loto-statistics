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
    public partial class PlayForm: Form
    {
        private Kolon[] kolon = new Kolon[8];
        private Sheet sheet;
        private int KolonPrice = 4;
        private int[,] mySheet = new int[6, 8];
        private int[,] draw = new int[6, 8];
        private int streak = 0;
        private int streakBounty = 20;
        Random random = new Random();
        private int one = 0, two = 0, three = 0, four = 0, five = 0, six = 0;
        private int profit = 0;

        public PlayForm() {

            InitializeComponent();
        }

        private void PlayForm_Load(object sender, EventArgs e) {
            dataGridView1.Columns.Add("BALL1", "TOP1");
            dataGridView1.Columns.Add("BALL2", "TOP2");
            dataGridView1.Columns.Add("BALL3", "TOP3");
            dataGridView1.Columns.Add("BALL4", "TOP4");
            dataGridView1.Columns.Add("BALL5", "TOP5");
            dataGridView1.Columns.Add("BALL6", "TOP6");
            dataGridView1.Rows.Add(count : 8);
            kolonPriceLaber.Text = KolonPrice.ToString();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) {
                for (int j = 0; j < dataGridView1.ColumnCount; j++) {
                    dataGridView1[j, i].Value = 5;
                }
            }
            DrawLoto();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            InitializeSheet();
            SheetArray();
            sheetAmountLabel.Text = (Convert.ToInt16(betText.Text) / sheet.price).ToString();
            for (int i = 0; i < draw.GetLength(0); i++)
            {
                for (int j = 0; j < draw.GetLength(1); j++)
                {
                    if (draw[i, j] == mySheet[i, j])
                    {
                        streak++;
                    }
                    else
                    {
                        if (streak == 1)
                        {
                            ball1Label.Text = (Convert.ToInt16(ball1Label.Text) + 1).ToString();
                            profit += streak * streakBounty;
                        } else if (streak == 2)
                        {
                            ball2Label.Text = (Convert.ToInt16(ball2Label.Text) + 1).ToString();
                            profit += streak * streakBounty;
                        }else if (streak == 3)
                        {
                            ball3Label.Text = (Convert.ToInt16(ball3Label.Text) + 1).ToString();
                            profit += streak * streakBounty;
                        }else if (streak == 4)
                        {
                            ball4Label.Text = (Convert.ToInt16(ball4Label.Text) + 1).ToString();
                            profit += streak * streakBounty;
                        }else if (streak == 5)
                        {
                            ball5Label.Text = (Convert.ToInt16(ball5Label.Text) + 1).ToString();
                            profit += streak * streakBounty;
                        }else if (streak == 6)
                        {
                            ball6Label.Text = (Convert.ToInt16(ball6Label.Text) + 1).ToString();
                            profit += streak * streakBounty;
                        }
                        streak = 0;
                    }
                }
            }
            profitLabel.Text = profit.ToString();
        }

        private void InitializeSheet()
        {
            for (int i = 0; i < kolon.Length; i++) {
                kolon[i] = new Kolon();
                kolon[i].price = 5;
                kolon[i].bounty = 20;
            }
            sheet = new Sheet(kolon);

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) {
                for (int j = 0; j < dataGridView1.Columns.Count - 1; j++) {
                    sheet.kolon[i].numbers[j] = Convert.ToInt16(dataGridView1[j, i].Value);
                }
            }
            sheet.price = KolonPrice * 8;

            Sheet[] sheets = new Sheet[(int) Convert.ToInt16(betText.Text) / sheet.price];
            for (int i = 0; i < sheets.Length; i++)
            {
                sheets[i] = sheet;
            }
        }

        private void SheetArray()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) {
                for (int j = 0; j < dataGridView1.ColumnCount; j++) {
                    mySheet[j, i] = Convert.ToInt16(dataGridView1[j, i].Value);
                }
            }
        }

        private void DrawLoto()
        {
            for (int i = 0; i < 6; i++) {
                for (int j = 0; j < 8; j++) {
                    draw[i, j] = random.Next(3, 6);
                }
            }
        }

        private void betText_TextChanged(object sender, EventArgs e) {
        }
    }
}
