<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LogueoCliente.aspx.cs" Inherits="LogueoCliente" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="ConsultasReservas.css" rel="stylesheet" type="text/css" />
    <link href="ConsultasReservas.css" rel="stylesheet" type="text/css" />
    <link href="ConsultasReservas.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" class="MiClase">
    <div>
    
        <asp:Menu ID="Menu1" runat="server" CssClass="Micss">
            <Items>
                <asp:MenuItem NavigateUrl="~/Default.aspx" Text="ConsultaVuelos" 
                    Value="Nuevo elemento"></asp:MenuItem>
            </Items>
        </asp:Menu>
    
        <br />
        <asp:Label ID="lblcliente" runat="server" Font-Size="X-Large" 
            Text="LogueoCliente" CssClass="Micss"></asp:Label>
        <br />
        <br />
        <asp:Login ID="Login1" runat="server" onauthenticate="Login1_Authenticate" 
            CssClass="Micss">
        </asp:Login>
    
    </div>
    <asp:Label ID="Label1" runat="server" CssClass="Micss"></asp:Label>
    </form>
    <p class="Micss">
    </p>
</body>
</html>
