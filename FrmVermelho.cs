﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste_michele
{
    public partial class FrmVermelho : Form
    {
        public FrmVermelho()
        {
            InitializeComponent();
        }

        private void exibirFrmamarelo_Click(object sender, EventArgs e)
        {
            FrmAmarelo frm = new FrmAmarelo(); //indico qual form será aberto
            this.Hide();
            frm.ShowDialog();
        }

        private void exibirFrmazul_Click(object sender, EventArgs e)
        {
            FrmAzul frm = new FrmAzul(); //indico qual form será aberto
            this.Hide();
            frm.ShowDialog();
        }

        private void exibirFrmvermelho_Click(object sender, EventArgs e)
        {
            FrmVermelho frm = new FrmVermelho(); //indico qual form será aberto
            this.Hide();
            frm.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
