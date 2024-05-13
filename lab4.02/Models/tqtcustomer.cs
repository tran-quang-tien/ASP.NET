using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab4_02.Models
{
    public class tqtcustomer
    {
        public string CustomerId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Balance { get; set; }
    }

    public interface ICustomerRepository
    {
        IList<tqtcustomer> GetCustomers();
        tqtcustomer GetCustomer(string customerId);
        void AddCustomer(tqtcustomer cus);
        void UpdateCustomer(tqtcustomer cus);
        IList<tqtcustomer> SearchCustomer(string name);
        void DeleteCustomer(tqtcustomer cus);
    }

    public class CustomerRepository : ICustomerRepository
    {
        static readonly List<tqtcustomer> data = new List<tqtcustomer>()
        {
            new tqtcustomer()
            {
                CustomerId = "KH001",
                FullName = "Trịnh Văn Chung",
                Address = "Hà Nội",
                Email = "devmaster.founder@gmail.com",
                Phone = "0978.611.889",
                Balance = 15200000
            },
            new tqtcustomer()
            {
                CustomerId = "KH002",
                FullName = "Đỗ Thị Cúc",
                Address = "Hà Nội",
                Email = "cucdt@gmail.com",
                Phone = "0986.767.444",
                Balance = 2200000
            },
            new tqtcustomer()
            {
                CustomerId = "KH003",
                FullName = "Nguyễn Tuấn Thắng",
                Address = "Nam Định",
                Email = "thangnt@gmail.com",
                Phone = "0924.656.542",
                Balance = 1200000
            },
            new tqtcustomer()
            {
                CustomerId = "KH004",
                FullName = "Lê Ngọc Hải",
                Address = "Hà Nội",
                Email = "hailn@gmail.com",
                Phone = "0996.555.267",
                Balance = 6200000
            }
        };

        public IList<tqtcustomer> GetCustomers()
        {
            return data;
        }

        public IList<tqtcustomer> SearchCustomer(string name)
        {
            return data.Where(c => c.FullName.EndsWith(name)).ToList();
        }

        public tqtcustomer GetCustomer(string customerId)
        {
            return data.FirstOrDefault(c => c.CustomerId.Equals(customerId));
        }

        public void AddCustomer(tqtcustomer cus)
        {
            data.Add(cus);
        }

        public void UpdateCustomer(tqtcustomer cus)
        {
            var customer = data.FirstOrDefault(c => c.CustomerId.Equals(cus.CustomerId));
            if (customer != null)
            {
                customer.FullName = cus.FullName;
                customer.Address = cus.Address;
                customer.Email = cus.Email;
                customer.Phone = cus.Phone;
                customer.Balance = cus.Balance;
            }
        }

        public void DeleteCustomer(tqtcustomer cus)
        {
            data.Remove(cus);
        }
    }
}