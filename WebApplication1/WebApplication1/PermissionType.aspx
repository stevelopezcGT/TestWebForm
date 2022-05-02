<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PermissionType.aspx.cs" Inherits="WebApplication1.PermissionType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Permission</title>
</head>
<body>
    <h3>Permission</h3>
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-4">
                <label >Description:</label>
            </div>
            <div class="col-8">
                <asp:TextBox ID="description" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="description" ID="req_EmployeeName" CssClass="text-danger" ErrorMessage="Please enter a valid Description"></asp:RequiredFieldValidator>
            </div>
        </div>


        <asp:Button ID="saveData" CssClass="btn btn-primary" runat="server" OnClick ="saveData_Click" Text="Save" />
    </form>
</body>
</html>