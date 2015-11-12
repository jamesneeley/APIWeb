<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="TestHorizonWebService.main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style type="text/css">
.btn_sm, .btn_sm:link, .btn_sm:visited {
    padding: 4px 5px;
    font-size: 12px;
    border: solid #ccc 1px;
    background-color: #eee;
    color: #666;
    text-transform: capitalize;
    -moz-border-radius: 5px;
    -webkit-border-radius: 5px;
    border-radius: 5px;
    width: 100%;
}
input:valid, textarea:valid {
}
body, select, input, textarea {
    color: #4B4B4B;
    font-family: "Arial", sans-serif;
    font-size: 12px;
}
button, input, select, textarea {
    margin: 0;
}
select, input, textarea, button {
    font: 80% "Arial", sans-serif;
}
input, select, button, textarea {
    vertical-align: middle;
    padding: 5px 3px;
    border: solid #ccc 1px;
}
user agent stylesheetinput:not([type]), input[type="email" i], input[type="number" i], input[type="password" i], input[type="tel" i], input[type="url" i], input[type="text" i] {
    padding: 1px 0px;
}
user agent stylesheetinput {
    -webkit-appearance: textfield;
    padding: 1px;
    background-color: white;
    border: 2px inset;
    border-image-source: initial;
    border-image-slice: initial;
    border-image-width: initial;
    border-image-outset: initial;
    border-image-repeat: initial;
    -webkit-rtl-ordering: logical;
    -webkit-user-select: text;
    cursor: auto;
}
user agent stylesheetinput, textarea, keygen, select, button {
    margin: 0em;
    font: 10px Arial;
    text-rendering: auto;
    color: initial;
    letter-spacing: normal;
    word-spacing: normal;
    text-transform: none;
    text-indent: 0px;
    text-shadow: none;
    display: inline-block;
    text-align: start;
}
user agent stylesheetinput, textarea, keygen, select, button, meter, progress {
    -webkit-writing-mode: horizontal-tb;
}
</style>
<script type = "text/javascript">
	function Confirm() {
		var confirm_value = document.createElement("INPUT");
		confirm_value.type = "hidden";
		confirm_value.name = "confirm_value";
		if (confirm("The server certificate is not valid.\nAccept?")) {
			confirm_value.value = "Yes";
		} else {
			confirm_value.value = "No";
		}
		document.forms[0].appendChild(confirm_value);
	}
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="align:center;" align="center">
    
    	<strong>Login and Information</strong><br />
    
    	<table style="width:1000px;" cellspacing="2" cellpadding="1" border="0" 
				bgcolor="#F4F8FF">
				<tr>
					<td width="16%">
						<asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
					</td>
					<td width="16%">
						<asp:TextBox ID="TextBoxUser" runat="server"></asp:TextBox>
					</td>
					<td width="16%">
						<asp:Button ID="Button1" runat="server" Text="Categories" CssClass="btn_sm" 
							onclick="Button1_Click" />
					</td>
					<td width="16%">
						<asp:Button ID="Button2" runat="server" Text="Daily Styles" CssClass="btn_sm" 
							onclick="Button2_Click1" />
					</td>
					<td rowspan="4" valign="top">
						<asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" MaxLength="300" 
							Rows="10" Width="346px"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td>
						<asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
					</td>
					<td>
						<asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
					</td>
					<td>
						<asp:Button ID="Button3" runat="server" Text="Master Item List" 
							CssClass="btn_sm" onclick="Button3_Click1" />
					</td>
					<td>
						<asp:Button ID="Button4" runat="server" Text="BOM List" CssClass="btn_sm" 
							onclick="Button4_Click1" />
					</td>
				</tr>
				<tr>
					<td>
						<asp:Label ID="Label3" runat="server" Text="Customer"></asp:Label>
					</td>
					<td>
						<asp:TextBox ID="TextBoxCustomer" runat="server"></asp:TextBox>
					</td>
					<td>
						&nbsp;</td>
					<td>
						&nbsp;</td>
				</tr>
				<tr>
					<td>
						&nbsp;</td>
					<td>
						&nbsp;</td>
					<td>
						&nbsp;</td>
					<td>
						&nbsp;</td>
				</tr>
			</table>


			<br />
			<strong>Options</strong><br />
			<table style="width:1000px; cellspacing="2" cellpadding="1" border="0" 
				bgcolor="#F4F8FF">
				<tr>
					<td width="16%">
						<asp:Label ID="Label4" runat="server" Text="Category"></asp:Label>
					</td>
					<td width="16%">
						<asp:TextBox ID="TextBoxCategory" runat="server"></asp:TextBox>
					</td>
					<td width="16%">
						<asp:Button ID="Button5" runat="server" Text="Items" CssClass="btn_sm" 
							onclick="Button5_Click1" />
					</td>
					<td width="16%">
						<asp:Button ID="Button6" runat="server" Text="Realtime Status" 
							CssClass="btn_sm" onclick="Button6_Click1" />
					</td>
					<td width="18%">
						<asp:Button ID="Button7" runat="server" Text="Multiple Items" 
							CssClass="btn_sm" onclick="Button7_Click1" />
					</td>
					<td>
						<asp:Button ID="Button8" runat="server" Text="Recommended Items" 
							CssClass="btn_sm" onclick="Button8_Click1" />
					</td>
				</tr>
				<tr>
					<td>
						<asp:Label ID="Label5" runat="server" Text="Item ID"></asp:Label>
					</td>
					<td>
						<asp:TextBox ID="TextBoxItemId" runat="server"></asp:TextBox>
					</td>
					<td>
						<asp:Button ID="Button9" runat="server" Text="Single Item" CssClass="btn_sm" 
							onclick="Button9_Click1" />
					</td>
					<td>
						<asp:Button ID="Button10" runat="server" Text="Replacement Items" 
							CssClass="btn_sm" onclick="Button10_Click1" />
					</td>
					<td colspan="2">
						<asp:Button ID="Button11" runat="server" Text="BOM Components" 
							CssClass="btn_sm" onclick="Button11_Click1" />
					</td>
				</tr>
				<tr>
					<td>
						<asp:Label ID="Label6" runat="server" Text="Days"></asp:Label>
					</td>
					<td>
						<asp:TextBox ID="TextBoxDays" runat="server"></asp:TextBox>
					</td>
					<td colspan="2">
						<asp:Button ID="Button12" runat="server" Text="Inventory Changes" 
							CssClass="btn_sm" onclick="Button12_Click1" />
					</td>
					<td colspan="2">
						&nbsp;</td>
				</tr>
				<tr>
					<td>
						<asp:Label ID="Label7" runat="server" Text="Sono"></asp:Label>
					</td>
					<td>
						<asp:TextBox ID="TextBoxSono" runat="server"></asp:TextBox>
					</td>
					<td>
						<asp:Button ID="Button13" runat="server" Text="Sales Order" CssClass="btn_sm" 
							onclick="Button13_Click1" />
					</td>
					<td>
						<asp:Button ID="Button14" runat="server" Text="Tracking Number" 
							CssClass="btn_sm" onclick="Button14_Click1" />
					</td>
					<td colspan="2">
						<asp:Button ID="Button15" runat="server" Text="Post an Order" 
							CssClass="btn_sm" onclick="Button15_Click" />
					</td>
				</tr>
			</table>
			<br />
			<asp:Panel ID="PanelPostOrder" runat="server" Width="1000px" 
				BackColor="#F4F8FF" Visible="False">
				<br />
				<asp:Label ID="Label8" runat="server" Text="Order XML" style="font-weight: 700"></asp:Label>
				<br />
				<asp:TextBox ID="TextBoxOrderXML" runat="server" TextMode="MultiLine" Rows="10" 
					Width="990px"></asp:TextBox>
				<br />
				<asp:Button ID="ButtonPostOrder" runat="server" Text="Post Order" 
					CssClass="btn_sm" style="width: 200px;margin-top: 4px;margin-bottom:4px;" />
			</asp:Panel>
			<br />
			<asp:Panel ID="PanelResult" runat="server" Width="1000px" 
				BackColor="#F4F8FF" Visible="False"><br />
				<asp:TextBox ID="TextBoxResult" runat="server" TextMode="MultiLine" Rows="10" 
					Width="990px"></asp:TextBox><br /><br />
			</asp:Panel>
			<br />
			<br />

    
    </div>
    </form>
</body>
</html>
