namespace Software1Project
{
    partial class mainPage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            partsTable = new DataGridView();
            productTable = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            addPartButton = new Button();
            modifyPartButton = new Button();
            deletePartButton = new Button();
            deleteProductButton = new Button();
            modifyProductButton = new Button();
            addProductButton = new Button();
            exitButton = new Button();
            partSearchText = new TextBox();
            searchPartsButton = new Button();
            searchProductsButton = new Button();
            productSearchBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)partsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productTable).BeginInit();
            SuspendLayout();
            // 
            // partsTable
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            partsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            partsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            partsTable.DefaultCellStyle = dataGridViewCellStyle2;
            partsTable.Location = new Point(48, 130);
            partsTable.Name = "partsTable";
            partsTable.RowHeadersVisible = false;
            partsTable.RowHeadersWidth = 51;
            partsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            partsTable.Size = new Size(579, 313);
            partsTable.TabIndex = 0;
            // 
            // productTable
            // 
            productTable.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            productTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            productTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            productTable.DefaultCellStyle = dataGridViewCellStyle4;
            productTable.Location = new Point(741, 130);
            productTable.Name = "productTable";
            productTable.RowHeadersVisible = false;
            productTable.RowHeadersWidth = 51;
            productTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productTable.Size = new Size(591, 313);
            productTable.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(48, 34);
            label1.Name = "label1";
            label1.Size = new Size(283, 28);
            label1.TabIndex = 2;
            label1.Text = "Inventory Management System";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(48, 94);
            label2.Name = "label2";
            label2.Size = new Size(54, 28);
            label2.TabIndex = 3;
            label2.Text = "Parts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(741, 94);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 4;
            label3.Text = "Products";
            // 
            // addPartButton
            // 
            addPartButton.Location = new Point(286, 449);
            addPartButton.Name = "addPartButton";
            addPartButton.Size = new Size(94, 29);
            addPartButton.TabIndex = 5;
            addPartButton.Text = "Add";
            addPartButton.UseVisualStyleBackColor = true;
            addPartButton.Click += addPartButton_Click;
            // 
            // modifyPartButton
            // 
            modifyPartButton.Location = new Point(405, 449);
            modifyPartButton.Name = "modifyPartButton";
            modifyPartButton.Size = new Size(94, 29);
            modifyPartButton.TabIndex = 6;
            modifyPartButton.Text = "Modify";
            modifyPartButton.UseVisualStyleBackColor = true;
            modifyPartButton.Click += modifyPartButton_Click;
            // 
            // deletePartButton
            // 
            deletePartButton.Location = new Point(520, 449);
            deletePartButton.Name = "deletePartButton";
            deletePartButton.Size = new Size(94, 29);
            deletePartButton.TabIndex = 7;
            deletePartButton.Text = "Delete";
            deletePartButton.UseVisualStyleBackColor = true;
            deletePartButton.Click += deletePartButton_Click;
            // 
            // deleteProductButton
            // 
            deleteProductButton.Location = new Point(1234, 449);
            deleteProductButton.Name = "deleteProductButton";
            deleteProductButton.Size = new Size(94, 29);
            deleteProductButton.TabIndex = 10;
            deleteProductButton.Text = "Delete";
            deleteProductButton.UseVisualStyleBackColor = true;
            deleteProductButton.Click += deleteProductButton_Click;
            // 
            // modifyProductButton
            // 
            modifyProductButton.Location = new Point(1119, 449);
            modifyProductButton.Name = "modifyProductButton";
            modifyProductButton.Size = new Size(94, 29);
            modifyProductButton.TabIndex = 9;
            modifyProductButton.Text = "Modify";
            modifyProductButton.UseVisualStyleBackColor = true;
            modifyProductButton.Click += modifyProductButton_Click;
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(1000, 449);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(94, 29);
            addProductButton.TabIndex = 8;
            addProductButton.Text = "Add";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(1240, 505);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 11;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // partSearchText
            // 
            partSearchText.Location = new Point(452, 94);
            partSearchText.Name = "partSearchText";
            partSearchText.Size = new Size(175, 27);
            partSearchText.TabIndex = 12;
            // 
            // searchPartsButton
            // 
            searchPartsButton.Location = new Point(338, 92);
            searchPartsButton.Name = "searchPartsButton";
            searchPartsButton.Size = new Size(94, 29);
            searchPartsButton.TabIndex = 13;
            searchPartsButton.Text = "Search";
            searchPartsButton.UseVisualStyleBackColor = true;
            searchPartsButton.Click += searchPartsButton_Click;
            // 
            // searchProductsButton
            // 
            searchProductsButton.Location = new Point(1043, 91);
            searchProductsButton.Name = "searchProductsButton";
            searchProductsButton.Size = new Size(94, 29);
            searchProductsButton.TabIndex = 15;
            searchProductsButton.Text = "Search";
            searchProductsButton.UseVisualStyleBackColor = true;
            searchProductsButton.Click += searchProductsButton_Click;
            // 
            // productSearchBox
            // 
            productSearchBox.Location = new Point(1157, 93);
            productSearchBox.Name = "productSearchBox";
            productSearchBox.Size = new Size(175, 27);
            productSearchBox.TabIndex = 14;
            // 
            // mainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 607);
            Controls.Add(searchProductsButton);
            Controls.Add(productSearchBox);
            Controls.Add(searchPartsButton);
            Controls.Add(partSearchText);
            Controls.Add(exitButton);
            Controls.Add(deleteProductButton);
            Controls.Add(modifyProductButton);
            Controls.Add(addProductButton);
            Controls.Add(deletePartButton);
            Controls.Add(modifyPartButton);
            Controls.Add(addPartButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(productTable);
            Controls.Add(partsTable);
            Font = new Font("Segoe UI", 9F);
            Name = "mainPage";
            Text = "Main";
            Load += mainPage_Load;
            ((System.ComponentModel.ISupportInitialize)partsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)productTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView productTable;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button addPartButton;
        private Button modifyPartButton;
        private Button deletePartButton;
        private Button deleteProductButton;
        private Button modifyProductButton;
        private Button addProductButton;
        private Button exitButton;
        private TextBox partSearchText;
        private Button searchPartsButton;
        private Button searchProductsButton;
        private TextBox productSearchBox;
        private DataGridView partsTable;
    }
}
