namespace _01.EFDbFirstApplication
{
    partial class FrmAddProduct
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
            btnAdd = new Button();
            txtUnitPrice = new TextBox();
            txtStock = new TextBox();
            txtName = new TextBox();
            cmbCategory = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(383, 284);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(149, 226);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(328, 30);
            txtUnitPrice.TabIndex = 16;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(149, 173);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(328, 30);
            txtStock.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(149, 120);
            txtName.Name = "txtName";
            txtName.Size = new Size(328, 30);
            txtName.TabIndex = 14;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(149, 68);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(328, 30);
            cmbCategory.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 229);
            label4.Name = "label4";
            label4.Size = new Size(96, 22);
            label4.TabIndex = 12;
            label4.Text = "UnitPrice :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 176);
            label3.Name = "label3";
            label3.Size = new Size(65, 22);
            label3.TabIndex = 11;
            label3.Text = "Stock :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 123);
            label2.Name = "label2";
            label2.Size = new Size(67, 22);
            label2.TabIndex = 10;
            label2.Text = "Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 71);
            label1.Name = "label1";
            label1.Size = new Size(106, 22);
            label1.TabIndex = 9;
            label1.Text = "Categories :";
            // 
            // FrmAddProduct
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 421);
            Controls.Add(btnAdd);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtStock);
            Controls.Add(txtName);
            Controls.Add(cmbCategory);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmAddProduct";
            Text = "FrmAddProduct";
            Load += FrmAddProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtUnitPrice;
        private TextBox txtStock;
        private TextBox txtName;
        private ComboBox cmbCategory;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}