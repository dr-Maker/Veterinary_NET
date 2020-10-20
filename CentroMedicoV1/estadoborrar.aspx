<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="estadoborrar.aspx.cs" Inherits="CentroMedicoV1.estadoborrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Borrar Estado</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                 <div class="card-header">
                      <div class="row">
                        <div class="col-md-10">
                            <h2 >Borrar Estado</h2>
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
                        <asp:Label runat="server" Text="Id.Estado" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="idestado" runat="server" />
                    </div>


                     <div class="form-group">
                        <asp:Label runat="server" Text="Estado" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="txtdescripcion" runat="server" />
                        <asp:RequiredFieldValidator runat="server" CssClass="alert alert-danger" ErrorMessage="Requerido" ControlToValidate="txtdescripcion"/>
                    </div>


                    <div class="form-group">
                        <asp:Button ID="btnEliminar" CssClass="btn btn-danger" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                    </div>

                    <p>
                        <a  href="estadolistar.aspx">Volver</a>
                    </p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
