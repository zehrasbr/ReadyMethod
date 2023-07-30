using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HazirMetot1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] yazilar = { "Pazartesi", "Salı", "Çarşamba" };
            Label1.Text += String.Concat(yazilar);
            //string yazi1, yazi2;
            //yazi1 = "Merhaba";
            //yazi2 = " Dünya";
            //Label1.Text += String.Concat(yazi1, yazi2);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sifre1, sifre2;
            int sonuc;

            sifre1 = TextBox1.Text;
            sifre2 = TextBox2.Text;
            sonuc = String.Compare(sifre1, sifre2);
            if (sonuc == 0)
                Label1.Text = "İki şifre aynı";
            else if (sonuc < 0)
                Label1.Text = "sonuc 0'dan küçük";
            else if (sonuc > 0)
                Label1.Text = "sonuc 0'dan büyük";
            
        }
    }
}