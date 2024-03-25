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
                customer.Name = reader["CustomerName"].ToString();
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

        public static Customer SearchUser(int customerId)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            try
            {
                SqlCommand cmdSearch = new SqlCommand();
                cmdSearch.Connection = conn;
                cmdSearch.CommandText = "SELECT * FROM Costumers " +
                                        "WHERE CustomerId=@CustomerId";
                cmdSearch.Parameters.AddWithValue("@CustomerId", customerId);
                SqlDataReader reader = cmdSearch.ExecuteReader();

                reader.Read();
                Customer customer = new Customer();
                customer.CustomerId = Convert.ToInt32(reader["StudentId"]);
                customer.Name = reader["CustomerName"].ToString();
                customer.Street = reader["Street"].ToString();
                customer.City = reader["City"].ToString();
                customer.PostalCode = reader["PostalCode"].ToString();
                customer.PhoneNumber = reader["PhoneNumber"].ToString();
                customer.FaxNumber = reader["FaxNumber"].ToString();
                customer.CreditLimit = Convert.ToDecimal(reader["CreditLimit"]);


                return customer;
            }
            catch (SqlException ex)
            {
                throw ex;

            }
            finally
            {
                conn.Close();
            }


        }

        public static void SaveCustomer(Customer customer)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "INSERT INTO Customers (CustomerName,Street,City,PostalCode,PhoneNumber,FaxNumber,CreditLimit)" +
                                     "VALUES(@CustomerName,@Street,@City,@PostalCode,@PhoneNumber,@FaxNumber,@CreditLimit)";


            cmdInsert.Parameters.AddWithValue("@CustomerName", customer.Name);
            cmdInsert.Parameters.AddWithValue("@Street", customer.Street);
            cmdInsert.Parameters.AddWithValue("@City", customer.City);
            cmdInsert.Parameters.AddWithValue("@PostalCode", customer.PostalCode);
            cmdInsert.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
            cmdInsert.Parameters.AddWithValue("@FaxNumber", customer.FaxNumber);
            cmdInsert.Parameters.AddWithValue("@CreditLimit", customer.CreditLimit);




            //write the sequence statement (line to execute)
            cmdInsert.ExecuteNonQuery();
            conn.Close();

        }

        public static bool IsAnExistingCustomer(int customerId)
        {
            List<Customer> listU = new List<Customer>();
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdFind = new SqlCommand("SELECT * FROM Customers WHERE CustomerId = @CustomerId", conn);
            cmdFind.Parameters.AddWithValue("@CustomerId", customerId);

            SqlDataReader reader = cmdFind.ExecuteReader(); //applied to select statement

            Customer customer = new Customer();


            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }

            conn.Close();
        }

        public static void modifyCustomer(Customer customerUpdated)
        {
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {

                SqlCommand cmdUpdate = new SqlCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandText = "UPDATE Customers " +
                    "SET CustomerName=@CustomerName, " +
                         "Street=@Street, " +
                         "City=@City " +
                         "PostalCode=@PostalCode " +
                         "PhoneNumber=@PhoneNumber " +
                         "FaxNumber=@FaxNumber " +
                         "CreditLimit=@CreditLimit " +
                         "WHERE CustomerId = @CustomerId ";
                cmdUpdate.Parameters.AddWithValue("@CustomerId", customerUpdated.CustomerId);
                cmdUpdate.Parameters.AddWithValue("@CustomerName", customerUpdated.Name);
                cmdUpdate.Parameters.AddWithValue("@Street", customerUpdated.Street);
                cmdUpdate.Parameters.AddWithValue("@City", customerUpdated.City);
                cmdUpdate.Parameters.AddWithValue("@PostalCode", customerUpdated.PostalCode);
                cmdUpdate.Parameters.AddWithValue("@PhoneNumber", customerUpdated.PhoneNumber);
                cmdUpdate.Parameters.AddWithValue("@FaxNumber", customerUpdated.FaxNumber);
                cmdUpdate.Parameters.AddWithValue("@CreditLimit", customerUpdated.CreditLimit);



                cmdUpdate.ExecuteNonQuery();

            }
        }

        public static void Delete(int customerId)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            try
            {
                SqlCommand cmdDelete = new SqlCommand();
                cmdDelete.Connection = conn;
                cmdDelete.CommandText = "DELETE Customers " +
                                        "WHERE CustomerId = @CustomerId";
                cmdDelete.Parameters.AddWithValue("@StudentId", customerId);
                cmdDelete.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
