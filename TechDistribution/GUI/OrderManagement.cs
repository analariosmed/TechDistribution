using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechDistribution.BLL;
using TechDistribution.DAL;

namespace TechDistribution.GUI
{
    public partial class OrderManagement : Form
    {

        List<OrderItem> orderItems = new List<OrderItem>();
        Form prevForm;
        public OrderManagement(Form prevForm)
        {
            this.prevForm = prevForm;
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
         
            foreach (Customer ctm in CustomerDB.GetAllRecords())
            {
                comboBoxCustomer.Items.Add(ctm.CustomerId + "," + ctm.CustomerName);
            }

            comboBoxBook.Items.Clear();
          
            BookRepository bookRepository = new BookRepository(new TechDistributionEntities());
            foreach (Book book1 in bookRepository.GetBooks())
            {
                comboBoxBook.Items.Add(book1.ISBN + "," + book1.Title);
            }

        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            //string input = comboBoxCustomer.Text.Trim();
            //string[] field = input.Split(',');
            //int customerId = Convert.ToInt32(field[0]);

            //string input2 = comboBoxBook.Text.Trim();
            //string[] field2 = input2.Split(',');
            //int bookId = Convert.ToInt32(field2[0]);

            //Order order = new Order();
            //order.CustomerId = customerId;
            //order.BookId = bookId;
            //order.OrderDate = Convert.ToDateTime(maskedTextBoxDate);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

           
            string input = comboBoxBook.Text.Trim();
            string[] field = input.Split(',');
            string ISBN = field[0];
            string Title = field[1];
            OrderItemController orderItemController = new OrderItemController();
            OrderItem orderItem = new OrderItem();
            orderItem.ISBN = ISBN;
            //  orderItem.Title = Title;
            try
            {
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

        private void buttonDelet_Click(object sender, EventArgs e)
        {
            //string input = comboBoxBook.Text.Trim();
            //string[] field = input.Split(',');
            //string ISBN = field[0];

            //OrderItem orderItem = new OrderItem();
            //orderItem.ISBN = ISBN;
            //orderItem.Quantity = Convert.ToInt32(textBoxQuantity.Text);
            //orderItem.DeleteOrderItem(orderItem);



        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close this window?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);



            if (result == DialogResult.Yes)
            {
                prevForm.Show();
                Close();
            }
        }

        private void buttonExit2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close this window?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);



            if (result == DialogResult.Yes)
            {
                prevForm.Show();
                Close();
            }
        }
    }
}
