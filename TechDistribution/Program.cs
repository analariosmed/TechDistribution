using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechDistribution.GUI;
using TechDistribution.BLL;

namespace TechDistribution
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //using (TechDistributionEntities db = new TechDistributionEntities())
            //{
            //   foreach (var item in db.Items.ToList())
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //}
                Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BookForm(new Form()));
        }
    }
}
