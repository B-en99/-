using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace DS
{
    class Dal_imp : Idal
    {
        public void AddCustomer(GuestRequest guestRequest)
        {


        }

        public void AddHostingUnit(HostingUnit hostingUnit)
        {
        }

        public void AddInvitation(Order order)
        {
        }

        public void CustomerRequirementUpdate(GuestRequest guestRequest)
        {
        }

        public void DeleteHostingUnit(HostingUnit hostingUnit)
        {
            throw new NotImplementedException();
        }

        public List<HostingUnit> GetListOfAllAccommodationUnits()
        {
            throw new NotImplementedException();
        }

        public List<BankBranch> GetListOfAllExistingBankBranches()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetListOfAllInvitations()
        {
            throw new NotImplementedException();
        }

        public void HostingUnitUpdate(HostingUnit hostingUnit)
        {
        }

        public List<GuestRequest> ListAllCustomerRequirements()
        {
            throw new NotImplementedException();
        }

        public void UpdateInvitation(Order order)
        {
        }
    }
}
