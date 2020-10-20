﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="especialidadeditar.aspx.cs" Inherits="CentroMedicoV1.especialidadeditar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Editar especialidad</title>
</head>
<body>
     <form id="form1" runat="server">
        <div class="container">
            <div class="card">
                 <div class="card-header">
                      <div class="row">
                        <div class="col-md-10">
                            <h2 >Editar Especialidad</h2>
                        </div>
                        <div class="col-md-2">
                            <%
                                Response.Write("Hola " + Session["usuario"].ToString()+ "<br>");
                                %>
                            <a href="logout.aspx">Cerrar sesión</a>
                        </div>
                    </div>
                     <p> <a href="especialidadnuevo.aspx">Nueva especialidad</a></p>
                </div>

                <div class="card-body">
                    <div class="form-group">
                        <asp:Label runat="server" Text="Id.Especialidad" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="idespecialidad" runat="server" />
                    </div>


                     <div class="form-group">
                        <asp:Label runat="server" Text="Especialidad" />
                        <asp:TextBox  CssClass="form-control" ID="txtespecialidad" runat="server" />
                        <asp:RequiredFieldValidator runat="server" CssClass="alert alert-danger" ErrorMessage="Requerido" ControlToValidate="txtespecialidad"/>
                    </div>


                    <div class="form-group">
                        <asp:Button ID="btnGrabar" CssClass="btn btn-success" runat="server" Text="Actualizar" OnClick="btnGrabar_Click"/>
                    </div>

                    <p>
                        <a  href="especialidadlistar.aspx">Volver</a>
                    </p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
