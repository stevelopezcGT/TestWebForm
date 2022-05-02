<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewPermission.aspx.cs" Inherits="WebApplication1.NewPermission"  %>

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
                <label >Employee Name:</label>
            </div>
            <div class="col-8">
                <asp:TextBox ID="employeeName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="employeeName" ID="req_EmployeeName" CssClass="text-danger" ErrorMessage="Please enter a valid Name"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="row">
            <div class="col-4">
                <label >Employee Last Name:</label>
            </div>
            <div class="col-8">
                <asp:TextBox ID="employeeLastName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="employeeLastName" ID="req_EmployeeLastName" CssClass="text-danger" ErrorMessage="Please enter a valid Last Name"></asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="row">
            <div class="col-4">
                <label >Permission Type:</label>
            </div>
            <div class="col-8">
                <asp:DropDownList ID="permissionType" SelectMethod="permissionType_GetData" DataTextField="Description" DataValueField="Id" runat="server"></asp:DropDownList>
                <asp:RangeValidator runat="server" ControlToValidate="permissionType" ID="permissionTypeValidator" MinimumValue="0" MaximumValue="32222" CssClass="text-danger" ErrorMessage="Please select a valid Permission Type"></asp:RangeValidator>
            </div>
        </div>

        <asp:Button ID="saveData" CssClass="btn btn-primary" runat="server" OnClick ="saveData_Click" Text="Save" />
    </form>
</body>
</html>
