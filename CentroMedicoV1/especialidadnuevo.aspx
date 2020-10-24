<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="especialidadnuevo.aspx.cs" Inherits="CentroMedicoV1.especialidadnuevo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Nueva Especialidad</title>
</head>
<body>
     <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                 <div class="card-header">
                      <div class="row">
                        <div class="col-md-10">
                            <h2 >Nueva Especialidad</h2>
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
                        <asp:Label runat="server" Text="Id.Especialidad" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="idespecialidad" runat="server" />
                    </div>


                     <div class="form-group">
                        <asp:Label runat="server" Text="Especialidad" />
                        <asp:TextBox  CssClass="form-control" ID="txtespecialidad" placeholder="Ingrese nueva especialidad Medica" runat="server" />
                        <asp:RequiredFieldValidator runat="server" CssClass="alert alert-danger" ErrorMessage="El campo especialidad es requerido" ControlToValidate="txtespecialidad"/>
                    </div>


                    <div class="form-group">
                        <asp:Button ID="btnGrabar" CssClass="btn btn-primary" runat="server" Text="Grabar" OnClick="btnGrabar_Click" />
                    </div>

                    <p>
                        <a class="btn btn-info" href="especialidadlistar.aspx">Volver</a>
                    </p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
