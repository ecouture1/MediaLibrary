using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GroupProject_MediaLibrary
{
	public partial class catalog2 : System.Web.UI.Page
	{

		//Page Load sets UnobtrusiveValidationMode for validation events
		protected void Page_Load(object sender, EventArgs e)
		{
			UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
		}

		protected void ObjectDataSource1_GetAffectedRows(object sender, ObjectDataSourceStatusEventArgs e)
		{ e.AffectedRows = Convert.ToInt32(e.ReturnValue); }

		protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
		{
			if (e.Exception != null)
			{
				lblError.Text = DatabaseErrorMessage(e.Exception);
				e.ExceptionHandled = true;
				e.KeepInEditMode = true;
			}
			else
			{
				lblError.Text = ConcurrencyErrorMessage();
			}
		}

		private string ConcurrencyErrorMessage()
		{
			return "Another user may have updated that category. Try again.";
		}

		private string DatabaseErrorMessage(Exception ex)
		{
			string msg = $"<b>A database error has occurred: </b> {ex.Message}";
			if (ex.InnerException != null)
			{ msg += $"<br />Message: {ex.InnerException.Message}"; }
			return msg;
		}
	}
}


/* Tim Comments 
 * 
 *  If a class is located in your project in the "App_Code" folder then that should 
 *  be part of the namespace and all the classes within that folder 
 *  should have the same namespace.  Something like:

namespace GroupProject_MediaLibrary.App_Code

Then use an "using" statement in the code behind files where you use it, like:
using GroupProject_MediaLibrary.App_Code;

Next is that the UpdateBook method you had was expecting "Book", 
but you are setting "MediaItem" as the type in the DataObjectTypeName 
and so the update code is looking for that specific method signature, 
that is partly why it is complaining about not finding the correct method.

Couple of more things, I noticed is that the parameter in the "up" 
sql string is named @title but the Parameters.AddWIthValue is using "Name" 
so that will have an issue.  Same thing is there for original_title and orginal_name.

The is no comma in the line ending "@length" and also there is no space 
at the end of the line for "@copyright" and so that will be a syntax error when the query runs.

I believe that should get you moving on that page. 
If you have additional questions, please let me know.

	*/