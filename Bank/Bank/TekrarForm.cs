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
    public partial class TekrarForm : Form
    {
        public TekrarForm()
        {
            InitializeComponent();

           
            
        }

        private void Btn_Go_Click(object sender, EventArgs e)
        {
            using (BankDBEntities bankDBEntities = new BankDBEntities())
            {
                var a = bankDBEntities.Users.ToList();
                foreach (var item in a)
                {
                    if (item.PassportNumber == TxbPassportNumber.Text)
                    {
                        int.TryParse(TxbAmount.Text, out int amount);
                        if (amount!=0)
                        {
                            bankDBEntities.CreditInfoes.Add(new CreditInfo()
                            {
                                Amount = amount,
                                DateCredit = dateTimePickerDateCredit.Value,
                                UserId = item.Id,
                            });
                            bankDBEntities.SaveChanges();

                        }
                        
                    }
                }

            }
        }
    }
}
