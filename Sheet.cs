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
        public Kolon[] kolon {
            get;
            set;
        }

        public int price { get; set; }

        public Sheet(Kolon[] _kolon)
        {
            kolon = _kolon;
        }
    }
}
