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
    public partial class frmProductoEdit : Form
    {
        private ProductoUpdateController controllerEdit = new ProductoUpdateController();
        private ProductoGetController controller = new ProductoGetController();
        public frmProductoEdit()
        {
            InitializeComponent();
        }
        
        private void frmProductoEdit_Load(object sender, EventArgs e)
        {
            SetGrid();
            CoordinarBotones(0);
            DisableControls();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadControlsFromGrid();
        }
        private void SetGrid()
        {
            ProductoView producto = new ProductoView();
            dataGridView1.DataSource = controller.GetAll();

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            dataGridView1.Columns[0].Visible = false;//id
            dataGridView1.Columns[1].Visible = true;//Codigo
            dataGridView1.Columns[2].Visible = true;//Descripcion
            dataGridView1.Columns[3].Visible = true;//Precio
            dataGridView1.Columns[4].Visible = true;//DescripcionLarga

            dataGridView1.Columns[0].Width = 0;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 300;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoView oProductoView = new ProductoView();
                oProductoView.Id = Guid.Parse(txtIdProducto.Text);
                oProductoView.Descripcion = txtDescripcion.Text;
                oProductoView.Codigo = txtCodigo.Text;
                oProductoView.Precio = Decimal.Parse(txtPrecio.Text);
                controllerEdit.Update(oProductoView);
                SetGrid();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally 
            {
                CoordinarBotones(0);
                DisableControls();
            }

        }

        private void LoadControlsFromGrid()
        {
            txtIdProducto.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtCodigo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPrecio.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
        private void CoordinarBotones(int iOpcion)
        {
            if (iOpcion == 0)
            {
                this.btnEdit.Visible = true;
                this.btnSave.Visible = false;
                this.btnUndo.Visible = false;
                this.btnExit.Visible = true;
            }
            else
            {
                this.btnEdit.Visible = false;
                this.btnSave.Visible = true;
                this.btnUndo.Visible = true;
                this.btnExit.Visible = true;
            }

        }
        private void EnableControls()
        {
            txtCodigo.Enabled = true;
            txtDescripcion.Enabled = true;
            txtPrecio.Enabled = true;
        }
        private void DisableControls()
        {
            txtCodigo.Enabled = false;
            txtDescripcion.Enabled = false;
            txtPrecio.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CoordinarBotones(1);
            EnableControls();

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            CoordinarBotones(0);
            DisableControls();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*
            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                String strFila = Row.Index.ToString();
                string Valor = Convert.ToString(Row.Cells["Descripcion"].Value);

                if (Valor == this.txtBusqueda.Text)
                {
                    int iFila = Row.Index;
                    dataGridView1.Rows[iFila].DefaultCellStyle.BackColor = Color.Red;
                }
            }*/
            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                String strFila = Row.Index.ToString();
                foreach (DataGridViewCell cell in Row.Cells)
                {
                    string Valor = Convert.ToString(cell.Value);
                    if (Valor == this.txtBusqueda.Text)
                    {
                        dataGridView1.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.Red;
                    }
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                String strFila = Row.Index.ToString();
                foreach (DataGridViewCell cell in Row.Cells)
                {
                    string Valor = Convert.ToString(cell.Value);
                    int iLong = (this.txtBusqueda.Text.Trim()).Length;
                    if (Valor.Substring(0,iLong) == this.txtBusqueda.Text.Trim())
                    {
                        dataGridView1.Rows[Convert.ToInt32(strFila)].DefaultCellStyle.BackColor = Color.Red;
                    }
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetGrid();
        }
    }
}
