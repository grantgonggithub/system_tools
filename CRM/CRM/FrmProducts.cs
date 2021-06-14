using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CRM
{
    public partial class FrmProducts : skinBase
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            FrmBuy frmBuy = new FrmBuy();
            frmBuy.ShowDialog();
        }
    }
}
