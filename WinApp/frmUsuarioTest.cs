using BLL.BusinessExceptions;
using DomainModel;
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
using Component = Services.DomainModel.Security.Composite.Component;

namespace WinApp
{
    public partial class frmUsuarioTest : Form
    {
        public frmUsuarioTest()
        {
            InitializeComponent();
        }

        private void frmUsuarioTest_Load(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Password = "qwerty";
            Console.WriteLine(user.HashPassword);

            Patente patenteGet = LoginService.SelectOnePatente(Guid.Parse("3EA3B92B-6024-4D88-A0DF-3439C2E526D4"));

            Console.WriteLine(patenteGet.FormName);

            foreach (var item in LoginService.SelectAllPatentes())
            {
                Console.WriteLine(item.FormName + " " + item.MenuItemName);
            }

            Familia familia = LoginService.SelectOneFamilia(Guid.Parse("C3CB0322-EE8F-40C2-8496-03EB1A714706"));

            Console.WriteLine(familia.Nombre);

            RecorrerComposite(familia.GetChildrens(), "-");

            user.Permisos.Clear();

            user.Permisos.Add(familia);

            foreach (var item in user.GetPatentesAll())
            {
                Console.WriteLine($"Patente: {item.MenuItemName}");
            }

            Patente patente = new Patente() { FormName = "frmGestionVentas", MenuItemName = "Gestión de ventas" };
            Patente patente2 = new Patente() { FormName = "frmGestionCompras", MenuItemName = "Gestión de compras" };
            Patente patente3 = new Patente() { FormName = "frmReportesGenerales", MenuItemName = "Reportes general" };
            Patente patente4 = new Patente() { FormName = "frmPerfilUsuario", MenuItemName = "Perfil" };
            Patente patente5 = new Patente() { FormName = "frmPrincipal", MenuItemName = "Principal" };

            Familia familiaGestionVentas = new Familia(patente, "Rol Gestión Ventas");
            Familia familiaGestionCompras = new Familia(patente2, "Rol Gestión Compras");
            familiaGestionCompras.Add(patente3);

            Familia administrador = new Familia(familiaGestionVentas, "Rol Administrador");
            administrador.Add(familiaGestionCompras);
            administrador.Add(patente4);
            administrador.Add(patente5);

            Usuario usuario = new Usuario();
            usuario.Permisos.Add(administrador);
            usuario.Permisos.Add(patente5);

            Console.WriteLine("Listado de permisos de mi usuario:");

            List<Patente> patentesUser = usuario.GetPatentesAll();
            int iCantidadPatentes=patentesUser.Count;

            List<Button> lBotones = new List<Button>();

            int iInicioBotones = 50;
            int iMargenBotones = 30;
            int iAnchoBotones = 200;

            foreach (var item in patentesUser)
            {
                Button oBoton = new Button();
                oBoton.Left = iMargenBotones;
                oBoton.Width = iAnchoBotones;
                oBoton.Top = iInicioBotones;
                oBoton.Text = item.FormName.ToString();
                lBotones.Add(oBoton);
                iInicioBotones += oBoton.Height + 2;
                this.Controls.Add(oBoton);
            }
        }
        private static void RecorrerComposite(List<Component> components, string tab)
        {
            foreach (var item in components)
            {
                if (item.ChildrenCount() == 0)
                {
                    Patente patente1 = item as Patente;
                    Console.WriteLine($"{tab} Patente: {patente1.FormName}");
                }
                else
                {
                    Familia familia = item as Familia;
                    Console.WriteLine($"{tab} Familia: {familia.Nombre}");
                    RecorrerComposite(familia.GetChildrens(), tab + "-");
                }
            }
        }
    }
}
