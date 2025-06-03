using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

public class Service : IService
{
    #region Mensaje
    private readonly MensajeControladora mensajeControladora = new MensajeControladora();

    public void InsertarMensaje(EntidadMensaje mensaje)
    {
        mensajeControladora.Insertar(mensaje);
    }

    public void ActualizarMensaje(EntidadMensaje mensaje)
    {
        mensajeControladora.Actualizar(mensaje);
    }

    public void EliminarMensaje(int idMensaje)
    {
        mensajeControladora.Eliminar(idMensaje);
    }

    public EntidadMensaje ObtenerMensaje(int idMensaje)
    {
        return mensajeControladora.Obtener(idMensaje);
    }

    public List<EntidadMensaje> ObtenerMensajesPorUsuario(int idUsuario)
    {
        return mensajeControladora.ObtenerPorUsuario(idUsuario);
    }

    public List<EntidadMensaje> ObtenerMensajesPorConversacion(int idRemitente, int idDestinatario)
    {
        return mensajeControladora.ObtenerPorConversacion(idRemitente, idDestinatario);
    }

    public List<EntidadMensaje> ObtenerTodosLosMensajes()
    {
        return mensajeControladora.ObtenerTodos();
    }

    public List<EntidadMensaje> ObtenerMensajesPorEstado(string estado)
    {
        return mensajeControladora.ObtenerPorEstado(estado);
    }
    #endregion

    #region HistorialConversacion
    private readonly HistorialControladora historialControladora = new HistorialControladora();

    public void InsertarHistorial(EntidadHistorialConversacion historial)
    {
        historialControladora.Insertar(historial);
    }

    public void ActualizarHistorial(EntidadHistorialConversacion historial)
    {
        historialControladora.Actualizar(historial);
    }

    public void EliminarHistorial(int idHistorial)
    {
        historialControladora.Eliminar(idHistorial);
    }

    public EntidadHistorialConversacion ObtenerHistorial(int idHistorial)
    {
        return historialControladora.Obtener(idHistorial);
    }

    public List<EntidadHistorialConversacion> ObtenerHistorialPorUsuario(int idUsuario)
    {
        return historialControladora.ObtenerPorUsuario(idUsuario);
    }

    public List<EntidadHistorialConversacion> ObtenerHistorialPorConversacion(int idUsuario, int idConversacionCon)
    {
        return historialControladora.ObtenerPorConversacion(idUsuario, idConversacionCon);
    }
    #endregion


}
