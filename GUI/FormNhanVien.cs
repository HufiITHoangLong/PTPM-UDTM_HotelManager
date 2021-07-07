﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace GUI
{
    public partial class FormNhanVien : Form
    {
        NhanVien nv = new NhanVien();
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            DGVNhanVien.DataSource = nv.GetData();
            CBBQuyen.DisplayMember = "QUYEN";
            CBBQuyen.ValueMember = "USERNAME";
            CBBQuyen.DataSource = nv.GetQuyenNV();
        }

        
       
    }
}