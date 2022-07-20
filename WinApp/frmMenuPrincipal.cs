using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services.Services.Extensions;


namespace WinApp
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void operacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaProducto oFrmAltaProducto = new frmAltaProducto();
            oFrmAltaProducto.Show();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            //Text = "Leonardo Da Vinci University College. Boulogne".Translate();

        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductosALl oFrmProductosALL = new frmProductosALl();
            oFrmProductosALL.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductoEdit ofrmProductoEdit = new frmProductoEdit();
            ofrmProductoEdit.Show();
        }

        private void usuarioTestCompositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarioTest oFrmUsuarioTest=new frmUsuarioTest();
            oFrmUsuarioTest.Show();
        }

        private void testCompositeRepositoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatentesDB oFrmPatentesDB = new frmPatentesDB();
            oFrmPatentesDB.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUsoFactory oFrmUsoFactory = new frmUsoFactory();
            oFrmUsoFactory.Show();
        }
    }
}
