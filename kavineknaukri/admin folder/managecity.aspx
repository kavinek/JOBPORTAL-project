<%@ Page Title="" Language="C#" MasterPageFile="~/admin folder/admin.Master" AutoEventWireup="true" CodeBehind="managecity.aspx.cs" Inherits="kavineknaukri.admin_folder.managecity" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
        <tr>
            <td>COUNTRY NAME:</td>
            <td><asp:DropDownList ID="ddlcountry" runat="server" OnSelectedIndexChanged="ddlcountry_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
        </tr>
         <tr>
            <td>STATE:</td>
            <td><asp:DropDownList ID="ddlstate" runat="server"></asp:DropDownList></td>
        </tr>
         <tr>
            <td>CITY:</td>
            <td><asp:Textbox ID="txtcityname" runat="server"></asp:Textbox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnsave" runat="server" Text="SAVE STATE" OnClick="btnsave_Click" /></td>
        </tr>

        <tr>
            <td></td>
            <td><asp:GridView ID="gvcity" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="CITY ID">
                        <ItemTemplate>
                            <%#Eval("tcity_id")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="STATE NAME">
                        <ItemTemplate>
                            <%#Eval("ts_name")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="COUNTRY NAME">
                        <ItemTemplate>
                            <%#Eval("tc_name")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="CITY NAME">
                        <ItemTemplate>
                            <%#Eval("tcity_name")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                </asp:GridView></td>
        </tr>

    </table>
</asp:Content>
