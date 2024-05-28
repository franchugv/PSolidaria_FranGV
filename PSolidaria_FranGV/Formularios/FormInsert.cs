using PSolidaria_FranGV.API;
using PSolidaria_FranGV.Modelo_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSolidaria_FranGV.Formularios
{
    public partial class FormInsert : Form
    {
        public FormInsert()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            // Recursos
            string MensajeError = "";
            bool esValido = true; // inicializado a true
            string Instruccion = null;

            // Clase
            Participantes participante = null;
            

            try
            {
                participante = new Participantes(textBoxNombre.Text, textBoxApellidos.Text, Conversiones.ConvertInt(maskedTextBoxEdad.Text));
                // Asignar instrucción:
                Instruccion = $"INSERT INTO Participantes VALUES ('{participante.Nombre}', '{participante.Apellidos}', '{participante.Edad}', '{participante.Minutos}', {participante.Segundos})";

                // Hacer insercción
                API_BD.EjecutarInstruccion(Instruccion);

                // Mensaje exito
                UI.MostrarMensaje($"El participante {participante.Nombre} ha sido agregado correctamente");
            }
            catch (Exception error)
            {
                esValido = false;
                MensajeError = error.Message;
            }
            finally
            {
                if (!esValido) UI.MostrarError(MensajeError);
                // Si todo a ido bien, se limpiarán los objetos
                else
                {
                    textBoxNombre.Text = "";
                    textBoxApellidos.Text = "";
                    maskedTextBoxEdad.Text = "";
                }

            }
        }
    }
}
