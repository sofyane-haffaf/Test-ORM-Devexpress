using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using XpoTutorial1.DataModel;

namespace XpoTutorial1
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            if (xpCollection1.Count == 0)
            {
                var customer1 = new Customer(session1);
                customer1.Name = "John";
                customer1.Age = 21;
                customer1.Save();
                xpCollection1.Add(customer1);
                var customer2 = new Customer(session1);
                customer2.Name = "Bob";
                customer2.Age = 37;
                customer2.Save();
                xpCollection1.Add(customer2);
            }
        }
    }
}