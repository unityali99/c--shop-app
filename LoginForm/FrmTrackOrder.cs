using CodeFirst_DAL.Repository.UnitOfWork;
using CodeFirst_Models.Models;
using CustomMBoxes.InfoMBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class FrmTrackOrder : Form
    {
        Person person = null;
        UnitOfWork uow = null;
        List<OrderDetails> orderDetails = null;
        private int selectedOrderID;
        public FrmTrackOrder(Person getPerson, UnitOfWork localUow)
        {
            person = getPerson;
            uow = localUow;
            InitializeComponent();
        }

        private void FrmTrackOrder_Load(object sender, EventArgs e)
        {
            var orders = uow.RepositoryOrder.Get(p => p.PersonID.Equals(person.PersonID)).ToList();

            if (orders.Count < 1)
            {
                WarningMBox.ShowMBox("You've not submitted any orders yet.");
                this.Close();
                return;
            }
            foreach (var item in orders)
                ListBoxOrder.Items.Add($"ID : {item.ID} - Date & Time : {item.InsertDateTime}");
            ListBoxOrder.SelectedIndex = 0;
        }

        private void ListBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderDetails != null)
                ListBoxOrderDetail.Items.Clear();
            string[] splittedOrder = ListBoxOrder.SelectedItem.ToString().Split(' ');
            selectedOrderID = int.Parse(splittedOrder[2]);
            LblStatus.Text = uow.RepositoryOrder.GetByID(selectedOrderID).IsPaid ? "Status: Paid" : "Status: Not Paid";
            BtnGotoPay.Enabled = !uow.RepositoryOrder.GetByID(selectedOrderID).IsPaid;
            orderDetails = uow.RepositoryOrderDetails.Get(p => p.OrderID.Equals(selectedOrderID)).ToList();
            foreach (var item in orderDetails)
            {
                var gun = uow.RepositoryGun.GetByID(item.GunID);
                ListBoxOrderDetail.Items.Add($"ID : {item.GunID} - Gun : {gun.Name} - Quantity : {item.Quantity}");
            }
        }

        private void BtnGotoPay_Click(object sender, EventArgs e)
        {
            var selectedOrder = uow.RepositoryOrder.GetByID(selectedOrderID);
            selectedOrder.IsPaid = true;
            uow.RepositoryOrder.Update(selectedOrder);
            InfoMBox.ShowMBox("Your order is now paid !  ThankYou for your purchase.");
            ListBoxOrder.Items.Clear();
            FrmTrackOrder_Load(null, null);
            uow.Save();
        }

        private void BtnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete your order ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (uow.RepositoryOrder.GetByID(selectedOrderID).IsPaid)
                {
                    WarningMBox.ShowMBox("Sorry, you can't delete paid orders.");
                    return;
                }
                foreach (var item in orderDetails)
                    uow.RepositoryOrderDetails.DeleteByID(item.ID);

                uow.RepositoryOrder.DeleteByID(selectedOrderID);
                uow.Save();
                InfoMBox.ShowMBox("Your order has been deleted successfully.");
                ListBoxOrder.Items.Clear();
                FrmTrackOrder_Load(null, null);
            }
        }
    }
}
