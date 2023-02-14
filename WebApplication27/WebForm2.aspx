<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication27.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="Black">
    <form id="form1" runat="server">
    <asp:Label ID="Label1" style="position: absolute;" runat="server" Font-Bold="False" Font-Names="Impact" Font-Size="Large" ForeColor="#FFFF66"></asp:Label>
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Interval="2000" ontick="Timer1_Tick">
                </asp:Timer>
                <asp:Image ID="Image1" runat="server" Height="691px" ImageUrl="~/images/1.jpg" 
                    style="margin-right: 7px" Width="1353px" />
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
