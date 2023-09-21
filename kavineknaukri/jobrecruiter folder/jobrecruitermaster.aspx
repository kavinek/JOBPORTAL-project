<%@ Page Title="" Language="C#" MasterPageFile="~/default.Master" AutoEventWireup="true" CodeBehind="jobrecruitermaster.aspx.cs" Inherits="kavineknaukri.jobrecruiter_folder.jobrecruitermaster" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td style="background-color:gold;text-decoration-color:black">COMAPNY NAME : </td>
            <td><asp:TextBox ID="txtcomapnyname" runat="server"></asp:TextBox></td>
        </tr>
        
        <tr>
            <td style="background-color:gold;text-decoration-color:black">COMAPNY URL : </td>
            <td><asp:TextBox ID="txtcomapnyurl" runat="server"></asp:TextBox></td>
        </tr>
       <%-- <tr>
            <td>GENDER : </td>
            <td><asp:RadioButtonList ID="rblgender" runat="server" RepeatColumns="3">
                <asp:ListItem Text="MALE" Value="1"></asp:ListItem>
                <asp:ListItem Text="FEMALE" Value="2"></asp:ListItem>
                <asp:ListItem Text="OTHERS" Value="3"></asp:ListItem>
                </asp:RadioButtonList></td>
        </tr>--%>


        <tr>
            <td style="background-color:gold;text-decoration-color:black">EMAIL : </td>
            <td><asp:TextBox ID="txtemail" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td style="background-color:gold;text-decoration-color:black">PASSWORD : </td>
            <td><asp:TextBox ID="txtpassword" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
           <td style="background-color:gold;text-decoration-color:black" >PRESS HERE : </td>
            <td><asp:button ID="btnregister2" Text="REGISTER" runat="server" OnClick="btnregister2_Click"></asp:button></td>
            </tr>
    </table>
</asp:Content>
