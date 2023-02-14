<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication27.WebForm4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body background="images/AboutUs.png" style="background-size:cover; background-repeat: no-repeat;">
    <form id="form1" runat="server">
    <asp:Label ID="Label1" style="position: absolute;" runat="server" Font-Bold="False" Font-Names="Impact" Font-Size="Large" ForeColor="#FFFF66"></asp:Label>
    <div>
    
        <asp:LinkButton ID="LinkButton1" runat="server" 
            style="position: absolute; top: 226px; left: 31px" Height="25px" 
            Width="25px" onclick="LinkButton1_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton2" runat="server" 
            style="position: absolute; top: 268px; left: 31px" Height="25px" 
            Width="25px" onclick="LinkButton2_Click"></asp:LinkButton>
            <asp:LinkButton ID="LinkButton3" runat="server" 
            style="position: absolute; top: 315px; left: 31px" Height="25px" 
            Width="25px" onclick="LinkButton3_Click"></asp:LinkButton>
    
    </div>
    </form>
</body>
</html>

