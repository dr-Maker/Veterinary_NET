<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="estadolistar.aspx.cs" Inherits="CentroMedicoV1.estadolistar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Estado listar</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">
               <div class="card-header">
                    <div class="row">
                        <div class="col-md-10">
                            <h2 >Lista de Estados</h2>
                        </div>
                        <div class="col-md-2">
                            <%
                                Response.Write("Hola " + Session["usuario"].ToString()+ "<br>");
                                %>
                            <a href="logout.aspx">Cerrar sesión</a>
                        </div>
                    </div>
                   <p> <a href="estadonuevo.aspx">Nuevo estado</a></p>
                </div>
                
                <div class="card-body">
                    <asp:Table runat="server" ID="tblEstado" CssClass="table table-bordered table-striped"> 
                        <asp:TableRow runat="server" TableSection="TableHeader">
                            <asp:TableCell runat="server">Id.Estado</asp:TableCell>
                             <asp:TableCell runat="server">Descripción</asp:TableCell>
                            <asp:TableCell runat="server">Editar</asp:TableCell>
                            <asp:TableCell runat="server">Eliminar</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>

            </div>
        </div>
    </form>
</body>
</html>
