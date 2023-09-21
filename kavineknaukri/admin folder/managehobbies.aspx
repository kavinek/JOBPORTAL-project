<%@ Page Title="" Language="C#" MasterPageFile="~/admin folder/admin.Master" AutoEventWireup="true" CodeBehind="managehobbies.aspx.cs" Inherits="kavineknaukri.admin_folder.managehobbies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
        <tr>
            <td>HOBBIES:</td>
            <td><asp:TextBox ID="txthobbiesname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnsave" runat="server" Text="SAVE HOBBIE" OnClick="btnsave_Click" /></td>
        </tr>

        <tr>
            <td></td>
            <td><asp:GridView ID="gvhobbies" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="HOBBIE ID">
                        <ItemTemplate>
                            <%#Eval("th_id")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="HOBBIE NAME">
                        <ItemTemplate>
                            <%#Eval("th_name")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                </asp:GridView></td>
        </tr>

    </table>
</asp:Content>
