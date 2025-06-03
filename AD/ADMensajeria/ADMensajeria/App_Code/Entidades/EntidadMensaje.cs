using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

[DataContract]
public class EntidadMensaje
{
    [DataMember]
    public int IdMensaje { get; set; }
    [DataMember]
    public int IdRemitente { get; set; }
    [DataMember]
    public int IdDestinatario { get; set; }
    [DataMember]
    public string Contenido { get; set; }
    [DataMember]
    public bool Editado { get; set; }
    [DataMember]
    public DateTime FechaEnvio { get; set; }
    [DataMember]
    public string Estado { get; set; }
    [DataMember]
    public DateTime FechaRegistro { get; set; }
    [DataMember]
    public DateTime FechaActualizacion { get; set; }
}