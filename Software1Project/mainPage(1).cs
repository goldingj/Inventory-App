namespace Software1Project
{
    public partial class mainPage : Form
    {
        private Inventory inventory = new Inventory();

        public mainPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            addPartTable newForm = new addPartTable(inventory);
            newForm.ShowDialog();
        }

        private void modifyPartButton_Click(object sender, EventArgs e)
        {
            if (partsTable.SelectedRows.Count > 0)
            {
                var selectedRow = partsTable.SelectedRows[0];
                int partIndex = partsTable.Rows.IndexOf(selectedRow);
                Part selectedPart = (Part)selectedRow.DataBoundItem;

                modifyParts newForm = new modifyParts(inventory, selectedPart, partIndex);
                newForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Must select a part first.");
            }


        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            addProduct newForm = new addProduct(inventory);
            newForm.ShowDialog();
        }

        private void modifyProductButton_Click(object sender, EventArgs e)
        {
            
            if (productTable.SelectedRows.Count > 0)
            {
                var selectedRow = productTable.SelectedRows[0];
                int partIndex = productTable.Rows.IndexOf(selectedRow);
                Product selectedProduct = (Product)selectedRow.DataBoundItem;

                modifyProduct newForm = new modifyProduct(inventory, selectedProduct, partIndex);
                newForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Must select a product to modify.");
            }
        }

        private void mainPage_Load(object sender, EventArgs e)
        {
            productTable.DataSource = Inventory.Products;
            partsTable.DataSource = Inventory.AllParts;
        }

        private void deletePartButton_Click(object sender, EventArgs e)
        {
            DialogResult deleteConfirmation = MessageBox.Show("Are you sure you want to delete this part?", "Confirm delete", MessageBoxButtons.YesNo);

            if (deleteConfirmation == DialogResult.Yes && partsTable.SelectedRows.Count > 0)
            {
                var selectedRow = partsTable.SelectedRows[0];
                Part selectedPart = (Part)selectedRow.DataBoundItem;

                inventory.deletePart(selectedPart);
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {

            if (productTable.SelectedRows.Count > 0)
            {
                var selectedRow = productTable.SelectedRows[0];
                Product selectedProduct = (Product)selectedRow.DataBoundItem;

                if(selectedProduct.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Product cannot be deleted because at least one part is assigned to it.");
                    return;
                }
                DialogResult deleteConfirmation = MessageBox.Show("Are you sure you want to delete this product?", "confirm delete?", MessageBoxButtons.YesNo);

                if(deleteConfirmation == DialogResult.Yes)
                {
                    inventory.removeProduct(selectedProduct);
                }

                


            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchPartsButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(partSearchText.Text, out int partId))
            {
                MessageBox.Show("Must enter a valid number for id");
                return;
            }

            var partChosen = inventory.lookupPart(partId);

            if (partChosen != null)
            {
                foreach (DataGridViewRow row in partsTable.Rows)
                {
                    var part = (Part)row.DataBoundItem;
                    if(part != null && part.PartId == partChosen.PartId)
                    {
                        row.Selected = true;
                        partsTable.CurrentCell = row.Cells[0];
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Part does not exist.");
            }

        }

        private void searchProductsButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(productSearchBox.Text, out int productId))
            {
                MessageBox.Show("Must enter a valid number for id");
            }

            var productChosen = inventory.lookupProduct(productId);

            if (productChosen != null)
            {
                foreach (DataGridViewRow row in productTable.Rows)
                {
                    var product = (Product)row.DataBoundItem;
                    if (product != null && product.ProductId == productChosen.ProductId)
                    {
                        row.Selected = true;
                        productTable.CurrentCell = row.Cells[0];
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Product does not exist.");
            }
        }
    }
}
