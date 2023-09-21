<%@ Page Title="" Language="C#" MasterPageFile="~/jobrecruiter folder/jobrecruiter.Master" AutoEventWireup="true" CodeBehind="jobpost_jobrecruiter.aspx.cs" Inherits="kavineknaukri.jobrecruiter_folder.jobpost_jobrecruiter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table style="background-color:rebeccapurple;width:1000px;border-bottom-style:double">
      
        <tr>
           <td style="background-color:silver;text-decoration-color:black">JOP PROFILE</td>
            <td><asp:DropDownList ID="ddljobprofile" runat="server"></asp:DropDownList></td>
        </tr>
         <tr>
           <td style="background-color:silver;text-decoration-color:black">MINIMUM EXPERIENCE</td>
            <td ><asp:TextBox ID="txtminexp" runat="server"></asp:TextBox></td>
             </tr>
         <tr>
             <td style="background-color:silver;text-decoration-color:black">MAXIMUM EXPERIENCE</td>
            <td><asp:TextBox ID="txtmaxexp" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
           <td style="background-color:silver;text-decoration-color:black">MINIMUM SALARY</td>
            <td><asp:TextBox ID="txtminsalary" runat="server"></asp:TextBox></td>
             </tr>
         <tr>
             <td style="background-color:silver;text-decoration-color:black">MAXIMUM SALARY</td>
            <td><asp:TextBox ID="txtmaxsalary" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
           <td style="background-color:silver;text-decoration-color:black">JOB TYPE</td>
            <td ><asp:RadioButtonList ID="rbljobtype" runat="server"></asp:RadioButtonList></td>
        </tr>
          <tr>
           <td style="background-color:silver;text-decoration-color:black">JOP LOCATION</td>
            <td><asp:DropDownList ID="ddljoblocation" runat="server"></asp:DropDownList></td>
        </tr>
           <tr>
          <td style="background-color:silver;text-decoration-color:black">NUMBER OF VACANCY</td>
            <td><asp:TextBox ID="txtnoofvacancy" runat="server"></asp:TextBox></td>
        </tr>
          <tr>
          <td style="background-color:silver;text-decoration-color:black">DESCRIPTION</td>
            <td><asp:TextBox ID="txtcomment" runat="server" Width="200px" Height="200px"></asp:TextBox></td>
        </tr>
         <tr>
             <td  style="background-color:silver;text-decoration-color:black">PRESS TO POST JOB </td>
             <td><asp:Button ID="btnpost" Text="POST JOB" runat="server" OnClick="btnpost_Click" /></td>
         </tr>
               
    </table>
</asp:Content>
