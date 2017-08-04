<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentDetails.aspx.cs" Inherits="BasicWebFormMVPApp.PaymentDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Payment Details</h1>
        <p>
            First Name:
            <asp:TextBox ID="FirstNameTB" runat="server"></asp:TextBox>
        </p>
        <p>
            SecondName:
            <asp:TextBox ID="SecondNameTB" runat="server"></asp:TextBox>
        </p>
        <p>
            Card Number:
            <asp:TextBox ID="CardNumberTB" runat="server"></asp:TextBox>
        </p>
        <p>
            Card Expire
            <asp:TextBox ID="CardExpireTB" runat="server"></asp:TextBox>
        </p>
        <p>
            Card Type:
            <asp:DropDownList ID="CardTypeDDL" runat="server">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>Visa</asp:ListItem>
                <asp:ListItem>Mastercard</asp:ListItem>
                <asp:ListItem>Laser</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            Card CVN:
            <asp:TextBox ID="CardCVNTB" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="SubmitPaymentDetails" runat="server" Text="Submit" OnClick="SubmitPaymentDetails_OnClick" />
        </p>
    </div>
    </form>
</body>
</html>
