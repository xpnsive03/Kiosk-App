﻿using System;
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
    public partial class ProductListUserControl : UserControl, IUserControlNavigation
    {
        public ProductListUserControl()
        {
            InitializeComponent();
        }

        public UserControl GetUserControl()
        {
            return this;
        }
    }
}
