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
    public partial class FormEliminar : Form
    {
        public FormEliminar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funcionalidad que carga las marcas de la base de datos en el CB
        /// </summary>
        private void CargarListadoParticipantes()
        {
            // Limpiar previamente CB
            comboBoxListaParticipantes.Items.Clear();
            // Recursos
            // Instrucción completa
            const string INSTRUCCION = "SELECT * FROM Participantes";

            // Lista clase
            List<Participantes> ParticipantesList = new List<Participantes>();

            // Asignar lista con el contenido de la base de datos
            ParticipantesList.AddRange(API_BD.ObtenerListaParticipantes(INSTRUCCION));
            // Redactar lista
            for (int indice = 0; indice < ParticipantesList.Count; indice++)
            {
                comboBoxListaParticipantes.Items.Add($"{ParticipantesList[indice].Apellidos},{ParticipantesList[indice].Nombre},{ParticipantesList[indice].Edad}");
            }
        }

        /// <summary>
        /// Al iniciarse el programa se cargarán las marcas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEliminar_Load(object sender, EventArgs e)
        {
            // Recursos
            string MensajeError = "";
            bool esValido = true; // inicializado a true

            // Clase

            try
            {
                // Cargar las marcas al iniciar le programa
                CargarListadoParticipantes();

            }
            catch (Exception error)
            {
                esValido = false;
                MensajeError = error.Message;
            }
            finally
            {
                if (!esValido) UI.MostrarError(MensajeError);

            }
        }

        /// <summary>
        /// Al pulsar el botón, se eliminará el participante que tengamos seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Recursos
            string MensajeError = "";
            bool esValido = true; // inicializado a true

            // Datos participante
            // Coge los datos seleccionados del CB
            string apellidos = comboBoxListaParticipantes.Text.Split(',')[0];
            string nombre = comboBoxListaParticipantes.Text.Split(',')[1];
            string edad = comboBoxListaParticipantes.Text.Split(',')[2];



            try
            {
                // Inicializar clase:
                Participantes participantes = new Participantes(nombre, apellidos, Conversiones.ConvertInt(edad));

                string instruccion = $"DELETE FROM Participantes WHERE Nombre = '{participantes.Nombre}' AND Edad = '{participantes.Edad}' AND Apellidos = '{participantes.Apellidos}'";

                if (UI.VentanaConfirmacion($"¿Desea eliminar a {participantes.Nombre}?") == DialogResult.Yes)
                {
                    // Si el usuario dice que sí, el usuario será eliminado
                    API_BD.EjecutarInstruccion(instruccion);
                    UI.MostrarMensaje($"El usuario {participantes.Nombre} ha sido eliminado correctamente");



                }
            }
            catch (Exception error)
            {
                esValido = false;
                MensajeError = error.Message;
            }
            finally
            {
                if (!esValido) UI.MostrarError(MensajeError);
                else
                {
                    // Limpiar formulario
                    CargarListadoParticipantes();
                    comboBoxListaParticipantes.Text = "";
                }
                buttonDelete.Enabled = false;

            }
        }
        /// <summary>
        /// Simplemente al seleccionar un participante nos habilita el botón de eliminación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxListaParticipantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Al seleccionar un participante, se habilitará automaticamente el botón del eliminación
            buttonDelete.Enabled = true;
        }
    }
}
