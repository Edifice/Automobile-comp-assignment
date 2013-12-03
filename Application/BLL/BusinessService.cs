using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BusinessService : IBusinessService
    {
        private Repository rep;

        public BusinessService()
        {
            rep = new Repository();
        }

        public List<AutomobileSerializable> GetAutomobiles()
        {
            List<AutomobileSerializable> tmpList = new List<AutomobileSerializable>();
            foreach (Automobile a in rep.GetAutomobiles())
                tmpList.Add(TranslateAutomobile(a));
            return tmpList;
        }

        public List<VendorSerializable> GetAllVendors()
        {
            List<VendorSerializable> tmpList = new List<VendorSerializable>();
            foreach (Vendor v in rep.GetVendors())
                tmpList.Add(TranslateVendor(v));
            return tmpList;
        }

        private VendorSerializable TranslateVendor(DAL.Vendor oldVendor)
        {
            return new VendorSerializable()
            {
                Id = oldVendor.Id,
                Name = oldVendor.Name
            };
        }

        private AutomobileSerializable TranslateAutomobile(DAL.Automobile oldAutomobile)
        {
            return new AutomobileSerializable()
            {
                id = oldAutomobile.id,
                model = oldAutomobile.model,
                acceleration = Convert.ToDecimal(oldAutomobile.acceleration),
                enginePower = Convert.ToInt32(oldAutomobile.enginePower),
                fuelEconomy = Convert.ToDecimal(oldAutomobile.fuelEconomy),
                maxSpeed = Convert.ToInt32(oldAutomobile.maxSpeed),
                price = Convert.ToDecimal(oldAutomobile.price),
                vendorId = oldAutomobile.vendorId
            };
        }
    }
}
