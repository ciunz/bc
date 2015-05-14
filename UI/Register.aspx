﻿<%@ Page Title="" Language="C#" MasterPageFile="~/ProgramFiles.Master" AutoEventWireup="true"
    CodeBehind="Register.aspx.cs" Inherits="UI.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .imgUpload
        {
            max-width: 200px;
        }
        .pwds
        {
            font-family: 'Source Sans Pro' , sans-serif;
            background: #FFFFFF;
            border: 1px solid #E7E7E7;
            color: rgba(85, 81, 81, 0.84);
            padding: 8px;
            display: block;
            width: 96.3333%;
            outline: none;
            -webkit-appearance: none;
            text-transform: capitalize;
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
                            Sign Up</h2>
                        <div>
                            <asp:Image ID="Image1" runat="server" Visible="False" CssClass="imgUpload" /><br />
                            <asp:FileUpload ID="FileUploadControl" runat="server" />
                            <br />
                            <asp:Button runat="server" ID="UploadButton" Text="Upload" OnClick="UploadButton_Click" />
                            <br />
                            <br />
                            <asp:Label runat="server" ID="StatusLabel" Text="Upload status: " Visible="False" />
                            <br />
                            <br />
                        </div>
                        <div>
                            <span>
                                <label>
                                    Nama</label></span> <span>
                                        <asp:TextBox ID="Names" CssClass="textbox" runat="server"></asp:TextBox></span>
                        </div>
                        <div>
                            <span>
                                <label>
                                    User Name</label></span> <span>
                                        <asp:TextBox ID="usrnm" CssClass="textbox" runat="server"></asp:TextBox></span>
                        </div>
                        <div>
                            <span>
                                <label>
                                    Email</label></span> <span>
                                        <asp:TextBox ID="mail" CssClass="textbox" runat="server"></asp:TextBox></span>
                        </div>
                        <div>
                            <span>
                                <label>
                                    Telp</label></span> <span>
                                        <asp:TextBox ID="tel" CssClass="textbox" runat="server"></asp:TextBox></span>
                        </div>
                        <div>
                            <span>
                                <label>
                                    Alamat</label></span> <span>
                                        <textarea name="Address" runat="server" id="alamat"> </textarea></span>
                        </div>
                        <div>
                            <span>
                                <label>
                                    Kota</label></span> <span>
                                        <asp:TextBox ID="city" CssClass="textbox" runat="server"></asp:TextBox></span>
                        </div>
                        <div>
                            <span>
                                <label>
                                    Provinsi</label></span> <span>
                                        <asp:TextBox ID="prov" CssClass="textbox" runat="server"></asp:TextBox></span>
                        </div>
                        <div>
                            <span>
                                <label>
                                    Kode Pos</label></span> <span>
                                        <asp:TextBox ID="kdpos" CssClass="textbox" runat="server"></asp:TextBox></span>
                        </div>
                        <div>
                            <span>
                                <label>
                                    Password</label></span> <span>
                                        <asp:TextBox ID="pwrd" runat="server" CssClass="pwds" TextMode="Password"></asp:TextBox></span>
                        </div>
                        <div>
                            <span>
                                <label>
                                    Re-Enter Password</label></span> <span>
                                        <asp:TextBox ID="repwrd" CssClass="pwds" TextMode="Password" runat="server"></asp:TextBox></span>
                        </div>
                        <div>
                            <span>
                                <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" /></span>
                        </div>
                    </div>
                    <div class="clear">
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
