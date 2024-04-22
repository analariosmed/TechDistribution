using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechDistribution.BLL;
using TechDistribution.DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TechDistribution.GUI
{
    public partial class OrderManagement : Form
    {

        HashSet<OrderItem> orderItems = new HashSet<OrderItem>();
        TechDistributionEntities context = new TechDistributionEntities();
        public OrderManagement()
        {
            InitializeComponent();
        }

        private void buttonListAll_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {
            comboBoxCustomer.Items.Clear();
            comboBoxCustomer2.Items.Clear();

            foreach (Customer ctm in CustomerDB.GetAllRecords())
            {
                comboBoxCustomer.Items.Add(ctm.CustomerId + "," + ctm.CustomerName);
                comboBoxCustomer2.Items.Add(ctm.CustomerId + "," + ctm.CustomerName);
            }

            comboBoxBook.Items.Clear();
          
            BookRepository bookRepository = new BookRepository(context);
            foreach (Book book1 in bookRepository.GetBooks())
            {
                comboBoxBook.Items.Add(book1.ISBN + "," + book1.Title);
                comboBoxBook2.Items.Add(book1.ISBN + "," + book1.Title);
            }
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            

            OrderRepository orderRepo = new OrderRepository(context);
            StatusRepository statusRepository = new StatusRepository(context);
            Order order = new Order();
            OrderItemRepository orderItemRepository = new OrderItemRepository(context);

            try
            {
                string input = comboBoxStatus.Text.Trim();
                order.Status1 = statusRepository.GetStatusByDesc(input);
                order.OrderType = comboBox1.Text;
                order.OrderDate = Convert.ToDateTime(maskedTextBoxDate.Text);
                order.CustomerID = Convert.ToInt32(comboBoxCustomer.Text.Split(',')[0]);
                order.PhoneNumber = textBoxPhone.Text;
                order.Email = textBoxEmail.Text;
                order.Fax = textBoxFax.Text;
                order.TotalPayment = Convert.ToDecimal(textBox9.Text);
                order.PaymentMethod = "Direct Withdrawal";
                order.OrderItems = orderItems.ToList();
                Console.WriteLine("Order : " + order.ToString() + order.OrderID);
                listView2.Items.Clear();
                foreach (OrderItem orderIt in orderItems.ToList())
                {
                    Console.WriteLine("orderItem : " + orderIt.ToString() + orderIt.ISBN);
                    ListViewItem row = new ListViewItem(orderIt.ISBN);
                    row.SubItems.Add(orderIt.Quantity.ToString());
                    listView2.Items.Add(row);
                    orderItemRepository.AddOrderItemWithoutSave(orderIt);
                }
                orderRepo.AddOrder(order);
                MessageBox.Show("Order created successfully");

                
            }
            catch (DbEntityValidationException ee)
            {
                foreach (var eve in ee.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error while creating the order: " + ex);
            }



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {



        }

        private void buttonDelet_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonAmount_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                string input = comboBoxBook.Text.Trim();
                string[] field = input.Split(',');
                string ISBN = field[0];
                string Title = field[1];
                OrderItemController orderItemController = new OrderItemController();
                OrderItem orderItem = new OrderItem();
                orderItem.ISBN = ISBN;
                //  orderItem.Title = Title;
                orderItem.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                orderItems.Add(orderItem);

                listView2.Items.Clear();
                foreach (OrderItem orderIt in orderItems)
                {
                    ListViewItem row = new ListViewItem(orderIt.ISBN);
                    row.SubItems.Add(orderIt.Quantity.ToString());
                    listView2.Items.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid quantity");
            }
            // orderItemController.AddOrderItem(orderItem);

        }

        private void buttonAmount_Click_1(object sender, EventArgs e)
        {

            string input = comboBoxBook.Text.Trim();
            OrderItemController orderItemController = new OrderItemController();
            BookRepository bookRepository = new BookRepository(context);
            try
            {
                decimal totalAmount = 0;
                foreach (OrderItem orderIt in orderItems)
                {

                    Book bookFound = bookRepository.GetBookByISBN(orderIt.ISBN);
                    decimal amount = bookFound.UnitPrice ?? 0;
                    totalAmount = totalAmount + (amount * orderIt.Quantity ?? 0);
                    textBox9.Text = totalAmount.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not calculate the total amount: " + ex);
            }
        }

        private void buttonDelet_Click_1(object sender, EventArgs e)
        {
            //string input = comboBoxBook.Text.Trim();
            //string[] field = input.Split(',');
            //string ISBN = field[0];

            //OrderItem orderItem = new OrderItem();
            //orderItem.ISBN = ISBN;
            //orderItem.Quantity = Convert.ToInt32(textBoxQuantity.Text);
            //orderItem.DeleteOrderItem(orderItem);

            string input = comboBoxBook.Text.Trim();
            string[] field = input.Split(',');
            string ISBN = field[0];
            OrderItem orderItem = new OrderItem();
            orderItem.ISBN = ISBN;
            bool found = false;
            try
            {
                listView2.Items.Clear();
                foreach (OrderItem orderIt in orderItems)
                {
                    if (orderIt.ISBN == ISBN)
                    {
                        orderItem = orderIt;
                        found = true;
                    }
                }
                if (found)
                {
                    bool ret = orderItems.Remove(orderItem);
                    if (!ret)
                    {
                        MessageBox.Show("Item not found");
                    }
                }

                foreach (OrderItem orderIt in orderItems)
                {
                    ListViewItem row = new ListViewItem(orderIt.ISBN);
                    row.SubItems.Add(orderIt.Quantity.ToString());
                    listView2.Items.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text = "Error: " + ex);
            }
            textBoxPhone.Clear();
            textBoxEmail.Clear(); ;
            textBoxFax.Clear(); 
            comboBox2.Items.Clear();
            comboBoxStatus.Items.Clear();
         //   textBox8.Text.Clear();
          
        }

        private void buttonHowOrders_Click(object sender, EventArgs e)
        {
            OrderRepository orderRepo = new OrderRepository(context);
            StatusRepository statusRepository = new StatusRepository(context);
            Order order = new Order();
            OrderItemRepository orderItemRepository = new OrderItemRepository(context);

            try
            {
                string input = comboBoxCustomer2.Text.Trim();
                string[] field = input.Split(',');
                int customerId = Convert.ToInt32(field[0]);
                
                listViewDS.Items.Clear();
                foreach (Order orderIt in orderRepo.GetOrderByCustomers(customerId))
                {
                    ListViewItem row = new ListViewItem(orderIt.OrderID.ToString());
                    row.SubItems.Add(orderIt.CustomerID.ToString());
                    row.SubItems.Add(orderIt.OrderDate.ToString());
                    row.SubItems.Add(orderIt.OrderType.ToString());
                    row.SubItems.Add(orderIt.PaymentMethod??"".ToString());
                    row.SubItems.Add(orderIt.TotalPayment.ToString());
                    row.SubItems.Add(orderIt.Email.ToString());
                    row.SubItems.Add(orderIt.PhoneNumber.ToString());
                    row.SubItems.Add(orderIt.Fax.ToString());
                    row.SubItems.Add(orderIt.Status1.StatusDesc.ToString());

                    listViewDS.Items.Add(row);
                }
            }
            catch (DbEntityValidationException ee)
            {
                foreach (var eve in ee.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a customer" );
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            OrderRepository orderRepo = new OrderRepository(context);
            StatusRepository statusRepository = new StatusRepository(context);
            OrderItemRepository orderItemRepository = new OrderItemRepository(context);
            BookRepository bookRepository = new BookRepository(context);

            try
            {
                int input = Convert.ToInt32(textBoxOrderId.Text.Trim());
                Order order = orderRepo.GetOrderByID(input);
                if (order == null)
                {
                    MessageBox.Show("Order not found");
                    return;
                }
                textBoxPhone.Text = order.PhoneNumber;
                textBoxEmail.Text = order.Email;
                textBoxFax.Text = order.Fax;
                comboBox2.Text = order.OrderType;
                comboBoxStatus.Text = order.Status1.StatusDesc;
                textBox8.Text = order.TotalPayment.ToString();
                orderItems = order.OrderItems.ToHashSet();

                listView3.Items.Clear();
                foreach (OrderItem orderIt in order.OrderItems)  //orderItemRepository.GetOrderItemsByOrderId(input))
                {
                    ListViewItem row = new ListViewItem(orderIt.ISBN.ToString());
                    row.SubItems.Add(orderIt.Quantity.ToString());
                    listView3.Items.Add(row);
                }
            }
            catch (DbEntityValidationException ee)
            {
                foreach (var eve in ee.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid Order ID");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string input = comboBoxBook2.Text.Trim();
            string[] field = input.Split(',');
            string ISBN = field[0];
            OrderItem orderItem = new OrderItem();
            orderItem.ISBN = ISBN;
            bool found = false;
            try
            {
                listView3.Items.Clear();
                foreach (OrderItem orderIt in orderItems)
                {
                    if (orderIt.ISBN == ISBN)
                    {
                        orderItem = orderIt;
                        found = true;
                    }
                }
                if (found)
                {
                    bool ret = orderItems.Remove(orderItem);
                    if (!ret)
                    {
                        MessageBox.Show("Item not found");
                    }
                }

                foreach (OrderItem orderIt in orderItems)
                {
                    ListViewItem row = new ListViewItem(orderIt.ISBN);
                    row.SubItems.Add(orderIt.Quantity.ToString());
                    listView3.Items.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text = "Error: " + ex);
            }

        }

        private void buttonUpdateAmount_Click(object sender, EventArgs e)
        {

            string input = comboBoxBook2.Text.Trim();
            BookRepository bookRepository = new BookRepository(context);
            try
            {
                decimal totalAmount = 0;
                foreach (OrderItem orderIt in orderItems)
                {

                    Book bookFound = bookRepository.GetBookByISBN(orderIt.ISBN);
                    decimal amount = bookFound.UnitPrice ?? 0;
                    totalAmount = totalAmount + (amount * orderIt.Quantity ?? 0);
                    textBox8.Text = totalAmount.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not calculate the total amount: "+ ex);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                int input = Convert.ToInt32(textBoxOrderId.Text.Trim());
                OrderRepository orderRepo = new OrderRepository(context);
                orderRepo.DeleteOrder(input);
                MessageBox.Show("Order removed successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not remove the Order: " + ex);
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            try
            {
                int input = Convert.ToInt32(textBoxOrderId.Text.Trim());
                OrderRepository orderRepo = new OrderRepository(context);
                StatusRepository statusRepository = new StatusRepository(context);
                Order order = orderRepo.GetOrderByID(input);
                order.PhoneNumber = textBoxPhone.Text;
                order.Email = textBoxEmail2.Text;
                order.Fax = textBoxFax2.Text;
                order.OrderType = comboBox2.Text;
                order.TotalPayment = Convert.ToDecimal(textBox8.Text);
                order.Status1 = statusRepository.GetStatusByDesc(comboBoxStatus.Text);
                order.OrderItems = orderItems.ToList();
                orderRepo.UpdateOrder(order);
                MessageBox.Show("Order updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not modify the Order: " + ex);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string input = comboBoxBook2.Text.Trim();
                string[] field = input.Split(',');
                string ISBN = field[0];
                string Title = field[1];
                OrderItemController orderItemController = new OrderItemController();
                OrderItem orderItem = new OrderItem();
                orderItem.ISBN = ISBN;
                //  orderItem.Title = Title;
                orderItem.Quantity = Convert.ToInt32(textBoxQunatitySearch.Text);
                orderItems.Add(orderItem);

                listView3.Items.Clear();
                foreach (OrderItem orderIt in orderItems)
                {
                    ListViewItem row = new ListViewItem(orderIt.ISBN);
                    row.SubItems.Add(orderIt.Quantity.ToString());
                    listView3.Items.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid quantity");
            }
            // orderItemController.AddOrderItem(orderItem);

        }

        private void buttonListAll_Click_1(object sender, EventArgs e)
        {
            OrderRepository orderRepo = new OrderRepository(context);
            try
            {
                List<Order> orders = orderRepo.GetOrders();
                listView1.Items.Clear();
                foreach (Order orderIt in orders)  //orderItemRepository.GetOrderItemsByOrderId(input))
                {
                    ListViewItem row = new ListViewItem(orderIt.OrderID.ToString());
                    row.SubItems.Add(orderIt.OrderType.ToString());
                    row.SubItems.Add(orderIt.Email.ToString());
                    row.SubItems.Add(orderIt.Customer.CustomerName.ToString());
                    row.SubItems.Add(orderIt.Fax.ToString());
                    row.SubItems.Add(orderIt.PhoneNumber.ToString());
                    row.SubItems.Add(orderIt.Status1.StatusDesc.ToString());
                    row.SubItems.Add(orderIt.TotalPayment.ToString());
                    listView1.Items.Add(row);
                }
            }
            catch (DbEntityValidationException ee)
            {
                foreach (var eve in ee.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid Order ID");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Login();
            form.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
