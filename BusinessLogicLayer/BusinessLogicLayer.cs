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
                return DAL.Get();
            } catch {
                throw;
            }
        }

        public DataTable GetBallStats(string ballNo) {
            try {
                DAL dal = new DAL();
                return dal.GetBallStats(ballNo);
            } catch {
                throw;
            }
        }

        public DataTable GetSeasonStats(string season) {
            try {
                DAL dal = new DAL();
                return dal.GetSeasonStats(season);
            } catch  {
                
                throw;
            }
        }
    }
}
