using ADMensajeria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

public class Service : IService
{
    private readonly ControladoraLN controladoraLN;

    public Service()
    {
        controladoraLN = new ControladoraLN();
    }

    public List<EntidadMensaje> Recuperar_HistorialPorFecha(DateTime fechaInicio, DateTime fechaFin)
    {
        return controladoraLN.Recuperar_HistorialPorFecha( fechaInicio,  fechaFin);
    }

    public List<EntidadMensaje> Recuperar_HistorialPorUsuario(int id_Usuario)
    {
        return controladoraLN.Recuperar_HistorialPorUsuario(id_Usuario);
    }

    public List<EntidadMensaje> Recuperar_HistorialPorPalabras(string palabra)
    {
        return controladoraLN.Recuperar_HistorialPorPalabras(palabra);
    }
}
