﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Salsa.TestManager.Views
{
    public partial class ManxcatView : UserControl
    {
        public ManxcatView()
        {
            InitializeComponent();
        }
        public object DataSource
        {
            get
            {
                return bindingSource.DataSource;
            }
            set
            {
                bindingSource.DataSource = value;
            }
        }
    }
}
