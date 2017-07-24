namespace LotoStatistics {
    partial class Form1 {
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.showBallsButton = new System.Windows.Forms.Button();
            this.ballsComboBox = new System.Windows.Forms.ComboBox();
            this.ballGroupBox = new System.Windows.Forms.GroupBox();
            this.showSeasonButton = new System.Windows.Forms.Button();
            this.seasonsComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.ballGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(351, 290);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // showBallsButton
            // 
            this.showBallsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.showBallsButton.Location = new System.Drawing.Point(6, 57);
            this.showBallsButton.Name = "showBallsButton";
            this.showBallsButton.Size = new System.Drawing.Size(121, 35);
            this.showBallsButton.TabIndex = 1;
            this.showBallsButton.Text = "Show Ball Stats";
            this.showBallsButton.UseVisualStyleBackColor = true;
            this.showBallsButton.Click += new System.EventHandler(this.ballButton_Click);
            // 
            // ballsComboBox
            // 
            this.ballsComboBox.FormattingEnabled = true;
            this.ballsComboBox.Items.AddRange(new object[] {
            "TOP1",
            "TOP2",
            "TOP3",
            "TOP4",
            "TOP5",
            "TOP6"});
            this.ballsComboBox.Location = new System.Drawing.Point(6, 25);
            this.ballsComboBox.Name = "ballsComboBox";
            this.ballsComboBox.Size = new System.Drawing.Size(121, 26);
            this.ballsComboBox.TabIndex = 2;
            this.ballsComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ballsComboBox_KeyPress);
            // 
            // ballGroupBox
            // 
            this.ballGroupBox.AutoSize = true;
            this.ballGroupBox.BackColor = System.Drawing.Color.Bisque;
            this.ballGroupBox.Controls.Add(this.ballsComboBox);
            this.ballGroupBox.Controls.Add(this.showBallsButton);
            this.ballGroupBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ballGroupBox.Location = new System.Drawing.Point(369, 12);
            this.ballGroupBox.Name = "ballGroupBox";
            this.ballGroupBox.Size = new System.Drawing.Size(148, 117);
            this.ballGroupBox.TabIndex = 3;
            this.ballGroupBox.TabStop = false;
            this.ballGroupBox.Text = "Ball";
            // 
            // showSeasonButton
            // 
            this.showSeasonButton.Location = new System.Drawing.Point(6, 57);
            this.showSeasonButton.Name = "showSeasonButton";
            this.showSeasonButton.Size = new System.Drawing.Size(121, 48);
            this.showSeasonButton.TabIndex = 4;
            this.showSeasonButton.Text = "Show Season Stats";
            this.showSeasonButton.UseVisualStyleBackColor = true;
            this.showSeasonButton.Click += new System.EventHandler(this.showSeasonButton_Click);
            // 
            // seasonsComboBox
            // 
            this.seasonsComboBox.FormattingEnabled = true;
            this.seasonsComboBox.Items.AddRange(new object[] {
            "Spring",
            "Summer",
            "Fall",
            "Winter"});
            this.seasonsComboBox.Location = new System.Drawing.Point(6, 22);
            this.seasonsComboBox.Name = "seasonsComboBox";
            this.seasonsComboBox.Size = new System.Drawing.Size(121, 26);
            this.seasonsComboBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.seasonsComboBox);
            this.groupBox1.Controls.Add(this.showSeasonButton);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(369, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seasons";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(627, 37);
            this.progressBar1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(651, 464);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ballGroupBox);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.Text = "Loto Statistic";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ballGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showBallsButton;
        public System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.ComboBox ballsComboBox;
        private System.Windows.Forms.GroupBox ballGroupBox;
        private System.Windows.Forms.Button showSeasonButton;
        private System.Windows.Forms.ComboBox seasonsComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ProgressBar progressBar1;
    }
}

