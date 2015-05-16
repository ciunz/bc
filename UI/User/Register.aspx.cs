using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL;

namespace UI
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                Response.Redirect("/home.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MsUserBAL ubal = new MsUserBAL
           {
               nama = Names.Text,
               username = usrnm.Text,
               email = mail.Text,
               telp = tel.Text,
               alamat = alamat.InnerText,
               kota = city.Text,
               provinsi = prov.Text,
               kodepos = kdpos.Text,
               img = FileUploadControl.FileName,
               lvl = 0,
               pwd = pwrd.Text
           };

            UserBAL ub = new UserBAL();
            if (ub.AddUser(ubal))
            {
                Response.Write("<script>alert('berhasil')</script>");
            }
            else
            {
                Response.Write("<script>alert('gagal')</script>");
            }

            if (FileUploadControl.HasFile)
            {
                try
                {
                    string filename = FileUploadControl.FileName;
                    FileUploadControl.SaveAs(Server.MapPath("~/usrImg/") + filename);
                    Response.Write("<script>alert('File uploaded!')</script>");
                    Image1.Visible = true;
                    Image1.ImageUrl = "usrImg/" +filename;
                }
                catch (Exception ex)
                {
                    string err = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                    Response.Write("<script>alert('" + err + "')</script>");                 
                }
            }
        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {

        }
    }
}