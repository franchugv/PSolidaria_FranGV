using PSolidaria_FranGV.API;
using PSolidaria_FranGV.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSolidaria_FranGV
{
    public partial class FormParticipantes : Form
    {
        public FormParticipantes()
        {
            InitializeComponent();
        }

        private void Controlador_Click(object sender, EventArgs e)
        {
            // Recursos
            string MensajeError = "";
            bool esValido = true; // Siempre inicializado a true
            Button Opcion = (Button) sender;

            try
            {
                switch (Opcion.Name)
                {
                    case "buttonInsert":
                        Insert();
                        break;
                    case "buttonConsultar":
                        Consultar();
                        break;
                    case "buttonDelete":
                        Delete();
                        break;
                    case "buttonUpdate": 
                        Update();
                        break;
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
            }

        }
        #region Funcionalidades Botones
        private void Insert()
        {
            FormInsert formInsert = new FormInsert();
            formInsert.ShowDialog();
        }

        private void Consultar()
        {
            FormConsultar formConsult = new FormConsultar();
            formConsult.ShowDialog();
        }

        private void Update()
        {
            FormUpdate formUpdate = new FormUpdate();
            formUpdate.ShowDialog();
        }

        private void Delete()
        {
            FormEliminar formdel = new FormEliminar();
            formdel.ShowDialog();
        }
        #endregion


    }
}
