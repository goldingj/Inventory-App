using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software1Project
{
    public partial class modifyParts : Form
    {
        private Inventory inventory;
        private Part chosenPart;
        private int partIndex;
        public modifyParts(Inventory inv, Part selectedPart, int index)
        {
            InitializeComponent();
            inventory = inv;
            chosenPart = selectedPart;
            partIndex = index;

            modifyPartIdText.Text = chosenPart.PartId.ToString();
            modifyPartNameText.Text = chosenPart.Name;
            modifyPartInventoryText.Text = chosenPart.InStock.ToString();
            modifyPartPriceCostText.Text = chosenPart.Price.ToString();
            modifyPartMinPartText.Text = chosenPart.Min.ToString();
            modifyPartMaxPartText.Text = chosenPart.Max.ToString();

            if (chosenPart is InHouse)
            {
                InHouse inHousePart = (InHouse)chosenPart;
                modifyInHousePartRadio.Checked = true;
                modifyPartMachineIdText.Text = inHousePart.MachineID.ToString();
            }
            else if (chosenPart is Outsourced)
            {
                Outsourced outSourcedPart = (Outsourced)chosenPart;
                modifyOutSourcedPartRadio.Checked = true;
                modifyPartMachineIdText.Text = outSourcedPart.CompanyName;
            }


        }

        private void modifyPartSaveButton_Click(object sender, EventArgs e)
        {
            string name = modifyPartNameText.Text;

            if (!int.TryParse(modifyPartInventoryText.Text, out int instock))
            {
                MessageBox.Show("A valid number must be entered for inventory.");
                return;
            }

            if (!decimal.TryParse(modifyPartPriceCostText.Text, out decimal price))
            {
                MessageBox.Show("A valid number must be entered for price.");
                return;
            }

            if (!int.TryParse(modifyPartMinPartText.Text, out int min))
            {
                MessageBox.Show("A valid number must be entered for min.");
                return;
            }

            if (!int.TryParse(modifyPartMaxPartText.Text, out int max))
            {
                MessageBox.Show("A valid number must be entered for max.");
                return;
            }

            if (min > max || max < min)
            {
                MessageBox.Show("Min cannot be higher than max.");
                return;
            }

            if (instock < min || instock > max)
            {
                MessageBox.Show("Inventory value must be between the min and max values.");
                return;
            }


            if (modifyInHousePartRadio.Checked)
            {
                if (!int.TryParse(modifyPartMachineIdText.Text, out int machineId))
                {
                    MessageBox.Show("A valid number must be entered for machine id.");
                    return;
                }

                InHouse newItem = new InHouse
                {
                    PartId = chosenPart.PartId,
                    Name = name,
                    Price = price,
                    InStock = instock,
                    Min = min,
                    Max = max,
                    MachineID = machineId
                };

                inventory.updatePart(partIndex, newItem);
                this.Close();

            }

            else if (modifyOutSourcedPartRadio.Checked)
            {
                string companyName = modifyPartMachineIdText.Text;

                Outsourced newItem = new Outsourced
                {
                    PartId = chosenPart.PartId,
                    Name = name,
                    Price = price,
                    InStock = instock,
                    Min = min,
                    Max = max,
                    CompanyName = companyName
                };

                inventory.updatePart(partIndex, newItem);
                this.Close();

            }

        }

        private void modifyPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyOutSourcedPartRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (modifyInHousePartRadio.Checked)
            {
                modifyPartMachineIdLabel.Text = "Machine ID";

            }
            else if (modifyOutSourcedPartRadio.Checked)
            {
                modifyPartMachineIdLabel.Text = "Company Name";
            }
        }
    }
}

