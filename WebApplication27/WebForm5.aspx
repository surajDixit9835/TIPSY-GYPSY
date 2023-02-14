<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication27.WebForm5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body style="background-attachment: fixed; background-repeat: no-repeat; background-image: url('Images/table.jpg'); background-position: center center;background-size:cover">
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" 
            style="position: absolute; top: 200px; left: 1150px" BackColor="#663300" Height="250px" 
            Width="89px" onclick="Button1_Click" Text="Dine Table" />
        <asp:Button ID="Button2" runat="server" Text="Table" 
            style="position: absolute; top: 180px; left: 1018px" BackColor="#66FF66" Height="89px" 
            Width="89px" onclick="Button2_Click"/>
        <asp:Button
                ID="Button3" runat="server" Text="Tabel" 
            style="position: absolute; top: 280px; left: 1018px" BackColor="#66FF66" Height="89px" 
            Width="89px" onclick="Button3_Click"/>
        <asp:Button ID="Button4" runat="server"
                    Text="Table" style="position: absolute; top: 380px; left: 1018px" 
            BackColor="#66FF66" Height="89px" Width="89px" onclick="Button4_Click"/>
        <asp:Button ID="Button5" runat="server" 
            style="position: absolute; top: 150px; left: 978px; width: 12px; height: 350px;" 
            BackColor="#3366FF" Enabled="False"/>
        <asp:Button ID="Button7" runat="server" Text="Table" 
            style="position: absolute; top: 280px; left: 865px" BackColor="Green" Height="89px" 
            Width="89px" onclick="Button7_Click"/>
        <asp:Button ID="Button8" runat="server" Text="Table" 
            style="position: absolute; top: 380px; left: 865px" BackColor="#66FF66" Height="89px" 
            Width="89px" onclick="Button8_Click"/>
        <asp:Button ID="Button6" runat="server" Text="Table" 
            style="position: absolute; top: 180px; left: 865px; bottom: 181px;" 
            BackColor="#66FF66" Height="89px" 
            Width="89px" onclick="Button6_Click"/>
        <asp:Button ID="Button9" runat="server" Text="Sofa Table" 
            style="position: absolute; top: 179px; left: 650px" BackColor="#66FF66" Height="89px" 
            Width="150px" onclick="Button9_Click" ondatabinding="Page_Load"/>
         <asp:Button ID="Button10" runat="server" Text="Sofa Table" 
            style="position: absolute; top: 280px; left: 650px" BackColor="#66FF66" Height="89px" 
            Width="150px" onclick="Button10_Click"/>
         <asp:Button ID="Button11" runat="server" Text="Sofa Table" 
            style="position: absolute; top: 380px; left: 650px" BackColor="#66FF66" Height="89px" 
            Width="150px" onclick="Button11_Click"/>
         <asp:Button ID="Button12" runat="server" text="Bar Counter"
            style="position: absolute; top: 100px; left: 750px; width: 252px; height: 19px;" 
            BackColor="#3366FF" Enabled="False" ForeColor="Red"/>
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:Database1ConnectionString %>" 
        SelectCommand="SELECT [Tableid], [Tablestatus] FROM [TABLEBOOKING] WHERE ([Tablestatus] = @Tablestatus)">
        <SelectParameters>
            <asp:Parameter DefaultValue="Unbooked" Name="Tablestatus" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
        <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Names="Impact" Font-Size="Large" ForeColor="#FFFF66"></asp:Label>
    </form>
</body>
</html>
