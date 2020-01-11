using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class HostingUnit
    {
        public static int HostingUnitKey// מספר מזהה של יחידת האירוח
        {
            get { return HostingUnitKey; }
            set { HostingUnitKey = 100000000 + 1; }
        }
        Host Owner;
        int nomberOfPersons;
        string area;
        int numOfRooms;
        bool pool;
        string type;
        string HostingUnitName { get; set; }
        // Creates an initialized boolean matrix in FALSE:
        bool[,] Diary = new bool[12, 31];
    }
}
