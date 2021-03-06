﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="horanuevo.aspx.cs" Inherits="CentroMedicoV1.horanuevo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Nueva Hora</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">

                <div class="card-header">
                    <div class="row">
                        <div class="col-md-10">
                            <h2>Nueva Hora</h2>
                        </div>
                        <div class="col-md-2">
                            <%
                                Response.Write("Hola " + Session["usuario"].ToString() + "<br>");
                            %>
                            <a class="btn btn-secondary" href="logout.aspx">Cerrar sesión</a>
                        </div>
                    </div>
                </div>

                <div class="card-body">
                    <div class="form-group">
                        <asp:Label runat="server" Text="Id.Hora" />
                        <asp:TextBox ReadOnly="true"  CssClass="form-control" ID="idhora" runat="server" />
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" Text="Fecha" />
                        <asp:TextBox CssClass="form-control" TextMode="Date" ID="fecha" runat="server" />
                        <asp:RegularExpressionValidator runat="server" CssClass="alert alert-danger" ErrorMessage="fecha no valida" ValidationExpression="\d{4}-\d{2}-\d{2}" ControlToValidate="fecha"/>
                        <asp:RequiredFieldValidator CssClass="alert alert-danger" runat="server" ErrorMessage="Requerido" ControlToValidate="fecha"/>       
                    </div>


                    <div class="form-group">
                        <asp:Label runat="server" Text="Hora minuto" />
                        <asp:TextBox  TextMode="Time" CssClass="form-control" ID="horaminuto" runat="server" />
                         <asp:RequiredFieldValidator runat="server"  CssClass="alert alert-danger" ErrorMessage="Requerido" ControlToValidate="horaminuto"/>
                         <asp:RegularExpressionValidator runat="server" CssClass="alert alert-danger" ErrorMessage="Hora no valida" ValidationExpression="\d{2}:\d{2}" ControlToValidate="horaminuto"/>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" Text="Medico" />
                        <asp:DropDownList  CssClass="form-control" ID="idmedico" runat="server" AutoPostBack="True" />
                         <asp:RequiredFieldValidator runat="server" CssClass="alert alert-danger" ErrorMessage="Requerido" ControlToValidate="idestado"/>
                    </div>


                     <div class="form-group">
                        <asp:Label runat="server" Text="Estado" />
                        <asp:DropDownList  CssClass="form-control" ID="idestado" runat="server" />
                        <asp:RequiredFieldValidator runat="server" CssClass="alert alert-danger" ErrorMessage="Requerido" ControlToValidate="idestado"/>
                    </div>


                    <div class="form-group">
                        <asp:Button ID="btnGrabar" CssClass="btn btn-primary" runat="server" Text="Grabar" OnClick="btnGrabar_Click"/>
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
