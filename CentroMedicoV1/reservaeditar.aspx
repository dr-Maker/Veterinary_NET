<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reservaeditar.aspx.cs" Inherits="CentroMedicoV1.reservaeditar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Editar Reserva </title>
</head>
<body>
       <form id="form1" runat="server">
        <div class="container">
            <div class="card">       
                <div class="card-header">
                    <div class="row">
                        <div class="col-md-10">
                            <h2>Editar Reserva</h2>
                        </div>
                        <div class="col-md-2 text-center">
                            <%
                                Response.Write("Hola " + Session["usuario"].ToString() + "<br>");
                            %>
                            <a class="btn btn-secondary" href="logout.aspx">Cerrar sesión</a>
                        </div>
                    </div>
                </div>
                   <div class="card-body">
                     <div class="form-group">
                        <asp:Label runat="server" Text="Id.Reserva" />
                        <asp:TextBox ReadOnly="true" CssClass="form-control" ID="idreserva" runat="server" />
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" Text="Especialidad" />
                        <asp:DropDownList  CssClass="form-control" ID="dlespecialidad" runat="server" AutoPostBack="True" OnSelectedIndexChanged="EspecialidadSelected" />
                    </div>

                     <div class="form-group">
                        <asp:Label runat="server" Text="Medico" />
                        <asp:DropDownList  CssClass="form-control" ID="idmedico" runat="server" AutoPostBack="True" OnSelectedIndexChanged="idmedico_SelectedIndexChanged" />
                    </div>

                     <div class="form-group">
                        <asp:Label runat="server" Text="Paciente" />
                        <asp:DropDownList   CssClass="form-control" ID="idpaciente" runat="server" />
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" Text="Fecha" />
                        <asp:TextBox runat="server" TextMode="Date" CssClass="form-control" ID="tbfecha" OnTextChanged="tbfecha_TextChanged" AutoPostBack="True"   />
                   </div>

                   <div class="form-group">
                        <asp:Label runat="server" Text="Hora" />
                        <asp:DropDownList   CssClass="form-control" ID="dlHoraMinuto" runat="server" />
                   </div>

                   <div class="form-group">
                        <asp:Button ID="btnGrabar" CssClass="btn btn-success" runat="server" Text="Actualizar" OnClick="btnGrabar_Click" />
                   </div>

                        <asp:TextBox runat="server" ID="tbidhoraantiguo" />
                </div>

                   <p>
                        <a class="btn btn-info" href="reservalistar.aspx">Volver</a>
                   </p>
            </div>
        </div>

    </form>
</body>
</html>
