using System;
using System.Runtime.Serialization;

[DataContract]
public class EntidadHistorialConversacion
{
    [DataMember]
    public int IdHistorial { get; set; }

    [DataMember]
    public int IdUsuario { get; set; }

    [DataMember]
    public int IdConversacionCon { get; set; }

    [DataMember]
    public char Estado { get; set; }

    [DataMember]
    public DateTime FechaRegistro { get; set; }

    [DataMember]
    public DateTime FechaActualizacion { get; set; }

    public EntidadHistorialConversacion()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}