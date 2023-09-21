<%@ Page Title="" Language="C#" MasterPageFile="~/admin folder/admin.Master" AutoEventWireup="true" CodeBehind="managequalification.aspx.cs" Inherits="kavineknaukri.admin_folder.managequalification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
        <tr>
            <td>QUALIFICATION:</td>
            <td><asp:TextBox ID="txtqualname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnsave" runat="server" Text="SAVE HOBBIE" OnClick="btnsave_Click" /></td>
        </tr>

        <tr>
            <td></td>
            <td><asp:GridView ID="gvqual" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="QUALIFICATION ID">
                        <ItemTemplate>
                            <%#Eval("tql_id")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="QUALIFICATION NAME">
                        <ItemTemplate>
                            <%#Eval("tql_name")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                </asp:GridView></td>
        </tr>

    </table>
</asp:Content>
