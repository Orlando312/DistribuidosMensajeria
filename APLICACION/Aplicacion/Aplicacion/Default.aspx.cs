using Aplicacion.LNMensajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aplicacion
{
    public partial class _Default : Page
    {
        private ServiceClient LNMensajeria;

        private Controladoras.ControladoraLN controladoraLN = new Controladoras.ControladoraLN();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio, fechaFin;
            if (DateTime.TryParse(txtFechaInicio.Text, out fechaInicio) &&
                DateTime.TryParse(txtFechaFin.Text, out fechaFin))
            {
                List<EntidadMensaje> resultados = controladoraLN.Recuperar_HistorialPorFecha(fechaInicio, fechaFin);
                gvResultados.DataSource = resultados;
                gvResultados.DataBind();
            } else
            {
                gvResultados.DataSource = null;
                gvResultados.DataBind();
            }
        }

        protected void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            int idUsuario;
            if (int.TryParse(txtIdUsuario.Text, out idUsuario))
            {
                List<EntidadMensaje> resultados = controladoraLN.Recuperar_HistorialPorUsuario(idUsuario);
                gvResultados.DataSource = resultados;
                gvResultados.DataBind();
            } else
            {
                gvResultados.DataSource = null;
                gvResultados.DataBind();
            }
        }

        protected void btnBuscarPalabra_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text?.Trim();
            if (!string.IsNullOrEmpty(palabra))
            {
                List<EntidadMensaje> resultados = controladoraLN.Recuperar_HistorialPorPalabras(palabra);
                gvResultados.DataSource = resultados;
                gvResultados.DataBind();
            } else
            {
                gvResultados.DataSource = null;
                gvResultados.DataBind();
            }
        }
    }
}