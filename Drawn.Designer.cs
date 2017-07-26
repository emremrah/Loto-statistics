namespace LotoStatistics {
    partial class Drawn {
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
            this.drawnDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.drawnDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // drawnDataGrid
            // 
            this.drawnDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drawnDataGrid.Location = new System.Drawing.Point(12, 12);
            this.drawnDataGrid.Name = "drawnDataGrid";
            this.drawnDataGrid.Size = new System.Drawing.Size(586, 378);
            this.drawnDataGrid.TabIndex = 0;
            // 
            // Drawn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 402);
            this.Controls.Add(this.drawnDataGrid);
            this.Name = "Drawn";
            this.Text = "Drawn";
            this.Load += new System.EventHandler(this.Drawn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drawnDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView drawnDataGrid;
    }
}