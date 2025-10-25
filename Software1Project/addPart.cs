using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software1Project
{
    public partial class addPartTable : Form
    {
        private Inventory inventory;
        private static int idCounter = 0;
        public addPartTable(Inventory inv)
        {
            InitializeComponent();
            inventory = inv;
        }

        private void addPartSaveButton_Click(object sender, EventArgs e)
        {
            string name = addPartNameText.Text;

            if (!int.TryParse(addPartInventoryText.Text, out int instock))
            {
                MessageBox.Show("A valid number must be entered for inventory.");
                return;
            }

            if (!decimal.TryParse(addPartPriceCostText.Text, out decimal price))
            {
                MessageBox.Show("A valid number must be entered for price.");
                return;
            }

            if (!int.TryParse(addPartMinPartText.Text, out int min))
            {
                MessageBox.Show("A valid number must be entered for min.");
                return;
            }

            if (!int.TryParse(addPartMaxPartText.Text, out int max))
            {
                MessageBox.Show("A valid number must be entered for max.");
                return;
            }

            if (max < min || min > max)
            {
                MessageBox.Show("Min cannot be higher than max.");
                return;
            }

            if (instock < min || instock > max)
            {
                MessageBox.Show("Inventory value must be between the min and max values.");
                return;
            }

            if (addInHousePartRadio.Checked)
            {
                if (!int.TryParse(addPartMachineIdText.Text, out int machineId))
                {
                    MessageBox.Show("A valid number must be entered for machine id.");
                    return;
                }

                InHouse newItem = new InHouse
                {
                    PartId = idCounter,
                    Name = name,
                    Price = price,
                    InStock = instock,
                    Min = min,
                    Max = max,
                    MachineID = machineId
                };

                inventory.addPart(newItem);
                idCounter++;
                this.Close();

            }

            else if (addOutSourcedPartRadio.Checked)
            {
                string companyName = addPartMachineIdText.Text;

                Outsourced newItem = new Outsourced
                {
                    PartId = idCounter,
                    Name = name,
                    Price = price,
                    InStock = instock,
                    Min = min,
                    Max = max,
                    CompanyName = companyName
                };

                inventory.addPart(newItem);
                idCounter++;
                this.Close();

            }

        }

        private void addInHousePartRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (addInHousePartRadio.Checked)
            {
                addPartMachineIdLabel.Text = "Machine ID";

            }
            else if (addOutSourcedPartRadio.Checked)
            {
                addPartMachineIdLabel.Text = "Company Name";
            }
        }

        private void addPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
