using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gallery
{
    public partial class Motorcycles : System.Web.UI.Page
    {
        private string customUrl = "~/Img/Motorcycles/";
        private int imageIndexSpoliPosition = 3;
        private readonly static List<Gallery.Models.Gallery> GalleriesList = new List<Models.Gallery>()
        {
            new Models.Gallery(1,"Motocykl1","Opis Motocykl 1","19-softail-breakout-hero.jpg",1),
            new Models.Gallery(2,"Motocykl2","Opis Motocykl 2","3618.jpg",2),
            new Models.Gallery(3,"Motocykl3","Opis Motocykl 3","https___specials-images.forbesimg.com_imageserve_5c0aa5554bbe6f0f2aa19644_960x0.jpg",3),
            new Models.Gallery(4,"Motocykl4","Opis Motocykl 4","images.jpg",4),
            new Models.Gallery(5,"Motocykl5","Opis Motocykl 5","IMG_8125.jpg",5),
            new Models.Gallery(6,"Motocykl6","Opis Motocykl 6","indiant-ftr-1200-1540482461.jpg",6),
            new Models.Gallery(7,"Motocykl7","Opis Motocykl 7","protongts.jpg",7),
            new Models.Gallery(8,"Motocykl8","Opis Motocykl 8","SY125-10.png",8),
            new Models.Gallery(9,"Motocykl9","Opis Motocykl 9","thearsenale-nash-motorcycle-ko-chopper-nash-motorcycles_1024x1024.jpg",9),
        };
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, ImageClickEventArgs e)
        {
            var img = GalleriesList[0];
            CarBigView.ImageUrl = customUrl += img.Path;
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