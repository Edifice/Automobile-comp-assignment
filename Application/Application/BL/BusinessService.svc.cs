using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Application.BL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BusinessService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BusinessService.svc or BusinessService.svc.cs at the Solution Explorer and start debugging.
    public class BusinessService : IBusinessService
    {
        public DataTable GetCarsByVendor(int vendorId)
        {
            var ret = new DataTable();
            ret.Columns.Add("Model");
            ret.Columns.Add("Max Speed");
            ret.Columns.Add("Acceleration");
            ret.Columns.Add("Engine Power");
            ret.Columns.Add("Fuel on Economy");
            ret.Columns.Add("Price");

            using (var db = new AutomobilesEntities())
            {
                var query = from car in db.Automobile
                            where car.vendorId == vendorId
                            orderby car.model
                            //join v in db.Vendor on car.vendorId equals v.Id
                            //select new { car, v.Name } ;
                            select car;

                foreach (var car in query)
                {
                    ret.Rows.Add(
                        car.model,
                        car.maxSpeed.ToString(),
                        car.acceleration.ToString(),
                        car.enginePower.ToString(),
                        car.fuelEconomy.ToString(),
                        car.price.ToString()
                    );
                }
            }

            return ret;
        }

        public SortedList<int, string> GetAllVendor()
        {
            var ret = new SortedList<int, string>();

            using (var db = new AutomobilesEntities())
            {
                var query = from v in db.Vendor
                            orderby v.Name
                            select v;

                foreach (var v in query)
                {
                    ret.Add(v.Id, v.Name);
                }
            }

            return ret;
        }
    }
}
