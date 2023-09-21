<%@ Page Title="" Language="C#" MasterPageFile="~/admin folder/admin.Master" AutoEventWireup="true" CodeBehind="managejobprofile.aspx.cs" Inherits="kavineknaukri.admin_folder.managejobprofile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <table>
        <tr>
            <td>JOB PROFILE:</td>
            <td><asp:TextBox ID="txtname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnsave" runat="server" Text="SAVE PROFILE" OnClick="btnsave_Click" /></td>
        </tr>

        <tr>
            <td></td>
            <td><asp:GridView ID="gvjobprofile" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="JOB-PROFILE ID">
                        <ItemTemplate>
                            <%#Eval("jpr_id")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="JOB-PROFILE NAME">
                        <ItemTemplate>
                            <%#Eval("jpr_name")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                </asp:GridView></td>
        </tr>

    </table>

</asp:Content>
