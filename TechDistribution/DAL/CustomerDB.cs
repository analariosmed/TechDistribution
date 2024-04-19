using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDistribution.BLL;

namespace TechDistribution.DAL
{
    public class CustomerDB
    {
        public static List<Customer> GetAllRecords()
        {
            List<Customer> listS = new List<Customer>();
            SqlConnection conn = UtilityDB.GetDBConnection();
            //Students table
            SqlCommand cmdSelectAll = new SqlCommand("SELECT * FROM Customers", conn);
            SqlDataReader reader = cmdSelectAll.ExecuteReader();
            Customer customer;
            while (reader.Read())
            {
                customer = new Customer();
                customer.CustomerId = Convert.ToInt32(reader["CustomerID"]);
                customer.CustomerName = reader["CustomerName"].ToString();
                customer.Street = reader["Street"].ToString();
                customer.City = reader["City"].ToString();
                customer.PostalCode = reader["PostalCode"].ToString();
                customer.PhoneNumber = reader["PhoneNumber"].ToString();
                customer.FaxNumber = reader["FaxNumber"].ToString();
                customer.CreditLimit = Convert.ToDecimal(reader["CreditLimit"]);


                listS.Add(customer);
            }
            conn.Close();
            return listS;

        }


    }
}

