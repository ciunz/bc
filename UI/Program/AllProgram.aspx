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
                <!-- start grids_of_3 -->
                <div runat="server" id="pro">
                    <%--<div class="grids_of_3">
			<div class="grid1_of_3">
				<a href="details.html">
					<img src="images/w_pic4.jpg" alt=""/>
					<h3>branded handbags</h3>
					<div class="price">
						<h4>$299<span>indulge</span></h4>
					</div>
					<span class="b_btm"></span>
				</a>
			</div>
			<div class="grid1_of_3">
				<a href="details.html">
					<img src="images/w_pic5.jpg" alt=""/>
					<h3>branded handbags</h3>
					<div class="price">
						<h4>$299<span>indulge</span></h4>
					</div>
					<span class="b_btm"></span>
				</a>
			</div>
			<div class="grid1_of_3">
				<a href="details.html">
					<img src="images/w_pic6.jpg" alt=""/>
					<h3>branded handbags</h3>
					<div class="price">
						<h4>$299<span>indulge</span></h4>
					</div>
					<span class="b_btm"></span>
				</a>
			</div>
			<div class="clear"></div>
		</div>	--%>
                    <!-- end grids_of_3 -->
                </div>
            </div>
        </div>
    </div>
</asp:Content>
