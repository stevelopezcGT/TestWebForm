﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col">
            <h3>Permissions</h3>
        </div>
    </div>
    <div class="row">
        <div class="col">
            <asp:Button CssClass="btn btn-primary" runat="server" ID="newPermission" OnClick="newPermission_Click" Text="New Permission" PostBackUrl="~/NewPermission.aspx" />
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col">
            <asp:GridView ID="GridView1" runat="server" ItemType="TestEntities.PermissionEntity" DataKeyNames="Id" OnRowDataBound="GridView1_RowDataBound"
                SelectMethod="GridView1_GetData" UpdateMethod="GridView1_UpdateItem" DeleteMethod="GridView1_DeleteItem"
                AutoGenerateDeleteButton="true" AutoGenerateEditButton="true"
                AutoGenerateColumns="false">
                <Columns>
                    <asp:DynamicField DataField="Id" ItemStyle-Width="50px" />
                    <asp:DynamicField DataField="EmployeeLastName" HeaderText="Last Name" ItemStyle-Width="200px" />
                    <asp:DynamicField DataField="EmployeeName" HeaderText ="Name" ItemStyle-Width="200px" />
                    <asp:DynamicField DataField="PermissionDate" HeaderText ="Date" ItemStyle-Width="150px" />
                    
                    <asp:DynamicField DataField="PermissionTypeDescription" HeaderText="Permission Type" ItemStyle-Width="250px" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
    

</asp:Content>
