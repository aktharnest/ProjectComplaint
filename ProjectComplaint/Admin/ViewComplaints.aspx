<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="ViewComplaints.aspx.cs" Inherits="ProjectComplaint.Admin.ViewComplaints" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        margin-left: 0px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 align="center">Complaints</h2>
    <asp:Label ID="Label1" runat="server" Text="From"></asp:Label><asp:TextBox ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>&nbsp;<asp:Label ID="Label2" runat="server" Text="To"></asp:Label><asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" Text="View Complaints" align="center" />
    <h3 align="center">Not verified</h3>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="auto-style1" ForeColor="#333333" GridLines="None" Height="294px" Width="427px" OnRowDeleting="GridView1_RowDeleting" DataKeyNames="cId" >
    <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="username" HeaderText="User Name" />
            <asp:BoundField DataField="pname" HeaderText="Product Name" />
            <asp:BoundField DataField="complaint" HeaderText="Complaint" />
            <asp:BoundField DataField="cur_date" HeaderText="Date" />
            <asp:CommandField DeleteText="Approve" HeaderText="Status" ShowDeleteButton="True" />
        </Columns>
    <EditRowStyle BackColor="#7C6F57" />
    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#E3EAEB" />
    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F8FAFA" />
    <SortedAscendingHeaderStyle BackColor="#246B61" />
    <SortedDescendingCellStyle BackColor="#D4DFE1" />
    <SortedDescendingHeaderStyle BackColor="#15524A" />
</asp:GridView>
    <h3 align="center">In Progress</h3>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="cId" OnRowDeleting="GridView2_RowDeleting">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="username" HeaderText="User Name" />
            <asp:BoundField DataField="pname" HeaderText="Product Name" />
            <asp:BoundField DataField="complaint" HeaderText="Complaint" />
            <asp:BoundField DataField="cur_date" HeaderText="Date" />
            <asp:CommandField DeleteText="Confirm" HeaderText="Status" ShowDeleteButton="True" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    <h3 align="center">Completed</h3>
    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="username" HeaderText="User Name" />
            <asp:BoundField DataField="pname" HeaderText="Product Name" />
            <asp:BoundField DataField="complaint" HeaderText="Complaint" />
            <asp:BoundField DataField="cur_date" HeaderText="Date" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ComplaintConnectionString %>" SelectCommand="SELECT Login.username,Product.pname, ComplaintBox.complaint,ComplaintBox.cur_date  FROM Product CROSS JOIN Login INNER JOIN ComplaintBox ON Product.pId = ComplaintBox.pid AND Login.LId = ComplaintBox.lid"></asp:SqlDataSource>

</asp:Content>
