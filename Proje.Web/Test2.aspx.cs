using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Proje.Web
{
    public partial class Test2 : System.Web.UI.Page
    {
        static public List<Proje.Business.Category> categoriesList = new List<Business.Category>();
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] sayilar = new int[] { 1, 2, 4, 5, 7, 9 };
            //Query
            var sonuc = from sayi in sayilar where sayi>5 select sayi;
            foreach (var item in sonuc)
            {
               
                lst.Items.Add((item.ToString()));
               
            }

            //Method
            List<int> sonuc1 = sayilar.Where(p => p > 5).ToList();
            foreach (var item in sonuc1)
            {
                lst.Items.Add(item.ToString());
            }

            
            for (int i = 0; i < 3; i++)
            {
                Proje.Business.Category category = new Business.Category();
                
            }
             
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //SqlConnection baglan = new SqlConnection("Data Source=SEVVAL\MSSQLEXPRESS;Initial Catalog=Kitap;Integrated Security=True");
            string isim = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["baglanti"].ConnectionString;
            SqlConnection baglan = new SqlConnection(isim);
            //baglan.Open();

            /*string sorgu = "select * from category";
            SqlCommand com = new SqlCommand(sorgu, baglan);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                var id = dr.GetValue(1).ToString();
                var name = dr.GetValue(0);
            }

            baglan.Close();
            */

            string sorgu1 = "insert into category values ('Çocuk')";
            //string sorgu2 = "update users set username = 'severkilinc' where password=12345";
            //string sorgu3 = "delete from username where password = 852963";

            baglan.Open();
            SqlCommand com1 = new SqlCommand(sorgu1, baglan);
            var deger = com1.ExecuteNonQuery();
            //ADO.NET YAPISI
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Proje.Business.KitapCategory nesne = new Business.KitapCategory();
            var sonuc = nesne.Listele();
            GridView1.DataSource = sonuc;
            GridView1.DataBind();
        }
    }
}