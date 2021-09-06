using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace clienteWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            wsReniecWPF.wsReniecSoapClient servicio = new wsReniecWPF.wsReniecSoapClient();

            string dni = txtDni.Text.Trim();

            gvDatos.DataContext = servicio.BuscarDNI(dni);
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            wsReniecWPF.wsReniecSoapClient servicio = new wsReniecWPF.wsReniecSoapClient();

            string dni = txtDni.Text.Trim();
            string Nombres = txtNombre.Text.Trim();
            string ApellidoPaterno = txtApePate.Text.Trim();
            string ApellidoMaterno = txtApeMate.Text.Trim();
            string Sexo = txtSex.Text.Trim();
            int año = int.Parse(txtAño.Text);
            int mes = int.Parse(txtMes.Text);
            int dia = int.Parse(txtDia.Text);
            string Nacionalidad = txtNacionalidad.Text.Trim();
            string Dirección = txtDireccion.Text.Trim();

            gvDatos.DataContext = servicio.AgregarDNI(dni, Nombres, ApellidoPaterno, ApellidoMaterno, Sexo, año, mes, dia, Nacionalidad, Dirección);
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            wsReniecWPF.wsReniecSoapClient servicio = new wsReniecWPF.wsReniecSoapClient();

            string dni = txtDni.Text.Trim();
            string Nombres = txtNombre.Text.Trim();
            string ApellidoPaterno = txtApePate.Text.Trim();
            string ApellidoMaterno = txtApeMate.Text.Trim();
            string Sexo = txtSex.Text.Trim();
            int año = int.Parse(txtAño.Text);
            int mes = int.Parse(txtMes.Text);
            int dia = int.Parse(txtDia.Text);
            string Nacionalidad = txtNacionalidad.Text.Trim();
            string Dirección = txtDireccion.Text.Trim();

            gvDatos.DataContext = servicio.ActualizarDNI(dni, Nombres, ApellidoPaterno, ApellidoMaterno, Sexo, año, mes, dia, Nacionalidad, Dirección);

        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            wsReniecWPF.wsReniecSoapClient servicio = new wsReniecWPF.wsReniecSoapClient();

            string dni = txtDni.Text.Trim();

            gvDatos.DataContext = servicio.EliminarDNI(dni);
        }

        private void btnListar_Click(object sender, RoutedEventArgs e)
        {
            wsReniecWPF.wsReniecSoapClient servicio = new wsReniecWPF.wsReniecSoapClient();

            gvDatos.DataContext = servicio.ListarDNI();
        }
    }
}
