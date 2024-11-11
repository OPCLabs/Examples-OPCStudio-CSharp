<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AutoRefreshWeb._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<META HTTP-EQUIV="Refresh" CONTENT="3">
    <title>AutoRefreshWeb</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox ID="TextBox1" runat="server" Width="150px"></asp:TextBox>
    </div>
    <div>
    <asp:TextBox ID="TextBox2" runat="server" Width="150px"></asp:TextBox>
    </div>
    <div>
    <asp:TextBox ID="TextBox3" runat="server" Width="150px"></asp:TextBox>
    </div>
    </form>
</body>
</html>
