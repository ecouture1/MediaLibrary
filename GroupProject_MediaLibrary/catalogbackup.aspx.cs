using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroupProject_MediaLibrary
{
    /**
     * Authors:            Jesse Uchytil
     * Date of creation:   3/9/18
     * Last Edit:          3/9/18
     * Title:              catalog.aspx CodeBehind file
     * 
     * List of things that need done:
     * 
     * Make more classes for items in the catalog (dvds, audio books, etc.)
     * Make it so that images on page don't streach aspect ratios.
     * Create buttons on page and codebehind for moving between pages.
     * Add functionality to connect to database and pull from it.
     * Add functionality to detect whether user is logged in, and if so...
     * Add functionality to add items to user's personal catalog.  
     * Add header and footer (best to create a master page for that).
     */
    public partial class catalogue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ArrayList catalogList = createList(0);
                createPage(catalogList);

            }
        }
        

        /* This method is for retrieving information from the database and processing it into an arraylist
         * so that it may be passed back to the calling method.  
         * 
         * Currently, it is just a dummy method that produces an arraylist for testing purposes.  Eventually,
         * it will take the pagenumber given and use that to look up the right info in the database.
         * 
         */
        private ArrayList createList(int pageNumber)
        {
            ArrayList catalogList = new ArrayList();
            for(int i = 0; i<5; i++)
            {
                Book bookItem = new Book();
                bookItem.Title = "Title " + i;
                bookItem.PublishDate = new DateTime(1999+i, 3, 19);
                bookItem.Description = "This is a description";
                bookItem.author = "Guy McGuyson";
                bookItem.publisher = "publishing inc.";
                bookItem.isbn = "1234567890";
                MediaItem catalogItem = bookItem;
                catalogList.Add(catalogItem);
            }
            return catalogList;
        }


        /* While a bit unweildly and ugly, this method works and thats what matters.  This method is 
         * used to populate the page based on an arrayList.  It tests to make sure that each index of the list
         * is not null and produces up to ten panels with all information included.
         * 
         */
        private void createPage(ArrayList catalogList)
        {
            if(catalogList.Count >= 1)
            {
                catalogitem1.Visible = true;
                MediaItem catalogItem = (MediaItem)catalogList[0];
                pictureSelector(CatalogImage1, catalogItem.MediaType);
                CatalogTitle1.Text = catalogItem.Title;
                CatalogInfo1.Text = catalogItem.getInfo();
                CatalogDescription1.Text = catalogItem.Description;
            }
            if (catalogList.Count >= 2)
            {
                catalogitem2.Visible = true;
                MediaItem catalogItem = (MediaItem)catalogList[1];
                pictureSelector(CatalogImage2, catalogItem.MediaType);
                CatalogTitle2.Text = catalogItem.Title;
                CatalogInfo2.Text = catalogItem.getInfo();
                CatalogDescription2.Text = catalogItem.Description;
            }
            if (catalogList.Count >= 3)
            {
                catalogitem3.Visible = true;
                MediaItem catalogItem = (MediaItem)catalogList[2];
                pictureSelector(CatalogImage3, catalogItem.MediaType);
                CatalogTitle3.Text = catalogItem.Title;
                CatalogInfo3.Text = catalogItem.getInfo();
                CatalogDescription3.Text = catalogItem.Description;
            }
            if (catalogList.Count >= 4)
            {
                catalogitem4.Visible = true;
                MediaItem catalogItem = (MediaItem)catalogList[3];
                pictureSelector(CatalogImage4, catalogItem.MediaType);
                CatalogTitle4.Text = catalogItem.Title;
                CatalogInfo4.Text = catalogItem.getInfo();
                CatalogDescription4.Text = catalogItem.Description;
            }
            if (catalogList.Count >= 5)
            {
                catalogitem5.Visible = true;
                MediaItem catalogItem = (MediaItem)catalogList[4];
                pictureSelector(CatalogImage5, catalogItem.MediaType);
                CatalogTitle5.Text = catalogItem.Title;
                CatalogInfo5.Text = catalogItem.getInfo();
                CatalogDescription5.Text = catalogItem.Description;
            }
            if (catalogList.Count >= 6)
            {
                catalogitem6.Visible = true;
                MediaItem catalogItem = (MediaItem)catalogList[5];
                pictureSelector(CatalogImage6, catalogItem.MediaType);
                CatalogTitle6.Text = catalogItem.Title;
                CatalogInfo6.Text = catalogItem.getInfo();
                CatalogDescription6.Text = catalogItem.Description;
            }
            if (catalogList.Count >= 7)
            {
                catalogitem7.Visible = true;
                MediaItem catalogItem = (MediaItem)catalogList[6];
                pictureSelector(CatalogImage7, catalogItem.MediaType);
                CatalogTitle7.Text = catalogItem.Title;
                CatalogInfo7.Text = catalogItem.getInfo();
                CatalogDescription7.Text = catalogItem.Description;
            }
            if (catalogList.Count >= 8)
            {
                catalogitem8.Visible = true;
                MediaItem catalogItem = (MediaItem)catalogList[7];
                pictureSelector(CatalogImage8, catalogItem.MediaType);
                CatalogTitle8.Text = catalogItem.Title;
                CatalogInfo8.Text = catalogItem.getInfo();
                CatalogDescription8.Text = catalogItem.Description;
            }
            if (catalogList.Count >= 9)
            {
                catalogitem9.Visible = true;
                MediaItem catalogItem = (MediaItem)catalogList[8];
                pictureSelector(CatalogImage9, catalogItem.MediaType);
                CatalogTitle9.Text = catalogItem.Title;
                CatalogInfo9.Text = catalogItem.getInfo();
                CatalogDescription9.Text = catalogItem.Description;
            }
            if (catalogList.Count >= 10)
            {
                catalogitem10.Visible = true;
                MediaItem catalogItem = (MediaItem)catalogList[9];
                pictureSelector(CatalogImage10, catalogItem.MediaType);
                CatalogTitle10.Text = catalogItem.Title;
                CatalogInfo10.Text = catalogItem.getInfo();
                CatalogDescription10.Text = catalogItem.Description;
            }
        }

        private void pictureSelector(Image catalogImage, int mediaType)
        {
            switch (mediaType)
            {
                case 0:
                    catalogImage.ImageUrl = "images/library.png";
                    break;

                case 1:
                    catalogImage.ImageUrl = "images/book.png";
                    break;

                default:
                    catalogImage.ImageUrl = "images/library.png";
                    break;
            }
        }
    }
}