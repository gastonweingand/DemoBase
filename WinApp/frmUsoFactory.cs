using BLL.BusinessExceptions;
using DomainModel;
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
    public partial class frmUsoFactory : Form
    {
        public frmUsoFactory()
        {
            InitializeComponent();
        }

        private void frmUsoFactory_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Customer customer = new Customer()
                {
                    Doc = txtDNI.Text,
                    DateBirth = Convert.ToDateTime(txtFechaNacimiento.Text),
                    FirstName = txtNombre.Text,
                    LastName = txtApellido.Text,
                };

                BLL.Services.CustomerService.Current.Add(customer);
            }
            catch (ClienteMayorEdadException ex)
            {
                MessageBox.Show($"Exception del negocio: {ex.Message}, Helplink: {ex.HelpLink}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mensaje: {ex.Message}, StackTrace: {ex.StackTrace}");

            }
        }
    }
}
