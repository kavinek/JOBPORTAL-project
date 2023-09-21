<%@ Page Title="" Language="C#" MasterPageFile="~/admin folder/admin.Master" AutoEventWireup="true" CodeBehind="Homeadmin.aspx.cs" Inherits="kavineknaukri.admin_folder.Homeadmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
        <tr>
             <td>ADMIN NAME</td>
            <td><asp:Label ID="lblname" runat="server"></asp:Label></td>
        </tr>
         <tr>
           <td>ADMIN GENDER</td>
            <td><asp:Label ID="lblgender" runat="server"></asp:Label></td>
        </tr>
         <tr>
           <td>ADMIN EMAIL</td>
            <td><asp:Label ID="lblemail" runat="server"></asp:Label></td>
        </tr>
         <tr>
           <td>ADMIN PASSWORD</td>
            <td><asp:Label ID="lblpassword" runat="server"></asp:Label></td>
        </tr>
       
    </table>
</asp:Content>
