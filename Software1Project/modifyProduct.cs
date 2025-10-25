using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software1Project
{

    public partial class modifyProduct : Form
    {
        private Inventory inventory;
        private Product chosenProduct;
        private int productIndex;
        public modifyProduct(Inventory inv, Product selectedProduct, int index)
        {
            InitializeComponent();
            inventory = inv;
            chosenProduct = selectedProduct;
            productIndex = index;

            modifyProductIdText.Text = chosenProduct.ProductId.ToString();
            modifyProductNameText.Text = chosenProduct.Name;
            modifyProductInventoryText.Text = chosenProduct.InStock.ToString();
            modifyProductPriceText.Text = chosenProduct.Price.ToString();
            modifyProductMinText.Text = chosenProduct.Min.ToString();
            modifyProductMaxText.Text = chosenProduct.Max.ToString();
        }

        private void modifyProductSaveButton_Click(object sender, EventArgs e)
        {
            string name = modifyProductNameText.Text;

            if (!int.TryParse(modifyProductInventoryText.Text, out int instock))
            {
                MessageBox.Show("A valid number must be entered for inventory.");
                return;
            }

            if (!decimal.TryParse(modifyProductPriceText.Text, out decimal price))
            {
                MessageBox.Show("A valid number must be entered for price.");
                return;
            }

            if (!int.TryParse(modifyProductMinText.Text, out int min))
            {
                MessageBox.Show("A valid number must be entered for min.");
                return;
            }

            if (!int.TryParse(modifyProductMaxText.Text, out int max))
            {
                MessageBox.Show("A valid number must be entered for max.");
                return;
            }

            if(min > max || max < min)
            {
                MessageBox.Show("Min cannot be higher than max.");
                return;
            }

            if (instock < min || instock > max)
            {
                MessageBox.Show("Inventory value must be between the min and max values.");
                return;
            }


            chosenProduct.ProductId = chosenProduct.ProductId;
            chosenProduct.Name = name;
            chosenProduct.Price = price;
            chosenProduct.InStock = instock;
            chosenProduct.Min = min;
            chosenProduct.Max = max;


            inventory.updateProduct(chosenProduct.ProductId, chosenProduct);
            this.Close();

        }

        private void modifyProduct_Load(object sender, EventArgs e)
        {
            modifyProductCandidatePartsTable.DataSource = Inventory.AllParts;
            modifyProductAsscPartsTable.DataSource = chosenProduct.AssociatedParts;
        }

        private void modifyProductSearchButton_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(modifyProductSearchText.Text, out int PartId))
            {
                MessageBox.Show("Must enter a valid number for id");
                return;
            }

            var partChosen = inventory.lookupPart(PartId);

            if (partChosen != null)
            {
                foreach (DataGridViewRow row in modifyProductCandidatePartsTable.Rows)
                {
                    var part = (Part)row.DataBoundItem;
                    if (part != null && part.PartId == partChosen.PartId)
                    {
                        row.Selected = true;
                        modifyProductCandidatePartsTable.CurrentCell = row.Cells[0];
                        return;
                    }
                }
            } else
            {
                MessageBox.Show("Part does not exist.");
            }

        }

        private void modifyProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyProductDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmDelete = MessageBox.Show("Are you sure you want to remove this part?", "Confirm delete", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes && modifyProductAsscPartsTable.SelectedRows.Count > 0)
            {
                var selectedRow = modifyProductAsscPartsTable.SelectedRows[0];
                Part selectedPart = (Part)selectedRow.DataBoundItem;

                chosenProduct.removeAssociatedPart(selectedPart);
            }
        }

        private void modifyProductAddButton_Click(object sender, EventArgs e)
        {
            if (modifyProductCandidatePartsTable.SelectedRows.Count > 0)
            {
                var selectedRow = modifyProductCandidatePartsTable.SelectedRows[0];
                var candidatePart = selectedRow.DataBoundItem as Part;

                chosenProduct.addAssociatedPart(candidatePart);
            }
        }
    }
}
