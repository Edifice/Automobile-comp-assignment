using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Repository
    {
        private AutomobilesEntities model;
        public Repository()
        {
            model = new AutomobilesEntities();
            
        }

        public List<Vendor> GetVendors()
        {
            return model.Vendor.ToList();
        }

        public List<Automobile> GetAutomobiles()
        {
            return model.Automobile.ToList();
        }
    }
}
