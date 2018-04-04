<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DotnetPosition_Irvine.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 40%;">
            <tr>
                <td>
                    <b>Second Longest Word : </b>
                </td>
                <td>
                    <asp:Label ID="lblWord" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <b>Total Count :</b>
                </td>
                <td>  <asp:Label ID="lblCount" runat="server"></asp:Label></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
