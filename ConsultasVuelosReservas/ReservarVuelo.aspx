<%@ Page Title="" Language="C#" MasterPageFile="~/Clientes.master" AutoEventWireup="true" CodeFile="ReservarVuelo.aspx.cs" Inherits="ReservarVuelo" %>



<%@ Register assembly="Controles" namespace="Controles" tagprefix="cc1" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            height: 63px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 103%; height: 356px;">
        <tr>
           
            <td class="style1">
                <cc1:ReservarVuelo ID="ReservarVuelo1" runat="server" />
               
            </td>
            <td class="style1">
                </td>
        </tr>
        <tr>
            <td>
                &nbsp;Numero Documento del Cliente:
                <asp:TextBox ID="txtcliente" runat="server" CssClass="Micss" Height="21px" 
                    Width="142px" ReadOnly="True"></asp:TextBox>
                &nbsp;<br />
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
                <asp:Button ID="btnreservarr" runat="server" Height="31px" 
                    onclick="btnreservarr_Click" Text="Reservar" Width="73px" 
                    CssClass="Micss" />
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
    </table>
</asp:Content>

