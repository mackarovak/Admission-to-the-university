using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veryhelpfulsystem
{
    public class PeopleFromPrikaz
    {
        public long ID { get; set; }
        public string FIO { get; set; }
        public int EGE { get; set; }
        public PeopleFromPrikaz(long ID, string FIO, int EGE)
        {
            this.ID = ID;
            this.FIO = FIO;
            this.EGE = EGE;
        }
    }
}
