<%@ Page Title="" Language="C#" MasterPageFile="~/Clientes.master" AutoEventWireup="true" CodeFile="ConsultasdeReservas.aspx.cs" Inherits="ConsultasdeReservas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        <asp:Label ID="lblreservas" runat="server" CssClass="Micss" Font-Bold="True" 
            Font-Size="X-Large" Text="Reservas Del Cliente"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnlimpiarfiltroxml" runat="server" CssClass="Micss" 
            Text="LimpiarFiltros" onclick="btnlimpiarfiltroxml_Click" />
    </p>
    <p>
        <asp:TextBox ID="txtfechaxml" runat="server" CssClass="Micss" Height="24px" 
            Width="138px" MaxLength="12"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btnfechaxml" runat="server" CssClass="Micss" Height="32px" 
            Text="FiltrarFechaconHora" Width="142px" onclick="btnfechaxml_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="txtfechaxml" 
            ErrorMessage="Filtro de la fecha debe tener 12 digitos" ForeColor="Red" 
            ValidationExpression="^[0-9]{12,12}$"></asp:RegularExpressionValidator>
&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
    </p>
    <asp:TextBox ID="txtaerosalidaxml" runat="server" CssClass="Micss" Width="94px" 
        MaxLength="3"></asp:TextBox>
    <asp:Button ID="btnaerosalidaxml" runat="server" CssClass="Micss" Height="26px" 
        Text="Filtrar AeropuertoSalida" Width="171px" 
        onclick="btnaerosalidaxml_Click" />
    &nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
        ControlToValidate="txtaerosalidaxml" 
        ErrorMessage="Filtro de AeropuertoSalida debe tener 3 Caracteres" 
        ForeColor="Red" ValidationExpression="^[\S\S]{3,3}$"></asp:RegularExpressionValidator>
&nbsp;<p>
        <asp:Xml ID="XMLListado" runat="server" TransformSource="~/Vuelos.xslt"></asp:Xml>
    </p>
    <p>
    </p>
    <p>
        <asp:Label ID="lblerror" runat="server"></asp:Label>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

