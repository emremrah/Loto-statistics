using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL = LotoStatistics.DataAccessLayer.DataAccessLayer;

namespace LotoStatistics.BusinessLogicLayer {
    class BusinessLogicLayer {
        //DAL = DATA ACCESS LAYER
        //SELECT
        public DataTable Get() {
            try {
                DAL DAL = new DAL();
                return DAL.Read();
            } catch {
                throw;
            }
        }

        public DataTable GetBalls(string ballNo) {
            try {
                DAL dal = new DAL();
                return dal.GetBalls(ballNo);
            } catch {
                throw;
            }
        }
    }
}
