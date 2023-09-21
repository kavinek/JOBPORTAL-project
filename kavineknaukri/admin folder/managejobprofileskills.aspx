<%@ Page Title="" Language="C#" MasterPageFile="~/admin folder/admin.Master" AutoEventWireup="true" CodeBehind="managejobprofileskills.aspx.cs" Inherits="kavineknaukri.admin_folder.managejobprofileskills" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>JOB PROFILE : </td>
            <td><asp:DropDownList ID="ddljobprofile" runat="server"></asp:DropDownList></td>
        </tr>
        <tr>
            <td>SKILLS : </td>
            <td><asp:TextBox ID="txtskillname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnsaveskills" Text="SAVE SKILLS" runat="server" OnClick="btnsaveskills_Click" /></td>
        </tr>


        <tr>
            <td></td>
            <td><asp:GridView ID="gvjobskills" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="SKILL ID">
                        <ItemTemplate>
                            <%#Eval("tsk_id") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="JOB PROFILE">
                        <ItemTemplate>
                             <%#Eval("jpr_name") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="SKILL NAME">
                        <ItemTemplate>
                             <%#Eval("tsk_name") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                </asp:GridView></td>
        </tr>



    </table>



</asp:Content>
