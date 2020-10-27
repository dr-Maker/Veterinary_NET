<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reservanuevo.aspx.cs" Inherits="CentroMedicoV1.reservanuevo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Nueva Reserva</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">

                <div class="card-header">
                    <div class="row">
                        <div class="col-md-10">
                            <h2>Nueva Reserva</h2>
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
                        <asp:DropDownList  CssClass="form-control" ID="dlespecialidad" runat="server" AutoPostBack="True" OnSelectedIndexChanged="EspecialidadSelected" />
                    </div>

                     <div class="form-group">
                        <asp:Label runat="server" Text="Medico" />
                        <asp:DropDownList  CssClass="form-control" ID="idmedico" runat="server" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="idmedico" CssClass="alert alert-danger" ErrorMessage="Se requiere la elección de un Medico"/>
                    </div>

                     <div class="form-group">
                        <asp:Label runat="server" Text="Paciente" />
                        <asp:DropDownList   CssClass="form-control" ID="idpaciente" runat="server" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="idpaciente" CssClass="alert alert-danger" ErrorMessage="Se requiere la elección de un Paciente"/>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" Text="Fecha" />
                        <asp:TextBox runat="server" TextMode="Date" CssClass="form-control" ID="tbfecha" OnTextChanged="tbfecha_TextChanged" AutoPostBack="True"   />
                        <asp:RegularExpressionValidator runat="server" CssClass="alert alert-danger" ErrorMessage="fecha no valida" ValidationExpression="\d{4}-\d{2}-\d{2}" ControlToValidate="tbfecha"/>
                        <asp:RequiredFieldValidator CssClass="alert alert-danger" runat="server" ErrorMessage="La fecha es requerida" ControlToValidate="tbfecha"/> 
                   </div>

                   <div class="form-group">
                        <asp:Label runat="server" Text="Hora" />
                        <asp:DropDownList   CssClass="form-control" ID="dlHoraMinuto" runat="server" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="dlHoraMinuto" CssClass="alert alert-danger" ErrorMessage="Se requiere la elección de una Hora disponible"/>
                   </div>

                   <div class="form-group">
                        <asp:Button ID="btnGrabar" CssClass="btn btn-primary" runat="server" Text="Grabar" OnClick="btnGrabar_Click" />
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
