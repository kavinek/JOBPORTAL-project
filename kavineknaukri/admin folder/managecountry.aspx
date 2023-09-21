<%@ Page Title="" Language="C#" MasterPageFile="~/admin folder/admin.Master" AutoEventWireup="true" CodeBehind="managecountry.aspx.cs" Inherits="kavineknaukri.admin_folder.managecountry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
        <tr>
            <td>COUNTRY:</td>
            <td><asp:TextBox ID="txtcountryname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnsave" runat="server" Text="SAVE COUNTRY" OnClick="btnsave_Click" /></td>
        </tr>

        <tr>
            <td></td>
            <td><asp:GridView ID="gvcountry" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="COUNTRY ID">
                        <ItemTemplate>
                            <%#Eval("tc_id")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="COUNTRY NAME">
                        <ItemTemplate>
                            <%#Eval("tc_name")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                </asp:GridView></td>
        </tr>

    </table>
</asp:Content>
