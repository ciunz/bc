<%@ Page Title="" Language="C#" MasterPageFile="~/ProgramFiles.Master" AutoEventWireup="true" CodeBehind="CekOut.aspx.cs" Inherits="UI.CekOut" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



<div class="main_bg">
<div class="wrap">	
<div class="main">

<div runat="server" id="cekout">
</div>

    <asp:Button ID="Button1" runat="server" Text="Cek Out" CssClass="tombol" 
        onclick="Button1_Click" />
</div>
</div>
</div>
</asp:Content>
