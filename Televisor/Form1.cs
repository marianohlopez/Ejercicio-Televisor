using System.Reflection;
using System.Text.RegularExpressions;

namespace Televisor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Televisor newTelevisor = new Televisor("Samsung", "Silver", 50);
        Domicilio domicilio = new Domicilio("Jonte", 5299, "Monte Castro");

        private void Form1_Load(object sender, EventArgs e)
        {
            string nombreUsuario = Microsoft.VisualBasic.Interaction.InputBox
                ("Ingrese nombre de usuario", "Datos");
            Persona usuario = new Persona(nombreUsuario, domicilio);
            if (string.IsNullOrWhiteSpace(usuario.Nombre))
            {
                MessageBox.Show("Debe ingresar un nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                usuarioLabel.Text = $"Bienvenido/a, {usuario.Nombre}!";
                labelDireccion.Text = $"{domicilio}";
                labelCanal.Text = $"Canal: {newTelevisor.obtenerCanalActual()}";
            }
        }

        private void btnPrenderTv_Click(object sender, EventArgs e)
        {
            newTelevisor.CambiarEstado();
            if (newTelevisor.verPrendido())
            {
                labelEstado.Text = "Encendido";
                return;
            }
            labelEstado.Text = "Apagado";
        }

        private void btnCambiarCanal_Click(object sender, EventArgs e)
        {
            newTelevisor.cambiarCanal();
            labelCanal.Text = $"Canal: {newTelevisor.obtenerCanalActual()}";
        }

        private void txtNumCanal_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(txtNumCanal.Text, out int numCanal);
            newTelevisor.cambiarCanal(numCanal);
            labelCanal.Text = $"Canal: {newTelevisor.obtenerCanalActual()}";
        }
    }
}
