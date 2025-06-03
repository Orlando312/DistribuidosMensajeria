using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface IService
{
    #region Mensaje
    [OperationContract]
    void InsertarMensaje(EntidadMensaje mensaje);

    [OperationContract]
    void ActualizarMensaje(EntidadMensaje mensaje);

    [OperationContract]
    void EliminarMensaje(int idMensaje);

    [OperationContract]
    EntidadMensaje ObtenerMensaje(int idMensaje);

    [OperationContract]
    List<EntidadMensaje> ObtenerMensajesPorUsuario(int idUsuario);

    [OperationContract]
    List<EntidadMensaje> ObtenerMensajesPorConversacion(int idRemitente, int idDestinatario);

    [OperationContract]
    List<EntidadMensaje> ObtenerTodosLosMensajes();

    [OperationContract]
    List<EntidadMensaje> ObtenerMensajesPorEstado(string estado);
    #endregion

    #region HistorialConversacion
    [OperationContract]
    void InsertarHistorial(EntidadHistorialConversacion historial);

    [OperationContract]
    void ActualizarHistorial(EntidadHistorialConversacion historial);

    [OperationContract]
    void EliminarHistorial(int idHistorial);

    [OperationContract]
    EntidadHistorialConversacion ObtenerHistorial(int idHistorial);

    [OperationContract]
    List<EntidadHistorialConversacion> ObtenerHistorialPorUsuario(int idUsuario);

    [OperationContract]
    List<EntidadHistorialConversacion> ObtenerHistorialPorConversacion(int idUsuario, int idConversacionCon);
    #endregion
}