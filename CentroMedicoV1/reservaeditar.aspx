<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reservaeditar.aspx.cs" Inherits="CentroMedicoV1.reservaeditar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Editar Reserva </title>
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
                        <div class="col-md-2">
                            <%
                                Response.Write("Hola " + Session["usuario"].ToString() + "<br>");
                            %>
                            <a href="logout.aspx">Cerrar sesión</a>
                        </div>
                    </div>
                </div>
                <div class="card-body">
                     <div class="form-group">
                        <asp:Label runat="server" Text="Id.Reserva" />
                        <asp:TextBox  CssClass="form-control" ID="idhora" runat="server" />
                    </div>

                     <div class="form-group">
                        <asp:Label runat="server" Text="Medico" />
                        <asp:TextBox  CssClass="form-control" ID="TextBox1" runat="server" />
                    </div>

                     <div class="form-group">
                        <asp:Label runat="server" Text="Paciente" />
                        <asp:TextBox   CssClass="form-control" ID="TextBox2" runat="server" />
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" Text="Hora" />
                        <asp:TextBox   CssClass="form-control" ID="TextBox3" runat="server" />
                   </div>

                   <div class="form-group">
                        <asp:Button ID="btnGrabar" CssClass="btn btn-info" runat="server" Text="Grabar" />
                   </div>

                </div>

            </div>
        </div>

    </form>
</body>
</html>
