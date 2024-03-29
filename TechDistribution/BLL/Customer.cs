﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDistribution.DAL;

namespace TechDistribution.BLL
{
    public class Customer
    {
        private int customerId;
        private string name;
        private string street;
        private string city;
        private string postalCode;
        private string phoneNumber;      
        private string faxNumber;
        private decimal creditLimit;


        public Customer() { }


        public Customer(int customerId, string name, string street, string city, string postalCode, string phoneNumber, string faxNumber, decimal creditLimit)
        {
            this.CustomerId = customerId;
            this.Name = name;
            this.Street = street;
            this.City = city;
            this.PostalCode = postalCode;
            this.PhoneNumber = phoneNumber;
            this.FaxNumber = faxNumber;
            this.CreditLimit = creditLimit;
        }

        public int CustomerId { get => customerId; set => customerId = value; }
        public string Name { get => name; set => name = value; }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string FaxNumber { get => faxNumber; set => faxNumber = value; }
        public decimal CreditLimit { get => creditLimit; set => creditLimit = value; }

        public List<Customer> GetCustomers()
        {
            return CustomerDB.GetAllRecords();
        }

    }
}
