using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Imaging;

namespace logginweb {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            string codess = "";
            codess=(string)Session["paracode"];
            System.Drawing.Image img;
            BarcodeLib.Barcode codigo = new BarcodeLib.Barcode();

            {
                codigo.IncludeLabel = false;
            };
            img = codigo.Encode(BarcodeLib.TYPE.CODE128, codess, Color.Blue, Color.White, 50, 15);

            Response.ContentType = "image/jpeg";
            img.Save(Response.OutputStream, ImageFormat.Jpeg);
            Response.End();


        }
    }
}