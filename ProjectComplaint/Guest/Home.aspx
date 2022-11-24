<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ProjectComplaint.Guest.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1 align="Center">Login</h1>
              <form >
                  <div class=" align-items-center">
              <div class="form-group ">
                <div class="col-sm-2">
                    <asp:TextBox ID="TextBox1" runat="server" class="form-control"  placeholder="Username"></asp:TextBox>
                </div>
              </div>
              <div class="form-group ">
                <div class="col-sm-2">
                  <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" class="form-control"  placeholder="Password"></asp:TextBox>
                </div>
              </div>
              <div class="form-group ">
                <div class="col-sm-10">
                    <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="Log In" OnClick="Button1_Click" />
                </div>
              </div>
                      </div>
            </form>
</asp:Content>
