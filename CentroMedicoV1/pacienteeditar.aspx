<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pacienteeditar.aspx.cs" Inherits="CentroMedicoV1.pacienteeditar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Paciente Editar</title>
</head>
<body>
 <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                <div class="card-header">
                    <div class="row">
                        <div class="col-md-10">
                            <h2 >Paciente Editar</h2>
                        </div>
                        <div class="col-md-2">
                            <%
                                Response.Write("Hola " + Session["usuario"].ToString()+ "<br>");
                                %>
                            <a class="btn btn-secondary" href="logout.aspx">Cerrar sesión</a>
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
                        <asp:TextBox CssClass="form-control" ID="nombres" runat="server" />
                        <asp:RequiredFieldValidator runat="server" ErrorMessage="Nombres es requerido" ControlToValidate="nombres" CssClass="alert alert-danger"/>                    
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Apellidos" />
                        <asp:TextBox CssClass="form-control" ID="apellidos" runat="server" />
                         <asp:RequiredFieldValidator  CssClass="alert alert-danger" runat="server" ErrorMessage="Apellido es requerido" ControlToValidate="apellidos" />
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Email" />
                        <asp:TextBox CssClass="form-control" ID="email" runat="server" TextMode="Email" />
                        <asp:RequiredFieldValidator runat="server" CssClass="alert alert-danger" ErrorMessage="el email es requerido" ControlToValidate="email" />
                        <asp:RegularExpressionValidator runat="server" CssClass="alert alert-danger" ErrorMessage="Error en el formato del correo" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" ControlToValidate="email"/>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Teléfono" />
                        <asp:TextBox CssClass="form-control" ID="telefono" runat="server" TextMode="Number" />
                        <asp:RequiredFieldValidator
                            CssClass="alert alert-danger"
                            runat="server"
                            ErrorMessage="Teléfono es requerido"
                            ControlToValidate="telefono" />
                        <asp:RegularExpressionValidator
                            CssClass="alert alert-danger"
                            runat="server"
                            ErrorMessage="Teléfono debe tener 9 dígitos"
                            ValidationExpression="\d{9}"
                            ControlToValidate="telefono" />
                    </div>

                    <div>
                        <asp:Label runat="server" Text="Genero" ID="genero" />
                        <asp:RadioButtonList ID="rblgenero" runat="server" >
                            <asp:ListItem Text="Masculino" Value="M"></asp:ListItem>
                            <asp:ListItem Text="Femenino" Value="F"></asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:RequiredFieldValidator 
                        runat="server"
                        ControlToValidate="rblgenero"
                        CssClass="alert alert-danger"
                        ErrorMessage="Es necesario seleccionar un genero"
                        />
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" Text="Edad" />
                        <asp:TextBox CssClass="form-control" TextMode="Number" ID="edad" runat="server"/>
                        <asp:RangeValidator runat="server" controltovalidate="edad" type="Integer" minimumvalue="0" maximumvalue="120" errormessage="La edad ingresada es inválida"  CssClass="alert alert-danger"/>
                    </div>

                    <div class="form-group">
                        <asp:Button   CssClass="btn btn-success"  ID="btnGrabar" runat="server"  Text="Actualizar" OnClick="btnGrabar_Click" />               
                    </div>
                    <p>
                        <a class="btn btn-info" href="pacientelistar.aspx">Volver</a>
                    </p>
                </div>
            </div>
         </div>             
    </form>
</body>
</html>
