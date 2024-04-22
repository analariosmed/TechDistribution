using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechDistribution.BLL;
using TechDistribution.DAL;

namespace TechDistribution.DAL
{
    /// <summary>
    /// Handles database operations related to employees.
    /// </summary>
    public class EmployeeDB
    {
        /// <summary>
        /// Rolls back a SQL transaction.
        /// </summary>
        /// <param name="transaction">The SQL transaction to roll back.</param>
        private static void RollBack(SqlTransaction transaction)
        {
            transaction.Rollback();
        }

        /// <summary>
        /// Adds a new employee to the database.
        /// </summary>
        /// <param name="emp">The employee object to add.</param>
        /// <returns>True if the employee was added successfully, otherwise false.</returns>
        public static bool AddEmployee(Employee emp)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Employees(FirstName, LastName, Email, PhoneNumber, StatusId, JobId) " +
                                  "VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @StatusId, @JobId);";

                cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
                cmd.Parameters.AddWithValue("@LastName", emp.LastName);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", emp.PhoneNumber);
                cmd.Parameters.AddWithValue("@StatusId", emp.StatusId);
                cmd.Parameters.AddWithValue("@JobId", emp.JobId);

                cmd.ExecuteNonQuery();
            }
            catch (Exception en)
            {
                MessageBox.Show(en.ToString());
                return false;
            }

