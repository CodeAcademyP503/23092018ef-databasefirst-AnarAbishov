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
    public partial class ShowAllForm : Form
    {
        public ShowAllForm()
        {
            InitializeComponent();
           
            using (BankDBEntities bankDBEntities = new BankDBEntities())
            {
                var us = bankDBEntities.Users.ToList();


                //var cs = bankDBEntities.CreditInfoes.ToList();
                //var t = us.GroupJoin(cs, u => u.Id, c => c.UserId, (u, css) => new
                //{
                //    Name = u.Name,
                //    Amount = css.Sum(x => x.Amount)
                //});
                //dgvAll.DataSource = t.ToList();

               

                var g = us.Select(u => new
                {
                    Name = u.Name,
                    Surname = u.Surname,
                    PasportNumber = u.PassportNumber,
                    Amount = u.CreditInfoes.Sum(c => c.Amount),
                    Data = u.CreditInfoes.Select(x=> x.DateCredit).FirstOrDefault()
                });
                dgvAll.DataSource = g.ToList();


                //var newUsers = us.Select(c => new
                //{
                //    Name = c.Name,
                //    Surname = c.Surname,
                //    Passport = c.PassportNumber
                //});
                //dgvAll.DataSource = newUsers.ToList();
                //int count = 0;
                //foreach (var item in bankDBEntities.Users)
                //{
                //    dgvAll.Rows.Add();
                //    dgvAll.Rows[count].Cells[0].Value = item.Name;
                //    dgvAll.Rows[count].Cells[1].Value = item.Surname;
                //    dgvAll.Rows[count].Cells[2].Value = item.PassportNumber;

                //    count++;

                //}
            }
        }

     
    }
}
