﻿<%@ Page Title="" Language="C#" MasterPageFile="~/ProgramFiles.Master" AutoEventWireup="true"
    CodeBehind="details.aspx.cs" Inherits="UI.details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main_bg">
        <div class="wrap">
            <div class="main">
                <!-- start content -->
                <div class="single">
                    <!-- start span1_of_1 -->
                    <div class="left_content">
                        <div class="span1_of_1">
                            <!-- start product_slider -->
                            <div class="product-view">
                                <div class="product-essential">
                                    <div class="product-img-box">
                                        <div class="product-image">
                                            <img runat="server" id="gambar" src="" alt="" title="" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- end product_slider -->
                        </div>
                        <!-- start span1_of_1 -->
                        <div class="span1_of_1_des">
                            <div class="desc1">
                                <asp:Label ID="Label1" runat="server" Text="Empty"></asp:Label>
                                <p id="keterangan" runat="server">
                                    Empty</p>
                                <h5 runat="server" id="ukuran">
                                    Empty <a href="#">Add to Cart</a></h5>
                                <div class="available">
                                    <form action="/home.aspx" method="post">
                                    <h4>
                                        Available Options :</h4>
                                    <ul>
                                        <li>Rating:
                                            <select>
                                                <option value="1">1</option>
                                                <option value="2">2</option>
                                                <option value="3">3</option>
                                                <option value="4">4</option>
                                                <option value="5">5</option>
                                            </select>
                                        </li>
                                    </ul>
                                    <div class="btn_form">
                                        <asp:Button ID="Button1" runat="server" Text="add to cart" CssClass="tombol" OnClick="Button1_Click" />
                                    </div>
                                    </form>
                                </div><div class="clear"></div>
                                <div class="share-desc">
                                <div class="share">
                                    <h4>
                                        Share Product :</h4>
                                    <ul class="share_nav">
                                        <li><a href="#">
                                            <img src="/images/facebook.png" title="facebook" alt="" /></a></li>
                                        <li><a href="#">
                                            <img src="/images/twitter.png" title="Twiiter" alt="" /></a></li>
                                        <li><a href="#">
                                            <img src="/images/rss.png" title="Rss" alt="" /></a></li>
                                        <li><a href="#">
                                            <img src="/images/gpluse.png" title="Google+" alt="" /></a></li>
                                    </ul>
                                </div>
                                <div class="clear">
                                </div>
                            </div>
                            </div>
                            
                            
                        </div>
                        <div class="clear">
                        </div>
                        <!-- start tabs -->
                        <section class="tabs">
		            <input id="tab-1" type="radio" name="radio-set" class="tab-selector-1" checked="checked">
			        <label for="tab-1" class="tab-label-1">Comments</label>
			
		            <input id="tab-2" type="radio" name="radio-set" class="tab-selector-2">
			        <label for="tab-2" class="tab-label-2">Rating</label>

                    <input id="tab-3" type="radio" name="radio-set" class="tab-selector-3">
			        <label for="tab-2" class="tab-label-2">Description</label>
			
				    <div class="clear-shadow"></div>
					
			        <div class="content">
				        <div class="content-1">
				        	<p class="para top" runat="server" id="descr"><span>LOREM IPSUM</span> </p>
                            
                            <ul>
								<li>Research</li>
								<li>Design and Development</li>
								<li>Porting and Optimization</li>
								<li>System integration</li>
								<li>Verification, Validation and Testing</li>
								<li>Maintenance and Support</li>
							</ul>
							<div class="clear"></div>
						</div>
				        <div class="content-2">
							<p class="para" runat="server" id="rating"><span>WELCOME </span></p>
                            <ul class="qua_nav">
								<li>Multimedia Systems</li>
								<li>Digital media adapters</li>
								<li>Set top boxes for HDTV and IPTV Player applications on various Operating Systems and Hardware Platforms</li>
							</ul>
                            <div class="clear"></div>
                      </div>
                      <div class="content-3">
							<p class="para" runat="server" id="P1"><span>WELCOME </span></p>
                            <ul class="qua_nav">
								<li>Multimedia Systems</li>
								<li>Digital media adapters</li>
								<li>Set top boxes for HDTV and IPTV Player applications on various Operating Systems and Hardware Platforms</li>
							</ul>
                            <div class="clear"></div>
                      </div>			       
			        </div>
			        </section>
                        <!-- end tabs -->
                    </div>
                    <!-- start sidebar -->
                    <div class="left_sidebar">
                        <div class="sellers">
                            <h4>
                                Comments</h4>
                            <div class="single-nav">
                                <ul runat="server" id="komentar">
                                    <li><a href="#">Always free from repetition</a></li>
                                    <li><a href="#">Always free from repetition</a></li>
                                    <li><a href="#">The standard chunk of Lorem Ipsum</a></li>
                                    <li class="comm"><a href="#">Write a Comment</a>
                                        <textarea class="ta"> </textarea>
                                    </li>
                                    <li class="comm2">
                                        <input type="submit"/>
                                    </li>
                                </ul>
                            </div>
                            <div class="banner-wrap bottom_banner color_link">
                                <a href="#" class="main_link">
                                    <figure><img src="/images/delivery.png" alt=""/></figure>
                                    <h5>
                                        <span>Free Shipping</span><br>
                                        on orders over $99.</h5>
                                    <p>
                                        This offer is valid on all our store items.</p>
                                </a>
                            </div>
                            <div class="brands">
                                <h1>
                                    Brands</h1>
                                <div class="field">
                                    <select class="select1">
                                        <option>Please Select</option>
                                        <option>Lorem ipsum dolor sit amet</option>
                                        <option>Lorem ipsum dolor sit amet</option>
                                        <option>Lorem ipsum dolor sit amet</option>
                                    </select>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- end sidebar -->
                    <div class="clear">
                    </div>
                </div>
            </div>
            <!-- end content -->
        </div>
    </div>
</asp:Content>