            conn.Close();
            return true;
        }

        /// <summary>
        /// Retrieves a list of all employees with complete information from the database.
        /// </summary>
        /// <returns>A list of all employees with complete information.</returns>
        public static List<Employee> GetEmployeesComplete()
        {
            List<Employee> listE = new List<Employee>();
            SqlConnection conn = UtilityDB.GetDBConnection();

            SqlCommand cmd = new SqlCommand("SELECT EmployeeId, FirstName, LastName, Email, PhoneNumber, e.StatusId, StatusDesc, e.JobId, JobTitle " +
                                             "FROM Employees e, Status s, Jobs j " +
                                             "WHERE e.StatusId = s.StatusId AND e.JobId = j.JobId;", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee emp;

            while (reader.Read())
            {
                emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                emp.FirstName = reader["FirstName"].ToString();
                emp.LastName = reader["LastName"].ToString();
                emp.Email = reader["Email"].ToString();
                emp.PhoneNumber = reader["PhoneNumber"].ToString();
                emp.StatusId = Convert.ToInt32(reader["StatusId"]);
                emp.StatusDesc = reader["StatusDesc"].ToString();
                emp.JobId = Convert.ToInt32(reader["JobId"]);
                emp.JobTitle = reader["JobTitle"].ToString();
                listE.Add(emp);
            }

            conn.Close();
            return listE;
        }

        /// <summary>
        /// Retrieves an employee from the database by their ID.
        /// </summary>
        /// <param name="id">The ID of the employee to retrieve.</param>
        /// <returns>The employee object.</returns>
        public static Employee GetEmployeeByID(int id)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            try
            {
                SqlCommand cmdSearch = new SqlCommand();
                cmdSearch.Connection = conn;
                cmdSearch.CommandText = "SELECT EmployeeId, FirstName, LastName, Email, PhoneNumber, StatusDesc, JobTitle " +
                                        "FROM Employees e, Status s, Jobs j " +
                                        "WHERE EmployeeId = @EmployeeId AND e.StatusId = s.StatusId AND e.JobId = j.JobId;";
                cmdSearch.Parameters.AddWithValue("@EmployeeId", id);
                SqlDataReader reader = cmdSearch.ExecuteReader();

                reader.Read();
                Employee emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                emp.FirstName = reader["FirstName"].ToString();
                emp.LastName = reader["LastName"].ToString();
                emp.Email = reader["Email"].ToString();
                emp.PhoneNumber = reader["PhoneNumber"].ToString();
                emp.StatusDesc = reader["StatusDesc"].ToString();
                emp.JobTitle = reader["JobTitle"].ToString();

                return emp;
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

        /// <summary>
        /// Updates an existing employee in the database.
        /// </summary>
        /// <param name="emp">The updated employee object.</param>
        public static void UpdateEmployee(Employee emp)
        {
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE Employees " +
                                  "SET FirstName = @FirstName, " +
                                  "LastName = @LastName, " +
                                  "Email = @Email, " +
                                  "PhoneNumber = @PhoneNumber, " +
                                  "StatusId = @StatusId, " +
                                  "JobId = @JobId " +
                                  "WHERE EmployeeId = @EmployeeId;";

                cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
                cmd.Parameters.AddWithValue("@LastName", emp.LastName);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@PhoneNumber", emp.PhoneNumber);
                cmd.Parameters.AddWithValue("@StatusId", emp.StatusId);
                cmd.Parameters.AddWithValue("@JobId", emp.JobId);
                cmd.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    return;
                }
            }
        }

        // Other methods for searching, checking existence, and deleting employees are also present in this class.

        /// <summary>
        /// Searches for an employee by their ID.
        /// </summary>
        /// <param name="employeeId">The ID of the employee to search for.</param>
        /// <returns>The employee object if found, otherwise null.</returns>
        public static Employee SearchEmployee(int employeeId)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            try
            {
                SqlCommand cmdSearch = new SqlCommand();
                cmdSearch.Connection = conn;
                cmdSearch.CommandText = "SELECT * FROM Employees " +
                                        "WHERE EmployeeId=@EmployeeId";
                cmdSearch.Parameters.AddWithValue("@EmployeeId", employeeId);
                SqlDataReader reader = cmdSearch.ExecuteReader();

                reader.Read();
                Employee employee = new Employee();
                employee.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                employee.FirstName = reader["FirstName"].ToString();
                employee.LastName = reader["LastName"].ToString();
                employee.Email = reader["Email"].ToString();

                return employee;
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

        /// <summary>
        /// Checks if an employee with the given ID exists in the database.
        /// </summary>
        /// <param name="employeeId">The ID of the employee to check.</param>
        /// <returns>True if the employee exists, otherwise false.</returns>
        public static bool IsAnExistingEmployee(int employeeId)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdFind = new SqlCommand("SELECT * FROM Employees WHERE EmployeeId = @EmployeeId", conn);
            cmdFind.Parameters.AddWithValue("@EmployeeId", employeeId);

            SqlDataReader reader = cmdFind.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                conn.Close();
                return true;
            }
            else
            {
                reader.Close();
                conn.Close();
                return false;
            }
        }

        /// <summary>
        /// Modifies details of an existing employee in the database.
        /// </summary>
        /// <param name="employeeUpdated">The updated employee object.</param>
        public static void ModifyEmployee(Employee employeeUpdated)
        {
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {
                SqlCommand cmdUpdate = new SqlCommand();
                cmdUpdate.Connection = conn;
                cmdUpdate.CommandText = "UPDATE Employees " +
                    "SET FirstName=@FirstName, " +
                         "LastName=@LastName, " +
                         "Email=@Email " +
                         "WHERE EmployeeId = @EmployeeId ";
                cmdUpdate.Parameters.AddWithValue("@EmployeeId", employeeUpdated.EmployeeId);
                cmdUpdate.Parameters.AddWithValue("@FirstName", employeeUpdated.FirstName);
                cmdUpdate.Parameters.AddWithValue("@LastName", employeeUpdated.LastName);
                cmdUpdate.Parameters.AddWithValue("@Email", employeeUpdated.Email);
                cmdUpdate.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Deletes an employee from the database by their ID.
        /// </summary>
        /// <param name="employeeId">The ID of the employee to delete.</param>
        public static void DeleteEmployee(int employeeId)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            try
            {
                SqlCommand cmdDelete = new SqlCommand();
                cmdDelete.Connection = conn;
                cmdDelete.CommandText = "DELETE Employees " +
                                        "WHERE EmployeeId = @EmployeeId";
                cmdDelete.Parameters.AddWithValue("@EmployeeId", employeeId);
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
