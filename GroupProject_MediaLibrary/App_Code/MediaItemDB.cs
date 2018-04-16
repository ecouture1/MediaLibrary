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
		public string PublishDate { get; set; } // OLoughlin changed to string rather than Date type

		[DataObjectMethod(DataObjectMethodType.Select)]
		public static List<MediaItem> GetCatalogue()
		{
			List<MediaItem> mediaList = new List<MediaItem>();
			string sel = "SELECT BookID, ISBN10, title, copyright, description "
				+ "FROM fullCatalogue ORDER BY BookID";
			using (SqlConnection con = new SqlConnection(GetConnectionString()))
			{
				using (SqlCommand cmd = new SqlCommand(sel, con))
				{
					con.Open();
					SqlDataReader dr = cmd.ExecuteReader();
					MediaItem mediaItem;
					while (dr.Read())
					{
						mediaItem = new MediaItem();
						mediaItem.BookID = (int)dr["BookID"];
                        mediaItem.ISBN10 = dr["ISBN10"].ToString();
						mediaItem.Title = dr["title"].ToString();
						mediaItem.Copyright = dr["copyright"].ToString();
						mediaItem.Description = dr["description"].ToString();
						mediaList.Add(mediaItem);
					}
					dr.Close();
				}
			}
			return mediaList;
		}

		[DataObjectMethod(DataObjectMethodType.Update)]
		public static int UpdateMediaItem(MediaItem original_MediaItem, MediaItem mediaItem)
		{
			int updateCount = 0;
			string up = "UPDATE fullCatalogue "
				+ "SET Description = @Description "
				+ "WHERE BookID = @original_BookID "
				+ "AND Title = @original_Title ";
			using (SqlConnection con = new SqlConnection(GetConnectionString()))
			{
				using (SqlCommand cmd = new SqlCommand(up, con))
				{
					cmd.Parameters.AddWithValue("Description", mediaItem.Description);
					cmd.Parameters.AddWithValue("original_BookID",
						original_MediaItem.BookID);
					cmd.Parameters.AddWithValue("original_Title",
						original_MediaItem.Title);

					con.Open();
					updateCount = cmd.ExecuteNonQuery();
					con.Close();
				}
			}
			return updateCount;
		}

		[DataObjectMethod(DataObjectMethodType.Delete)]
		public static int DeleteCategory(MediaItem mediaItem)
		{
			int deleteCount = 0;
			string del = "DELETE FROM fullCatalogue "
				+ "WHERE BookID = @original_BookID "
				+ "AND Title = @original_Title ";
			using (SqlConnection con = new SqlConnection(GetConnectionString()))
			{
				using (SqlCommand cmd = new SqlCommand(del, con))
				{
					cmd.Parameters.AddWithValue("original_BookID",	mediaItem.BookID);
					cmd.Parameters.AddWithValue("original_Title",mediaItem.Title);
					con.Open();
					deleteCount = cmd.ExecuteNonQuery();
				}
			}
			return deleteCount;
		}


		[DataObjectMethod(DataObjectMethodType.Insert)]
		public static void InsertCategory(MediaItem mediaItem)
		{
			string ins = "INSERT INTO fullCatalogue "
				+ " (BookID,ISBN10, ISBN13, Title, Author, Publisher, Copyright, Length, Description) "
				+ " VALUES(@BookID,@ISBN10, @ISBN13, @Title, @Author, @Publisher, @Copyright, @Length, @Description)";
			using (SqlConnection con = new SqlConnection(GetConnectionString()))
			{
				using (SqlCommand cmd = new SqlCommand(ins, con))
				{
					cmd.Parameters.AddWithValue("BookID", mediaItem.BookID);
					cmd.Parameters.AddWithValue("ISBN10", mediaItem.ISBN10);
					cmd.Parameters.AddWithValue("ISBN13", mediaItem.ISBN13);
					cmd.Parameters.AddWithValue("Title", mediaItem.Title);
					cmd.Parameters.AddWithValue("Author", mediaItem.Author);
					cmd.Parameters.AddWithValue("Publisher", mediaItem.Publisher);
					cmd.Parameters.AddWithValue("Copyright", mediaItem.Copyright);
					cmd.Parameters.AddWithValue("Length", mediaItem.Length);
					cmd.Parameters.AddWithValue("Description", mediaItem.Description);

					con.Open();
					cmd.ExecuteNonQuery();
				}
			}
		}

		private static string GetConnectionString()
		{
			return ConfigurationManager.ConnectionStrings
				["LibraryCatalogueString"].ConnectionString;
		}

	}
}



//[DataObject(true)]




//	[DataObjectMethod(DataObjectMethodType.Insert)]
//	public static void InsertCategory(Category category)
//	{
//		string ins = "INSERT INTO Categories "
//			+ " (CategoryID, ShortName, LongName) "
//			+ " VALUES(@CategoryID, @ShortName, @LongName)";
//		using (SqlConnection con = new SqlConnection(GetConnectionString()))
//		{
//			using (SqlCommand cmd = new SqlCommand(ins, con))
//			{
//				cmd.Parameters.AddWithValue("CategoryID", category.CategoryID);
//				cmd.Parameters.AddWithValue("ShortName", category.ShortName);
//				cmd.Parameters.AddWithValue("LongName", category.LongName);
//				con.Open();
//				cmd.ExecuteNonQuery();
//			}
//		}
//	}



