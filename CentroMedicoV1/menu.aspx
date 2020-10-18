<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="CentroMedicoV1.menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Menú Principal</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                 <div class="card-header">
                    <div class="row">
                        <div class="col-md-10">
                            <h2 >Nuevo Medicos</h2>
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
                    <p> <a href="horalistar.aspx">Hora
                        </a> </p>
                    <p> <a href="medicolistar.aspx">Medico</a> </p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
