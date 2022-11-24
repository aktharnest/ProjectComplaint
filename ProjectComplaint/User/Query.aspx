<%@ Page Title="" Language="C#" MasterPageFile="~/User/Site1.Master" AutoEventWireup="true" CodeBehind="Query.aspx.cs" Inherits="ProjectComplaint.User.Query" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 align="center">My Query</h2>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="pname" HeaderText="Product Name" />
            <asp:BoundField DataField="query" HeaderText="Query" />
            <asp:BoundField DataField="Replay" HeaderText="Replay" />
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
    <h2 align="center">New Query</h2>
    <asp:Label ID="Label1" runat="server" Text="Product Name"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="pname" DataValueField="pId"></asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ComplaintConnectionString %>" SelectCommand="SELECT [pname], [pId] FROM [Product]"></asp:SqlDataSource>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click1" />
</asp:Content>
