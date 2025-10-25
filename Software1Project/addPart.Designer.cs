namespace Software1Project
{
    partial class addPartTable
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
            label1 = new Label();
            addInHousePartRadio = new RadioButton();
            addOutSourcedPartRadio = new RadioButton();
            addPartIdLabel = new Label();
            addPartIdText = new TextBox();
            addPartNameText = new TextBox();
            addPartNameLabel = new Label();
            addPartInventoryText = new TextBox();
            addPartInventoryLabel = new Label();
            addPartPriceCostText = new TextBox();
            addPartPriceCostLabel = new Label();
            addPartMinPartText = new TextBox();
            addPartMinPartLabel = new Label();
            addPartMaxPartText = new TextBox();
            addPartMaxPartLabel = new Label();
            addPartMachineIdText = new TextBox();
            addPartMachineIdLabel = new Label();
            addPartSaveButton = new Button();
            addPartCancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(88, 28);
            label1.TabIndex = 0;
            label1.Text = "Add Part";
            // 
            // addInHousePartRadio
            // 
            addInHousePartRadio.AutoSize = true;
            addInHousePartRadio.Location = new Point(191, 26);
            addInHousePartRadio.Name = "addInHousePartRadio";
            addInHousePartRadio.Size = new Size(90, 24);
            addInHousePartRadio.TabIndex = 1;
            addInHousePartRadio.TabStop = true;
            addInHousePartRadio.Text = "In-House";
            addInHousePartRadio.UseVisualStyleBackColor = true;
            addInHousePartRadio.CheckedChanged += addInHousePartRadio_CheckedChanged;
            // 
            // addOutSourcedPartRadio
            // 
            addOutSourcedPartRadio.AutoSize = true;
            addOutSourcedPartRadio.Location = new Point(469, 26);
            addOutSourcedPartRadio.Name = "addOutSourcedPartRadio";
            addOutSourcedPartRadio.Size = new Size(106, 24);
            addOutSourcedPartRadio.TabIndex = 2;
            addOutSourcedPartRadio.TabStop = true;
            addOutSourcedPartRadio.Text = "Outsourced";
            addOutSourcedPartRadio.UseVisualStyleBackColor = true;
            // 
            // addPartIdLabel
            // 
            addPartIdLabel.AutoSize = true;
            addPartIdLabel.Location = new Point(207, 115);
            addPartIdLabel.Name = "addPartIdLabel";
            addPartIdLabel.Size = new Size(24, 20);
            addPartIdLabel.TabIndex = 3;
            addPartIdLabel.Text = "ID";
            // 
            // addPartIdText
            // 
            addPartIdText.Location = new Point(254, 112);
            addPartIdText.Name = "addPartIdText";
            addPartIdText.ReadOnly = true;
            addPartIdText.Size = new Size(246, 27);
            addPartIdText.TabIndex = 4;
            // 
            // addPartNameText
            // 
            addPartNameText.Location = new Point(254, 161);
            addPartNameText.Name = "addPartNameText";
            addPartNameText.Size = new Size(246, 27);
            addPartNameText.TabIndex = 6;
            // 
            // addPartNameLabel
            // 
            addPartNameLabel.AutoSize = true;
            addPartNameLabel.Location = new Point(191, 164);
            addPartNameLabel.Name = "addPartNameLabel";
            addPartNameLabel.Size = new Size(49, 20);
            addPartNameLabel.TabIndex = 5;
            addPartNameLabel.Text = "Name";
            // 
            // addPartInventoryText
            // 
            addPartInventoryText.Location = new Point(254, 212);
            addPartInventoryText.Name = "addPartInventoryText";
            addPartInventoryText.Size = new Size(246, 27);
            addPartInventoryText.TabIndex = 8;
            // 
            // addPartInventoryLabel
            // 
            addPartInventoryLabel.AutoSize = true;
            addPartInventoryLabel.Location = new Point(170, 215);
            addPartInventoryLabel.Name = "addPartInventoryLabel";
            addPartInventoryLabel.Size = new Size(70, 20);
            addPartInventoryLabel.TabIndex = 7;
            addPartInventoryLabel.Text = "Inventory";
            // 
            // addPartPriceCostText
            // 
            addPartPriceCostText.Location = new Point(254, 260);
            addPartPriceCostText.Name = "addPartPriceCostText";
            addPartPriceCostText.Size = new Size(246, 27);
            addPartPriceCostText.TabIndex = 10;
            // 
            // addPartPriceCostLabel
            // 
            addPartPriceCostLabel.AutoSize = true;
            addPartPriceCostLabel.Location = new Point(164, 267);
            addPartPriceCostLabel.Name = "addPartPriceCostLabel";
            addPartPriceCostLabel.Size = new Size(76, 20);
            addPartPriceCostLabel.TabIndex = 9;
            addPartPriceCostLabel.Text = "Price/Cost";
            // 
            // addPartMinPartText
            // 
            addPartMinPartText.Location = new Point(254, 310);
            addPartMinPartText.Name = "addPartMinPartText";
            addPartMinPartText.Size = new Size(96, 27);
            addPartMinPartText.TabIndex = 12;
            // 
            // addPartMinPartLabel
            // 
            addPartMinPartLabel.AutoSize = true;
            addPartMinPartLabel.Location = new Point(191, 313);
            addPartMinPartLabel.Name = "addPartMinPartLabel";
            addPartMinPartLabel.Size = new Size(34, 20);
            addPartMinPartLabel.TabIndex = 11;
            addPartMinPartLabel.Text = "Min";
            // 
            // addPartMaxPartText
            // 
            addPartMaxPartText.Location = new Point(460, 310);
            addPartMaxPartText.Name = "addPartMaxPartText";
            addPartMaxPartText.Size = new Size(94, 27);
            addPartMaxPartText.TabIndex = 14;
            // 
            // addPartMaxPartLabel
            // 
            addPartMaxPartLabel.AutoSize = true;
            addPartMaxPartLabel.Location = new Point(397, 313);
            addPartMaxPartLabel.Name = "addPartMaxPartLabel";
            addPartMaxPartLabel.Size = new Size(37, 20);
            addPartMaxPartLabel.TabIndex = 13;
            addPartMaxPartLabel.Text = "Max";
            // 
            // addPartMachineIdText
            // 
            addPartMachineIdText.Location = new Point(254, 368);
            addPartMachineIdText.Name = "addPartMachineIdText";
            addPartMachineIdText.Size = new Size(246, 27);
            addPartMachineIdText.TabIndex = 16;
            // 
            // addPartMachineIdLabel
            // 
            addPartMachineIdLabel.AutoSize = true;
            addPartMachineIdLabel.Location = new Point(130, 375);
            addPartMachineIdLabel.Name = "addPartMachineIdLabel";
            addPartMachineIdLabel.Size = new Size(84, 20);
            addPartMachineIdLabel.TabIndex = 15;
            addPartMachineIdLabel.Text = "Machine ID";
            // 
            // addPartSaveButton
            // 
            addPartSaveButton.Location = new Point(397, 437);
            addPartSaveButton.Name = "addPartSaveButton";
            addPartSaveButton.Size = new Size(94, 29);
            addPartSaveButton.TabIndex = 17;
            addPartSaveButton.Text = "Save";
            addPartSaveButton.UseVisualStyleBackColor = true;
            addPartSaveButton.Click += addPartSaveButton_Click;
            // 
            // addPartCancelButton
            // 
            addPartCancelButton.Location = new Point(525, 437);
            addPartCancelButton.Name = "addPartCancelButton";
            addPartCancelButton.Size = new Size(94, 29);
            addPartCancelButton.TabIndex = 18;
            addPartCancelButton.Text = "Cancel";
            addPartCancelButton.UseVisualStyleBackColor = true;
            addPartCancelButton.Click += addPartCancelButton_Click;
            // 
            // addPartTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 535);
            Controls.Add(addPartCancelButton);
            Controls.Add(addPartSaveButton);
            Controls.Add(addPartMachineIdText);
            Controls.Add(addPartMachineIdLabel);
            Controls.Add(addPartMaxPartText);
            Controls.Add(addPartMaxPartLabel);
            Controls.Add(addPartMinPartText);
            Controls.Add(addPartMinPartLabel);
            Controls.Add(addPartPriceCostText);
            Controls.Add(addPartPriceCostLabel);
            Controls.Add(addPartInventoryText);
            Controls.Add(addPartInventoryLabel);
            Controls.Add(addPartNameText);
            Controls.Add(addPartNameLabel);
            Controls.Add(addPartIdText);
            Controls.Add(addPartIdLabel);
            Controls.Add(addOutSourcedPartRadio);
            Controls.Add(addInHousePartRadio);
            Controls.Add(label1);
            Name = "addPartTable";
            Text = "Add Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton addInHousePartRadio;
        private RadioButton addOutSourcedPartRadio;
        private Label addPartIdLabel;
        private TextBox addPartIdText;
        private TextBox addPartNameText;
        private Label addPartNameLabel;
        private TextBox addPartInventoryText;
        private Label addPartInventoryLabel;
        private TextBox addPartPriceCostText;
        private Label addPartPriceCostLabel;
        private TextBox addPartMinPartText;
        private Label addPartMinPartLabel;
        private TextBox addPartMaxPartText;
        private Label addPartMaxPartLabel;
        private TextBox addPartMachineIdText;
        private Label addPartMachineIdLabel;
        private Button addPartSaveButton;
        private Button addPartCancelButton;
    }
}