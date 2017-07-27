namespace LotoStatistics {
    partial class PlayForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.betText = new System.Windows.Forms.TextBox();
            this.kolonPriceLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.sheetAmountLabel = new System.Windows.Forms.Label();
            this.profitLabel = new System.Windows.Forms.Label();
            this.kolonPriceTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bilen3 = new System.Windows.Forms.Label();
            this.bilen4 = new System.Windows.Forms.Label();
            this.bilen5 = new System.Windows.Forms.Label();
            this.bilen6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(589, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // betText
            // 
            this.betText.Location = new System.Drawing.Point(643, 368);
            this.betText.Name = "betText";
            this.betText.Size = new System.Drawing.Size(100, 20);
            this.betText.TabIndex = 9;
            // 
            // kolonPriceLabel
            // 
            this.kolonPriceLabel.AutoSize = true;
            this.kolonPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kolonPriceLabel.Location = new System.Drawing.Point(607, 12);
            this.kolonPriceLabel.Name = "kolonPriceLabel";
            this.kolonPriceLabel.Size = new System.Drawing.Size(86, 16);
            this.kolonPriceLabel.TabIndex = 10;
            this.kolonPriceLabel.Text = "Kolon Fiyatı:  ";
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.playButton.Location = new System.Drawing.Point(643, 394);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(98, 44);
            this.playButton.TabIndex = 11;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // sheetAmountLabel
            // 
            this.sheetAmountLabel.AutoSize = true;
            this.sheetAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sheetAmountLabel.Location = new System.Drawing.Point(607, 44);
            this.sheetAmountLabel.Name = "sheetAmountLabel";
            this.sheetAmountLabel.Size = new System.Drawing.Size(83, 16);
            this.sheetAmountLabel.TabIndex = 19;
            this.sheetAmountLabel.Text = "Form sayısı: ";
            // 
            // profitLabel
            // 
            this.profitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.profitLabel.Location = new System.Drawing.Point(164, 381);
            this.profitLabel.Name = "profitLabel";
            this.profitLabel.Size = new System.Drawing.Size(130, 50);
            this.profitLabel.TabIndex = 20;
            this.profitLabel.Text = "Profit";
            this.profitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kolonPriceTxt
            // 
            this.kolonPriceTxt.Location = new System.Drawing.Point(685, 11);
            this.kolonPriceTxt.Name = "kolonPriceTxt";
            this.kolonPriceTxt.Size = new System.Drawing.Size(30, 20);
            this.kolonPriceTxt.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(541, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 43);
            this.button1.TabIndex = 32;
            this.button1.Text = "Show Randoms";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(607, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bilen3
            // 
            this.bilen3.AutoSize = true;
            this.bilen3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilen3.Location = new System.Drawing.Point(30, 305);
            this.bilen3.Name = "bilen3";
            this.bilen3.Size = new System.Drawing.Size(71, 23);
            this.bilen3.TabIndex = 34;
            this.bilen3.Text = "3 Bilen";
            // 
            // bilen4
            // 
            this.bilen4.AutoSize = true;
            this.bilen4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilen4.Location = new System.Drawing.Point(171, 305);
            this.bilen4.Name = "bilen4";
            this.bilen4.Size = new System.Drawing.Size(71, 23);
            this.bilen4.TabIndex = 35;
            this.bilen4.Text = "4 Bilen";
            // 
            // bilen5
            // 
            this.bilen5.AutoSize = true;
            this.bilen5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilen5.Location = new System.Drawing.Point(312, 305);
            this.bilen5.Name = "bilen5";
            this.bilen5.Size = new System.Drawing.Size(71, 23);
            this.bilen5.TabIndex = 36;
            this.bilen5.Text = "5 Bilen";
            // 
            // bilen6
            // 
            this.bilen6.AutoSize = true;
            this.bilen6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilen6.Location = new System.Drawing.Point(453, 305);
            this.bilen6.Name = "bilen6";
            this.bilen6.Size = new System.Drawing.Size(71, 23);
            this.bilen6.TabIndex = 37;
            this.bilen6.Text = "6 Bilen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(607, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Formu göster";
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bilen6);
            this.Controls.Add(this.bilen5);
            this.Controls.Add(this.bilen4);
            this.Controls.Add(this.bilen3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kolonPriceTxt);
            this.Controls.Add(this.profitLabel);
            this.Controls.Add(this.sheetAmountLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.kolonPriceLabel);
            this.Controls.Add(this.betText);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PlayForm";
            this.Text = "PlayForm";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox betText;
        private System.Windows.Forms.Label kolonPriceLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label sheetAmountLabel;
        private System.Windows.Forms.Label profitLabel;
        private System.Windows.Forms.TextBox kolonPriceTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label bilen3;
        private System.Windows.Forms.Label bilen4;
        private System.Windows.Forms.Label bilen5;
        private System.Windows.Forms.Label bilen6;
        private System.Windows.Forms.Label label1;
    }
}