<%@ Page Title="" Language="C#" MasterPageFile="~/default.Master" AutoEventWireup="true" CodeBehind="jobseekermaster.aspx.cs" Inherits="kavineknaukri.jobseeker_folder.jobseekermaster" %>
<%@ Register Assembly="AjaxControlToolKit" Namespace="AjaxControlToolKit" TagPrefix="ajax" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="mng" runat="server"></asp:ScriptManager>
    <table>
        <tr>
            <td style="background-color:gold;text-decoration-color:black">NAME : </td>
            <td><asp:TextBox ID="txtname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="background-color:gold;text-decoration-color:black">GENDER : </td>
            <td><asp:RadioButtonList ID="rblgender" runat="server" RepeatColumns="3"></asp:RadioButtonList></td>
              
        </tr>
        <tr>
            <td style="background-color:gold;text-decoration-color:black">EMAIL : </td>
            <td><asp:TextBox ID="txtemail" runat="server"></asp:TextBox> </td>
                 </tr>
         <tr>
            <td style="background-color:gold;text-decoration-color:black">PASSWORD : </td>
            <td><asp:TextBox ID="txtpassword" runat="server"></asp:TextBox></td>
             
        </tr>
        <tr>
            <td style="background-color:gold;text-decoration-color:black">DATE OF BIRTH : </td>
            <td><asp:TextBox ID="txtdob" runat="server"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="caldob" runat="server" PopupButtonID="txtdob" PopupPosition="TopRight" TargetControlID="txtdob" />
            </td>
         
        </tr>
         <tr>
           <td style="background-color:gold;text-decoration-color:black">QUALIFICATION</td>
             <td><asp:DropDownList ID="ddlqualification" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
           <td style="background-color:gold;text-decoration-color:black">JOB PROFILE:</td>
             <td><asp:DropDownList ID="ddljobprofile" runat="server" OnSelectedIndexChanged="ddljobprofile_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
        </tr> 
        <tr id="tr_skills" runat="server">
           <td style="background-color:gold;text-decoration-color:black">JOB SKILLS :</td>
             <td><asp:CheckBoxList ID="cblskills" runat="server" RepeatColumns="6"></asp:CheckBoxList></td>
        </tr>
        <tr>
           <td style="background-color:gold;text-decoration-color:black">COUNTRY</td>
            <td><asp:DropDownList ID="ddlcountry" runat="server" OnSelectedIndexChanged="ddlcountry_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
        </tr>
         <tr>
           <td style="background-color:gold;text-decoration-color:black">STATE</td>
             <td><asp:DropDownList ID="ddlstate" runat="server" OnSelectedIndexChanged="ddlstate_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
        </tr>
        <tr>
           <td style="background-color:gold;text-decoration-color:black">CITY</td>
             <td><asp:DropDownList ID="ddlcity" runat="server"></asp:DropDownList></td>
        </tr>
       <%-- for uploading image --%>
         <tr>
           <td style="background-color:gold;text-decoration-color:black">UPLOAD IMAGE</td>
             <td><asp:FileUpload ID="fuimage" runat="server" /></td>
        </tr>
          <%-- for uploading RESUME --%>
         <tr>
           <td style="background-color:gold;text-decoration-color:black">UPLOAD RESUME</td>
             <td><asp:FileUpload ID="furesume" runat="server" /></td>
        </tr>
       
        <tr>
           <td style="background-color:gold;text-decoration-color:black">PRESS HERE : </td>
            <td><asp:button ID="btnregister" Text="REGISTER" runat="server" OnClick="btnregister_Click"></asp:button></td>
        </tr>
       
    </table>





</asp:Content>
