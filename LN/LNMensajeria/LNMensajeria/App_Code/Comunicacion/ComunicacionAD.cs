using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ADMensajeria;
using System.ServiceModel;

public class ComunicacionAD
{
    #region Variables miembro
    private ServiceClient adMensajeriaClient;
    #endregion

    #region Constructor

    public ComunicacionAD()
    {
        adMensajeriaClient = new ServiceClient();
    }
    #endregion

    #region Métodos

    public void InsertarMensaje(EntidadMensaje mensaje)
    {
        adMensajeriaClient.InsertarMensaje(mensaje);
    }

    public void ActualizarMensaje(EntidadMensaje mensaje)
    {
        adMensajeriaClient.ActualizarMensaje(mensaje);
    }

    public void EliminarMensaje(int idMensaje)
    {
        adMensajeriaClient.EliminarMensaje(idMensaje);
    }

    public EntidadMensaje ObtenerMensaje(int idMensaje)
    {
        return adMensajeriaClient.ObtenerMensaje(idMensaje);
    }

    public List<EntidadMensaje> ObtenerMensajesPorUsuario(int idUsuario)
    {
        return new List<EntidadMensaje>(adMensajeriaClient.ObtenerMensajesPorUsuario(idUsuario));
    }

    public List<EntidadMensaje> ObtenerMensajesPorConversacion(int idRemitente, int idDestinatario)
    {
        return new List<EntidadMensaje>(adMensajeriaClient.ObtenerMensajesPorConversacion(idRemitente, idDestinatario));
    }

    public List<EntidadMensaje> ObtenerTodosLosMensajes()
    {
        return new List<EntidadMensaje>(adMensajeriaClient.ObtenerTodosLosMensajes());
    }

    public List<EntidadMensaje> ObtenerMensajesPorEstado(string estado)
    {
        return new List<EntidadMensaje>(adMensajeriaClient.ObtenerMensajesPorEstado(estado));
    }

    public void InsertarHistorial(EntidadHistorialConversacion historial)
    {
        adMensajeriaClient.InsertarHistorial(historial);
    }

    public void ActualizarHistorial(EntidadHistorialConversacion historial)
    {
        adMensajeriaClient.ActualizarHistorial(historial);
    }

    public void EliminarHistorial(int idHistorial)
    {
        adMensajeriaClient.EliminarHistorial(idHistorial);
    }

    public EntidadHistorialConversacion ObtenerHistorial(int idHistorial)
    {
        return adMensajeriaClient.ObtenerHistorial(idHistorial);
    }

    public List<EntidadHistorialConversacion> ObtenerHistorialPorUsuario(int idUsuario)
    {
        return new List<EntidadHistorialConversacion>(adMensajeriaClient.ObtenerHistorialPorUsuario(idUsuario));
    }

    public List<EntidadHistorialConversacion> ObtenerHistorialPorConversacion(int idUsuario, int idConversacionCon)
    {
        return new List<EntidadHistorialConversacion>(adMensajeriaClient.ObtenerHistorialPorConversacion(idUsuario, idConversacionCon));
    }

    #endregion
}