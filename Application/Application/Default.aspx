<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Application.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-xs-12">
            Pleases select a vendor:
            <asp:DropDownList
                runat="server"
                ID="dropDown"
                DataSourceID="ObjectDataSource2"
                DataTextField="Value"
                DataValueField="Key"
                AutoPostBack="True"
                OnSelectedIndexChanged="dropDown_OnSelectedIndexChanged" />
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetAllVendor" TypeName="Application.BL.BusinessService" />
        </div>
    </div>
    <div class="row">
        <div class="col-xs-12">
            <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="true" />
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" TypeName="Application.BL.BusinessService" SelectMethod="GetCarsByVendor">
                <SelectParameters>
                    <asp:ControlParameter ControlID="dropDown" DefaultValue="1" Name="vendorId" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
    </div>
</asp:Content>
