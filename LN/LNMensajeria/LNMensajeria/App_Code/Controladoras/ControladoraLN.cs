using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ADMensajeria;
/// <summary>
/// Descripción breve de ControladoraLN
/// </summary>
public class ControladoraLN
{
    ComunicacionAD comunicacionAD;

    public ControladoraLN()
    {
        comunicacionAD = new ComunicacionAD();
    }

    #region metodos
    public List<EntidadMensaje> Recuperar_HistorialPorFecha(DateTime fechaInicio, DateTime fechaFin)
    {
        List<EntidadMensaje> lstMensaje = comunicacionAD.ObtenerMensajesPorEstado("H").FindAll(x => x.FechaEnvio > fechaInicio && x.FechaEnvio < fechaFin)
            .OrderBy(x => x.FechaEnvio).ToList();

        return lstMensaje;
    }

    public List<EntidadMensaje> Recuperar_HistorialPorUsuario(int id_Usuario)
    {
        List<EntidadMensaje> lstMensaje = comunicacionAD.ObtenerMensajesPorEstado("H").FindAll(x => x.IdRemitente == id_Usuario)
            .OrderBy(x => x.FechaEnvio).ToList();

        return lstMensaje;
    }

    public List<EntidadMensaje> Recuperar_HistorialPorPalabras(string palabra)
    {
        List<EntidadMensaje> lstMensaje = comunicacionAD.ObtenerMensajesPorEstado("H").FindAll(x =>
                !string.IsNullOrEmpty(x.Contenido) && x.Contenido.IndexOf(palabra, StringComparison.OrdinalIgnoreCase) >= 0)
            .OrderBy(x => x.FechaEnvio).ToList();

        return lstMensaje;
    }

    #endregion
}