<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="horalistar.aspx.cs" Inherits="CentroMedicoV1.horalistar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Listado de Horas</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                <div class="card-header">
                    <div class="row">
                        <div class="col-md-10">
                            <h2 >Lista de horas</h2>
                        </div>
                        <div class="col-md-2 text-center">
                            <%
                                Response.Write("Hola " + Session["usuario"].ToString()+ "<br>");
                                %>
                            <a class="btn btn-secondary" href="logout.aspx">Cerrar sesión</a>
                        </div>
                    </div>
                    
                   <a class="btn btn-primary" href="horanuevo.aspx"><img border='0' src="img/add.png" />Definir hora</a>
                </div>
                <div class="card-body">
                    <asp:Table 
                        ID="tblHora" 
                        runat="server" 
                        CssClass="table table-bordered table-striped text-center">
                        <asp:TableRow runat="server" TableSection="TableHeader">
                            <asp:TableCell runat="server">Id.Hora</asp:TableCell>
                            <asp:TableCell runat="server">Fecha</asp:TableCell>
                            <asp:TableCell runat="server">Hora Minuto</asp:TableCell>
                            <asp:TableCell runat="server">Medico</asp:TableCell>
                            <asp:TableCell runat="server">Especialidad</asp:TableCell>
                            <asp:TableCell runat="server">Estado</asp:TableCell>
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
