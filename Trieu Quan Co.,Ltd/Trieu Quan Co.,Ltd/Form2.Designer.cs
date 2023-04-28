namespace Trieu_Quan_Co._Ltd
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            grd6 = new GroupBox();
            del_all = new Button();
            del_detail = new Button();
            cancel = new Button();
            print = new Button();
            add_pro = new Button();
            edit = new Button();
            save = new Button();
            grb5 = new GroupBox();
            grd2 = new DataGridView();
            grb4 = new GroupBox();
            grd1 = new DataGridView();
            grb2 = new GroupBox();
            grb6 = new GroupBox();
            code_product = new ComboBox();
            new_pro = new RadioButton();
            old_pro = new RadioButton();
            product_name = new TextBox();
            label8 = new Label();
            label12 = new Label();
            TotalAmount = new TextBox();
            label11 = new Label();
            UnitPrice = new TextBox();
            label10 = new Label();
            id_detail = new TextBox();
            Quantity = new TextBox();
            label9 = new Label();
            label6 = new Label();
            id_we_de = new TextBox();
            label7 = new Label();
            grb3 = new GroupBox();
            del = new Button();
            add_ware = new Button();
            grb1 = new GroupBox();
            supplier = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            total = new TextBox();
            label4 = new Label();
            id_em = new TextBox();
            label3 = new Label();
            label2 = new Label();
            id_warehouse = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            grd6.SuspendLayout();
            grb5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd2).BeginInit();
            grb4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd1).BeginInit();
            grb2.SuspendLayout();
            grb6.SuspendLayout();
            grb3.SuspendLayout();
            grb1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1372, 620);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(grd6);
            tabPage1.Controls.Add(grb5);
            tabPage1.Controls.Add(grb4);
            tabPage1.Controls.Add(grb2);
            tabPage1.Controls.Add(grb3);
            tabPage1.Controls.Add(grb1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1364, 592);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Warehouse";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // grd6
            // 
            grd6.Controls.Add(del_all);
            grd6.Controls.Add(del_detail);
            grd6.Controls.Add(cancel);
            grd6.Controls.Add(print);
            grd6.Controls.Add(add_pro);
            grd6.Controls.Add(edit);
            grd6.Controls.Add(save);
            grd6.Location = new Point(676, 223);
            grd6.Name = "grd6";
            grd6.Size = new Size(682, 53);
            grd6.TabIndex = 7;
            grd6.TabStop = false;
            grd6.Text = "Tool";
            // 
            // del_all
            // 
            del_all.Location = new Point(395, 17);
            del_all.Name = "del_all";
            del_all.Size = new Size(100, 23);
            del_all.TabIndex = 7;
            del_all.Text = "DELETE ALL";
            del_all.UseVisualStyleBackColor = true;
            del_all.Click += del_all_Click;
            // 
            // del_detail
            // 
            del_detail.Location = new Point(314, 17);
            del_detail.Name = "del_detail";
            del_detail.Size = new Size(75, 23);
            del_detail.TabIndex = 2;
            del_detail.Text = "DELETE";
            del_detail.UseVisualStyleBackColor = true;
            del_detail.Click += del_detail_Click;
            // 
            // cancel
            // 
            cancel.Location = new Point(520, 16);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 6;
            cancel.Text = "CANCEL";
            cancel.UseVisualStyleBackColor = true;
            cancel.Click += cancel_Click;
            // 
            // print
            // 
            print.Location = new Point(601, 17);
            print.Name = "print";
            print.Size = new Size(75, 23);
            print.TabIndex = 5;
            print.Text = "PRINT PDF";
            print.UseVisualStyleBackColor = true;
            print.Click += print_Click;
            // 
            // add_pro
            // 
            add_pro.Location = new Point(6, 21);
            add_pro.Name = "add_pro";
            add_pro.Size = new Size(131, 24);
            add_pro.TabIndex = 2;
            add_pro.Text = "ADD PRODUCT";
            add_pro.UseVisualStyleBackColor = true;
            add_pro.Click += add_pro_Click;
            // 
            // edit
            // 
            edit.Location = new Point(143, 22);
            edit.Name = "edit";
            edit.Size = new Size(75, 23);
            edit.TabIndex = 3;
            edit.Text = "EDIT";
            edit.UseVisualStyleBackColor = true;
            edit.Click += edit_Click;
            // 
            // save
            // 
            save.Location = new Point(224, 22);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 4;
            save.Text = "SAVE";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // grb5
            // 
            grb5.Controls.Add(grd2);
            grb5.Location = new Point(661, 282);
            grb5.Name = "grb5";
            grb5.Size = new Size(669, 297);
            grb5.TabIndex = 4;
            grb5.TabStop = false;
            grb5.Text = "Warehouse Detail";
            // 
            // grd2
            // 
            grd2.AllowUserToAddRows = false;
            grd2.AllowUserToDeleteRows = false;
            grd2.AllowUserToResizeColumns = false;
            grd2.AllowUserToResizeRows = false;
            grd2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grd2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grd2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd2.Location = new Point(6, 22);
            grd2.Name = "grd2";
            grd2.RowTemplate.Height = 25;
            grd2.Size = new Size(657, 269);
            grd2.TabIndex = 1;
            grd2.CellClick += grd2_CellClick;
            // 
            // grb4
            // 
            grb4.Controls.Add(grd1);
            grb4.Location = new Point(7, 282);
            grb4.Name = "grb4";
            grb4.Size = new Size(648, 297);
            grb4.TabIndex = 3;
            grb4.TabStop = false;
            grb4.Text = "Warehouse";
            // 
            // grd1
            // 
            grd1.AllowUserToAddRows = false;
            grd1.AllowUserToDeleteRows = false;
            grd1.AllowUserToResizeRows = false;
            grd1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grd1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grd1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd1.Location = new Point(6, 22);
            grd1.Name = "grd1";
            grd1.RowTemplate.Height = 25;
            grd1.Size = new Size(634, 269);
            grd1.TabIndex = 0;
            grd1.CellClick += grd1_CellClick;
            // 
            // grb2
            // 
            grb2.Controls.Add(grb6);
            grb2.Controls.Add(TotalAmount);
            grb2.Controls.Add(label11);
            grb2.Controls.Add(UnitPrice);
            grb2.Controls.Add(label10);
            grb2.Controls.Add(id_detail);
            grb2.Controls.Add(Quantity);
            grb2.Controls.Add(label9);
            grb2.Controls.Add(label6);
            grb2.Controls.Add(id_we_de);
            grb2.Controls.Add(label7);
            grb2.Location = new Point(670, 6);
            grb2.Name = "grb2";
            grb2.Size = new Size(669, 211);
            grb2.TabIndex = 2;
            grb2.TabStop = false;
            grb2.Text = "Detail";
            // 
            // grb6
            // 
            grb6.Controls.Add(code_product);
            grb6.Controls.Add(new_pro);
            grb6.Controls.Add(old_pro);
            grb6.Controls.Add(product_name);
            grb6.Controls.Add(label8);
            grb6.Controls.Add(label12);
            grb6.Location = new Point(10, 56);
            grb6.Name = "grb6";
            grb6.Size = new Size(362, 149);
            grb6.TabIndex = 27;
            grb6.TabStop = false;
            grb6.Text = "Product";
            // 
            // code_product
            // 
            code_product.FormattingEnabled = true;
            code_product.Location = new Point(112, 69);
            code_product.Name = "code_product";
            code_product.Size = new Size(244, 23);
            code_product.TabIndex = 11;
            code_product.SelectedIndexChanged += code_product_SelectedIndexChanged;
            // 
            // new_pro
            // 
            new_pro.AutoSize = true;
            new_pro.Location = new Point(220, 19);
            new_pro.Name = "new_pro";
            new_pro.Size = new Size(94, 19);
            new_pro.TabIndex = 28;
            new_pro.TabStop = true;
            new_pro.Text = "New Product";
            new_pro.UseVisualStyleBackColor = true;
            new_pro.CheckedChanged += new_pro_CheckedChanged;
            // 
            // old_pro
            // 
            old_pro.AutoSize = true;
            old_pro.Location = new Point(28, 19);
            old_pro.Name = "old_pro";
            old_pro.Size = new Size(123, 19);
            old_pro.TabIndex = 27;
            old_pro.TabStop = true;
            old_pro.Text = "Products Available";
            old_pro.UseVisualStyleBackColor = true;
            old_pro.CheckedChanged += old_pro_CheckedChanged;
            // 
            // product_name
            // 
            product_name.Location = new Point(123, 111);
            product_name.Name = "product_name";
            product_name.Size = new Size(206, 23);
            product_name.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 69);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 13;
            label8.Text = "Product Code";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 119);
            label12.Name = "label12";
            label12.Size = new Size(84, 15);
            label12.TabIndex = 23;
            label12.Text = "Product Name";
            // 
            // TotalAmount
            // 
            TotalAmount.Location = new Point(473, 167);
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Size = new Size(164, 23);
            TotalAmount.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(388, 175);
            label11.Name = "label11";
            label11.Size = new Size(79, 15);
            label11.TabIndex = 21;
            label11.Text = "Total Amount";
            // 
            // UnitPrice
            // 
            UnitPrice.Location = new Point(452, 117);
            UnitPrice.Name = "UnitPrice";
            UnitPrice.Size = new Size(185, 23);
            UnitPrice.TabIndex = 20;
            UnitPrice.TextChanged += UnitPrice_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(388, 117);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 19;
            label10.Text = "UnitPrice";
            // 
            // id_detail
            // 
            id_detail.Location = new Point(95, 22);
            id_detail.Name = "id_detail";
            id_detail.Size = new Size(244, 23);
            id_detail.TabIndex = 12;
            // 
            // Quantity
            // 
            Quantity.Location = new Point(452, 64);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(185, 23);
            Quantity.TabIndex = 17;
            Quantity.TextChanged += Quantity_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 24);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 11;
            label9.Text = "ID Detail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(388, 69);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 16;
            label6.Text = "Quantity";
            // 
            // id_we_de
            // 
            id_we_de.Location = new Point(431, 21);
            id_we_de.Name = "id_we_de";
            id_we_de.Size = new Size(206, 23);
            id_we_de.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(345, 24);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 14;
            label7.Text = "ID Warehosue";
            // 
            // grb3
            // 
            grb3.Controls.Add(del);
            grb3.Controls.Add(add_ware);
            grb3.Location = new Point(7, 223);
            grb3.Name = "grb3";
            grb3.Size = new Size(648, 53);
            grb3.TabIndex = 1;
            grb3.TabStop = false;
            grb3.Text = "Tool";
            // 
            // del
            // 
            del.Location = new Point(183, 17);
            del.Name = "del";
            del.Size = new Size(75, 23);
            del.TabIndex = 1;
            del.Text = "DELETE";
            del.UseVisualStyleBackColor = true;
            del.Click += del_Click;
            // 
            // add_ware
            // 
            add_ware.Location = new Point(20, 16);
            add_ware.Name = "add_ware";
            add_ware.Size = new Size(131, 23);
            add_ware.TabIndex = 0;
            add_ware.Text = "ADD WAREHOUSE";
            add_ware.UseVisualStyleBackColor = true;
            add_ware.Click += add_ware_Click;
            // 
            // grb1
            // 
            grb1.Controls.Add(supplier);
            grb1.Controls.Add(dateTimePicker1);
            grb1.Controls.Add(label5);
            grb1.Controls.Add(total);
            grb1.Controls.Add(label4);
            grb1.Controls.Add(id_em);
            grb1.Controls.Add(label3);
            grb1.Controls.Add(label2);
            grb1.Controls.Add(id_warehouse);
            grb1.Controls.Add(label1);
            grb1.Location = new Point(16, 6);
            grb1.Name = "grb1";
            grb1.Size = new Size(648, 211);
            grb1.TabIndex = 0;
            grb1.TabStop = false;
            grb1.Text = "Infomation";
            // 
            // supplier
            // 
            supplier.FormattingEnabled = true;
            supplier.Location = new Point(95, 71);
            supplier.Name = "supplier";
            supplier.Size = new Size(244, 23);
            supplier.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(95, 114);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(244, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 117);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 8;
            label5.Text = "Date Create";
            // 
            // total
            // 
            total.Location = new Point(434, 69);
            total.Name = "total";
            total.Size = new Size(206, 23);
            total.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(355, 72);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 6;
            label4.Text = "Total Value";
            // 
            // id_em
            // 
            id_em.Location = new Point(434, 21);
            id_em.Name = "id_em";
            id_em.Size = new Size(206, 23);
            id_em.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 24);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 4;
            label3.Text = "Employee ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 74);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Supplier";
            // 
            // id_warehouse
            // 
            id_warehouse.Location = new Point(95, 21);
            id_warehouse.Name = "id_warehouse";
            id_warehouse.Size = new Size(244, 23);
            id_warehouse.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 24);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1364, 592);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 668);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            grd6.ResumeLayout(false);
            grb5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd2).EndInit();
            grb4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd1).EndInit();
            grb2.ResumeLayout(false);
            grb2.PerformLayout();
            grb6.ResumeLayout(false);
            grb6.PerformLayout();
            grb3.ResumeLayout(false);
            grb1.ResumeLayout(false);
            grb1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox grb1;
        private Label label1;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox id_em;
        private Label label3;
        private Label label2;
        private TextBox id_warehouse;
        private DateTimePicker dateTimePicker1;
        private ComboBox supplier;
        private GroupBox grb3;
        private Button del;
        private Button add_ware;
        private Button print;
        private Button save;
        private Button edit;
        private Button add_pro;
        private GroupBox grb2;
        private TextBox id_detail;
        private TextBox Quantity;
        private Label label9;
        private Label label6;
        private Label label8;
        private TextBox id_we_de;
        private Label label7;
        private TextBox UnitPrice;
        private Label label10;
        private TextBox TotalAmount;
        private Label label11;
        private GroupBox grb5;
        private DataGridView grd2;
        private GroupBox grb4;
        private DataGridView grd1;
        private TextBox total;
        private TextBox product_name;
        private Label label12;
        private GroupBox grb6;
        private RadioButton new_pro;
        private RadioButton old_pro;
        private ComboBox code_product;
        private Button cancel;
        private GroupBox grd6;
        private Button del_all;
        private Button del_detail;
    }
}