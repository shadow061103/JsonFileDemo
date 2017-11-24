<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadJsonFile.aspx.cs" Inherits="JsonFileDemo.ReadJsonFile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="讀取json檔" />
        結果:<asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
