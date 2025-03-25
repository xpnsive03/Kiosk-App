namespace Kiosk.UI.Views
{
    partial class AdminView
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
            DashboardButton = new Button();
            MenuButton = new Button();
            InventoryButton = new Button();
            AdminContentPanel = new Panel();
            ProductButton = new Button();
            SuspendLayout();
            // 
            // DashboardButton
            // 
            DashboardButton.BackColor = Color.FromArgb(255, 128, 128);
            DashboardButton.Location = new Point(12, 126);
            DashboardButton.Name = "DashboardButton";
            DashboardButton.Size = new Size(94, 29);
            DashboardButton.TabIndex = 0;
            DashboardButton.Text = "Dashboard";
            DashboardButton.UseVisualStyleBackColor = false;
            DashboardButton.Click += DashboardButton_Click;
            // 
            // MenuButton
            // 
            MenuButton.BackColor = Color.FromArgb(255, 255, 128);
            MenuButton.Location = new Point(12, 161);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(94, 29);
            MenuButton.TabIndex = 1;
            MenuButton.Text = "Menu";
            MenuButton.UseVisualStyleBackColor = false;
            MenuButton.Click += MenuButton_Click;
            // 
            // InventoryButton
            // 
            InventoryButton.BackColor = Color.FromArgb(128, 255, 128);
            InventoryButton.Location = new Point(12, 196);
            InventoryButton.Name = "InventoryButton";
            InventoryButton.Size = new Size(94, 29);
            InventoryButton.TabIndex = 2;
            InventoryButton.Text = "Inventory";
            InventoryButton.UseVisualStyleBackColor = false;
            InventoryButton.Click += InventoryButton_Click;
            // 
            // AdminContentPanel
            // 
            AdminContentPanel.Location = new Point(112, 12);
            AdminContentPanel.Name = "AdminContentPanel";
            AdminContentPanel.Size = new Size(1052, 647);
            AdminContentPanel.TabIndex = 3;
            // 
            // ProductButton
            // 
            ProductButton.BackColor = Color.FromArgb(255, 128, 255);
            ProductButton.Location = new Point(12, 231);
            ProductButton.Name = "ProductButton";
            ProductButton.Size = new Size(94, 29);
            ProductButton.TabIndex = 4;
            ProductButton.Text = "Menu";
            ProductButton.UseVisualStyleBackColor = false;
            ProductButton.Click += ProductButton_Click;
            // 
            // AdminView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 671);
            Controls.Add(ProductButton);
            Controls.Add(AdminContentPanel);
            Controls.Add(InventoryButton);
            Controls.Add(MenuButton);
            Controls.Add(DashboardButton);
            Name = "AdminView";
            Text = "AdminView";
            ResumeLayout(false);
        }

        #endregion

        public Button DashboardButton;
        public Button MenuButton;
        public Button InventoryButton;
        private Panel AdminContentPanel;
        public Button ProductButton;
    }
}