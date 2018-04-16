using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProject_MediaLibrary.App_Code
{

    /**
     * Authors:            Jesse Uchytil
     * Date of creation:   3/8/18
     * Last Edit:          3/9/18
     * Title:              MediaItem.cs and Child classes
     * 
     * Description: This class is for the storage, tranfer, and retrieval of media items in the catalog.
     * Each class inside this file is a child that inherits from the generic MediaItem class.  The MediaItem
     * class contains information common to every item such as title, description, and publishdate.  Along with this,
     * the MediaItem class also defines a getInfo() method whose purpose is to return the relevant information in a
     * format that will work within the Labels on the page (specifically the catalogeInfoX label).  Finally, there is a
     * single global variable called MediaType whose use is solely to help identify what type of media the object
     * is.  This is useful for discerning what is what during coding.
     * 
     * The current list of MediaTypes is:
     * 
     * 0 = generic MediaType
     * 1 = Book
     * 
     */

    public class MediaItem
    {
        public int MediaType { get; set; }

        public MediaItem()
        {
            MediaType = 0;
        }
		public int BookID { get; set; }
		public string ISBN10 { get; set; }
		public string ISBN13 { get; set; }
	    public string Title { get; set; }
		public string Author { get; set; }
		public string Publisher { get; set; }
		public string Copyright { get; set; }
		public int Length { get; set; }
		public string Description { get; set; } 
		
        public virtual string getInfo()
        {
           // return ("Publish Date: " + PublishDate.Year); // Jesse
			return ("Copyright " + Copyright);  // OLoughlin
        }
    }

    public class Book : MediaItem
    {
        public Book()
        {
            MediaType = 1;
        }
        public string author { get; set; }
        public string publisher { get; set; }
        public string isbn { get; set; }
        public override string getInfo()
        {
            return ("Author: " + author + "<br />" + base.getInfo() + "<br />Publisher: " + publisher + "<br />ISBN: " + isbn);
        }
    }
}

