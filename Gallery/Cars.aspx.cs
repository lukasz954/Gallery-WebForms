using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gallery
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string customUrl = "~/Img/";
        private int imageIndexSpoliPosition = 2;
        private readonly static List<Gallery.Models.Gallery> GalleriesList = new List<Models.Gallery>()
        {
            new Models.Gallery(1,"Auto1","Opis Auto 1","34289_75.jpg",1),
            new Models.Gallery(2,"Auto2","Opis Auto 2","Audi-R8-powłoka-ceramiczna-Ceramic-Pro-1024x683.jpg",2),
            new Models.Gallery(3,"Auto3","Opis Auto 3","auto-moto-spa-czyszczenie-samochodow-bydgoszcz.jpg",3),
            new Models.Gallery(4,"Auto4","Opis Auto 4","auto-spa-posejdon-slider-bg.png",4),
            new Models.Gallery(5,"Auto5","Opis Auto 5","auto3.png",5),
            new Models.Gallery(6,"Auto6","Opis Auto 6","images.jpg",6),
            new Models.Gallery(7,"Auto7","Opis Auto 7","lexus_lc500_1.1200.jpg",7),
            new Models.Gallery(8,"Auto8","Opis Auto 8","slide_1.jpg",8),
            new Models.Gallery(9,"Auto9","Opis Auto 9","z23867990Q,Warszawa-M20-GT.jpg",9),
        };
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Unnamed1_Click(object sender, ImageClickEventArgs e)
        {
            var img = GalleriesList[0];
            CarBigView.ImageUrl = customUrl +=img.Path;
            Label_Title.Text = img.Title;
            Label_Description.Text = img.Description;
        }

        protected void Unnamed2_Click(object sender, ImageClickEventArgs e)
        {
            var img = GalleriesList[1];
            CarBigView.ImageUrl = customUrl += img.Path;
            Label_Title.Text = img.Title;
            Label_Description.Text = img.Description;
        }

        protected void Unnamed3_Click(object sender, ImageClickEventArgs e)
        {
            var img = GalleriesList[2];
            CarBigView.ImageUrl = customUrl += img.Path;
            Label_Title.Text = img.Title;
            Label_Description.Text = img.Description;
        }

        protected void Unnamed4_Click(object sender, ImageClickEventArgs e)
        {
            var img = GalleriesList[3];
            CarBigView.ImageUrl = customUrl += img.Path;
            Label_Title.Text = img.Title;
            Label_Description.Text = img.Description;
        }

        protected void Unnamed5_Click(object sender, ImageClickEventArgs e)
        {
            var img = GalleriesList[4];
            CarBigView.ImageUrl = customUrl += img.Path;
            Label_Title.Text = img.Title;
            Label_Description.Text = img.Description;
        }

        protected void Unnamed6_Click(object sender, ImageClickEventArgs e)
        {
            var img = GalleriesList[5];
            CarBigView.ImageUrl = customUrl += img.Path;
            Label_Title.Text = img.Title;
            Label_Description.Text = img.Description;
        }

        protected void Unnamed7_Click(object sender, ImageClickEventArgs e)
        {
            var img = GalleriesList[6];
            CarBigView.ImageUrl = customUrl += img.Path;
            Label_Title.Text = img.Title;
            Label_Description.Text = img.Description;
        }

        protected void Unnamed8_Click(object sender, ImageClickEventArgs e)
        {
            var img = GalleriesList[7];
            CarBigView.ImageUrl = customUrl += img.Path;
            Label_Title.Text = img.Title;
            Label_Description.Text = img.Description;
        }

        protected void Unnamed9_Click(object sender, ImageClickEventArgs e)
        {
            var img = GalleriesList[8];
            CarBigView.ImageUrl = customUrl += img.Path;
            Label_Title.Text = img.Title;
            Label_Description.Text = img.Description;
        }

        protected void ImageButton_Left_Click(object sender, ImageClickEventArgs e)
        {
            var imgPath = CarBigView.ImageUrl;
            if (!string.IsNullOrEmpty(imgPath))
            {
                string imgName = imgPath.Split(new char[1] { '/' })[imageIndexSpoliPosition];
                var position = GalleriesList.FirstOrDefault(c => c.Path.Contains(imgName)).Position;
                --position;
                if (position > 0)
                    SetNewImage(position);
            }
        }

        protected void ImageButton_Right_Click(object sender, ImageClickEventArgs e)
        {
            var imgPath = CarBigView.ImageUrl;
            if (!string.IsNullOrEmpty(imgPath))
            {
                string imgName = imgPath.Split(new char[1] { '/' })[imageIndexSpoliPosition];
                var position = GalleriesList.FirstOrDefault(c => c.Path.Contains(imgName)).Position;
                ++position;
                if (position <= 9)
                    SetNewImage(position);
            }
        }
        private void SetNewImage(int position)
        {
            var img = GalleriesList.FirstOrDefault(c => c.Position == position);
            CarBigView.ImageUrl = customUrl += img.Path;
            Label_Title.Text = img.Title;
            Label_Description.Text = img.Description;
        }
    }
}