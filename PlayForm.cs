using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotoStatistics {
    public partial class PlayForm: Form
    {
        private Sheet sheet;
        private Kolon[] kolon = new Kolon[8];
        private int[,] mySheet = new int[6, 8];
        private int[,] draw = new int[6, 8];

        private int profit = 0;
        private int KolonPrice = 4;
        private const int streakBounty = 1000;
        private int streak = 0;
        private int sheetAmount = 0;
        private int sheetPrice = 0;
        Random random = new Random();


        public PlayForm() {

            InitializeComponent();
        }

        private void PlayForm_Load(object sender, EventArgs e) {
            //Prepare DataGridView for 6(Numbers)*8(Kolons)
            dataGridView1.Columns.Add("BALL1", "TOP1");
            dataGridView1.Columns.Add("BALL2", "TOP2");
            dataGridView1.Columns.Add("BALL3", "TOP3");
            dataGridView1.Columns.Add("BALL4", "TOP4");
            dataGridView1.Columns.Add("BALL5", "TOP5");
            dataGridView1.Columns.Add("BALL6", "TOP6");
            dataGridView1.Rows.Add(count : 8);
            FillRandom();
            DrawLoto();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedCells.Clear();
            try {
                KolonPrice = Convert.ToInt32(kolonPriceTxt.Text);
                sheetPrice = KolonPrice * 8;
                sheetAmount = Convert.ToInt32(betText.Text) / sheetPrice;
                sheetAmountLabel.Text = sheetAmount.ToString();

            } catch {
                MessageBox.Show("Make sure you entered the values.");
                return;
            }
            InitializeSheet();
            SheetArray();
            DrawLoto();
            try {
                sheetAmountLabel.Text = "Sheet Amount: " + (Convert.ToInt32(betText.Text) / sheet.price).ToString();

            } catch (Exception)
            {
                return;
            }
            //Reset kolon values
            foreach (Control control in Controls) {
                if (control is Label && control.Name.Contains("kolon") && !control.Name.Contains("Price")) {
                    control.Text = "0";
                }
            }
            EditLabels();
        }

        private void InitializeSheet()
        {
            //Generate Kolons
            for (var i = 0; i < kolon.Length; i++) {
                kolon[i] = new Kolon
                {
                    price = 5,
                    bounty = 20
                };
            }
            //Generate single sheet and prepare it's kolon
            sheet = new Sheet(kolon);

            //Take all numbers in kolons from DataGrid
            for (var i = 0; i < dataGridView1.Rows.Count - 1; i++) {
                for (var j = 0; j < dataGridView1.Columns.Count - 1; j++) {
                    sheet.kolon[i].numbers[j] = Convert.ToInt32(dataGridView1[j, i].Value);
                }
            }
            sheet.price = KolonPrice * 8;
            try {
                //Create a Sheet array. It's amount depends on Bet and Kolon price
                var sheets = new Sheet[Convert.ToInt32(betText.Text) / sheet.price];
                //Make all sheets the same
                for (var i = 0; i < sheets.Length; i++) {
                    sheets[i] = sheet;
                }
            } catch (Exception) {
                MessageBox.Show("Enter the bet amount.");
                return;
            }
        }

        private void SheetArray()
        {
            //Take all values from DataGrid and prepare the Sheet
            for (var i = 0; i < dataGridView1.Rows.Count - 1; i++) {
                for (var j = 0; j < dataGridView1.ColumnCount; j++) {
                    mySheet[j, i] = Convert.ToInt32(dataGridView1[j, i].Value);
                }
            }
        }

        private void DrawLoto()
        {
            //Make a random Sheet
            for (var i = 0; i < 6; i++) {
                for (var j = 0; j < 8; j++) {
                    draw[i, j] = random.Next(1, 7);
                }
            }
        }

        private void EditLabels()
        {
            for (var i = 0; i < draw.GetLength(1); i++) {   //Rows (Kolons)
                for (var j = 0; j < draw.GetLength(0); j++) {   //Columns (Numbers)
                    if (draw[j, i] == mySheet[j, i]) {  // If drawn number and our number is equal
                        dataGridView1[j, i].Style.BackColor = Color.Cyan;
                        streak++;   //Increase streak
                    }
                    else
                    {
                        dataGridView1[j, i].Style.BackColor = Color.White;
                    }
                    //If the last number checked and at least three of numbers predicted
                    if (j >= 5 && streak >= 3)
                    {
                        foreach (Control control in Controls) {
                            //Find the exact label that represents the kolon that we just looked
                            if (control is Label && control.Name.Contains("kolon" + (i + 1).ToString())) {
                                //Then increase it as streak (predicted numbers on that kolon)
                                control.Text = (Convert.ToInt32(control.Text) + streak).ToString();
                            }
                        }
                        profit += streak * streakBounty; //Increase the profit
                    }
                }
                streak = 0;
            }
            profitLabel.Text = profit.ToString();
            profit = 0;
        }

        private void FillRandom()
        {
            //Fill the DataGrid with random values to play quickly. Values will be DISTINCT.
            bool available = true;
            for (var i = 0; i < dataGridView1.Rows.Count - 1; i++) {
                for (var j = 0; j < dataGridView1.ColumnCount; j++) {
                    int number = random.Next(1, 7);
                    for (int k = 0; k < j; k++)
                    {
                        if ((int) dataGridView1[k, i].Value == number)
                        {
                            available = false;
                            j--;
                            break;
                        }
                        else
                        {
                            available = true;
                        }
                    }
                    if (available)
                    {
                        dataGridView1[j, i].Value = number;
                    }
                }
            }
        }
    }
}
