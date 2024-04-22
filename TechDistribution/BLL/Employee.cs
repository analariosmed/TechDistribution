using TechDistribution.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TechDistribution.BLL
{
    /// <summary>
    /// Represents an Employee entity with properties related to employee information.
    /// </summary>
    public class Employee
    {
        private int employeeId; // Employee ID
        private string firstName; // First name of the employee
        private string lastName; // Last name of the employee
        private string email; // Email address of the employee
        private string phoneNumber; // Phone number of the employee
        private int statusId; // Status ID of the employee
        private string statusDesc; // Description of the employee status
        private int jobId; // Job ID of the employee
        private string jobTitle; // Job title of the employee

        // Getters and setters for properties
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int StatusId { get => statusId; set => statusId = value; }
        public string StatusDesc { get => statusDesc; set => statusDesc = value; }
        public int JobId { get => jobId; set => jobId = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }

        /// <summary>
        /// Default constructor for the Employee class.
        /// </summary>
        public Employee() { }

        /// <summary>
        /// Retrieves a list of all employees with complete details.
        /// </summary>
        /// <returns>A list of Employee objects.</returns>
        public static List<Employee> GetEmployees()
        {
            return EmployeeDB.GetEmployeesComplete();
        }

        /// <summary>
        /// Adds a new employee to the database.
        /// </summary>
        /// <param name="employee">The Employee object to add.</param>
        /// <returns>True if the employee is added successfully, otherwise false.</returns>
        public bool AddEmployee(Employee employee)
        {
            return EmployeeDB.AddEmployee(employee);
        }

        /// <summary>
        /// Searches for an employee by their employee ID.
        /// </summary>
        /// <param name="employeeId">The ID of the employee to search for.</param>
        /// <returns>The Employee object if found, otherwise null.</returns>
        public Employee SearchEmployee(int employeeId)
        {
            return EmployeeDB.SearchEmployee(employeeId);
        }

        /// <summary>
        /// Deletes an employee from the database by their employee ID.
        /// </summary>
        /// <param name="empId">The ID of the employee to delete.</param>
        public static void DeleteEmployee(int empId)
        {
            EmployeeDB.DeleteEmployee(empId);
        }

        /// <summary>
        /// Checks if an employee with the specified employee ID exists in the database.
        /// </summary>
        /// <param name="employeeId">The ID of the employee to check.</param>
        /// <returns>True if the employee exists, otherwise false.</returns>
        public static bool IsAExistingEmployee(int employeeId)
        {
            bool existing = EmployeeDB.IsAnExistingEmployee(employeeId);
            return existing;
        }
        /// <summary>
        /// Searches for employees by their first name.
        /// </summary>
        /// <param name="FirstName">The first name of the employees to search for.</param>
        /// <returns>A list of Employee objects matching the search criteria.</returns>
        public static List<Employee> SearchByFirstName(string FirstName)
        {
            List<Employee> employees = EmployeeDB.GetEmployeesComplete();
            var empFiltered = employees.Where(x => x.firstName.ToLower() == FirstName.ToLower()).ToList();

            return empFiltered;
        }

        /// <summary>
        /// Searches for employees by their last name.
        /// </summary>
        /// <param name="LastName">The last name of the employees to search for.</param>
        /// <returns>A list of Employee objects matching the search criteria.</returns>
        public static List<Employee> SearchByLastName(string LastName)
        {
            List<Employee> empFiltered = EmployeeDB.GetEmployeesComplete().Where(x => x.lastName.ToLower() == LastName.ToLower()).ToList();

            return empFiltered;

        }

        /// <summary>
        /// Searches for employees by their email address.
        /// </summary>
        /// <param name="Email">The email address of the employees to search for.</param>
        /// <returns>A list of Employee objects matching the search criteria.</returns>
        public static List<Employee> SearchByEmail(string Email)
        {
            var empFiltered = EmployeeDB.GetEmployeesComplete().Where(x => x.email == Email).ToList();
            return empFiltered;
        }

        /// <summary>
        /// Searches for employees by their phone number.
        /// </summary>
        /// <param name="PhoneNumber">The phone number of the employees to search for.</param>
        /// <returns>A list of Employee objects matching the search criteria.</returns>

        public static List<Employee> SearchByPhoneNumber(string PhoneNumber)
        {
            var empFiltered = EmployeeDB.GetEmployeesComplete().Where(x => x.phoneNumber == PhoneNumber).ToList();

            return empFiltered;
        }

        /// <summary>
        /// Updates the information of an existing employee in the database.
        /// </summary>
        /// <param name="emp">The Employee object containing the updated information.</param>
        public static void UpdateEmployee(Employee emp)
        {
            EmployeeDB.UpdateEmployee(emp);
        }


    }
}
