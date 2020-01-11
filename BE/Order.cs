using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Order
    {
        int HostingUnitKey { get; set; }

        int GuestRequestKey { get; set; }
        public static int OrderKey// מספר מזהה של ההזמנה
        {
            get { return OrderKey; }
            set { OrderKey = 100000000 + 1; }
        }
        DateTime CreateDate;
        DateTime OrderDate;
    }
}
