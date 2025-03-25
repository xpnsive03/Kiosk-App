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

namespace Kiosk.UI.Views.UserControls
{
    public partial class MenuUserControl : UserControl, IUserControlNavigation
    {
        public MenuUserControl()
        {
            InitializeComponent();
        }

        public UserControl GetUserControl()
        {
            return this;
        }
    }
}
