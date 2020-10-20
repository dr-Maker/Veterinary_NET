<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reservalistar.aspx.cs" Inherits="CentroMedicoV1.reservalistar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <title>Lista de Reservas</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="card">
               <div class="card-header">
                    <div class="row">
                        <div class="col-md-10">
                            <h2 >Lista de Reservas</h2>
                        </div>
                        <div class="col-md-2">
                            <%
                                Response.Write("Hola " + Session["usuario"].ToString()+ "<br>");
                                %>
                            <a href="logout.aspx">Cerrar sesión</a>
                        </div>
                    </div>
                   <p> <a href="reservanuevo.aspx">nueva reserva</a> </p>
                </div>
                
                <div class="card-body">

                     <div class="form-group row">
                                <asp:Label runat="server" CssClass="col-sm-2 col-form-label" Text="Fecha" />
                          <div class="col-sm-2">
                                <asp:TextBox CssClass="form-control" ID="txtFecha" runat="server" />
                           </div> 
                        <asp:Label runat="server" Text="Medico" />
                                <div class="col-sm-3">
                                    <asp:DropDownList CssClass="form-control" ID="ddlMedico" runat="server" />
                              </div> 
                         <asp:Label runat="server" Text="Especialidad" />
                                 <div class="col-sm-3">
                         <asp:DropDownList CssClass="form-control" ID="ddlEspecialidad" runat="server" />
                                 </div>

                    </div>

                    <asp:Table runat="server" ID="tblEspecialidad" CssClass="table table-bordered table-striped"> 
                        <asp:TableRow runat="server" TableSection="TableHeader">
                            <asp:TableCell runat="server">Id.Reserva</asp:TableCell>
                            <asp:TableCell runat="server">Hora Minuto</asp:TableCell>
                            <asp:TableCell runat="server">Especialidad</asp:TableCell>
                            <asp:TableCell runat="server">Paciente</asp:TableCell>
                            <asp:TableCell runat="server">Editar</asp:TableCell>
                            <asp:TableCell runat="server">Eliminar</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>

                </div>

            </div>
        </div>
    </form>
    </form>
</body>
</html>
