﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechDistribution.BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TechDistribution.DAL
{
    public class UserDB
    {
        private static void RollBack(SqlTransaction transaction)
        {
            transaction.Rollback();
        }


        public static bool CreateUserAccount(User user)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();

            try
            {

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;

                cmd.CommandText = "INSERT INTO UserAccounts(Password, EmployeeId) " +
                                  "VALUES (@Password, @EmployeeId);";

                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@EmployeeId", user.EmployeeId);


                cmd.ExecuteNonQuery();
            }
            catch (Exception en)
            {
                MessageBox.Show(en.ToString());
                return false;
            }
            finally { 
                conn.Close();
            }
            return true;
        }


        public static List<User> GetAllUsers()
        {
            
            List<User> listU = new List<User>();
            SqlConnection conn = UtilityDB.GetDBConnection();

            SqlCommand cmd = new SqlCommand("SELECT UA.UserId, E.FirstName, E.LastName, UA.DateCreated, UA.DateModified,  E.JobId, J.JobTitle " +
                                "FROM UserAccounts UA " +
                                "INNER JOIN Employees E ON UA.EmployeeId = E.EmployeeId " +
                                "LEFT OUTER JOIN Jobs J ON E.JobId = J.JobId;", conn);

            try
            {
                conn.Close();
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User
                    {
                        UserId = Convert.ToInt32(reader["UserId"]),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        DateCreated = reader["DateCreated"].ToString(),
                        DateModified = reader["DateModified"].ToString(),
                        JobId = Convert.ToInt32(reader["JobId"]),
                        JobTitle = reader["JobTitle"].ToString()
                    };

                    listU.Add(user);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return listU;
        }


       

        public static bool UpdateUser(User user)
        {
            using (SqlConnection conn = UtilityDB.GetDBConnection())
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "UPDATE UserAccounts " +
                                  "SET Password = @Password " +
                                  "WHERE UserId = @UserId;";

                cmd.Parameters.AddWithValue("@UserId", user.UserId);
                cmd.Parameters.AddWithValue("@Password", user.Password);


                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    Console.WriteLine("Error updating your new password!" + e.Message);
                    return false;
                }
            }
        }



        public static void DeleteUser(int userId)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            try
            {
                SqlCommand cmdDelete = new SqlCommand();
                cmdDelete.Connection = conn;
                cmdDelete.CommandText = "DELETE UserAccounts " +
                                        "WHERE UserId = @UserId";
                cmdDelete.Parameters.AddWithValue("@UserId", userId);
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

        public static User SearchUser(int userId)
        {

            SqlConnection conn = UtilityDB.GetDBConnection();

            SqlCommand cmd = new SqlCommand("SELECT UA.UserId, E.FirstName, E.LastName, UA.DateCreated, UA.DateModified, E.JobId, J.JobTitle " +
                                 "FROM UserAccounts UA " +
                                 "INNER JOIN Employees E ON UA.EmployeeId = E.EmployeeId " +
                                 "LEFT OUTER JOIN  Jobs J ON E.JobId = J.JobId " +
                                 "WHERE UA.UserId = @UserId;", conn);

            cmd.Parameters.AddWithValue("@UserId", userId); // Add UserId parameter

            try
            {
                conn.Close();
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User
                    {
                        UserId = Convert.ToInt32(reader["UserId"]),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        DateCreated = reader["DateCreated"].ToString(),
                        DateModified = reader["DateModified"].ToString(),
                        JobId = Convert.ToInt32(reader["JobId"]),
                        JobTitle = reader["JobTitle"].ToString()
                    };

                    return user;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;

        }

        public static User SearchUserByUserId(int userId)
        {

            SqlConnection conn = UtilityDB.GetDBConnection();

            SqlCommand cmd = new SqlCommand("SELECT UserId, Password, EmployeeId " +
                                "FROM UserAccounts " +
                                 "WHERE UserId = @UserId;", conn);

            cmd.Parameters.AddWithValue("@UserId", userId); // Add UserId parameter

            try
            {
                conn.Close();
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User
                    {
                        UserId = Convert.ToInt32(reader["UserId"]),
                        Password = reader["Password"].ToString(),
                        EmployeeId = Convert.ToInt32(reader["EmployeeId"]),
                    };

                    return user;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;

        }

        public static User SearchUserByEmployeeId(int employeeId)
        {

            SqlConnection conn = UtilityDB.GetDBConnection();

            SqlCommand cmd = new SqlCommand("SELECT UA.UserId, E.FirstName, E.LastName, UA.DateCreated " +
                             "FROM UserAccounts UA " +
                             "INNER JOIN Employees E ON UA.EmployeeId = E.EmployeeId " +
                             "LEFT OUTER JOIN Jobs J ON E.JobId = J.JobId " +
                             "WHERE UA.EmployeeId = @EmployeeId;", conn);

            cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

            try
            {
                conn.Close();
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User
                    {
                        UserId = Convert.ToInt32(reader["UserId"]),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        DateCreated = reader["DateCreated"].ToString(),
                    };

                    return user;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

    }


 }


