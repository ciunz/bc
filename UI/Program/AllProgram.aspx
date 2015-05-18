<%@ Page Title="" Language="C#" MasterPageFile="~/ProgramFiles.Master" AutoEventWireup="true"
    CodeBehind="AllProgram.aspx.cs" Inherits="UI.AllProgram" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .tech
        {
            display: inline-block;
            font-size: 1.1em;
            background: #3CC395;
            color: #ffffff;
            padding: 8px 20px;
            margin-left: 30px;
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
                <div id="tec" runat="server">
                </div>
                <h2 class="style top">
                    All Program</h2>
                <div runat="server" id="pro">
                </div>
            </div>
        </div>
        <div class="main_bg1">
            <div class="wrap">
                <div class="main3" runat="server" id="pagination">
                </div>
            </div>
        </div>
        <br />
        <div class="clear">
        </div>
    </div>
</asp:Content>
