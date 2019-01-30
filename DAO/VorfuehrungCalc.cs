using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public partial class Vorfuehrung
    {
        public long RemainingSeats {
            get
            {
                long remaining = 0;
                if (Saal != null && Buchung != null)
                    remaining = Saal.AnzahlPlaetze - Buchung.Count();
                return remaining;
            }
        }
    }
}
