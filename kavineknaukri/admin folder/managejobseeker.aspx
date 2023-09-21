<%@ Page Title="" Language="C#" MasterPageFile="~/admin folder/admin.Master" AutoEventWireup="true" CodeBehind="managejobseeker.aspx.cs" Inherits="kavineknaukri.admin_folder.managejobseeker" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
           <td><asp:GridView ID="gvjobseeker" runat="server" AutoGenerateColumns="false" OnRowCommand="gvjobseeker_RowCommand">
               <Columns>
                   <asp:TemplateField HeaderText="JOB-SEEKER ID">
                       <ItemTemplate>
                           <%#Eval("js_id")%>
                       </ItemTemplate>
                   </asp:TemplateField>
                   <asp:TemplateField HeaderText="JOB-SEEKER NAME">
                       <ItemTemplate>
                           <%#Eval("js_name")%>
                       </ItemTemplate>
                   </asp:TemplateField>
                   <asp:TemplateField HeaderText="JOB-SEEKER GENDER">
                       <ItemTemplate>
                           <%#Eval("js_gender")%>
                       </ItemTemplate>
                   </asp:TemplateField>
                   <asp:TemplateField HeaderText="JOB-SEEKER EMAIl">
                       <ItemTemplate>
                           <%#Eval("js_email")%>
                       </ItemTemplate>
                   </asp:TemplateField>

                    <asp:TemplateField HeaderText="DATE OF BIRTH">
                       <ItemTemplate>
                           <%#Eval("js_dob")%>
                       </ItemTemplate>
                   </asp:TemplateField>


                   <%--<asp:TemplateField HeaderText="JOB-SEEKER PASSWORD">
                       <ItemTemplate>
                           <%#Eval("js_password")%>
                       </ItemTemplate>
                   </asp:TemplateField>--%>

                    <asp:TemplateField HeaderText="JOB-SEEKER QUALIFICATION">
                       <ItemTemplate>
                           <%#Eval("js_qualification")%>
                       </ItemTemplate>
                   </asp:TemplateField>

                    <asp:TemplateField HeaderText="JOB-SEEKER JOB PROFILE">
                       <ItemTemplate>
                           <%#Eval("js_jobprofile")%>
                       </ItemTemplate>
                   </asp:TemplateField>

                   <asp:TemplateField HeaderText="JOB-SEEKER JOB PROFILE">
                       <ItemTemplate>
                           <%#Eval("js_skills")%>
                       </ItemTemplate>
                   </asp:TemplateField>

                    <asp:TemplateField HeaderText="JOB-SEEKER LOCATION">
                       <ItemTemplate>
                           <%#Eval("tcity_name")%> , <%#Eval("ts_name")%> ,  <%#Eval("tc_name")%>
                       </ItemTemplate>
                   </asp:TemplateField>

                    <asp:TemplateField HeaderText="JOBSEEKER IMAGE">
                       <ItemTemplate>
                         <asp:Image ID="imgjs" runat="server" Height="70px" Width="70px" ImageUrl='<%#Eval("js_image","~/jobseeker folder/JOBSEEKERIMAGES/{0}")%>' />
                      </ItemTemplate>
                   </asp:TemplateField>

                   <asp:TemplateField HeaderText="JOBSEEKER RESUME">
                       <ItemTemplate>
                       <asp:LinkButton ID="btnresumeshow" runat="server" Text='<%#Eval("js_resume")%>' CommandName="R" CommandArgument='<%#Eval("js_resume")%>' ></asp:LinkButton>
                       </ItemTemplate>
                   </asp:TemplateField>
                   
                   <asp:TemplateField HeaderText="JOB-SEEKER INSERTED DATE">
                       <ItemTemplate>
                           <%#Eval("inserted_date")%>
                       </ItemTemplate>
                   </asp:TemplateField>
                   <asp:TemplateField HeaderText="JOB-SEEKER STATUS">
                       <ItemTemplate>
                           <%#Eval("status").ToString() == "0" ? "ACTIVE-STATUS" : "INACTIVE-STATUS" %>
                       </ItemTemplate>
                   </asp:TemplateField>
                    <asp:TemplateField HeaderText="ACTION BUTTON">
                       <ItemTemplate>
                          <asp:Button ID="actionbtn" runat="server" Text=' <%#Eval("status").ToString() == "0" ? "BLOCK" : "UNBLOCK" %>' CommandName="B" CommandArgument='<%#Eval("js_id")%>' />
                       </ItemTemplate>
                   </asp:TemplateField>
               </Columns>
               </asp:GridView></td>
        </tr>
    </table>
</asp:Content>
