<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="GridViewBased_CRUD_Project.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee CRUD WebForms
    </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Green" Font-Bold="true"></asp:Label>

            <asp:GridView ID="gvEmployee" runat="server" AutoGenerateColumns="false" DataKeyNames="EmpId" ShowFooter="true" CssClass="table" OnRowEditing="gvEmployee_RowEditing" OnRowUpdating="gvEmployee_RowUpdating" OnRowDeleting="gvEmployee_RowDeleting" OnRowCancelingEdit="gvEmployee_RowCancelingEdit">
                <EmptyDataTemplate>
                    <div>
                        <b>OOPS! Sorry, no record found. </b>
                    </div>
                </EmptyDataTemplate>
                <Columns>
                    <%--Employee Id--%>
                    <asp:TemplateField HeaderText="Employee Id">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblEmpId" Text='<%# Eval("EmpId") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:Label ID="lblEditEmpId" runat="server" Text='<%# Eval("EmpId") %>' />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:Label ID="lblFooterEmpId" runat="server" Text=""></asp:Label>
                        </FooterTemplate>
                        <ItemStyle Width="2%" />
                    </asp:TemplateField>

                    <%--Employee name--%>
                    <asp:TemplateField HeaderText="Employee Name">
                        <%--View Mode--%>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblName" Text='<%# Eval("EmpName") %>'></asp:Label>
                        </ItemTemplate>

                        <%--Edit Mode (Editable as using Bind())--%>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtName" runat="server" Text='<%# Bind("EmpName") %>'></asp:TextBox>
                        </EditItemTemplate>

                        <%--Insert Mode--%>
                        <FooterTemplate>
                            <asp:TextBox ID="txtNewName" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemStyle Width="2%" />
                    </asp:TemplateField>

                    <%--Department--%>
                    <asp:TemplateField HeaderText="Employee Department">
                        <%--View Mode--%>
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblDepartment" Text='<%# Eval("Department") %>'></asp:Label>
                        </ItemTemplate>

                        <%--Edit Mode (Editable as using Bind())--%>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtDepartment" runat="server" Text='<%# Bind("Department") %>'></asp:TextBox>
                        </EditItemTemplate>

                        <%--Insert Mode--%>
                        <FooterTemplate>
                            <asp:TextBox ID="txtNewDepartment" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemStyle Width="2%" />
                    </asp:TemplateField>

                    <%--Salary--%>
                    <asp:TemplateField HeaderText="Employee Salary">
                        <ItemTemplate>
                            <asp:Label runat="server" ID="lblSalary" Text='<%# Eval("Salary") %>'></asp:Label>
                        </ItemTemplate>

                        <%--Edit Mode (Editable as using Bind())--%>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtSalary" runat="server" Text='<%# Bind("Salary") %>'></asp:TextBox>
                        </EditItemTemplate>

                        <%--Insert Mode--%>
                        <FooterTemplate>
                            <asp:TextBox ID="txtNewSalary" runat="server"></asp:TextBox>
                        </FooterTemplate>
                        <ItemStyle Width="2%" />
                    </asp:TemplateField>

                    <%--Action Buttons--%>
                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>

                            <asp:ImageButton ID="btnEdit" runat="server" CommandName="Edit" ImageUrl="~/Images/edit-Button.png" AlternateText="Edit" Height="25px" Width="25px" />

                            <asp:ImageButton ID="btnDelete" runat="server" CommandName="Delete" ImageUrl="~/Images/deleteButton.png" AlternateText="Delete" Height="25px" Width="25px" OnClientClick="return confirm('Are you sure to delete this record?')"/>

                            <%--<asp:LinkButton ID="lnkEdit" runat="server" CommandName="Edit" Text="Edit"></asp:LinkButton>
                            <asp:LinkButton ID="lnkDelete" runat="server" CommandName="Delete" Text="Delete" OnClientClick="return confirm('Are you sure to delete this record?');"></asp:LinkButton>--%>
                        </ItemTemplate>
                        <%--Edit Mode--%>
                        <EditItemTemplate>

                            <asp:ImageButton ID="lnkUpdate" runat="server" CommandName="Update" ImageUrl="~/Images/update-Button.png" AlternateText="Update" Height="30px" Width="30px" />

                            <asp:ImageButton ID="lnkCancel" runat="server" CommandName="Cancel" ImageUrl="~/Images/cancel-Button.png" AlternateText="Cancel" Height="30px" Width="30px" />

                            <%--<asp:LinkButton ID="lnkUpdate" runat="server" CommandName="Update" Text="Update"></asp:LinkButton>--%>


                            <%--<asp:LinkButton ID="lnkCancel" runat="server" CommandName="Cancel" Text="Cancel"></asp:LinkButton>--%>
                        </EditItemTemplate>
                        <%--Insert Mode--%>
                        <FooterTemplate>
                            <asp:ImageButton ID="btnAdd" runat="server" ImageUrl="~/Images/addButton.png" AlternateText="Add" Height="25px" Width="25px" OnClick="btnAdd_Click"/>
                        </FooterTemplate>
                        <ItemStyle Width="2%" />
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
