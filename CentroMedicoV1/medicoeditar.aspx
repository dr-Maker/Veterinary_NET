<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="medicoeditar.aspx.cs" Inherits="CentroMedicoV1.medicoeditar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Editar Medico</title>
</head>
<body>
 <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                <div class="card-header">
                      <div class="row">
                        <div class="col-md-10">
                            <h2 >Editar Medico</h2>
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
                        <asp:TextBox CssClass="form-control" ID="nombres" runat="server" />
                        <asp:RequiredFieldValidator
                            CssClass="alert alert-danger"
                            runat="server"
                            ErrorMessage="Nombres es requerido"
                            ControlToValidate="nombres" />

                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Apellidos" />
                        <asp:TextBox CssClass="form-control" ID="apellidos" runat="server" />
                        <asp:RequiredFieldValidator
                            CssClass="alert alert-danger"
                            runat="server"
                            ErrorMessage="Apellidos es requerido"
                            ControlToValidate="apellidos" />
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Email" />
                        <asp:TextBox CssClass="form-control" ID="email" runat="server" />
                        <asp:RequiredFieldValidator
                            CssClass="alert alert-danger"
                            runat="server"
                            ErrorMessage="Email es requerido"
                            ControlToValidate="email" />
                        <asp:RegularExpressionValidator
                            CssClass="alert alert-danger"
                            runat="server"
                            ErrorMessage="Formato de email incorrecto"
                            ValidationExpression ="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                            ControlToValidate="email" />
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" Text="Teléfono" />
                        <asp:TextBox CssClass="form-control" ID="telefono" runat="server" />
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
                    <div class="form-group">
                        <asp:Label runat="server" Text="Especialidad" />
                        <asp:DropDownList CssClass="form-control" ID="idespecialidad" runat="server">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator
                            CssClass="alert alert-danger"
                            runat="server"
                            ErrorMessage="Especialidad es requerido"
                            ControlToValidate="idespecialidad" />
                    </div>
                    <div class="form-group">
                        <asp:Button
                            CssClass="btn btn-success"
                            ID="btnGrabar"
                            runat="server"
                            Text="Grabar" OnClick="btnGrabar_Click"
                           
                             />
                    </div>
                     <p>
                        <a class="btn btn-info" href="horalistar.aspx">Volver</a>
                    </p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
