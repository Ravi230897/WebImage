using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebImage
{
    public partial class WebForm25 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fileName = FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Data/" +  fileName));
            }

            foreach (string strFileName in Directory.GetFiles(Server.MapPath("~/Data/")))
            {
                ImageButton imageButton = new ImageButton();

                FileInfo fileInfo = new FileInfo(strFileName);
                imageButton.ImageUrl = "~/Data/" + fileInfo.Name;
                imageButton.Width = Unit.Pixel(100);
                imageButton.Height = Unit.Pixel(100);
                imageButton.Style.Add("padding", "5px");
                imageButton.Click += new ImageClickEventHandler(imageButton_Click);
                Panel1.Controls.Add(imageButton);

            }
        }
        void imageButton_Click(object sender, EventArgs e)
        {
            Response.Write("Button Clicked");
        }
       
    }
}