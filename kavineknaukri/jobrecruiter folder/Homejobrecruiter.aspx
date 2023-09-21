<%@ Page Title="" Language="C#" MasterPageFile="~/jobrecruiter folder/jobrecruiter.Master" AutoEventWireup="true" CodeBehind="Homejobrecruiter.aspx.cs" Inherits="kavineknaukri.jobrecruiter_folder.Homejobrecruiter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
      
        <tr>
           <td>COMANY NAME</td>
            <td><asp:Label ID="lblname" runat="server"></asp:Label></td>
        </tr>
         <tr>
           <td>COMANY URL</td>
            <td><asp:Label ID="lblurl" runat="server"></asp:Label></td>
        </tr>
         <tr>
           <td>COMANY EMAIL</td>
            <td><asp:Label ID="lblemail" runat="server"></asp:Label></td>
        </tr>
         <tr>
           <td>COMANY PASSWORD</td>
            <td><asp:Label ID="lblpassword" runat="server"></asp:Label></td>
        </tr>
               
    </table>
</asp:Content>
