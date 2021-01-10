<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            height: 24px;
        }
    </style>
    <link href="ConsultasReservas.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" CssClass="Micss" 
                        Font-Size="X-Large">
                        <Items>
                            <asp:MenuItem NavigateUrl="~/LogueoCliente.aspx" Text="LogueoCliente........" 
                                Value="LogueoCliente........"></asp:MenuItem>
                            <asp:MenuItem NavigateUrl="~/RegistroCliente.aspx" Text="RegistroCliente......" 
                                Value="RegistroCliente"></asp:MenuItem>
                            <asp:MenuItem NavigateUrl="~/ConsultasdeReservas.aspx" 
                                Text="ReservasClienteLogueado....." Value="Nuevo elemento"></asp:MenuItem>
                        </Items>
                    </asp:Menu>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Menu ID="Menu2" runat="server" CssClass="Micss" Font-Bold="True" 
                        Font-Size="XX-Large" onmenuitemclick="Menu2_MenuItemClick">
                    </asp:Menu>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                </td>
                <td class="style1">
                </td>
                <td class="style1">
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblmostrar" runat="server" CssClass="Micss" Font-Size="XX-Large"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Repeater ID="RpListar" runat="server" onitemcommand="RpListar_ItemCommand">
                    <ItemTemplate>
                    <table>
                         <tr bgcolor="#CCFFFF">
                                <td>
                                    CodVuelo: <asp:TextBox ID="TxtCodVuelo" runat="server" Text='<%# Bind("CodVuelo") %>'></asp:TextBox>
                                    <br />
                                </td>
                                <td>
                                    Asientos: <asp:TextBox ID="TxtAsientos" runat="server" Text='<%# Bind("Asientos") %>'></asp:TextBox>
                                    <br />
                                </td>
                                <td>
                                    FechaHora: <asp:TextBox ID="TxtFechaHora" runat="server" Text='<%# Bind("FechaHora") %>'></asp:TextBox>
                                    <br />
                                </td>
                                <td>
                                    Linea: <asp:TextBox ID="TxtLinea" runat="server" Text='<%# Bind("SiglaLinea") %>'></asp:TextBox>
                                    <br />
                                </td>
                                 <td>
                                    Aeropuertosalida: <asp:TextBox ID="TxtAeropuertosalida" runat="server" Text='<%# Bind("CodAeropuertoSalida") %>'></asp:TextBox>
                                    <br />
                                </td>
                                  <td>
                                    Aeropuertollegada: <asp:TextBox ID="TxtAeropuertollegada" runat="server" Text='<%# Bind("CodAeropuertoLlegada") %>'></asp:TextBox>
                                    <br />
                                </td>
                                 <td>
                                    CantReservas: <asp:TextBox ID="TxtCantReservas" runat="server" Text='<%# Bind("CantReservas") %>'></asp:TextBox>
                                    <br />
                                </td>
                                <td>
                                    
                                    <asp:Button id="Button2" runat="server" CommandName="Reservar" style="text-align:center" text="Reservar"/>
                                </td>
                            </tr>
                    </table>
                    </ItemTemplate>
                    <AlternatingItemTemplate>
                         <table>
                        <tr bgcolor="#FFFF99">
                           <td>
                                    CodVuelo: <asp:TextBox ID="TxtCodVuelo" runat="server" Text='<%# Bind("CodVuelo") %>'></asp:TextBox>
                                    <br />
                                </td>
                                <td>
                                    Asientos: <asp:TextBox ID="TxtAsientos" runat="server" Text='<%# Bind("Asientos") %>'></asp:TextBox>
                                    <br />
                                </td>
                                <td>



                                    FechaHora: <asp:TextBox ID="TxtFechaHora" runat="server" Text='<%# Bind("FechaHora") %>'></asp:TextBox>
                                    <br />
                                </td>
                                <td>
                                    Linea: <asp:TextBox ID="TxtLinea" runat="server" Text='<%# Bind("SiglaLinea") %>'></asp:TextBox>
                                    <br />
                                </td>
                                 <td>
                                    Aeropuertosalida: <asp:TextBox ID="TxtAeropuertosalida" runat="server" Text='<%# Bind("CodAeropuertoSalida") %>'></asp:TextBox>
                                    <br />
                                </td>
                                  <td>
                                    Aeropuertollegada: <asp:TextBox ID="TxtAeropuertollegada" runat="server" Text='<%# Bind("CodAeropuertoLlegada") %>'></asp:TextBox>
                                    <br />
                                </td>
                                  <td>
                                    CantReservas: <asp:TextBox ID="TxtCantReservas" runat="server" Text='<%# Bind("CantReservas") %>'></asp:TextBox>
                                    <br />
                                </td>
                                <td>
                                    
                                    <asp:Button id="Button2" runat="server" CommandName="Reservar" style="text-align:center" text="Reservar"/>
                                </td>
                        </tr>
                    </table>
                    </AlternatingItemTemplate>
                    </asp:Repeater>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" CssClass="Micss"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
