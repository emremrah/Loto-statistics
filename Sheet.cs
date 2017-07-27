using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoStatistics {

    class Sheet {
        public List<Kolon> Kolons = new List<Kolon>(8);

        public Sheet()
        {
            for (int i = 0; i < 8; i++)
            {
                Kolons.Add(new Kolon());
            }
        }
    }
}
