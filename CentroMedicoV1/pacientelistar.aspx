<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pacientelistar.aspx.cs" Inherits="CentroMedicoV1.pacientelistar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Lista Pacientes</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                <div class="card-header">
                    <div class="row">
                        <div class="col-md-10">
                            <h2>Lista de Pacientes</h2>

                        </div>
                        <div class="col-md-2 text-center text-center">
                            <%
                                Response.Write("Hola " + Session["usuario"].ToString()+ "<br>");
                                %>
                            <a class="btn btn-secondary" href="logout.aspx">Cerrar sesión</a>
                        </div>
                    </div>

                       <a class="btn btn-primary" href="pacientenuevo.aspx"><img border='0' src="img/add.png" />Nuevo Paciente</a>

                </div>
                <div class="card-body">

                    <asp:Table ID="tblMedicos" runat="server" CssClass="table table-bordered table-striped text-center">
                        <asp:TableRow runat="server" TableSection="TableHeader">
                            <asp:TableCell runat="server">ID.Paciente</asp:TableCell>
                            <asp:TableCell runat="server">Nombre</asp:TableCell>                      
                            <asp:TableCell runat="server">Email</asp:TableCell>
                            <asp:TableCell runat="server">Teléfono</asp:TableCell>
                            <asp:TableCell runat="server">Genero</asp:TableCell>
                            <asp:TableCell runat="server">Edad</asp:TableCell>
                            <asp:TableCell runat="server">Editar</asp:TableCell>
                            <asp:TableCell runat="server">Borrar</asp:TableCell>
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
