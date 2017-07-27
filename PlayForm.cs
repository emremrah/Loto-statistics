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
        private Kolon[] kolon = new Kolon[8];
        private int[,] draw = new int[6, 8];
        private Sheet[] sheets;
        private int profit = 0;
        private int KolonPrice = 4;
        private const int streakBounty = 1000;
        private int streak = 0;
        private int sheetAmount = 0;
        private int sheetPrice = 0;
        Random random = new Random();
        private int ucBilen = 0, dortBilen = 0, besBilen = 0, altiBilen = 0; 

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
            KolonPrice = 4;
            kolonPriceTxt.Text = KolonPrice.ToString();
            betText.Text = 32000.ToString();
            FillRandom();
            DrawLoto();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            try {
                KolonPrice = Convert.ToInt32(kolonPriceTxt.Text);   //Take kolon price
                sheetPrice = KolonPrice * 8;
                sheetAmount = Convert.ToInt32(betText.Text) / sheetPrice;
                sheetAmountLabel.Text = sheetAmount.ToString();
            } catch {
                MessageBox.Show("Make sure you entered the values.");
                return;
            }
            for (int i = 0; i < sheetAmount; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            InitializeSheet();
            SheetArray();
            DrawLoto();
            try {
                //sheetAmountLabel.Text = "Form sayısı: " + (Convert.ToInt32(betText.Text) / sheet.price).ToString();

            } catch (Exception)
            {
                return;
            }
            //Reset kolon values
            //foreach (Control control in Controls) {
            //    if (control is Label && control.Name.Contains("kolon") && !control.Name.Contains("Price")) {
            //        control.Text = "0";
            //    }
            //}
            EditLabels();
        }

        private void InitializeSheet()
        {
            sheets = new Sheet[sheetAmount];

            //Generate 8 number of kolons
            for (var i = 0; i < kolon.Length; i++) {
                kolon[i] = new Kolon();
            }
            //Generate single sheet and prepare it's kolon
            for (int i = 0; i < sheetAmount; i++)
            {
                //Hepsinin kolonunu aynı kolon yaptığım için call by reference oluyor sanırım. Hepsi aynı çıkıyor
                sheets[i] = new Sheet(kolon);
            }
            
            //Take all numbers in kolons from DataGrid
            for (int m = 0; m < sheetAmount; m++)
            {
                for (var i = 0; i < 8; i++) {
                    for (var j = 0; j < 6; j++) {
                        sheets[m].kolon[i].numbers[j] = random.Next(1,10);
                    }
                }
            }
            
            //sheet.price = KolonPrice * 8;
            //try {
            //    //Create a Sheet array. It's amount depends on Bet and Kolon price
            //    //var sheets = new Sheet[Convert.ToInt32(betText.Text) / sheet.price];
            //    //Make all sheets the same
            //    for (var i = 0; i < sheets.Length; i++) {
            //        sheets[i] = sheet;
            //    }
            //} catch (Exception) {
            //    MessageBox.Show("Enter the bet amount.");
            //    return;
            //}
        }

        private void SheetArray()
        {
            ////Take all values from DataGrid and prepare the Sheet
            //for (var i = 0; i < dataGridView1.Rows.Count - 1; i++) {
            //    for (var j = 0; j < dataGridView1.ColumnCount; j++) {
            //        sheets[j, i] = Convert.ToInt32(dataGridView1[j, i].Value);
            //    }
            //}
        }

        private void DrawLoto()
        {
            //Draw random loto
            
            bool available = true;
            for (var i = 0; i < 8; i++) {
                for (var j = 0; j < 6; j++) {
                    //First pick a random number. Then compare it with all previous values in the same kolon
                    int number = random.Next(1, 10);
                    for (int k = 0; k < j; k++) {
                        //If any value has been drawn before
                        if ((int) draw[k, i] == number) {
                            //Deny it and reroll number
                            available = false;
                            j--;
                            break;
                        } else
                            available = true;
                    }
                    //If number is not denied, grab it
                    if (available)
                        draw[j, i] = number;
                }
            }
        }

        private void EditLabels()
        {
            for (int mIndex = 0; mIndex < sheetAmount; mIndex++)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (draw[j, i] == sheets[mIndex].kolon[i].numbers[j])
                        {
                            streak++;
                        }
                        if (streak >= 3)
                        {
                            switch (streak)
                            {
                                case 3:
                                    ucBilen++;
                                    break;
                                case 4:
                                    dortBilen++;
                                    break;
                                case 5:
                                    besBilen++;
                                    break;
                            }
                        }
                    }
                }
            }

            //for (var i = 0; i < draw.GetLength(1); i++) {   //Rows (Kolons)
            //    for (var j = 0; j < draw.GetLength(0); j++) {   //Columns (Numbers)
            //        if (draw[j, i] == sheets[j, i]) {  // If drawn number and our number is equal
            //            dataGridView1[j, i].Style.BackColor = Color.Cyan;
            //            streak++;   //Increase streak
            //        }
            //        else
            //        {
            //            dataGridView1[j, i].Style.BackColor = Color.White;
            //        }
            //        //If the last number checked and at least three of numbers predicted
            //        if (j >= 5 && streak >= 3)
            //        {
            //            foreach (Control control in Controls) {
            //                //Find the exact label that represents the kolon that we just looked
            //                if (control is Label && control.Name.Contains("kolon" + (i + 1).ToString())) {
            //                    //Then increase it as streak (predicted numbers on that kolon)
            //                    control.Text = streak + " bilen\n" + sheetAmount;
            //                }
            //            }
            //            profit += streak * streakBounty * sheetAmount; //Increase the profit
            //        }
            //    }
            //    streak = 0;
            //}
            //profitLabel.Text = profit.ToString();
            //profit = 0;
        }

        private void FillRandom()
        {
            //Fill the DataGrid with random values to play quickly. Values will be DISTINCT.
            //bool available = true;
            //for (var i = 0; i < dataGridView1.Rows.Count - 1; i++)
            //{
            //    for (var j = 0; j < dataGridView1.ColumnCount; j++)
            //    {
            //        //First pick a random number. Then compare it with all previous values in the same kolon
            //        int number = random.Next(1, 49);
            //        for (int k = 0; k < j; k++)
            //        {
            //            //If any value has been drawn before
            //            if ((int) dataGridView1[k, i].Value == number)
            //            {
            //                //Deny it and reroll number
            //                available = false;
            //                j--;
            //                break;
            //            } else
            //                available = true;
            //        }
            //        //If number is not denied, grab it
            //        if (available)
            //            dataGridView1[j, i].Value = number;
            //    }
            //}
        }

        private Drawn drawnForm;
        private void button1_Click(object sender, EventArgs e) {
            try {
                drawnForm.Close();

            } catch  {
                //return;
            }
            drawnForm = new Drawn(draw);
            drawnForm.Show();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    dataGridView1[j, i].Value = sheets[comboBox1.SelectedIndex + 1].kolon[i].numbers[j];
                }
            }
        }
    }
}
