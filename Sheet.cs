using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoStatistics {

    class Sheet {
        public Kolon[] kolon {
            get;
            set;
        }

        public Sheet(Kolon[] _kolon)
        {
            kolon = _kolon;
        }
    }
}
