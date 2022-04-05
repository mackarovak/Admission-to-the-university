using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veryhelpfulsystem
{
    public class studente
    {
        public int ID { get; set; }
        public string FIO { get; set; }
        public string adres { get; set; }
        public int EGE { get; set; }
        public int progressballs { get; set; }
        public string consent { get; set; }
        public studente (int ID,string FIO, string adres, int EGE, int progressballs, string consent)
        {
            this.ID = ID;
            this.FIO = FIO;
            this.adres = adres;
            this.EGE = EGE;
            this.progressballs = progressballs;
            this.consent = consent;
        }
    }
}
