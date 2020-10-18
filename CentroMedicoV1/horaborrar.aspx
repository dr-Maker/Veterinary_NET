<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="horaborrar.aspx.cs" Inherits="CentroMedicoV1.horaborrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Borrar Hora</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                 <div class="card-header">
                    <div class="row">
                        <div class="col-md-10">
                            <h2 >Borrar horas</h2>
                        </div>
                        <div class="col-md-2">
                            <%
                                Response.Write("Hola " + Session["usuario"].ToString()+ "<br>");
                                %>
                            <a href="logout.aspx">Cerrar sesión</a>
                        </div>
                    </div>
                </div>

                <div class="card-body">
                    <div class="form-group">
                        <asp:Label runat="server" Text="Id.Hora" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="idhora" runat="server" />
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Fecha" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="fecha" runat="server" />
                         
                    </div>


                    <div class="form-group">
                        <asp:Label runat="server" Text="Hora minuto" />
                        <asp:TextBox ReadOnly="true" TextMode="Time" CssClass="form-control" ID="horaminuto" runat="server" />
                         

                        
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" Text="Medico" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="idmedico" runat="server" />
                        
                    </div>


                      <div class="form-group">
                        <asp:Label runat="server" Text="Estado" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="idestado" runat="server" />
                        
                    </div>


                    <div class="form-group">
                        <asp:Button ID="btnEliminar" CssClass="btn btn-danger" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                    </div>

                    <p>
                        <a  href="horalistar.aspx">Volver</a>
                    </p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
