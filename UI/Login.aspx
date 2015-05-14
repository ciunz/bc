<%@ Page Title="" Language="C#" MasterPageFile="~/ProgramFiles.Master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="UI.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
.buttonLogin{
	margin-top:10px;
	font-family: 'Source Sans Pro', sans-serif;
	-webkit-appearance: none;
	cursor:pointer;
	color: #ffffff;
	background: #3CC395;
	border:none;
	outline:none;
	display: inline-block;
	text-transform: uppercase;
	padding: 12px 38px;
	font-size: 0.875em;
	-webkit-transition: all 0.3s ease-in-out;
	-moz-transition: all 0.3s ease-in-out;
	-o-transition: all 0.3s ease-in-out;
	transition: all 0.3s ease-in-out;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main_bg">
        <div class="wrap">
            <div class="main">
                <div class="contact">
                    <div class="contact-form">
                        <h2>
                            Login</h2>
                        <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="<h3>Wrong Username or Password</h3>"
                            Visible="False"></asp:Label>
                        <div>
                            <span>
                                <label>
                                    Name</label></span> <span>
                                        <input name="Username" type="text" class="textbox" runat="server" id="usr" /></span>
                        </div>
                        <div>
                            <span>
                                <label>
                                    Password</label></span> <span>
                                        <input name="Password" type="text" class="textbox" runat="server" id="pwds" /></span>
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
