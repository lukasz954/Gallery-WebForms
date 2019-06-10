using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gallery
{
    public partial class Animals : System.Web.UI.Page
    {
        private string customUrl = "~/Img/Animals/";
        private int imageIndexSpoliPosition = 3;
        private readonly static List<Gallery.Models.Gallery> GalleriesList = new List<Models.Gallery>()
        {
            new Models.Gallery(1,"Animal1","Opis Animal 1","2fgau1c20e61000.jpg",1),
            new Models.Gallery(2,"Animal2","Opis Animal 2","baby-animal-names.jpg",2),
            new Models.Gallery(3,"Animal3","Opis Animal 3","BlackPanther1910.jpg",3),
            new Models.Gallery(4,"Animal4","Opis Animal 4","category-thumbnail-mammals_0.jpg",4),
            new Models.Gallery(5,"Animal5","Opis Animal 5","elephanthero1.jpg",5),
            new Models.Gallery(6,"Animal6","Opis Animal 6","loggerhead-turtle.jpg",6),
            new Models.Gallery(7,"Animal7","Opis Animal 7","p04f5x5v.jpg",7),
            new Models.Gallery(8,"Animal8","Opis Animal 8","panama-animal-transport-plane.jpg",8),
            new Models.Gallery(9,"Animal9","Opis Animal 9","TBY5IslL.jpeg",9),
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