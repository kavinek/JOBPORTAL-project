<%@ Page Title="" Language="C#" MasterPageFile="~/admin folder/admin.Master" AutoEventWireup="true" CodeBehind="managejobpost.aspx.cs" Inherits="kavineknaukri.admin_folder.managejobpost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
             <tr>
           <td><asp:GridView ID="gvjobs" runat="server" AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" OnRowCommand="gvjobs_RowCommand" >
               <AlternatingRowStyle BackColor="PaleGoldenrod" />
               <Columns>
                   <asp:TemplateField HeaderText="JOB ID">
                       <ItemTemplate>
                           <%#Eval("jp_id")%>
                       </ItemTemplate>
                   </asp:TemplateField>
                   <asp:TemplateField HeaderText="JOB-RECRUITER NAME">
                       <ItemTemplate>
                           <%#Eval("jr_name")%>
                       </ItemTemplate>
                   </asp:TemplateField>
                   <asp:TemplateField HeaderText="JOB-PROFILE ">
                       <ItemTemplate>
                           <%#Eval("jpr_name")%>
                       </ItemTemplate>
                   </asp:TemplateField>
                   <asp:TemplateField HeaderText="JOB-LOCATION ">
                       <ItemTemplate>
                           <%#Eval("tjl_name")%>
                       </ItemTemplate>
                   </asp:TemplateField>
                    <asp:TemplateField HeaderText="REQUIRED-EXPERIENCE ">
                       <ItemTemplate>
                           <%#Eval("minexp")%> years -   <%#Eval("maxexp")%> years
                       </ItemTemplate>
                   </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="OFFERED SALARY RANGE ">
                       <ItemTemplate>
                       Rs.<%#Eval("minsalary")%>- Rs.<%#Eval("maxsalary")%>
                       </ItemTemplate>
                   </asp:TemplateField>
                   
                   <asp:TemplateField HeaderText="NO OF VAcANCY">
                       <ItemTemplate>
                           <%#Eval("noofvacany")%>
                           </ItemTemplate>
                   </asp:TemplateField>
                    <asp:TemplateField HeaderText="JOB-DESCRIPTION">
                       <ItemTemplate>
                           <%#Eval("comment")%>
                           </ItemTemplate>
                   </asp:TemplateField>
                    <asp:TemplateField HeaderText="JOB-POSTED DATE">
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
                          <asp:Button ID="actionbtn" runat="server" Text=' <%#Eval("status").ToString() == "0" ? "BLOCK" : "UNBLOCK" %>' CommandName="B" CommandArgument='<%#Eval("jp_id")%>' />
                       </ItemTemplate>
                   </asp:TemplateField>


                     </Columns>
               <FooterStyle BackColor="Tan" />
               <HeaderStyle BackColor="Tan" Font-Bold="True" />
               <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
               <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
               <SortedAscendingCellStyle BackColor="#FAFAE7" />
               <SortedAscendingHeaderStyle BackColor="#DAC09E" />
               <SortedDescendingCellStyle BackColor="#E1DB9C" />
               <SortedDescendingHeaderStyle BackColor="#C2A47B" />
               </asp:GridView>

               </tr>
    </table>
</asp:Content>
