<%@ Page Title="" Language="C#" MasterPageFile="~/ProgramFiles.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="UI.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<style type="text/css">
.imgUpload
{
    max-width : 200px;
}
</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



<div class="main_bg">
<div class="wrap">	
<div class="main">
	 	 <div class="contact">				
				  <div class="contact-form">
			 	  	 	<h2>Sign Up</h2>
			 	 	    
                             <div>
                                <asp:Image ID="Image1" runat="server" Visible="False" CssClass="imgUpload" /><br />
                                <asp:FileUpload id="FileUploadControl" runat="server" />
                                <br />
                                <asp:Button runat="server" id="UploadButton" text="Upload" onclick="UploadButton_Click" />
                                <br /><br />
                                <asp:Label runat="server" id="StatusLabel" text="Upload status: " 
                                    Visible="False" />
                                 <br />
                                 <br />
                            </div>
					    	<div>
						    	<span><label>Nama</label></span>
						    	<span><asp:TextBox ID="TextBox1" CssClass="textbox" runat="server"></asp:TextBox></span>
						    </div>
						    <div>
						    	<span><label>User Name</label></span>
						    	<span><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></span>
						    </div>
                            <div>
						    	<span><label>Email</label></span>
						    	<span><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></span>
						    </div>
                            <div>
						    	<span><label>Telp</label></span>
						    	<span><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></span>
						    </div>
                            <div>
						    	<span><label>Alamat</label></span>
						    	<span><textarea name="Address" runat="server" id="alamat"> </textarea></span>
						    </div>
                            <div>
						    	<span><label>Kota</label></span>
						    	<span><input name="userEmail" type="text" class="textbox" runat="server" id="kota" /></span>
						    </div>
                            <div>
						    	<span><label>Provinsi</label></span>
						    	<span><input name="userEmail" type="text" class="textbox" runat="server"  id="prov" /></span>
						    </div>
                            <div>
						    	<span><label>Kode Pos</label></span>
						    	<span><input name="userEmail" type="text" class="textbox" runat="server"  id="postal" /></span>
						    </div>                          
						   <div>
						   		<span><asp:Button ID="Button1" runat="server" Text="Button" /></span>
						  </div>					    
				    </div>
  				<div class="clear"></div>		
			  </div>
		</div>
</div>
</div>


</asp:Content>
