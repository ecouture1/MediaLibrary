using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// Author: Karen O'Loughlin 3/12/2018 

namespace GroupProject_MediaLibrary.App_Code
{
	public class User
	{
		public User() {  }

		public string userName { get; set; }
		public string passWord { get; set; }
		public string email { get; set; }
		public string securityQuestion { get; set; }
		public string securityResponse { get; set; }
		public Boolean loggedIn { get; set; }

	}
}

