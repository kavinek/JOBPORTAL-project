<%@ Page Title="" Language="C#" MasterPageFile="~/admin folder/admin.Master" AutoEventWireup="true" CodeBehind="managegender.aspx.cs" Inherits="kavineknaukri.admin_folder.managegender" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
        <tr>
            <td>GENDER:</td>
            <td><asp:TextBox ID="txtgendername" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnsave" runat="server" Text="SAVE GENDER" OnClick="btnsave_Click" /></td>
        </tr>

        <tr>
            <td></td>
            <td><asp:GridView ID="gvgender" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="GENDER ID">
                        <ItemTemplate>
                            <%#Eval("tg_id")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="GENDER NAME">
                        <ItemTemplate>
                            <%#Eval("tg_name")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                </asp:GridView></td>
        </tr>

    </table>
</asp:Content>
