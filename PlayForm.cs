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
    public partial class PlayForm: Form {
        Sheet sheet;
        Kolon kolon;

        public PlayForm() {

            InitializeComponent();
        }

        private void PlayForm_Load(object sender, EventArgs e) {
            sheet = new Sheet();
            kolon = new Kolon();
        }

        private void playButton_Click(object sender, EventArgs e) {
            for (int i = 0; i < sheet.Kolon.Length; i++) {
                for (int j = 0; j < sheet.Kolon[i].numbers.Length; j++) {
                }
            }
        }
    }
}
