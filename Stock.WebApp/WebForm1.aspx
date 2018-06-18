<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Stock.WebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 349px; height: 178px; background-color:aliceblue;">
        
        <br />
        Select Sample Data File &nbsp; <asp:DropDownList ID="ddlDataSampleFiles" runat="server" OnSelectedIndexChanged="ddlDataSampleFiles_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label runat="server" id="lblResults" style="font-size: 13px; color: navy;"></asp:Label>
    </div>
    </form>
</body>
</html>
