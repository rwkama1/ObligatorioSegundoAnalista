<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegistroCliente.aspx.cs" Inherits="RegistroCliente" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 219px;
        }
        .style2
        {
            height: 38px;
        }
        .style3
        {
            width: 219px;
            height: 38px;
        }
        .style8
        {
            width: 173px;
        }
        .style9
        {
            height: 38px;
            width: 173px;
        }
        .style12
        {
            height: 35px;
            width: 173px;
        }
        .style13
        {
            width: 219px;
            height: 35px;
        }
        .style14
        {
            height: 35px;
        }
        .style15
        {
            height: 37px;
            width: 173px;
        }
        .style16
        {
            width: 219px;
            height: 37px;
        }
        .style17
        {
            height: 37px;
            color: #003300;
        }
        .style18
        {
            width: 173px;
            height: 27px;
        }
        .style19
        {
            width: 219px;
            height: 27px;
        }
        .style20
        {
            height: 27px;
            color: #003300;
        }
    </style>
    <link href="ConsultasReservas.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <table style="width: 100%; margin-bottom: 0px;">
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style1">
                <asp:Label ID="lblcliente" runat="server" Font-Size="XX-Large" Text="Clientes" 
                    CssClass="Micss"></asp:Label>
            </td>
            <td>
                <asp:Menu ID="Menu1" runat="server" CssClass="Micss">
                    <Items>
                        <asp:MenuItem NavigateUrl="~/Default.aspx" Text="ConsultaVuelos" 
                            Value="ConsultaVuelos"></asp:MenuItem>
                    </Items>
                </asp:Menu>
            </td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                <asp:Label ID="lbldocumento" runat="server" Text="Numero Documento" 
                    CssClass="Micss"></asp:Label>
            </td>
            <td class="style1">
                <asp:TextBox ID="txtndoc" runat="server" Height="23px" Width="132px" 
                    CssClass="Micss" MaxLength="9"></asp:TextBox>
                
                </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                    ErrorMessage="Numero de Documento solo debe contenter numeros" ForeColor="Red" 
                    ValidationExpression="^[0-9]{1,20}$" ControlToValidate="txtndoc"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style9">
                <asp:Label ID="lblnombre" runat="server" Text="Nombre" CssClass="Micss"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txtnombre" runat="server" Height="23px" Width="132px" 
                    CssClass="Micss" MaxLength="19"></asp:TextBox>
            </td>
            <td class="style2">
            </td>
        </tr>
        <tr>
            <td class="style12">
                <asp:Label ID="lblusuario" runat="server" Text="Usuario" CssClass="Micss"></asp:Label>
            </td>
            <td class="style13">
                <asp:TextBox ID="txtusuario" runat="server" Height="23px" Width="132px" 
                    CssClass="Micss" MaxLength="19"></asp:TextBox>
            </td>
            <td class="style14">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style15">
                <asp:Label ID="lblcontraseña" runat="server" Text="Contraseña" CssClass="Micss" 
                    style=""></asp:Label>
            </td>
            <td class="style16">
                <asp:TextBox ID="txtcontraseña" runat="server" Height="23px" Width="132px" 
                    CssClass="Micss" MaxLength="8" TextMode="Password"></asp:TextBox>
            </td>
            <td class="style17">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtcontraseña" 
                    ErrorMessage="Contraseña debe tener 8 caracteres" ForeColor="Red" 
                    ValidationExpression="^[\s\S]{8,8}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style18">
                <asp:Label ID="lbltargetacredito" runat="server" Text="Targeta de Credito" 
                    CssClass="Micss"></asp:Label>
            </td>
            <td class="style19">
                <asp:TextBox ID="txttargeta" runat="server" Height="23px" Width="132px" 
                    CssClass="Micss" MaxLength="16"></asp:TextBox>
            </td>
            <td class="style20">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="txttargeta" 
                    ErrorMessage="La Targeta debe tener 16 digitos y debe contener numeros" 
                    ForeColor="Red" ValidationExpression="^[0-9]{16,16}$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                <asp:Label ID="lblerror" runat="server" CssClass="Micss"></asp:Label>
            </td>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                <asp:Button ID="btnlimpiar" runat="server" Height="32px" 
                    onclick="btnlimpiar_Click" Text="Limpiar" Width="74px" CssClass="Micss" />
            </td>
            <td class="style1">
                <asp:Button ID="btnregistrarse" runat="server" Height="49px" 
                    onclick="btnregistrarse_Click" Text="Registrarse" Width="113px" 
                    CssClass="Micss" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
