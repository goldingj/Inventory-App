using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software1Project
{
    public partial class addProduct : Form
    {
        private Inventory inventory;
        private static int idCounter = 0;
        private Product currentProduct = new Product();
        public addProduct(Inventory inv)
        {
            InitializeComponent();
            inventory = inv;

        }

        private void addProductAddButton_Click(object sender, EventArgs e)
        {
            if (addProductCandidatePartsTable.SelectedRows.Count > 0)
            {
                var selectedRow = addProductCandidatePartsTable.SelectedRows[0];
                var candidatePart = selectedRow.DataBoundItem as Part;

                currentProduct.addAssociatedPart(candidatePart);
            }
        }

        private void addProductSaveButton_Click(object sender, EventArgs e)
        {
            
            string Name = addProductNameText.Text;

            if (!int.TryParse(addProductInventoryText.Text, out int instock))
            {
                MessageBox.Show("A valid number must be entered for inventory.");
                return;
            }

            if (!decimal.TryParse(addProductPriceText.Text, out decimal price))
            {
                MessageBox.Show("A valid number must be entered for price.");
                return;
            }

            if (!int.TryParse(addProductMinText.Text, out int min))
            {
                MessageBox.Show("A valid number must be entered for min.");
                return;
            }

            if (!int.TryParse(addProductMaxText.Text, out int max))
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


            currentProduct.ProductId = idCounter;
            currentProduct.Name = Name;
            currentProduct.Price = price;
            currentProduct.InStock = instock;
            currentProduct.Min = min;
            currentProduct.Max = max;
            

            inventory.addProduct(currentProduct);
            idCounter++;
            this.Close();
        }

        private void addProduct_Load(object sender, EventArgs e)
        {
            addProductIdText.Text = idCounter.ToString();
            addProductCandidatePartsTable.DataSource = Inventory.AllParts;
            addProductAsscPartsTable.DataSource = currentProduct.AssociatedParts;
        }

        private void addProductDeleteButton_Click(object sender, EventArgs e)
        {


            if (addProductAsscPartsTable.SelectedRows.Count > 0)
            {
                var selectedRow = addProductAsscPartsTable.SelectedRows[0];
                Part selectedPart = (Part)selectedRow.DataBoundItem;

                currentProduct.removeAssociatedPart(selectedPart);
            }
        }

        private void addProductSearchButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(addProductSearchText.Text, out int PartId))
            {
                MessageBox.Show("Must enter a valid number for id");
                return;
            }

            var partChosen = inventory.lookupPart(PartId);

            if (partChosen != null)
            {
                foreach (DataGridViewRow row in addProductCandidatePartsTable.Rows)
                {
                    var part = (Part)row.DataBoundItem;
                    if (part != null && part.PartId == partChosen.PartId)
                    {
                        row.Selected = true;
                        addProductCandidatePartsTable.CurrentCell = row.Cells[0];
                        return;
                    }
                }
            } else
            {
                MessageBox.Show("Product does not exist.");
            }
        }

        private void addProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
