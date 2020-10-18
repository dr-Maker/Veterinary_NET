<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="medicolistar.aspx.cs" Inherits="CentroMedicoV1.medicolistar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Médicos</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                <div class="card-header">
                    <div class="row">
                        <div class="col-md-10">
                            <h2 >Lista de Medicos</h2>

                        </div>
                        <div class="col-md-2">
                            <%
                                Response.Write("Hola " + Session["usuario"].ToString()+ "<br>");
                                %>
                            <a href="logout.aspx">Cerrar sesión</a>
                        </div>
                    </div>

                       <a href="mediconuevo.aspx">Nuevo Medico</a>

                </div>
                <div class="card-body">
                    <asp:Table ID="tblMedicos" runat="server" CssClass="table table-bordered table-striped">
                        <asp:TableRow runat="server" TableSection="TableHeader">
                            <asp:TableCell runat="server">ID.Médico</asp:TableCell>
                            <asp:TableCell runat="server">Nombre</asp:TableCell>
                            <asp:TableCell runat="server">Email</asp:TableCell>
                            <asp:TableCell runat="server">Teléfono</asp:TableCell>
                            <asp:TableCell runat="server">Especialidad</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
