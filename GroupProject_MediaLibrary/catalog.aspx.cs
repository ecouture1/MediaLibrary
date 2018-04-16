using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;              // needed to add this to make sql Conneciton work 
using System.Data.SqlClient;   // needed to add to make sql Connection work 

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
			createListFromTable(0);

			if (!IsPostBack)
			{
				// ArrayList catalogList = createList(0);  //Jesse - manual load
				ArrayList catalogList = createListFromTable(0); // OLoughlin - dynamic load from table
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
		 /*
		private ArrayList createList(int pageNumber)
		{
			ArrayList catalogList = new ArrayList();

			for (int i = 0; i < 10; i++)
			{
				Book bookItem = new Book();
				bookItem.Title = "Title " + i;
				bookItem.PublishDate = new DateTime(1999 + i, 3, 19);  //
				bookItem.Description = "This is a description";
				bookItem.author = "Guy McGuyson";
				bookItem.publisher = "publishing inc.";
				bookItem.isbn = "1234567890";
				MediaItem catalogItem = bookItem;
				catalogList.Add(catalogItem);
			}
			return catalogList;
		}
		*/

		//Karen O'Loughlin 
		//method will retrieve data from the fullCatalogue
		// It reads row at a time using (IDataRecord) reader
		//Resource: https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/retrieving-data-using-a-datareader

		private ArrayList createListFromTable(int row)
		{
			ArrayList catalogList = new ArrayList();
			//Connection String can be copied from SQl Data Source, Every \ needs to change to a \\ and remove a " at the beginning and end of the copied string 
			SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\uchyt\\Documents\\GitHub\\MediaLibrary\\GroupProject_MediaLibrary\\App_Data\\LibraryCatalogue.mdf;Integrated Security=True");
			using (connection)
			{
				SqlCommand command = new SqlCommand("SELECT BookID, ISBN10,ISBN13,title,author,publisher,copyright,length FROM fullCatalogue;", connection);
				connection.Open();
				SqlDataReader reader = command.ExecuteReader();

				if (reader.HasRows)
				{
					while (reader.Read())
					{
						Book bookItem = createBook((IDataRecord)reader);  // sends single row as a IDDataRecord
						MediaItem catalogItem = bookItem;
						catalogList.Add(catalogItem);
					}
				}
				connection.Close();
				return catalogList;
			}
		}

		// OLoughlin
		//This method takes a row from the data base and parses the data to a Book 
		// The format of the dataTable must be know as it uses the index of each column data 
		// to fill individual items 
		private static Book createBook(IDataRecord record)
		{   //   Index   0     ,   1  ,   2  ,   3,   4,      5,       6,        7
			//  "SELECT BookID, ISBN10,ISBN13,title,author,publisher,copyright,length FROM fullCatalogue;"

			Book bookItem = new Book();
			bookItem.Title = record.GetString(3);
			bookItem.PublishDate = new DateTime(1999, 3, 19); // Jesse with Date Time, need to assign i if used
			//bookItem.PublishDate = record.GetString(6);
			bookItem.Description = record.GetValue(7).ToString(); // Currently this the 'length' of the book in the  fullCatalogue
			bookItem.author = record.GetString(4);
			bookItem.publisher = record.GetString(5);
			bookItem.isbn = record.GetString(1);

			return bookItem;
		}


		/* While a bit unweildly and ugly, this method works and thats what matters.  This method is 
         * used to populate the page based on an arrayList.  It tests to make sure that each index of the list
         * is not null and produces up to ten panels with all information included.
         * 
         */
		private void createPage(ArrayList catalogList)
		{
			if (catalogList[0] != null)
			{
				catalogitem1.Visible = true;
				MediaItem catalogItem = (MediaItem)catalogList[0];
				pictureSelector(CatalogImage1, catalogItem.MediaType);
				CatalogTitle1.Text = catalogItem.Title;
				CatalogInfo1.Text = catalogItem.getInfo();
				CatalogDescription1.Text = catalogItem.Description;
			}
			if (catalogList[1] != null)
			{
				catalogitem2.Visible = true;
				MediaItem catalogItem = (MediaItem)catalogList[1];
				pictureSelector(CatalogImage2, catalogItem.MediaType);
				CatalogTitle2.Text = catalogItem.Title;
				CatalogInfo2.Text = catalogItem.getInfo();
				CatalogDescription2.Text = catalogItem.Description;
			}
			if (catalogList[2] != null)
			{
				catalogitem3.Visible = true;
				MediaItem catalogItem = (MediaItem)catalogList[2];
				pictureSelector(CatalogImage3, catalogItem.MediaType);
				CatalogTitle3.Text = catalogItem.Title;
				CatalogInfo3.Text = catalogItem.getInfo();
				CatalogDescription3.Text = catalogItem.Description;
			}
			if (catalogList[3] != null)
			{
				catalogitem4.Visible = true;
				MediaItem catalogItem = (MediaItem)catalogList[3];
				pictureSelector(CatalogImage4, catalogItem.MediaType);
				CatalogTitle4.Text = catalogItem.Title;
				CatalogInfo4.Text = catalogItem.getInfo();
				CatalogDescription4.Text = catalogItem.Description;
			}
			if (catalogList[4] != null)
			{
				catalogitem5.Visible = true;
				MediaItem catalogItem = (MediaItem)catalogList[4];
				pictureSelector(CatalogImage5, catalogItem.MediaType);
				CatalogTitle5.Text = catalogItem.Title;
				CatalogInfo5.Text = catalogItem.getInfo();
				CatalogDescription5.Text = catalogItem.Description;
			}
			if (catalogList[5] != null)
			{
				catalogitem6.Visible = true;
				MediaItem catalogItem = (MediaItem)catalogList[5];
				pictureSelector(CatalogImage6, catalogItem.MediaType);
				CatalogTitle6.Text = catalogItem.Title;
				CatalogInfo6.Text = catalogItem.getInfo();
				CatalogDescription6.Text = catalogItem.Description;
			}
			if (catalogList[6] != null)
			{
				catalogitem7.Visible = true;
				MediaItem catalogItem = (MediaItem)catalogList[6];
				pictureSelector(CatalogImage7, catalogItem.MediaType);
				CatalogTitle7.Text = catalogItem.Title;
				CatalogInfo7.Text = catalogItem.getInfo();
				CatalogDescription7.Text = catalogItem.Description;
			}
			if (catalogList[7] != null)
			{
				catalogitem8.Visible = true;
				MediaItem catalogItem = (MediaItem)catalogList[7];
				pictureSelector(CatalogImage8, catalogItem.MediaType);
				CatalogTitle8.Text = catalogItem.Title;
				CatalogInfo8.Text = catalogItem.getInfo();
				CatalogDescription8.Text = catalogItem.Description;
			}
			if (catalogList[8] != null)
			{
				catalogitem9.Visible = true;
				MediaItem catalogItem = (MediaItem)catalogList[8];
				pictureSelector(CatalogImage9, catalogItem.MediaType);
				CatalogTitle9.Text = catalogItem.Title;
				CatalogInfo9.Text = catalogItem.getInfo();
				CatalogDescription9.Text = catalogItem.Description;
			}
			if (catalogList[9] != null)
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


/* OLoughlin Personal Notes 
// Original Test Code in form load to test connections
//SqlCommand cmd = new SqlCommand("Select * FROM fullcatalogue WHERE BookID = 1", connection);
//connection.Open();
//HasRows(connection);
//CatalogTitle1.Text = HasRows(connection); // cmd.ExecuteScalar().ToString();
//connection.Close();
//catalogitem1.Visible = true;

// When creating a connection String 
// need to change every \ to \\, take out " at beginning at end to convert 
// connection string to proper parameter 


//Used for testing Original read from table. See MSDN docs for example 
private static String ReadSingleRow(IDataRecord record)
{
	String rowData = (String.Format("{0}, {1}, {2}", record[0], record[1], record[2]));
	return rowData + "test";
	//Console.WriteLine(String.Format("{0}, {1}", record[0], record[1]));
}

*/