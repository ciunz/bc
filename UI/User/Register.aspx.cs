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
            UserBAL ub = new UserBAL();
            int id = Convert.ToInt32(ub.GetLastId()) + 1;
            string ids = id.ToString(); string zero = "";
            for (int i = 1; i < (10 - (ids.Trim().Length)); i++)
            { zero += "0"; }
            zero = zero + ids;
            MsUserBAL ubal = new MsUserBAL
           {
               idCustomer = zero,
               nama = Names.Text,
               username = usrnm.Text,
               email = mail.Text,
               telp = tel.Text,
               alamat = alamat.InnerText,
               kota = city.Text,
               provinsi = prov.Text,
               kodepos = kdpos.Text,
               img = usrnm.Text,
               lvl = 2,
               pwd = pwrd.Text
           };
            if (FileUploadControl.HasFile)
            {
                try
                {
                    string filename = FileUploadControl.FileName;
                    FileUploadControl.SaveAs(Server.MapPath("~/images/usrImg/") + Session["username"].ToString());
                    Response.Write("<script>alert('File uploaded!')</script>");
                    Image1.Visible = true;
                    Image1.ImageUrl = "usrImg/" + filename;
                }
                catch (Exception ex)
                {
                    string err = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                    Response.Write("<script>alert('" + err + "')</script>");
                }
            }
            else
            { ubal.img = "anon.jpg"; }

            
            if (ub.AddUser(ubal) && Page.IsValid && ub.getUserByUsername(ubal.username) == null) 
            {
                Response.Write("<script>alert('berhasil')</script>");
            }
            else
            {
                Response.Write("<script>alert('gagal')</script>");
            }
        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {

        }
    }
}