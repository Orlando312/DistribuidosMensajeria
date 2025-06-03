using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using AccesoDatos;
using System.Configuration;


/// <summary>
/// Descripción breve de MensajeControladora
/// </summary>
public class MensajeControladora
{
    private DBDistribuidosMensajeriaEntities _context;

    public MensajeControladora()
    {
        _context = new DBDistribuidosMensajeriaEntities();
    }

    public void Insertar(EntidadMensaje mensaje)
    {
        _context.Database.ExecuteSqlCommand(
            "EXEC spInsertarMensaje @IdMensaje, @IdRemitente, @IdDestinatario, @Contenido, @Editado, @FechaEnvio, @Estado, @FechaRegistro, @FechaActualizacion",
            new SqlParameter("@IdMensaje", mensaje.IdMensaje),
            new SqlParameter("@IdRemitente", mensaje.IdRemitente),
            new SqlParameter("@IdDestinatario", mensaje.IdDestinatario),
            new SqlParameter("@Contenido", mensaje.Contenido ?? (object)DBNull.Value),
            new SqlParameter("@Editado", mensaje.Editado),
            new SqlParameter("@FechaEnvio", mensaje.FechaEnvio),
            new SqlParameter("@Estado", mensaje.Estado ?? (object)DBNull.Value),
            new SqlParameter("@FechaRegistro", mensaje.FechaRegistro),
            new SqlParameter("@FechaActualizacion", mensaje.FechaActualizacion)
        );
    }

    public void Actualizar(EntidadMensaje mensaje)
    {
        _context.Database.ExecuteSqlCommand(
            "EXEC spActualizarMensaje @IdMensaje, @Contenido, @Editado, @FechaEnvio, @Estado, @FechaRegistro, @FechaActualizacion",
            new SqlParameter("@IdMensaje", mensaje.IdMensaje),
            new SqlParameter("@Contenido", mensaje.Contenido ?? (object)DBNull.Value),
            new SqlParameter("@Editado", mensaje.Editado),
            new SqlParameter("@FechaEnvio", mensaje.FechaEnvio),
            new SqlParameter("@Estado", mensaje.Estado ?? (object)DBNull.Value),
            new SqlParameter("@FechaRegistro", mensaje.FechaRegistro),
            new SqlParameter("@FechaActualizacion", mensaje.FechaActualizacion)
        );
    }

    public void Eliminar(int idMensaje)
    {
        _context.Database.ExecuteSqlCommand(
            "EXEC spEliminarMensaje @IdMensaje",
            new SqlParameter("@IdMensaje", idMensaje)
        );
    }

    public EntidadMensaje Obtener(int idMensaje)
    {
        return _context.Database.SqlQuery<EntidadMensaje>(
            "EXEC spObtenerMensaje @IdMensaje",
            new SqlParameter("@IdMensaje", idMensaje)
        ).FirstOrDefault();
    }

    public List<EntidadMensaje> ObtenerPorUsuario(int idUsuario)
    {
        return _context.Database.SqlQuery<EntidadMensaje>(
            "EXEC spObtenerMensajesPorUsuario @IdUsuario",
            new SqlParameter("@IdUsuario", idUsuario)
        ).ToList();
    }

    public List<EntidadMensaje> ObtenerPorConversacion(int idRemitente, int idDestinatario)
    {
        return _context.Database.SqlQuery<EntidadMensaje>(
            "EXEC spObtenerMensajesPorConversacion @IdRemitente, @IdDestinatario",
            new SqlParameter("@IdRemitente", idRemitente),
            new SqlParameter("@IdDestinatario", idDestinatario)
        ).ToList();
    }

    public List<EntidadMensaje> ObtenerTodos()
    {
        return _context.Database.SqlQuery<EntidadMensaje>(
            "EXEC spObtenerTodosLosMensajes"
        ).ToList();
    }

    public List<EntidadMensaje> ObtenerPorEstado(string estado)
    {
        return _context.Database.SqlQuery<EntidadMensaje>(
            "EXEC spObtenerMensajesPorEstado @Estado",
            new SqlParameter("@Estado", estado)
        ).ToList();
    }

}