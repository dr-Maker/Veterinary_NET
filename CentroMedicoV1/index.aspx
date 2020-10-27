<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CentroMedicoV1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/base.css" rel="stylesheet" />
    <title>Centro médico</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                <div class="card-header">
                    <h2 class="text-center">Acceso usuario</h2>
                </div>
                <div class="card-body divLogin">
                    <div class="card-body">
                        <div class="form-group">
                            <asp:Label runat="server"  Text="Usuario"/>
                            <asp:TextBox CssClass="form-control" runat="server" ID="txtUsuario" />
                        </div>
                          <div class="form-group">
                            <asp:Label runat="server"  Text="Clave"/>
                            <asp:TextBox CssClass="form-control" runat="server" ID="txtClave" TextMode="Password" />
                        </div>
                          <div class="form-group text-center">
                            <asp:Button CssClass="btn btn-primary" runat="server" ID="btnLogin" Text="Envíar" OnClick="btnLogin_Click" />
                        </div>
                        <asp:Label runat="server" ID="lblMsg" Text="" CssClass="alert alert-danger" Visible="false"/>
                    </div>
                </div>   
            </div>
        </div>
    </form>
</body>
</html>
