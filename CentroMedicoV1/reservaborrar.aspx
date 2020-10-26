<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reservaborrar.aspx.cs" Inherits="CentroMedicoV1.reservaborrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Borrar Rerva</title>
</head>

 <body>
  <form id="form1" runat="server">
        <div class="container">
            <div class="card">

                <div class="card-header">
                    <div class="row">
                        <div class="col-md-10">
                            <h2>Borrar Reserva</h2>
                        </div>
                        <div class="col-md-2 text-center">
                            <%
                                Response.Write("Hola " + Session["usuario"].ToString() + "<br>");
                            %>
                            <a class="btn btn-secondary" href="logout.aspx">Cerrar sesión</a>
                        </div>
                    </div>
                </div>

                <div class="card-body">
                     <div class="form-group">
                        <asp:Label runat="server" Text="Id.Reserva" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="idreserva" runat="server" />
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" Text="Especialidad" />
                        <asp:TextBox  ReadOnly="true" CssClass="form-control" ID="dlespecialidad" runat="server"  />
                    </div>

                     <div class="form-group">
                        <asp:Label runat="server" Text="Medico" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="idmedico" runat="server" />
                    </div>

                     <div class="form-group">
                        <asp:Label runat="server" Text="Paciente" />
                        <asp:TextBox  ReadOnly="true" CssClass="form-control" ID="idpaciente" runat="server" />
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" Text="Fecha" />
                        <asp:TextBox ReadOnly="true" runat="server" CssClass="form-control" ID="tbfecha"  />
                   </div>

                   <div class="form-group">
                        <asp:Label runat="server" Text="Hora" />
                        <asp:TextBox ReadOnly="true"  CssClass="form-control" ID="dlHoraMinuto" runat="server" />
                   </div>

                     <asp:TextBox ReadOnly="true"  CssClass="form-control" ID="tbidhora" runat="server" />

                   <div class="form-group">
                        <asp:Button ID="btnBorrar" CssClass="btn btn-danger" runat="server" Text="Borrar" OnClick="btnBorrar_Click" />
                   </div>
                    <p>
                        <a class="btn btn-info" href="reservalistar.aspx">Volver</a>
                    </p>
                </div>
            </div>
        </div>

    </form>
</body>

</html>
