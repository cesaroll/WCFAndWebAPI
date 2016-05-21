<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateEmployee.aspx.cs" Inherits="WCF.Employees.Client.CreateEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <fieldset>
            <legend>Create Employee</legend>
            
            <asp:Table ID="Table1" runat="server">
                
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="tbFirstName" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:Label ID="Label2" runat="server" Text="Last Name:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="tbLastName" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                
                 <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:Label ID="Label3" runat="server" Text="Salary:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="tbSalary" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:Button runat="server" ID="Submit" Text="Submit" OnClick="Submit_Click"/>
                    </asp:TableCell>
                </asp:TableRow>

            </asp:Table>

            
            
            

        </fieldset>
       
    
    </div>
    </form>
</body>
</html>
