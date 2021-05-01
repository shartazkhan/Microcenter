using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcenter.Data_Access_Layer;
using Microcenter.Data_Access_Layer.Entities;

namespace Microcenter.Business_Logic_Layer
{

    class SaleService
    {
        SalesDataAccess salesDataAccess;

        public SaleService()
        {
            salesDataAccess = new SalesDataAccess();
        }

        public List<Sale> GetAllSales()
        {

            return this.salesDataAccess.GetSales();
        }

    }
}