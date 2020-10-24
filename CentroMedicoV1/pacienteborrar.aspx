<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pacienteborrar.aspx.cs" Inherits="CentroMedicoV1.pacienteborrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Borar Paciente</title>
</head>
<body>
 <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                <div class="card-header">
                    <div class="row">
                        <div class="col-md-10">
                            <h2 >Borrar Paciente</h2>
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
                        <asp:Label runat="server" Text="Id.Paciente" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="idpaciente" runat="server" />
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Nombres" />
                        <asp:TextBox CssClass="form-control" ReadOnly="true" ID="nombres" runat="server" />
                        <asp:RequiredFieldValidator runat="server" ErrorMessage="Nombres es requerido" ControlToValidate="nombres" />                    
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Apellidos" />
                        <asp:TextBox CssClass="form-control" ReadOnly="true" ID="apellidos" runat="server" />
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Email" />
                        <asp:TextBox CssClass="form-control" ID="email" ReadOnly="true" runat="server" TextMode="Email" />
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Teléfono" />
                        <asp:TextBox CssClass="form-control" ID="telefono" ReadOnly="true" runat="server" TextMode="Number" />
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Genero" />
                        <asp:TextBox CssClass="form-control" ID="genero" ReadOnly="true" runat="server" /> 
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Edad" />
                        <asp:TextBox CssClass="form-control" ID="edad" ReadOnly="true" runat="server"/> 
                    </div>
                    <div class="form-group">
                        <asp:Button   CssClass="btn btn-danger"  ID="btnEliminar" runat="server"  Text="Eliminar" OnClick="btnEliminar_Click"  />
                
                    </div>
                </div>
            </div>
         </div>             
    </form>
</body>
</html>
