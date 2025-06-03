<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Aplicacion._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <div class="container py-4" style="background-color: #121212; min-height: 100vh;">

        <h2 class="text-center mb-4 text-light">Buscar Historial de Mensajes</h2>

        <div class="row justify-content-center">

            <asp:Panel ID="panelFecha" runat="server" CssClass="col-md-5 rounded p-4 mb-4" 
                       style="background-color: #1f1f1f; box-shadow: 0 0 10px #0d6efd;">
                <h4 class="mb-3 text-info">Buscar por Fecha</h4>
                <div class="mb-3">
                    <label for="<%= txtFechaInicio.ClientID %>" class="form-label text-light">Desde:</label>
                    <asp:TextBox ID="txtFechaInicio" runat="server" CssClass="form-control bg-dark text-light border-secondary" placeholder="yyyy-MM-dd" />
                </div>
                <div class="mb-3">
                    <label for="<%= txtFechaFin.ClientID %>" class="form-label text-light">Hasta:</label>
                    <asp:TextBox ID="txtFechaFin" runat="server" CssClass="form-control bg-dark text-light border-secondary" placeholder="yyyy-MM-dd" />
                </div>
                <asp:Button ID="btnBuscarFecha" runat="server" CssClass="btn btn-info w-100" Text="Buscar" OnClick="btnBuscarFecha_Click" />
            </asp:Panel>

            <asp:Panel ID="panelUsuario" runat="server" CssClass="col-md-5 rounded p-4 mb-4 ms-md-4" 
                       style="background-color: #1f1f1f; box-shadow: 0 0 10px #0d6efd;">
                <h4 class="mb-3 text-info">Buscar por Usuario</h4>
                <div class="mb-3">
                    <label for="<%= txtIdUsuario.ClientID %>" class="form-label text-light">ID Usuario:</label>
                    <asp:TextBox ID="txtIdUsuario" runat="server" CssClass="form-control bg-dark text-light border-secondary" />
                </div>
                <asp:Button ID="btnBuscarUsuario" runat="server" CssClass="btn btn-info w-100" Text="Buscar" OnClick="btnBuscarUsuario_Click" />
            </asp:Panel>

            <asp:Panel ID="panelPalabra" runat="server" CssClass="col-md-5 rounded p-4 mb-4" 
                       style="background-color: #1f1f1f; box-shadow: 0 0 10px #0d6efd;">
                <h4 class="mb-3 text-info">Buscar por Palabra</h4>
                <div class="mb-3">
                    <label for="<%= txtPalabra.ClientID %>" class="form-label text-light">Palabra:</label>
                    <asp:TextBox ID="txtPalabra" runat="server" CssClass="form-control bg-dark text-light border-secondary" />
                </div>
                <asp:Button ID="btnBuscarPalabra" runat="server" CssClass="btn btn-info w-100" Text="Buscar" OnClick="btnBuscarPalabra_Click" />
            </asp:Panel>

        </div>

        <asp:GridView ID="gvResultados" runat="server" AutoGenerateColumns="false"
            EmptyDataText="No se encontraron resultados." CssClass="table table-striped table-hover table-bordered table-dark mt-4">
            <Columns>
                <asp:BoundField DataField="IdMensaje" HeaderText="ID Mensaje" />
                <asp:BoundField DataField="Contenido" HeaderText="Contenido" />
                <asp:BoundField DataField="FechaEnvio" HeaderText="Fecha Envío" DataFormatString="{0:yyyy-MM-dd HH:mm}" />
                <asp:BoundField DataField="Estado" HeaderText="Estado" />
                <asp:BoundField DataField="IdRemitente" HeaderText="Remitente" />
                <asp:BoundField DataField="IdDestinatario" HeaderText="Destinatario" />
            </Columns>
        </asp:GridView>

    </div>
</asp:Content>