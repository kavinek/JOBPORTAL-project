<%@ Page Title="" Language="C#" MasterPageFile="~/default.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="kavineknaukri.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td style="background-color:gold;text-decoration-color:black">USER TYPE</td>
            <td><asp:dropdownlist Id="ddlusertype" runat="server">
                <asp:Listitem Text="--SELECT ITEMS--" value="0"></asp:Listitem>
                 <asp:Listitem Text="JOB  RECRUITER" value="1"></asp:Listitem>
                 <asp:Listitem Text="JOB SEEKER" value="2"></asp:Listitem>
                 <asp:Listitem Text="ADMIN" value="3"></asp:Listitem>
                </asp:dropdownlist></td>
        </tr>
         <tr>
            <td style="background-color:gold;text-decoration-color:black">EMAIL : </td>
            <td><asp:TextBox ID="txtemail" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td style="background-color:gold;text-decoration-color:black">PASSWORD : </td>
            <td><asp:TextBox ID="txtpassword" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
           <td style="background-color:gold;text-decoration-color:black">PRESS HERE : </td>
            <td><asp:button ID="loginbtn" Text="REGISTER" runat="server" OnClick="loginbtn_Click"></asp:button></td>
            </tr>
        <tr>
            <td></td>
            <td style="background-color:white"><asp:Label ID="lblmsg" runat="server" ForeColor="Red" Font-Italic="true" Font-Bold="true"></asp:Label></td>
        </tr>
    </table>
</asp:Content>
