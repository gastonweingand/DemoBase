using Controller.Controllers;
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
    public partial class frmAltaProducto : Form
    {
        private AltaProductoController controller = new AltaProductoController();
        public frmAltaProducto()
        {
            InitializeComponent();
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoView producto = new ProductoView();
                //producto.Codigo = "";
                //producto.Descripcion = "Test de desc.";
                producto.Precio = 1234;

                controller.Add(producto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }
    }
}
