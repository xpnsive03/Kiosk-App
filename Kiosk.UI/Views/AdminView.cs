using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kiosk.Core.Services.Navigations;
using Kiosk.UI.Views.UserControls;
using MediatR;

namespace Kiosk.UI.Views
{
    public partial class AdminView : Form
    {
        private readonly UserControlNavigationManager _navigationManager;
        public AdminView()
        {
            InitializeComponent();
            _navigationManager = new UserControlNavigationManager(AdminContentPanel);
            _navigationManager.SetNavigation<AdminDashboardUserControl>();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            _navigationManager.SetNavigation<AdminDashboardUserControl>();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            _navigationManager.SetNavigation<MenuUserControl>();
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            _navigationManager.SetNavigation<InventoryUserControl>();
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            _navigationManager.SetNavigation<ProductListUserControl>();
        }
    }
}
