using CodeFirst_DAL.Repository.UnitOfWork;
using CodeFirst_Models.Models;
using CustomMBoxes.InfoMBox;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class FrmOrder : Form
    {
        List<Gun> guns = new List<Gun>();
        Person person = new Person();
        Order order = new Order();
        List<OrderDetails> orderDetails = new List<OrderDetails>();
        UnitOfWork uow;

        public FrmOrder(List<Gun> gunList, Person getPerson, UnitOfWork localUow)
        {
            uow = localUow;

            guns = gunList;

            person = getPerson;

            InitializeComponent();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            foreach (Gun gun in guns)
            {
                ListBoxGunOrder.Items.Add(gun.Name + " 1");
            }
        }


        private void BtnSetQyt_Click(object sender, EventArgs e)
        {
            #region SetItemsQty

            string gunSplit = ListBoxGunOrder.SelectedItem.ToString().Split(' ')[0];

            var qty = uow.RepositoryGun.Get(p => p.Name.Equals(gunSplit)).Select(p => p.Quantity).ToList();

            if (((int)NumericTxtBox.Value) > qty.FirstOrDefault())
            {
                WarningMBox.ShowMBox($"There are only {qty.FirstOrDefault()} items left for this product");
                return;
            }

            ListBoxGunOrder.Items[ListBoxGunOrder.SelectedIndex] = gunSplit + $" {NumericTxtBox.Value}";
            #endregion
        }

        private void ListBoxGunOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            NumericTxtBox.Enabled = true;
            NumericTxtBox.Focus();
            NumericTxtBox.Value = 1;
        }

        private void BtnSubmitOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to submit your order ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                order = new Order()
                {
                    PersonObj = person,
                    PersonID = person.PersonID,
                    IsPaid = false,
                    OrderDate = DateTime.Now
                };

                order.orderDetailsObj = GetOrderDetails();

                foreach (var item in orderDetails)
                {
                    uow.RepositoryOrderDetails.Insert(item);
                }

                uow.RepositoryOrder.Insert(order);

                uow.Save();

                //Gun gun1 = ctx.Guns.Find(1);
                //Gun gun2 = ctx.Guns.Find(2);

                //var orderItems = new List<OrderDetails>
                //{
                //    new OrderDetails
                //    {
                //    GunID = gun1.ID,
                //    GunObj = gun1,
                //    Quantity = 7
                //    },
                //    new OrderDetails
                //    {
                //    GunID = gun2.ID,
                //    GunObj = gun2,
                //    Quantity = 8
                //   }
                //};

                //var order = new Order
                //{
                //    IsPaid = false,
                //    OrderDate = DateTime.Now.AddDays(1),
                //    PersonID = person.PersonID,
                //    PersonObj = person,
                //};

                //order.orderDetailsObj = orderItems;

                //ctx.Orders.Add(order);

                //ctx.SaveChanges();

                this.DialogResult = DialogResult.OK;

                FrmCart frmCart = new FrmCart(orderDetails, uow, order);

                this.Close();

                frmCart.ShowDialog();
            }
        }

        private ICollection<OrderDetails> GetOrderDetails()
        {
            foreach (var item in ListBoxGunOrder.Items)
            {
                string gunName = item.ToString().Split(' ')[0];
                int count = int.Parse(item.ToString().Split(' ')[1]);
                Gun gun = uow.RepositoryGun.Get(p => p.Name.Equals(gunName)).FirstOrDefault();
                orderDetails.Add(new OrderDetails() { GunID = gun.ID, GunObj = gun, Quantity = count });
            }
            return orderDetails;
        }

        private void NumericTxtBox_ValueChanged(object sender, EventArgs e)
        {
            BtnSetQyt_Click(null, null);
        }
    }
}
