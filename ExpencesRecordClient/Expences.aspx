<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Expences.aspx.cs" Inherits="ExpencesRecordClient.Expences" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 899px;
            height: 533px;
        }
        .auto-style2 {
            width: 241px;
        }
    </style>
</head>
<body style="height: 834px">
    <form id="form1" runat="server">
        <div>
            <h1 style ="text-align:center;">Expences</h1>
            <table class="auto-style1"> 
                <tr> 
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="Category"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ExpencesDataSource" DataTextField="c_type" DataValueField="c_type">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="ExpencesDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ExpencesRecordConnectionString2 %>" SelectCommand="SELECT [c_type] FROM [Category]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr> 
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Description "></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtDes" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr> 
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="Amount"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr> 
                    <td class="auto-style2">
                        <asp:Label ID="Label4" runat="server" Text="Date"></asp:Label>
                    </td>
                    <td>
                        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                    </td>
                </tr>
                <tr> 
                    <td class="auto-style2">
                        <asp:Label ID="Label5" runat="server" Text="Expences ID"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txteid" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Label ID="lblres" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr> 
                    <td class="auto-style2"></td>
                    <td >&nbsp;<asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" Text="Add Expence" />
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btneRmove" runat="server" Text="Remove Expence" OnClick="btneRmove_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnCal" runat="server" Text="Calculate" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
