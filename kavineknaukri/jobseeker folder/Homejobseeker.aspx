<%@ Page Title="" Language="C#" MasterPageFile="~/jobseeker folder/jobseeker.Master" AutoEventWireup="true" CodeBehind="Homejobseeker.aspx.cs" Inherits="kavineknaukri.jobseeker_folder.Homejobseeker" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
           <td>NAME</td>
            <td><asp:Label ID="lblname" runat="server"></asp:Label></td>
        </tr>
         <tr>
           <td>GENDER</td>
            <td><asp:Label ID="lblgender" runat="server"></asp:Label></td>
        </tr>

        <tr>
           <td>DATE OF BIRTH</td>
            <td><asp:Label ID="lbldob" runat="server"></asp:Label></td>
        </tr>
         
         <tr>
           <td>EMAIL</td>
            <td><asp:Label ID="lblemail" runat="server"></asp:Label></td>
        </tr>
         <tr>
           <td>PASSWORD</td>
            <td><asp:Label ID="lblpassword" runat="server"></asp:Label></td>
        </tr>

        <tr>
           <td>QUALIFICATION</td>
            <td><asp:Label ID="lblqualification" runat="server"></asp:Label></td>
        </tr>

        <tr>
           <td>JOB PROFILE</td>
            <td><asp:Label ID="lbljobprofile" runat="server"></asp:Label></td>
        </tr>

        <tr>
           <td>SKILLS</td>
            <td><asp:Label ID="lblskills" runat="server"></asp:Label></td>
        </tr>

        <tr>
           <td>ADDRESS</td>
            <td><asp:Label ID="lbladdress" runat="server"></asp:Label></td>
        </tr>

         <tr>
           <td>IMAGE:</td>
            <td><asp:Image ID="imgjs" runat="server" Width="50px" Height="50px" /></td>
        </tr>

        <tr>
           <td>RESUME:</td>
            <td> <asp:LinkButton ID="btnresumeshow" runat="server" OnClick="btnresumeshow_Click"></asp:LinkButton></td>
        </tr>
        
        <tr>
           <td></td>
            <td> <asp:Button ID="editbtn" Text="EDIT" runat="server" OnClick="editbtn_Click" /></td>
        </tr>
        


                      
    </table>
</asp:Content>
