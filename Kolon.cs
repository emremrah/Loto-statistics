using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoStatistics {
    class Kolon {
        public float bounty {
            get;
            set;
        }
        public int[] numbers {
            get;
            set;
        }
        public float price {
            get;
            set;
        }

        public Kolon() {
            numbers = new int[6];
        }
    }
}
