﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CT_NhanPhong : Form
    {
        public CT_NhanPhong()
        {
            InitializeComponent();
        }

        private void CT_NhanPhong_Load(object sender, EventArgs e)
        {

        }

        private void BtnThem_Click(object sender, EventArgs e)
        {

        }

        private void BTNXoa_Click(object sender, EventArgs e)
        {

        }

        private void BTNSua_Click(object sender, EventArgs e)
        {

        }

        private void BTNTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fm = new FormMain();
            fm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}