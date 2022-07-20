using Services.DomainModel.Security.Composite;
using Services.Services;
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
    public partial class frmPatentesDB : Form
    {
        public frmPatentesDB()
        {
            InitializeComponent();
        }

        private void frmPatentesDB_Load(object sender, EventArgs e)
        {
            SetearForm();
            Botonera();


        }

        private void Botonera()
        {
            Usuario user = new Usuario();
            foreach (var item in LoginService.SelectAllPatentes())
            {
                Console.WriteLine(item.FormName + " " + item.MenuItemName);
            }
            Familia familia = LoginService.SelectOneFamilia(Guid.Parse("C3CB0322-EE8F-40C2-8496-03EB1A714706"));
            Console.WriteLine(familia.Nombre);
            //RecorrerComposite(familia.GetChildrens(), "-");

            List<Button> lBotones = new List<Button>();


            user.Permisos.Clear();
            user.Permisos.Add(familia);

            int iInicioBotones = 150;
            int iMargenBotones = 27;
            int iAnchoBotones = 190;

            foreach (var item in user.GetPatentesAll())
            {
                Button oBoton = new Button();
                oBoton.Left = iMargenBotones;
                oBoton.Width = iAnchoBotones;
                oBoton.Top = iInicioBotones;
                oBoton.FlatStyle=FlatStyle.Flat;
                oBoton.FlatAppearance.BorderSize = 0;   
                oBoton.ForeColor = Color.AntiqueWhite;
                oBoton.BackColor = Color.LightSlateGray;
                
                oBoton.Text = $"Patente: {item.MenuItemName}";  //item.FormName.ToString();
                lBotones.Add(oBoton);
                iInicioBotones += oBoton.Height + 2;
                this.Controls.Add(oBoton);
            }

        }

        private void SetearForm()
        {
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
