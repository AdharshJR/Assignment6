<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="Assignment_6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center><h1>Registration</h1></center>
            <table align="center">
                
                <tr>
                    <td>
                        Department Name
                    </td>
                    <td>
                         <asp:DropDownList ID="ddl1" runat="server">
                             <asp:ListItem>Army</asp:ListItem>
                             <asp:ListItem>Airforce</asp:ListItem>
                             <asp:ListItem>Navy</asp:ListItem>
                             <asp:ListItem>CRPF</asp:ListItem>
                             <asp:ListItem>BSF</asp:ListItem>
                             <asp:ListItem>ITBP</asp:ListItem>
                             <asp:ListItem>CISF</asp:ListItem>
                         </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                         Enter the designation
                    </td>
                    <td>
                        <asp:TextBox ID="txtdes" runat="server"></asp:TextBox>
                    </td>
                   
                </tr>
                <tr>
                    <td>
                                <asp:Button ID="btn" runat="server" Text="Register" OnClick="btnsub_Click" />
                    </td>
            
                </tr>
            </table>

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="des_id" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
                <Columns>
                    <asp:BoundField DataField="dept_name" HeaderText="Department" />
                    <asp:BoundField DataField="des_name" HeaderText="Designation" />
                    <asp:CommandField HeaderText="Update" ShowEditButton="True" />
                    <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                    <asp:HyperLinkField DataNavigateUrlFields="des_id" DataNavigateUrlFormatString="Go.aspx?did={0}" HeaderText="Go to next page" Text="Go" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
