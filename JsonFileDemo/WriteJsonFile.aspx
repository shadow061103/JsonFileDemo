﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WriteJsonFile.aspx.cs" Inherits="JsonFileDemo.WriteJsonFile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" Text="產Json檔案" OnClick="Button1_Click" />
        結果:
        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
    
    </div>
    </form>
</body>
</html>