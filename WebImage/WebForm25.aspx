<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm25.aspx.cs" Inherits="WebImage.WebForm25" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
            <br />
            <asp:Panel ID="Panel1" runat="server" BorderColor="#9900FF" BorderStyle="Dashed" Width="450px">
            </asp:Panel>
        </div>
    </form>
</body>
</html>
