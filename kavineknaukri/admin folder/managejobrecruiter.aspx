<%@ Page Title="" Language="C#" MasterPageFile="~/admin folder/admin.Master" AutoEventWireup="true" CodeBehind="managejobrecruiter.aspx.cs" Inherits="kavineknaukri.admin_folder.managejobrecruiter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table>
        <tr>
           <td><asp:GridView ID="gvjobrecruiter" runat="server" AutoGenerateColumns="false" OnRowCommand="gvjobrecruiter_RowCommand">
               <Columns>
                   <asp:TemplateField HeaderText="JOB-RECRUITER ID">
                       <ItemTemplate>
                           <%#Eval("jr_id")%>
                       </ItemTemplate>
                   </asp:TemplateField>
                   <asp:TemplateField HeaderText="JOB-RECRUITER NAME">
                       <ItemTemplate>
                           <%#Eval("jr_name")%>
                       </ItemTemplate>
                   </asp:TemplateField>
                   <asp:TemplateField HeaderText="JOB-RECRUITER URL">
                       <ItemTemplate>
                           <%#Eval("jr_url")%>
                       </ItemTemplate>
                   </asp:TemplateField>
                   <asp:TemplateField HeaderText="JOB-RECRUITER EMAIl">
                       <ItemTemplate>
                           <%#Eval("jr_email")%>
                       </ItemTemplate>
                   </asp:TemplateField>
                   <asp:TemplateField HeaderText="JOB-RECRUITER PASSWORD">
                       <ItemTemplate>
                           <%#Eval("jr_password")%>
                       </ItemTemplate>
                   </asp:TemplateField>
                   <asp:TemplateField HeaderText="JOB-SEEKER RECRUITER DATE">
                       <ItemTemplate>
                           <%#Eval("inserted_date")%>
                       </ItemTemplate>
                   </asp:TemplateField>
                   <asp:TemplateField HeaderText="JOB-RECRUITER STATUS">
                       <ItemTemplate>
                           <%#Eval("status").ToString() == "0" ? "ACTIVE-STATUS" : "INACTIVE-STATUS" %>
                       </ItemTemplate>
                   </asp:TemplateField>
                    <asp:TemplateField HeaderText="ACTION BUTTON">
                       <ItemTemplate>
                          <asp:Button ID="actionbtn" runat="server" Text=' <%#Eval("status").ToString() == "0" ? "BLOCK" : "UNBLOCK" %>' CommandName="B" CommandArgument='<%#Eval("jr_id")%>' />
                           </ItemTemplate>
                   </asp:TemplateField>
               </Columns>
               </asp:GridView></td>
        </tr>
    </table>

</asp:Content>
