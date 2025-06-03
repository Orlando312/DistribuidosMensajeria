using ADMensajeria;
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
    [OperationContract]
    List<EntidadMensaje> Recuperar_HistorialPorFecha(DateTime fechaInicio, DateTime fechaFin);

    [OperationContract]
    List<EntidadMensaje> Recuperar_HistorialPorUsuario(int id_Usuario);

    [OperationContract]
    List<EntidadMensaje> Recuperar_HistorialPorPalabras(string palabra);

}
