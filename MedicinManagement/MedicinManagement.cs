using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicinManagement
{
    public partial class MedicinManagement : Form
    {
        List<Product> products = new List<Product>();
        List<ProductType> productTypes = new List<ProductType>();
        public MedicinManagement()
        {
            InitializeComponent();
            createProductTypes();
            // setting cho listview
            lvProduct.View = View.Details;
            lvProduct.LabelEdit = true;
            lvProduct.AllowColumnReorder = true;
            lvProduct.FullRowSelect = true;
            lvProduct.GridLines = true;
            lvProduct.Sorting = SortOrder.Ascending;

            lvProduct.Columns.Add("No", -2, HorizontalAlignment.Left);
            lvProduct.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lvProduct.Columns.Add("ProductName", -2, HorizontalAlignment.Left);
            lvProduct.Columns.Add("Price", -2, HorizontalAlignment.Left);
            lvProduct.Columns.Add("Amount", -2, HorizontalAlignment.Left);
            lvProduct.Columns.Add("ExpiredDate", -2, HorizontalAlignment.Left);
            lvProduct.Columns.Add("Prioritize", -2, HorizontalAlignment.Left);
            lvProduct.Columns.Add("Type", -2, HorizontalAlignment.Left);



            displayListViewProduct();
        }

        private void MedicinManagement_Load(object sender, EventArgs e)
        {

        }

        private void displayListViewProduct()
        {
            lvProduct.Items.Clear();
            List<ListViewItem> listItem = new List<ListViewItem>();
            int Index = 1;
            for (int i = 0; i < products.Count; i++)
            {
                ListViewItem item = new ListViewItem(Index + "", Index);
                item.SubItems.Add(products[i].Id.ToString());
                item.SubItems.Add(products[i].ProductName);
                item.SubItems.Add(products[i].Price.ToString());
                item.SubItems.Add(products[i].Amount.ToString());
                item.SubItems.Add(products[i].ExpiredDate.ToString());
                if (products[i].Prioritize)
                {
                    item.SubItems.Add("High Priority");
                }
                else
                {
                    item.SubItems.Add("Low Priority");
                }
               
                item.SubItems.Add(products[i].Type.Name);
                listItem.Add(item);
                Index++;
            }
            lvProduct.Items.AddRange(listItem.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Id = Convert.ToInt32(tbID.Text);
            product.ProductName = tbProductName.Text;
            product.Price = Convert.ToInt32(tbPrice.Text);
            product.Amount = Convert.ToInt32(tbAmount.Text);
            product.ExpiredDate = tbExpiredDate.Text;
            product.Type = productTypes.Find(x => x.Id == Int32.Parse(cbbType.SelectedValue.ToString()));
            products.Add(product);
            displayListViewProduct();
        }

        private void lvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProduct.SelectedItems.Count > 0)
            {
                ListViewItem item = lvProduct.SelectedItems[0];
                tbID.Text = item.SubItems[1].Text;
                tbProductName.Text = item.SubItems[2].Text;
                tbPrice.Text = item.SubItems[3].Text;
                tbAmount.Text = item.SubItems[4].Text;
                tbExpiredDate.Text = item.SubItems[5].Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Xac nhan xoa ban ghi Id = " + tbID.Text, "Confirm", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                Product selectedProduct = this.products.Find(item => item.Id == Int32.Parse(tbID.Text));
                if (selectedProduct != null)
                {
                    products.Remove(selectedProduct);
                }
                displayListViewProduct();
            }

        }

        private void createProductTypes()
        {
            ProductType type1 = new ProductType("Khang Sinh", 1);
            ProductType type2 = new ProductType("Rang mieng", 2);
            ProductType type3 = new ProductType("Cam cum", 3);
            productTypes.Add(type1);
            productTypes.Add(type2);
            productTypes.Add(type3);

            cbbType.DataSource = productTypes;
            cbbType.DisplayMember = "Name";
            cbbType.ValueMember = "Id";
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbbType.SelectedValue.ToString());
        }
    }
}
