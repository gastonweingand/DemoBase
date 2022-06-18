﻿using Controller.Controllers;
using Controller.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class frmProductosALl : Form
    {
        private ProductoGetController controller = new ProductoGetController();
        public frmProductosALl()
        {
            InitializeComponent();
        }

        private void frmProductosALl_Load(object sender, EventArgs e)
        {
            try
            {
                ProductoView producto = new ProductoView();
                

                dataGridView1.DataSource= controller.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
