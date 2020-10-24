<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="medicoborrar.aspx.cs" Inherits="CentroMedicoV1.medicoborrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Medico Borrar</title>
</head>
<body>
 <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                   <div class="card-header">
                      <div class="row">
                        <div class="col-md-10">
                            <h2>Borrar Medico</h2>
                        </div>
                        <div class="col-md-2 text-center">
                            <%
                                Response.Write("Hola " + Session["usuario"].ToString()+ "<br>");
                                %>
                            <a class="btn btn-secondary" href="logout.aspx">Cerrar sesión</a>
                        </div>
                    </div>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <asp:Label runat="server" Text="Id.Médico" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="idmedico" runat="server" />
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Nombres" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="nombres" runat="server" />
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Apellidos" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="apellidos" runat="server" />
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Email" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="email" runat="server" />
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Teléfono" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="telefono" runat="server" />
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Especialidad" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="especialidad" runat="server" />
                    </div>
                    <div class="form-group">
                        <asp:Button
                            CssClass="btn btn-danger"
                            ID="btnBorrar"
                            runat="server"
                            Text="Borrar" OnClick="btnBorrar_Click" />
                    </div>
                     <p>
                        <a class="btn btn-info" href="estadolistar.aspx">Volver</a>
                    </p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
