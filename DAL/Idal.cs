using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    interface Idal
    {
        void AddCustomer(GuestRequest guestRequest); // הוספת דרישת לקוח
        void CustomerRequirementUpdate(GuestRequest guestRequest); // עדכון דרישת לקוח 

        void AddHostingUnit(HostingUnit hostingUnit); // הוספת יחידת אירוח 
        void DeleteHostingUnit(HostingUnit hostingUnit); // מחיקת יחידת אירוח 
        void HostingUnitUpdate(HostingUnit hostingUnit); // עדכון יחידת אירוח 

        void AddInvitation(Order order); // הוספת הזמנה 
        void UpdateInvitation(Order order); // עדכון הזמנה 
        List<HostingUnit> GetListOfAllAccommodationUnits(); // קבלת רשימת כל יחידות האירוח 
        List<GuestRequest> ListAllCustomerRequirements(); // קבלת רשימת כל דרישות הלקוחות 
        List<Order> GetListOfAllInvitations(); // קבלת רשימת כל ההזמנות
        List<BankBranch> GetListOfAllExistingBankBranches(); // קבלת רשימת כל סניפי הבנק הקיימים בארץ 
    }
}
