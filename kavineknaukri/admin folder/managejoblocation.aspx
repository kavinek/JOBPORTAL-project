<%@ Page Title="" Language="C#" MasterPageFile="~/admin folder/admin.Master" AutoEventWireup="true" CodeBehind="managejoblocation.aspx.cs" Inherits="kavineknaukri.admin_folder.managejoblocation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>JOB LOCATION:</td>
            <td><asp:TextBox ID="txtname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnsave" runat="server" Text="SAVE LOCATION" OnClick="btnsave_Click" /></td>
        </tr>

        <tr>
            <td></td>
            <td><asp:GridView ID="gvjoblocation" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="JOB-LOCATION ID">
                        <ItemTemplate>
                            <%#Eval("tjl_id")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="JOB-LOCATION NAME">
                        <ItemTemplate>
                            <%#Eval("tjl_name")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                </asp:GridView></td>
        </tr>

    </table>



</asp:Content>
