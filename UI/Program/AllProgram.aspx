<%@ Page Title="" Language="C#" MasterPageFile="~/ProgramFiles.Master" AutoEventWireup="true"
    CodeBehind="AllProgram.aspx.cs" Inherits="UI.AllProgram" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main_bg">
        <div class="wrap">
            <div class="main">
                <ul id="filters" class="clearfix">
                    <li><span class="filter active" data-filter="app card icon logo web">All</span></li>
                    <li><span class="filter" data-filter="app card web">men</span></li>
                    <li><span class="filter" data-filter="icon web card">women</span></li>
                    <li><span class="filter" data-filter="web app icon card">Watches</span></li>
                    <li><span class="filter" data-filter="icon app web logo">Accessories</span></li>
                </ul>
                <h2 class="style top">
                    All Program</h2>
                <div runat="server" id="pro">
                </div>
            </div>
        </div>
    </div>
</asp:Content>
