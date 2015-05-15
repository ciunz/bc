<%@ Page Title="" Language="C#" MasterPageFile="~/ProgramFiles.Master" AutoEventWireup="true" CodeBehind="ChgPwd.aspx.cs" Inherits="UI.ChgPwd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <div class="main_bg">
        <div class="wrap">
            <div class="main">
                <div class="contact">
                    <div class="contact-form">
                        <h2>
                            Change Password</h2>
                        <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="<h3>Password Not Match!!</h3>"
                            Visible="False"></asp:Label><br />
                            <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="<h3>Wrong Password!</h3>"
                            Visible="False"></asp:Label>
                        <div>
                            <span>
                                <label>
                                    New Password</label></span> <span>
                                        <input name="Username" type="text" class="textbox" runat="server" id="newP" /></span>
                        </div>
                        <div>
                            <span>
                                <label>
                                    Re-Confirm Password</label></span> <span>
                                        <input name="Password" type="text" class="textbox" runat="server" id="reP" /></span>
                        </div>
                        <div>
                            <span>
                                <label>
                                    Old Password</label></span> <span>
                                        <input name="Password" type="text" class="textbox" runat="server" id="oldP" /></span>
                        </div>
                        <div>
                            <span>
                                <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="buttonLogin" 
                                onclick="Button1_Click" />
                            </span>
                        </div>
                    </div>
                    <div class="clear">
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
