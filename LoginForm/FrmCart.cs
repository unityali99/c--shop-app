using CodeFirst_DAL.Repository.UnitOfWork;
using CodeFirst_Models.Models;
using CustomMBoxes.InfoMBox;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class FrmCart : Form
    {
        List<OrderDetails> orderDetails = new List<OrderDetails>();
        UnitOfWork uow = null;
        Order order = null;

        public FrmCart(List<OrderDetails> orderListLocal, UnitOfWork uowLocal, Order orderLocal)
        {
            order = orderLocal;
            orderDetails = orderListLocal;
            uow = uowLocal;
            InitializeComponent();
        }

        private void btnLabelClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCart_Load(object sender, EventArgs e)
        {
            TextBoxOrderID.Text = "Order ID : " + order.ID.ToString();
            int totalPrice = 0;

            foreach (var item in orderDetails)
            {
                var gunObj = uow.RepositoryGun.GetByID(item.GunID);
                totalPrice += gunObj.Price * item.Quantity;
            }
            TextBoxTotalPrice.Text = "Total Price : " + totalPrice.ToString() + "$";
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            InfoMBox.ShowMBox("ThankYou, your order has been paid successfully.", "Reception");
            order.IsPaid = true;
            uow.RepositoryOrder.Update(order);
            BtnPay.Enabled = false;
            foreach (var item in orderDetails)
            {
                var gun = uow.RepositoryGun.GetByID(item.GunID);
                gun.Quantity -= item.Quantity;
                uow.RepositoryGun.Update(gun);
            }
            uow.Save();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
