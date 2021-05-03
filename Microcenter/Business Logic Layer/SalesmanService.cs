using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcenter.Data_Access_Layer;
using Microcenter.Data_Access_Layer.Entities;

namespace Microcenter.Business_Logic_Layer
{
    class SalesmanService
    {
        SalesmanDataAccess salesmanDataAccess;

        public SalesmanService()
        {
            this.salesmanDataAccess = new SalesmanDataAccess();
        }
        public List<Salesman> GetAllSalesman()
        {
            return this.salesmanDataAccess.GetSalesmans();
        }

        public List<int> GetSalesmansId()
        {
            return this.salesmanDataAccess.GetSalesmansID();
        }

        public int RemoveSalesman(int employeeID)
        {
            return this.salesmanDataAccess.DeleteSalesman(employeeID);

        }

        public int AddNewSalesman(int salesmanSL, decimal unitCount , decimal moneyCount)
        {

            SalesmanDataAccess salesmanDataAccess = new SalesmanDataAccess();

            this.salesmanDataAccess = new SalesmanDataAccess();
            Salesman salesman = new Salesman() { SalesmanSL = salesmanSL, UnitCount = unitCount, MoneyCount = moneyCount};

            return this.salesmanDataAccess.AddSalesman(salesman);
        }

        public int AddSalesmanUM(int sl, int unit,decimal money)
        {
            Salesman salesman = new Salesman() {SalesmanSL = sl, UnitCount = unit,MoneyCount = money};
            return this.salesmanDataAccess.AddUnitMoney(salesman);
        }

        public int GetSalesmanUnit(int id)
        {
            this.salesmanDataAccess = new SalesmanDataAccess();
            return salesmanDataAccess.GetSalesmanUnit(id);
        }

        public decimal GetSalesmanMoney(int id)
        {
            this.salesmanDataAccess = new SalesmanDataAccess();
            return salesmanDataAccess.GetSalesmanMoney(id);
        }

        public int GetMaxUnit()
        {
            return this.salesmanDataAccess.GetMaxUnit();
        }
        public int GetMaxMoney()
        {
            return this.salesmanDataAccess.GetMaxMoney();
        }

        public int GetBestSalesmanCat1(decimal money)
        {
            return this.salesmanDataAccess.GetBestSalesmanCat1(money);
        }
        public int GetBestSalesmanCat2(int unit)
        {
            return this.salesmanDataAccess.GetBestSalesmanCat2(unit);
        }

    }
}
