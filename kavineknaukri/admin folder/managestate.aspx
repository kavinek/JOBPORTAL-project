<%@ Page Title="" Language="C#" MasterPageFile="~/admin folder/admin.Master" AutoEventWireup="true" CodeBehind="managestate.aspx.cs" Inherits="kavineknaukri.admin_folder.managestate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content> 
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
        <tr>
            <td>COUNTRY NAME:</td>
            <td><asp:DropDownList ID="ddlcountry" runat="server"></asp:DropDownList></td>
        </tr>
         <tr>
            <td>STATE:</td>
            <td><asp:TextBox ID="txtstatename" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnsave" runat="server" Text="SAVE STATE" OnClick="btnsave_Click" /></td>
        </tr>

        <tr>
            <td></td>
            <td><asp:GridView ID="gvstate" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="STATE ID">
                        <ItemTemplate>
                            <%#Eval("ts_id")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="COUNTRY NAME">
                        <ItemTemplate>
                            <%#Eval("tc_name")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="STATE NAME">
                        <ItemTemplate>
                            <%#Eval("ts_name")%>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                </asp:GridView></td>
        </tr>

    </table>
</asp:Content>
