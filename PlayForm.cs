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
        private int[] randomDraw = new int[6];
        private Sheet[] sheets;
        private int kolonPrice = 4;
        private int streak = 0;
        private int sheetAmount = 0;
        private int sheetPrice = 0;
        private Int64 profit = 0;
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

            kolonPriceTxt.Text = 4.ToString();
            betText.Text = 32000.ToString();
            RandomLotto();
        }

        private void InitializeComboBox()
        {
            //Add indexes to comboBox
            comboBox1.Items.Clear();
            for (int i = 0; i < sheetAmount; i++) {
                comboBox1.Items.Add((i + 1).ToString());
            }
        }

        private void InitializeVariables()
        {
            ucBilen = dortBilen = besBilen = altiBilen = 0;
            profit = 0;
            try {
                kolonPrice = Convert.ToInt32(kolonPriceTxt.Text);   //Take kolon price
                sheetPrice = kolonPrice * 8;    //Set sheet price
                sheetAmount = Convert.ToInt32(betText.Text) / sheetPrice;   //Set sheet amount
                sheetAmountLabel.Text = sheetAmount.ToString();
            } catch {
                MessageBox.Show("Make sure you entered the values.");
                return;
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls) {
                if (control.Name.StartsWith("bilen") && control is Label)
                {
                    control.Text = control.Name.Substring(5) + " Bilen: ";
                }
            }
            
            InitializeComboBox();

            InitializeVariables();

            InitializeSheets();

            RandomLotto();

            DrawLoto();

            profitLabel.Text = (profit - Convert.ToInt32(betText.Text)).ToString();
        }

        private void InitializeSheets()
        {
            #region Prepare Sheets and Kolons
            sheets = new Sheet[sheetAmount];

            for (int i = 0; i < sheetAmount; i++) {
                sheets[i] = new Sheet();

                for (int j = 0; j < 8; j++) {
                    sheets[i].Kolons[j] = new Kolon();
                }
            }
            //Fill all sheets and all kolons with random values
            for (int m = 0; m < sheetAmount; m++) {
                for (var i = 0; i < 8; i++) {
                    for (var j = 0; j < 6; j++) {
                        sheets[m].Kolons[i].numbers[j] = random.Next(1, 10);
                    }
                }
            }
                #endregion
        }

        private void RandomLotto()
        {
            // Draw a random lotto
            bool available = true;
            for (int i = 0; i < randomDraw.Length; i++)
            {
                int number = random.Next(1, 10);
                for (int j = 0; j < i; j++)
                {
                    if (randomDraw[j] == number)
                    {
                        available = false;
                        j--;
                        break;
                    }
                    else available = true;
                }
                if (available)
                {
                    randomDraw[i] = number;
                }
            }
        }

        private void DrawLoto()
        {
            //Compare our sheets and randoms
            for (int sheetIndex = 0; sheetIndex < sheetAmount; sheetIndex++)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (randomDraw[j] == sheets[sheetIndex].Kolons[i].numbers[j])
                        {
                            streak++;
                        }
                    }
                    if (streak >= 3) {
                        switch (streak) {
                            case 3:
                                ucBilen++;
                                profit += 11;
                                break;
                            case 4:
                                dortBilen++;
                                profit += 70;
                                break;
                            case 5:
                                besBilen++;
                                profit += 5000;
                                break;
                            case 6:
                                altiBilen++;
                                profit += 4000000;
                                break;
                        }
                    }
                    foreach (Control control in Controls)
                    {
                        if (control is Label && control.Name.StartsWith("bilen" + streak.ToString()))
                        {
                            if (streak == 3)
                            {
                                control.Text = streak + " Bilen: ";
                                control.Text = control.Text + ucBilen.ToString();
                            }
                            else if (streak == 4)
                            {
                                control.Text = streak + " Bilen: ";
                                control.Text = control.Text + dortBilen.ToString();
                            } else if (streak == 5) {
                                control.Text = streak + " Bilen: ";
                                control.Text = control.Text + besBilen.ToString();
                            } else if (streak == 6) {
                                control.Text = streak + " Bilen: ";
                                control.Text = control.Text + altiBilen.ToString();
                            }
                        }
                    }
                    streak = 0;
                }
            }
        }

        private Drawn drawnForm;
        private void button1_Click(object sender, EventArgs e) {
            try {
                drawnForm.Close();

            } catch  {
            }
            drawnForm = new Drawn(randomDraw);
            drawnForm.Show();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    dataGridView1[j, i].Value = sheets[comboBox1.SelectedIndex].Kolons[i].numbers[j];
                    if ((int) dataGridView1[j, i].Value == randomDraw[j])
                        dataGridView1[j, i].Style.BackColor = Color.CornflowerBlue;
                    else dataGridView1[j, i].Style.BackColor = Color.White;
                }
            }
        }
    }
}
