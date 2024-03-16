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
            ((System.ComponentModel.ISupportInitialize)dvgProducts).BeginInit();
            SuspendLayout();
            // 
            // dvgProducts
            // 
            dvgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgProducts.Location = new Point(12, 126);
            dvgProducts.Name = "dvgProducts";
            dvgProducts.RowHeadersWidth = 51;
            dvgProducts.Size = new Size(848, 357);
            dvgProducts.TabIndex = 0;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 495);
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
    }
}
