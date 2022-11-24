<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Site1.Master" AutoEventWireup="true" CodeBehind="UserReg.aspx.cs" Inherits="ProjectComplaint.Guest.UserReg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3 align="center">User Registartion</h3>
            <form >
                  <div class=" align-items-center">
              <div class="form-group ">
                <div class="col-sm-2">
                    <asp:TextBox ID="TextBox1" runat="server" class="form-control"  placeholder="Name"></asp:TextBox>
                </div>
              </div>
              <div class="form-group ">
                <div class="col-sm-2">
                  <asp:TextBox ID="TextBox2" runat="server"  class="form-control"  placeholder="E-Mail"></asp:TextBox>
                </div>
              </div>
                      <div class="form-group ">
                <div class="col-sm-2">
                  <asp:TextBox ID="TextBox3" runat="server" TextMode="Number" class="form-control"  placeholder="Phone"></asp:TextBox>
                </div>
              </div>
                      <div class="form-group ">
                <div class="col-sm-2">
                  <asp:TextBox ID="TextBox4" runat="server"  class="form-control"  placeholder="Username"></asp:TextBox>
                </div>
              </div>
                      <div class="form-group ">
                <div class="col-sm-2">
                  <asp:TextBox ID="TextBox5" runat="server" class="form-control"  placeholder="Password"></asp:TextBox>
                </div>
              </div>
              <div class="form-group ">
                <div class="col-sm-10">
                    <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Register" OnClick="Button1_Click" />
                </div>
              </div>
                      </div>
            </form>
</asp:Content>
