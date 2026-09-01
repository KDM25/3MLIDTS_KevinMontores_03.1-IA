using System;
using System.Globalization;
using System.Windows.Forms;

namespace _3MLIDTS_KevinMontores_03
{
    public partial class Form1 : Form
    {
        private const double CERO_ABSOLUTO_CELSIUS = -273.15;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Permite realizar el cálculo presionando Enter.
            AcceptButton = btnCalcular;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Este evento puede permanecer vacío.
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!EscalaSeleccionada())
            {
                MostrarError(
                    "Seleccione la escala de temperatura que desea convertir.",
                    "Escala no seleccionada"
                );
                return;
            }

            TextBox campoOrigen = ObtenerCampoOrigen();

            if (!IntentarConvertirNumero(campoOrigen.Text, out double temperatura))
            {
                MostrarError(
                    "Ingrese un valor numérico válido en el campo seleccionado.",
                    "Valor no válido"
                );

                campoOrigen.Focus();
                campoOrigen.SelectAll();
                return;
            }

            double celsius;
            double fahrenheit;
            double kelvin;

            if (rbCelsius.Checked)
            {
                celsius = temperatura;

                if (celsius < CERO_ABSOLUTO_CELSIUS)
                {
                    MostrarError(
                        "La temperatura no puede ser menor que -273.15 °C.",
                        "Temperatura no válida"
                    );
                    return;
                }

                fahrenheit = (celsius * 9.0 / 5.0) + 32.0;
                kelvin = celsius + 273.15;
            }
            else if (rbFahrenheit.Checked)
            {
                fahrenheit = temperatura;
                celsius = (fahrenheit - 32.0) * 5.0 / 9.0;

                if (celsius < CERO_ABSOLUTO_CELSIUS)
                {
                    MostrarError(
                        "La temperatura no puede ser menor que -459.67 °F.",
                        "Temperatura no válida"
                    );
                    return;
                }

                kelvin = celsius + 273.15;
            }
            else
            {
                kelvin = temperatura;

                if (kelvin < 0)
                {
                    MostrarError(
                        "La temperatura en Kelvin no puede ser menor que 0.",
                        "Temperatura no válida"
                    );
                    return;
                }

                celsius = kelvin - 273.15;
                fahrenheit = (celsius * 9.0 / 5.0) + 32.0;
            }

            MostrarResultados(celsius, fahrenheit, kelvin);
            ConfigurarCampos();
        }

        private bool EscalaSeleccionada()
        {
            return rbCelsius.Checked ||
                   rbFahrenheit.Checked ||
                   rbKelvin.Checked;
        }

        private TextBox ObtenerCampoOrigen()
        {
            if (rbCelsius.Checked)
                return tbxCelsius;

            if (rbFahrenheit.Checked)
                return tbxFahrenheit;

            return tbxKelvin;
        }

        private bool IntentarConvertirNumero(string texto, out double numero)
        {
            texto = texto.Trim();

            // Primero utiliza la configuración regional del equipo.
            if (double.TryParse(
                    texto,
                    NumberStyles.Float,
                    CultureInfo.CurrentCulture,
                    out numero))
            {
                return true;
            }

            // También acepta el punto como separador decimal.
            return double.TryParse(
                texto,
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out numero
            );
        }

        private void MostrarResultados(
            double celsius,
            double fahrenheit,
            double kelvin)
        {
            tbxCelsius.Text = celsius.ToString("0.##");
            tbxFahrenheit.Text = fahrenheit.ToString("0.##");
            tbxKelvin.Text = kelvin.ToString("0.##");
        }

        private void ConfigurarCampos()
        {
            // El campo de origen permanece habilitado para permitir correcciones.
            tbxCelsius.Enabled = rbCelsius.Checked;
            tbxFahrenheit.Enabled = rbFahrenheit.Checked;
            tbxKelvin.Enabled = rbKelvin.Checked;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxCelsius.Clear();
            tbxFahrenheit.Clear();
            tbxKelvin.Clear();

            tbxCelsius.Enabled = true;
            tbxFahrenheit.Enabled = true;
            tbxKelvin.Enabled = true;

            rbCelsius.Checked = false;
            rbFahrenheit.Checked = false;
            rbKelvin.Checked = false;

            tbxCelsius.Focus();
        }

        private void MostrarError(string mensaje, string titulo)
        {
            MessageBox.Show(
                mensaje,
                titulo,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}