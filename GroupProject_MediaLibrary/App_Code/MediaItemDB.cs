using System;
using System.Collections;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;


namespace GroupProject_MediaLibrary.App_Code
{
	[DataObject(true)]
	public class MediaItemDB
	{
		public string Title { get; set; }
		public string Description { get; set; }
		// public DateTime PublishDate { get; set; } // Jesse
		public string PublishDate { get; set; } // OLoughlin


		[DataObjectMethod(DataObjectMethodType.Select)]
		public static List<Book> GetCatalogue()
		{
			System.Text.StringBuilder errorMessages = new System.Text.StringBuilder();

			List<Book> mediaList = new List<Book>();
			string sel = "SELECT BookID, title, copyright, length "
				+ "FROM fullCatalogue ORDER BY BookID";
			using (SqlConnection con = new SqlConnection(GetConnectionString()))
			{
				using (SqlCommand cmd = new SqlCommand(sel, con))
				{
					con.Open();
					SqlDataReader dr = cmd.ExecuteReader(); // exception not handled
					Book mediaItem;
					while (dr.Read())
					{
						mediaItem = new Book();
						mediaItem.BookID = (int)dr["BookID"];
						mediaItem.Title = dr["title"].ToString();
						mediaItem.PublishDate = dr["copyright"].ToString();
						mediaItem.Description = dr["length"].ToString();
						mediaList.Add(mediaItem);
					}
					dr.Close();
				}
			}
			return mediaList;
		}


		//// 'UpdateBook' that has parameters: original_Book, Book
		//[DataObjectMethod(DataObjectMethodType.Update)]
		//public static int UpdateBook(Book original_Book, Book Book)
		//{
		//	int updateCount = 0;
		//	string up = "UPDATE fullCatalogue "
		//		+ "SET title = @title, "
		//		+ "length = @length "
		//		+ "copyright =@copyright"
		//		+ "WHERE BookID = @original_BookID "
		//		+ "AND title = @original_title";
		//	using (SqlConnection con = new SqlConnection(GetConnectionString()))
		//	{
		//		using (SqlCommand cmd = new SqlCommand(up, con))
		//		{
		//			cmd.Parameters.AddWithValue("Name", Book.Title);
		//			cmd.Parameters.AddWithValue("length", Book.Description);
		//			cmd.Parameters.AddWithValue("copyright", Book.PublishDate);
		//			cmd.Parameters.AddWithValue("original_BookID", original_Book.BookID);
		//			cmd.Parameters.AddWithValue("original_Name", original_Book.Title);
		//			cmd.Parameters.AddWithValue("original_length", original_Book.Description);
		//			con.Open();
		//			updateCount = cmd.ExecuteNonQuery();
		//			con.Close();
		//			//return cmd.ExecuteNonQuery();
		//		}
		//		return updateCount;
		//	}
		//}

		//Sets up connection string to LibraryCatalogue
		private static string GetConnectionString()
		{
			return ConfigurationManager.ConnectionStrings["LibraryCatalogueString"].ConnectionString;
		}
	}
}
/* 


// Did try the IEnumerable - I am not sure when I should try IEnumerable vs returning a list of Books 
//public static IEnumerable GetAllBooks()
//{
//	SqlConnection con = new SqlConnection(GetConnectionString());
//	string sql = "SELECT BookID, Name, OnHand "
//		+ "FROM Books ORDER BY Name";
//	SqlCommand cmd = new SqlCommand(sql, con);
//	con.Open();
//	SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
//	return dr;
//}


private static string GetConnectionString()
{
	return ConfigurationManager.ConnectionStrings
		["HalloweenConnectionString"].ConnectionString;
}

//d 'UpdateBook' that has parameters: original_Book, Book, BookID, Name, OnHand, original_BookID.
[DataObjectMethod(DataObjectMethodType.Update)]
public static int UpdateBook(Book original_Book, Book Book)
{
	int updateCount = 0; // from Category Maintenance
	string up = "UPDATE Books "
		+ "SET Name = @Name, "
		+ "OnHand = @OnHand "
		+ "WHERE BookID = @original_BookID "
		+ "AND Name = @original_Name "
		+ "And OnHand = @original_OnHand ";
	using (SqlConnection con = new SqlConnection(GetConnectionString()))
	{
		using (SqlCommand cmd = new SqlCommand(up, con))
		{
			cmd.Parameters.AddWithValue("Name", Book.Name);
			cmd.Parameters.AddWithValue("OnHand", Book.OnHand);
			cmd.Parameters.AddWithValue("original_BookID",original_Book.BookID);
			cmd.Parameters.AddWithValue("original_Name",original_Book.Name);
			cmd.Parameters.AddWithValue("original_OnHand",	original_Book.OnHand);
			con.Open();
			updateCount = cmd.ExecuteNonQuery();
			con.Close();
			//return cmd.ExecuteNonQuery();
		}
		return updateCount;
	}
}
}
}
*/
