﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOdonto
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuCadDentista_Click(object sender, EventArgs e)
        {
            frmCadDentista frm = new frmCadDentista();
            frm.ShowDialog();
        }
    }
}
