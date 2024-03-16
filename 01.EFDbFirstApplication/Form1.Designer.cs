namespace _01.EFDbFirstApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dvgProducts = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtMin = new TextBox();
            txtMax = new TextBox();
            btnFilter = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtUnitPrice = new TextBox();
            txtStock = new TextBox();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgProducts).BeginInit();
            SuspendLayout();
            // 
            // dvgProducts
            // 
            dvgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProducts.Location = new Point(12, 126);
            dvgProducts.Name = "dvgProducts";
            dvgProducts.RowHeadersWidth = 51;
            dvgProducts.Size = new Size(771, 357);
            dvgProducts.TabIndex = 0;
            dvgProducts.CellClick += dvgProducts_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 53);
            label1.Name = "label1";
            label1.Size = new Size(53, 22);
            label1.TabIndex = 1;
            label1.Text = "Min :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 53);
            label2.Name = "label2";
            label2.Size = new Size(56, 22);
            label2.TabIndex = 2;
            label2.Text = "Max :";
            // 
            // txtMin
            // 
            txtMin.Location = new Point(88, 50);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(125, 30);
            txtMin.TabIndex = 3;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(307, 50);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(125, 30);
            txtMax.TabIndex = 4;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(486, 50);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(94, 29);
            btnFilter.TabIndex = 5;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(800, 126);
            label3.Name = "label3";
            label3.Size = new Size(56, 22);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(800, 174);
            label4.Name = "label4";
            label4.Size = new Size(90, 22);
            label4.TabIndex = 7;
            label4.Text = "Unit Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(802, 218);
            label5.Name = "label5";
            label5.Size = new Size(54, 22);
            label5.TabIndex = 8;
            label5.Text = "Stock";
            // 
            // txtName
            // 
            txtName.Location = new Point(916, 123);
            txtName.Name = "txtName";
            txtName.Size = new Size(212, 30);
            txtName.TabIndex = 9;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(916, 171);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(212, 30);
            txtUnitPrice.TabIndex = 10;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(916, 215);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(212, 30);
            txtStock.TabIndex = 11;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1034, 276);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 495);
            Controls.Add(btnUpdate);
            Controls.Add(txtStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnFilter);
            Controls.Add(txtMax);
            Controls.Add(txtMin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dvgProducts);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dvgProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgProducts;
        private Label label1;
        private Label label2;
        private TextBox txtMin;
        private TextBox txtMax;
        private Button btnFilter;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtUnitPrice;
        private TextBox txtStock;
        private Button btnUpdate;
    }
}
