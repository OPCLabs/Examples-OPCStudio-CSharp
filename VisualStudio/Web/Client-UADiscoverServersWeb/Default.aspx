<%@ Page Language="C#" AutoEventWireup="false" CodeBehind="Default.aspx.cs" Inherits="UADiscoverServersWeb._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>BrowseServersWeb</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>

		<asp:ListBox ID="ListBox1" runat="server" Height="140px" Width="864px">
		</asp:ListBox>

		<asp:TextBox ID="TextBox1" runat="server" Height="64px" ReadOnly="True" 
			Visible="False" Width="368px"></asp:TextBox>
	</div>
	</form>
</body>
</html>