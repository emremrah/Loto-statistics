using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoStatistics {

    class Sheet {
        public int id {
            get;
            set;
        }
        public Kolon[] Kolon {
            get;
            set;
        }

        public Sheet() {
            Kolon = new Kolon[8];
        }
    }
}
