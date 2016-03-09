<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CaculatorWebForm.aspx.cs" Inherits="CaculatorWebApplication.CaculatorWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CaculatorStyleSheet.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style17">
             <tr>
                 <td colspan="3" class="auto-style16"> Calcuator Web Form</td>
             </tr>
             <tr>
                <td class="auto-style13"></td>
                <td class="auto-style14">X:</td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtX" runat="server" Height="16px" Width="132px"></asp:TextBox>
                </td>
                <td class="auto-style15"></td>
            </tr>
            <tr>
                <td class="auto-style13"></td>
                <td class="auto-style14">Y:</td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtY" runat="server" Height="16px" Width="132px"></asp:TextBox>
                </td>
                <td class="auto-style15"></td>
            </tr>
            <tr>
                <td class="auto-style13"></td>
                <td class="auto-style14">Result</td>
                <td class="auto-style15">
                    <asp:TextBox ID="txtResult" runat="server" Height="16px" Width="133px" ReadOnly="True"></asp:TextBox>
                </td>
                <td class="auto-style15"></td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5"></td>
                <td class="auto-style6">
                    <asp:Button ID="btnCaculate" runat="server" Text="Calculate" OnClick="btnCaculate_Click" />
                </td>
                <td class="auto-style6"></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
