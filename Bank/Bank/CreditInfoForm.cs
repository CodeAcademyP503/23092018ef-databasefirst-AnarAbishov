using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class CreditInfoForm : Form
    {
        public CreditInfoForm()
        {
            InitializeComponent();
            using (BankDBEntities bankDBEntities = new BankDBEntities())
            {
                string Name = bankDBEntities.Users.ToList().LastOrDefault().Name;
                txbUserName.Text = Name;
                txbUserName.ReadOnly = true;

            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (BankDBEntities bankDBEntities = new BankDBEntities())
            {
                bankDBEntities.CreditInfoes.Add(new CreditInfo()
                {
                    Amount = Convert.ToInt32(txbAmount.Text),
                    DateCredit = DateTime.Now,
                    UserId = bankDBEntities.Users.ToList().LastOrDefault().Id
                });
                bankDBEntities.SaveChanges();
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowAllForm showAllForm = new ShowAllForm();
            showAllForm.ShowDialog();
        }
    }
}
