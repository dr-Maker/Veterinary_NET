<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reservalistar.aspx.cs" Inherits="CentroMedicoV1.reservalistar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Lista de Reservas</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">
               <div class="card-header">
                    <div class="row">
                        <div class="col-md-10">
                            <h2 >Lista de Reservas</h2>
                        </div>
                        <div class="col-md-2 text-center">
                            <%
                                Response.Write("Hola " + Session["usuario"].ToString()+ "<br>");
                                %>
                            <a class="btn btn-secondary" href="logout.aspx">Cerrar sesión</a>
                        </div>
                    </div>
                   <p> <a class="btn btn-primary" href="reservanuevo.aspx"> <img border='0' src="img/add.png" /> nueva reserva</a> </p>
                </div>
                
                <div class="card-body">

                     <div class="form-group row">
                                <asp:Label runat="server" CssClass="col-sm-1 col-form-label" Text="Fecha" />
                          <div class="col-sm-3">
                                <asp:TextBox TextMode="Date" CssClass="form-control" ID="txtFecha" runat="server" OnTextChanged="txtFecha_TextChanged" AutoPostBack="True" />
                                <asp:RegularExpressionValidator runat="server" CssClass="alert alert-danger" ErrorMessage="fecha no valida" ValidationExpression="\d{4}-\d{2}-\d{2}" ControlToValidate="txtFecha"/>
                          </div> 
                        <asp:Label runat="server" Text="Medico" />
                                <div class="col-sm-3">
                                    <asp:DropDownList CssClass="form-control" ID="ddlMedico" runat="server" OnSelectedIndexChanged="ddlMedico_SelectedIndexChanged" AutoPostBack="True" />
                              </div> 
                         <asp:Label runat="server" Text="Especialidad" />
                                 <div class="col-sm-3">
                         <asp:DropDownList CssClass="form-control" ID="ddlEspecialidad" runat="server" OnSelectedIndexChanged="ddlEspecialidad_SelectedIndexChanged" AutoPostBack="True" />
                                 </div>

                    </div>

                    <asp:Table runat="server" ID="tblEspecialidad" CssClass="table table-bordered table-striped text-center"> 
                        <asp:TableRow runat="server" TableSection="TableHeader">
                            <asp:TableCell runat="server">Id.Reserva</asp:TableCell>
                            <asp:TableCell runat="server">Fecha</asp:TableCell>
                            <asp:TableCell runat="server">Hora Minuto</asp:TableCell>
                            <asp:TableCell runat="server">Medico</asp:TableCell>
                            <asp:TableCell runat="server">Especialidad</asp:TableCell>
                            <asp:TableCell runat="server">Paciente</asp:TableCell>
                            <asp:TableCell runat="server">Editar</asp:TableCell>
                            <asp:TableCell runat="server">Eliminar</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <p>
                        <a class="btn btn-info" href="menu.aspx">Volver</a>
                    </p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
