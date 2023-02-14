<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication27.WebForm3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body background="images/a1.jpg" style=" background-repeat: no-repeat;background-size:cover">
    <form id="form1" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:Database1ConnectionString %>" 
            SelectCommand="SELECT * FROM [REGISTRATION]"></asp:SqlDataSource>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        <asp:ListItem Selected="True">User</asp:ListItem>
        <asp:ListItem>Admin</asp:ListItem>
    </asp:DropDownList>
    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="View1" runat="server">
        
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <div align="center">
                <br>
                <br></br>
                <br>
                <br></br>
                <table align="center" cellspacing="8" style="margin-left:500px;">
                    <tr style="border-spacing: 100px">
                        <td align="center" colspan="3" height="10px">
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <asp:Label ID="Label7" runat="server" align="center" Font-Bold="True" 
                                Font-Names="Times New Roman" Font-Size="XX-Large" ForeColor="White" 
                                Text="Register"></asp:Label>
                        </td>
                        <td>
                            &nbsp;&nbsp;</td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                        </td>
                        <td>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;<asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="Larger" 
                                ForeColor="White" Text="Name :"></asp:Label>
                        </td>
                        <td class="style1">
                            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                ControlToValidate="TextBox5" Display="Dynamic" ErrorMessage="Enter the name" 
                                Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td class="style1">
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="Larger" 
                                ForeColor="White" Text="Age :"></asp:Label>
                        </td>
                        <td class="style1">
                            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                ControlToValidate="TextBox6" Display="Dynamic" ErrorMessage="Enter the age" 
                                Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="RangeValidator1" runat="server" 
                                ControlToValidate="TextBox6" Display="Dynamic" 
                                ErrorMessage="Your age is less than 21" Font-Bold="True" ForeColor="Red" 
                                MaximumValue="100" MinimumValue="18" Type="Integer"></asp:RangeValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td class="style1">
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="Larger" 
                                ForeColor="White" Text="Contact No:"></asp:Label>
                        </td>
                        <td class="style1">
                            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                ControlToValidate="TextBox7" Display="Dynamic" 
                                ErrorMessage="Enter the Mobile Number" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td class="style1">
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Size="Larger" 
                                ForeColor="White" Text="Email id : "></asp:Label>
                        </td>
                        <td class="style1">
                            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                ControlToValidate="TextBox8" Display="Dynamic" 
                                ErrorMessage="Enter the Email-ID" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                ControlToValidate="TextBox8" Display="Dynamic" 
                                ErrorMessage=" Enter the proper Email-ID" Font-Bold="True" ForeColor="Red" 
                                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td class="style1">
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="3">
                            <asp:Button ID="Button2" runat="server" align="center" BackColor="#33CCFF" 
                                BorderColor="#33CCFF" Font-Names="Arial Black" onclick="Button2_Click" 
                                style="margin-left: 0px" Text="Submit" Width="127px" />
                        </td>
                        <td>
                        </td>
                        <td>
                        </td>
                    </tr>
                </table>
                </br>
    </br>
    
    
    
    </div>
    </asp:View>
        <asp:View ID="View2" runat="server">
        <br>
        <br>
        <br>
        <br>
        <br><br>
        <br>
        <br><br><br><br><br>
        <br>
        <table cellpadding="20" align="center">
        <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Admin User" Font-Bold="True" 
                Font-Names="Times New Roman" ForeColor="White" Font-Size="Larger"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Password" Font-Bold="True" 
                Font-Names="Times New Roman" ForeColor="White" Font-Size="Larger"></asp:Label></td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
        <td colspan ="2" align="center">
            <asp:Button ID="Button1" runat="server" Text="Admin Login" align="center" 
                BackColor="#33CCFF" BorderColor="#33CCFF" Font-Bold="True" 
                Font-Names="Arial Black" onclick="Button1_Click1"/>
        </td>
        </tr>
        </table>
        </asp:View>
        </asp:MultiView>
    </form>
</body>
</html>
