using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microcenter.Data_Access_Layer.Entities;

namespace Microcenter.Data_Access_Layer
{
    class SalesmanDataAccess : DataAccess
    {
        public List<Salesman> GetSalesmans()
        {
            string sql = "SELECT * FROM Salesmans";
            SqlDataReader reader = this.GetData(sql);
            List<Salesman> salesmans = new List<Salesman>();
            while (reader.Read())
            {
                Salesman salesman = new Salesman();
                salesman.SalesmanSL = Convert.ToInt32(reader["SalesmanSL"]);
                salesman.UnitCount = Convert.ToDecimal(reader["UnitCount"]);
                salesman.MoneyCount = Convert.ToDecimal(reader["MoneyCount"]);
                salesmans.Add(salesman);
            }
            return salesmans;
        }


        public List<int> GetSalesmansID()
        {
            string sql = "SELECT SalesmanSL FROM Salesmans";
            SqlDataReader reader = this.GetData(sql);
            List<int> salesmanSL = new List<int>();
            while (reader.Read())
            {
                salesmanSL.Add(Convert.ToInt32(reader["SalesmanSL"]));
            }
            return salesmanSL;
        }

        public int AddSalesman(Salesman salesman)
        {
            string sql = "INSERT INTO Salesmans(SalesmanSL,UnitCount,MoneyCount) VALUES(" + salesman.SalesmanSL + "," + salesman.UnitCount + "," + salesman.MoneyCount + ")";
            return this.ExecuteQuery(sql);
        }

        public int UpdateSalesman(Salesman salesman)
        {
            string sql = "UPDATE Salesmans SET SalesmanSL=" + salesman.SalesmanSL + ",UnitCount=" + salesman.UnitCount + ",MoneyCount=" + salesman.MoneyCount;
            return this.ExecuteQuery(sql);


        }
        public int DeleteSalesman(int employeeId)
        {
            string sql = "DELETE FROM Salesmans WHERE SalesmanSL=" + employeeId;
            return this.ExecuteQuery(sql);
        }

        public int AddUnitMoney(Salesman salesman)
        {
            string sql = "UPDATE Salesmans SET UnitCount=" + salesman.UnitCount + ",MoneyCount=" + salesman.MoneyCount + " WHERE SalesmanSL = " + salesman.SalesmanSL;
            return this.ExecuteQuery(sql);

        }

        public int GetSalesmanUnit(int id)
        {
            string sql = "SELECT UnitCount FROM Salesmans WHERE SalesmanSL=" + id ;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["UnitCount"]); ;
            }
            return -1;
        }

        public int GetSalesmanMoney(int id)
        {
            string sql = "SELECT MoneyCount FROM Salesmans WHERE SalesmanSL=" + id;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["MoneyCount"]); ;
            }
            return -1;
        }

        public int GetMaxUnit()
        {
            string sql = "SELECT MAX(UnitCount) as UnitCount FROM Salesmans";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["UnitCount"]);
            }
            return -1;
        }

        public int GetMaxMoney()
        {
            string sql = "SELECT MAX(MoneyCount) as MoneyCount FROM Salesmans";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["MoneyCount"]);
            }
            return -1;
        }

        public int GetBestSalesmanCat1(decimal money)
        {
            string sql = "SELECT SalesmanSL FROM Salesmans WHERE MoneyCount=" + money;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["SalesmanSL"]); ;
            }
            return -1;
        }

        public int GetBestSalesmanCat2(int unit)
        {
            string sql = "SELECT SalesmanSL FROM Salesmans WHERE UnitCount=" + unit;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["SalesmanSL"]); ;
            }
            return -1;
        }

    }
}
