using BUS;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Trieu_Quan_Co._Ltd
{
    public partial class Form2 : Form
    {
        string id_acc;
        tblStockReceipt_BUS re;
        tblStockReceiptDetails_BUS reDetails;
        Suppliers_BUS sup;
        Products_BUS products;
        tblStockInOutSummary_BUS SOS;
        string id_tblStockInOutSummary;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            id_acc = Form1.uname;
            enable(grb2, false);
            id_warehouse.Enabled = false;
            id_em.Enabled = false;
            total.Enabled = false;
            dateTimePicker1.Enabled = false;

            re = new tblStockReceipt_BUS("", "", 0, "", 0);
            grd1.DataSource = re.selectQuery();

            sup = new Suppliers_BUS("", "", "", "");
            supplier.DataSource = sup.getSupplierNames();

        }
        public void enable(GroupBox grp, bool b)
        {
            grp.Enabled = b;
        }

        private void add_ware_Click(object sender, EventArgs e)
        {
            re = new tblStockReceipt_BUS("", "", 0, "", 0);
            id_warehouse.Text = "NKNCC" + re.getID_tblStockReceipt();
            id_em.Text = id_acc;

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
            id_we_de.Enabled = false;
            id_detail.Enabled = false;
            add_pro.Enabled = false;
            code_product.Enabled = false;
            product_name.Enabled = false;
            TotalAmount.Enabled = false;
            UnitPrice.Text = "";
            Quantity.Text = "";
            old_pro.Enabled = true;
            new_pro.Enabled = true;
            edit.Enabled = false;

            reDetails = new tblStockReceiptDetails_BUS("", "", "", 0, 0, 0);
            id_detail.Text = id_warehouse.Text + "-" + reDetails.getID_tblStockReceipt();

            bool isNumeric1 = decimal.TryParse(UnitPrice.Text, out _);
            bool isNumeric2 = decimal.TryParse(Quantity.Text, out _);
            if (isNumeric1 && isNumeric2)
            {
                TotalAmount.Text = (decimal.Parse(UnitPrice.Text) * decimal.Parse(Quantity.Text)).ToString();
            }

        }

        private void add_pro_Click(object sender, EventArgs e)
        {
            enable(grb2, true);
            id_we_de.Enabled = false;
            id_detail.Enabled = false;
            add_pro.Enabled = false;
            old_pro.Enabled = true;
            new_pro.Enabled = true;
            code_product.Enabled = false;
            product_name.Enabled = false;
            TotalAmount.Enabled = false;
            UnitPrice.Text = "";
            Quantity.Text = "";
            save.Enabled = true;

            reDetails = new tblStockReceiptDetails_BUS("", "", "", 0, 0, 0);
            id_detail.Text = id_warehouse.Text + "-" + reDetails.getID_tblStockReceipt();

        }

        private void new_pro_CheckedChanged(object sender, EventArgs e)
        {
            code_product.Enabled = false;
            product_name.Clear();
            UnitPrice.Clear();
            Quantity.Clear();
            products = new Products_BUS("", "", 0, 0);
            code_product.Text = "SP" + products.getID_product();
            product_name.Enabled = true;
        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {

            bool isNumeric1 = decimal.TryParse(UnitPrice.Text, out _);
            bool isNumeric2 = decimal.TryParse(Quantity.Text, out _);
            if (isNumeric1 && isNumeric2)
            {
                TotalAmount.Text = (decimal.Parse(UnitPrice.Text) * decimal.Parse(Quantity.Text)).ToString();
            }
        }

        private void UnitPrice_TextChanged(object sender, EventArgs e)
        {
            bool isNumeric1 = decimal.TryParse(UnitPrice.Text, out _);
            bool isNumeric2 = decimal.TryParse(Quantity.Text, out _);
            if (isNumeric1 && isNumeric2)
            {
                TotalAmount.Text = (decimal.Parse(UnitPrice.Text) * decimal.Parse(Quantity.Text)).ToString();
            }
        }

        private void old_pro_CheckedChanged(object sender, EventArgs e)
        {
            code_product.Enabled = true;
            product_name.Enabled = false;
            Quantity.Clear();
            products = new Products_BUS("", "", 0, 0);
            code_product.DataSource = products.getProductID();
            string temp;
            products = new Products_BUS(code_product.Text, "", 0, 0);
            (product_name.Text, temp) = products.get_Old_Product();
            UnitPrice.Text = decimal.Parse(temp).ToString();
        }

        private void code_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp;
            products = new Products_BUS(code_product.Text, "", 0, 0);
            (product_name.Text, temp) = products.get_Old_Product();
            UnitPrice.Text = decimal.Parse(temp).ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {
            add_pro.Enabled = true;
            if (Quantity.Text == "" || UnitPrice.Text == "" || TotalAmount.Text == "") MessageBox.Show("Please enter full information!!!!!");
            else
            {
                if (old_pro.Checked)
                {
                    reDetails = new tblStockReceiptDetails_BUS(id_detail.Text, id_we_de.Text, code_product.Text, decimal.Parse(Quantity.Text), decimal.Parse(UnitPrice.Text), decimal.Parse(TotalAmount.Text));
                    reDetails.addQuery();

                    reDetails = new tblStockReceiptDetails_BUS("", id_warehouse.Text, "", 0, 0, 0);
                    grd2.DataSource = reDetails.selectQuery();

                    SOS = new tblStockInOutSummary_BUS("", "", 0, 0);
                    string ID_tblStockInOutSummary = "TK" + SOS.getID_tblStockInOutSummary();

                    SOS = new tblStockInOutSummary_BUS(ID_tblStockInOutSummary, code_product.Text, 0, int.Parse(Quantity.Text));
                    SOS.addQuery();
                }
                else if (new_pro.Checked)
                {
                    reDetails = new tblStockReceiptDetails_BUS(id_detail.Text, id_we_de.Text, code_product.Text, decimal.Parse(Quantity.Text), decimal.Parse(UnitPrice.Text), decimal.Parse(TotalAmount.Text));
                    reDetails.addQuery();

                    products = new Products_BUS(code_product.Text, product_name.Text, decimal.Parse(Quantity.Text), decimal.Parse(UnitPrice.Text));
                    products.addQuery();

                    reDetails = new tblStockReceiptDetails_BUS("", id_warehouse.Text, "", 0, 0, 0);
                    grd2.DataSource = reDetails.selectQuery();

                    SOS = new tblStockInOutSummary_BUS("", "", 0, 0);
                    string ID_tblStockInOutSummary = "TK" + SOS.getID_tblStockInOutSummary();

                    SOS = new tblStockInOutSummary_BUS(ID_tblStockInOutSummary, code_product.Text, 0, int.Parse(Quantity.Text));
                    SOS.addQuery();
                }
                re = new tblStockReceipt_BUS(id_warehouse.Text, "", 0, "", 0);
                re.updateTotal();
                grd1.DataSource = re.selectQuery();
                grd2.ClearSelection();
                enable(grb2, false);
            }

        }

        private void grd2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enable(grb2, true);
            old_pro.Enabled = false;
            new_pro.Enabled = false;
            code_product.Enabled = false;
            id_detail.Enabled = false;
            save.Enabled = false;
            id_we_de.Enabled = false;
            TotalAmount.Enabled = false;
            product_name.Enabled = true;
            edit.Enabled = true;

            id_detail.Text = grd2.CurrentRow.Cells[0].Value.ToString();
            id_we_de.Text = grd2.CurrentRow.Cells[1].Value.ToString();
            code_product.Text = grd2.CurrentRow.Cells[2].Value.ToString();
            Quantity.Text = grd2.CurrentRow.Cells[3].Value.ToString();
            UnitPrice.Text = grd2.CurrentRow.Cells[4].Value.ToString();
            TotalAmount.Text = grd2.CurrentRow.Cells[5].Value.ToString();

            products = new Products_BUS(code_product.Text, "", 0, 0);
            (product_name.Text, _) = products.get_Old_Product();

            SOS = new tblStockInOutSummary_BUS("", code_product.Text, 0, int.Parse(Quantity.Text));
            id_tblStockInOutSummary = SOS.getID();

            //MessageBox.Show(id_tblStockInOutSummary);
        }

        private void edit_Click(object sender, EventArgs e)
        {
            reDetails = new tblStockReceiptDetails_BUS(id_detail.Text, id_we_de.Text, code_product.Text, decimal.Parse(Quantity.Text), decimal.Parse(UnitPrice.Text), decimal.Parse(TotalAmount.Text));
            reDetails.updateQuery();
            grd2.DataSource = reDetails.selectQuery();

            re = new tblStockReceipt_BUS(id_warehouse.Text, "", 0, "", 0);
            re.updateTotal();
            grd1.DataSource = re.selectQuery();


            SOS = new tblStockInOutSummary_BUS(id_tblStockInOutSummary, code_product.Text, 0, int.Parse(Quantity.Text));
            SOS.updateQuery();

            add_pro.Enabled = true;
            save.Enabled = true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            add_pro.Enabled = true;
            enable(grb2, false);
            enable(grb1, true);
            supplier.Enabled = true;
        }

        private void del_detail_Click(object sender, EventArgs e)
        {
            reDetails = new tblStockReceiptDetails_BUS(id_detail.Text, id_we_de.Text, code_product.Text, decimal.Parse(Quantity.Text), decimal.Parse(UnitPrice.Text), decimal.Parse(TotalAmount.Text));
            reDetails.deleteQuery();
            grd2.DataSource = reDetails.selectQuery();

            re = new tblStockReceipt_BUS(id_warehouse.Text, "", 0, "", 0);
            re.updateTotal();
            grd1.DataSource = re.selectQuery();
        }

        private void del_all_Click(object sender, EventArgs e)
        {
            reDetails = new tblStockReceiptDetails_BUS("", id_we_de.Text, "", 0, 0, 0);
            reDetails.deleteAll();
            grd2.DataSource = reDetails.selectQuery();

            re = new tblStockReceipt_BUS(id_warehouse.Text, "", 0, "", 0);
            re.updateTotal();
            grd1.DataSource = re.selectQuery();
        }

        private void del_Click(object sender, EventArgs e)
        {
            reDetails = new tblStockReceiptDetails_BUS("", id_we_de.Text, "", 0, 0, 0);
            reDetails.deleteAll();
            grd2.DataSource = reDetails.selectQuery();

            re = new tblStockReceipt_BUS(id_we_de.Text, "", 0, "", 0);
            re.deleteAll();
            grd1.DataSource = re.selectQuery();
        }

        private void print_Click(object sender, EventArgs e)
        {
            if (grd2.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Unable to write data to disk. Error description: " + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(grd2.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in grd2.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in grd2.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value.ToString() == null) continue;
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data exported successfully!!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error description: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No records to export!!!", "Info");
            }
        }
    }
}
