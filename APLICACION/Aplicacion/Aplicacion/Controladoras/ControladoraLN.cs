using Aplicacion.LNMensajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplicacion.Controladoras
{
    public class ControladoraLN
    {
        private ServiceClient LNMensajeria;

        public ControladoraLN()
        {
            LNMensajeria = new ServiceClient();
        }

        public List<EntidadMensaje> Recuperar_HistorialPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return LNMensajeria.Recuperar_HistorialPorFecha(fechaInicio, fechaFin).ToList();
        }

        public List<EntidadMensaje> Recuperar_HistorialPorUsuario(int idUsuario)
        {
            return LNMensajeria.Recuperar_HistorialPorUsuario(idUsuario).ToList();
        }

        public List<EntidadMensaje> Recuperar_HistorialPorPalabras(string palabra)
        {
            return LNMensajeria.Recuperar_HistorialPorPalabras(palabra).ToList();
        }
    }
}