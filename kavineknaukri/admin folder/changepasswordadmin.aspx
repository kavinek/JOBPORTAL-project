﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin folder/admin.Master" AutoEventWireup="true" CodeBehind="changepasswordadmin.aspx.cs" Inherits="kavineknaukri.admin_folder.changepasswordadmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <center>
        <tr>
            <td>CURRENT PASSWORD</td>
            <td><asp:TextBox ID="txtcurrentpassword" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>NEW PASSWORD</td>
            <td><asp:TextBox ID="txtnewpassword" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>CONFIRM NEW PASSWORD</td>
            <td><asp:TextBox ID="txtconfirmnewpassword" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btncp" Text="CHANGE PASSWORD" runat="server" OnClick="btncp_Click" /></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Label ID="lblmsg" runat="server" ForeColor="Red" Font-Bold="true"></asp:Label></td>
        </tr>
        </center>
        </table>
</asp:Content>
