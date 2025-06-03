using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using AccesoDatos;

public class HistorialControladora
{
    private DBDistribuidosMensajeriaEntities _context;

    public HistorialControladora()
    {
        _context = new DBDistribuidosMensajeriaEntities();
    }

    public void Insertar(EntidadHistorialConversacion historial)
    {
        _context.Database.ExecuteSqlCommand(
            "EXEC spInsertarHistorial @IdHistorial, @IdUsuario, @IdConversacionCon, @Estado, @FechaRegistro, @FechaActualizacion",
            new SqlParameter("@IdHistorial", historial.IdHistorial),
            new SqlParameter("@IdUsuario", historial.IdUsuario),
            new SqlParameter("@IdConversacionCon", historial.IdConversacionCon),
            new SqlParameter("@Estado", historial.Estado),
            new SqlParameter("@FechaRegistro", historial.FechaRegistro),
            new SqlParameter("@FechaActualizacion", historial.FechaActualizacion)
        );
    }

    public void Actualizar(EntidadHistorialConversacion historial)
    {
        _context.Database.ExecuteSqlCommand(
            "EXEC spActualizarHistorial @IdHistorial, @IdUsuario, @IdConversacionCon, @Estado, @FechaRegistro, @FechaActualizacion",
            new SqlParameter("@IdHistorial", historial.IdHistorial),
            new SqlParameter("@IdUsuario", historial.IdUsuario),
            new SqlParameter("@IdConversacionCon", historial.IdConversacionCon),
            new SqlParameter("@Estado", historial.Estado),
            new SqlParameter("@FechaRegistro", historial.FechaRegistro),
            new SqlParameter("@FechaActualizacion", historial.FechaActualizacion)
        );
    }

    public void Eliminar(int idHistorial)
    {
        _context.Database.ExecuteSqlCommand(
            "EXEC spEliminarHistorial @IdHistorial",
            new SqlParameter("@IdHistorial", idHistorial)
        );
    }

    public EntidadHistorialConversacion Obtener(int idHistorial)
    {
        return _context.Database.SqlQuery<EntidadHistorialConversacion>(
            "EXEC spObtenerHistorial @IdHistorial",
            new SqlParameter("@IdHistorial", idHistorial)
        ).FirstOrDefault();
    }

    public List<EntidadHistorialConversacion> ObtenerPorUsuario(int idUsuario)
    {
        return _context.Database.SqlQuery<EntidadHistorialConversacion>(
            "EXEC spObtenerHistorialPorUsuario @IdUsuario",
            new SqlParameter("@IdUsuario", idUsuario)
        ).ToList();
    }

    public List<EntidadHistorialConversacion> ObtenerPorConversacion(int idUsuario, int idConversacionCon)
    {
        return _context.Database.SqlQuery<EntidadHistorialConversacion>(
            "EXEC spObtenerHistorialPorConversacion @IdUsuario, @IdConversacionCon",
            new SqlParameter("@IdUsuario", idUsuario),
            new SqlParameter("@IdConversacionCon", idConversacionCon)
        ).ToList();
    }
}