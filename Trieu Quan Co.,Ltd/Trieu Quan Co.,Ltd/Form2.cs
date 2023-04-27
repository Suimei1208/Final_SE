using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trieu_Quan_Co._Ltd
{
    public partial class Form2 : Form
    {
        string id_acc;
        tblStockReceipt_BUS re;
        tblStockReceiptDetails_BUS reDetails;
        Suppliers_BUS sup;
        Products_BUS products;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            id_acc = Form1.uname;
            enable(grb1, false);
            enable(grb2, false);
            id_warehouse.Enabled = false;
            id_em.Enabled = false;
            total.Enabled = false;
            dateTimePicker1.Enabled = false;

            re = new tblStockReceipt_BUS("", "", 0, "", 0);
            grd1.DataSource = re.selectQuery();


        }
        public void enable(GroupBox grp, bool b)
        {
            grp.Enabled = b;
        }

        private void add_ware_Click(object sender, EventArgs e)
        {
            enable(grb1, true);
            sup = new Suppliers_BUS("", "", "", "");
            re = new tblStockReceipt_BUS("", "", 0, "", 0);
            id_warehouse.Text = "NKNCC" + re.getID_tblStockReceipt();
            id_em.Text = id_acc;
            supplier.DataSource = sup.getSupplierNames();

            re = new tblStockReceipt_BUS(id_warehouse.Text, DateTime.Today.ToString("yyyy-MM-dd"), int.Parse(id_em.Text), supplier.Text, 0);
            re.addQuery();
            grd1.DataSource = re.selectQuery();

        }

        private void grd1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_warehouse.Text = grd1.CurrentRow.Cells[0].Value.ToString();
            id_em.Text = grd1.CurrentRow.Cells[2].Value.ToString();
            supplier.Text = grd1.CurrentRow.Cells[3].Value.ToString();
            total.Text = grd1.CurrentRow.Cells[4].Value.ToString();
            id_we_de.Text = grd1.CurrentRow.Cells[0].Value.ToString();

            reDetails = new tblStockReceiptDetails_BUS("", id_warehouse.Text, "", 0, 0, 0);
            grd2.DataSource = reDetails.selectQuery();

            enable(grb1, false);
            enable(grb2, true);
            TotalAmount.Enabled = false;

            reDetails = new tblStockReceiptDetails_BUS("", "", "", 0, 0, 0);
            id_detail.Text = id_warehouse.Text + "-" + reDetails.getID_tblStockReceipt();
            products = new Products_BUS("", "", 0, 0);
            code_product.Text = "SP" + products.getID_product();
        }

        private void add_pro_Click(object sender, EventArgs e)
        {

            
        }
    }
}
