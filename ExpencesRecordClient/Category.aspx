<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="ExpencesRecordClient.Category" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 613px;
        }
        .auto-style4 {
            width: 45px;
        }
        .auto-style5 {
            width: 157px;
        }
    </style>
</head>
<body style="height: 407px">
    <form id="form1" runat="server">
        <div>
            <table class="auto-style2"> 
                <tr> 
                    <td class="auto-style5">
                        <asp:Label ID="Label1" runat="server" Text="Category ID"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtc_id" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr> 
                    <td class="auto-style5">
                        <asp:Label ID="Label2" runat="server" Text="Category Name"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtc_name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Label ID="lblres" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr> 
                    <td class="auto-style5"></td>
                    <td class="auto-style4">
                        <asp:Button ID="txtadd" runat="server" OnClick="txtadd_Click" Text="Add Category" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
