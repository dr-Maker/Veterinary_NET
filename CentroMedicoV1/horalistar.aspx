<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="horalistar.aspx.cs" Inherits="CentroMedicoV1.horalistar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Horas</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                <div class="card-header">
                    <h2 class="text-center">Lista de horas</h2>
                   <a href="horanuevo.aspx">Definir hora</a>
                </div>
                <div class="card-body">
                    <asp:Table 
                        ID="tblHora" 
                        runat="server" 
                        CssClass="table table-bordered table-striped">
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
                </div>
            </div>
        </div>
    </form>
</body>
</html>
