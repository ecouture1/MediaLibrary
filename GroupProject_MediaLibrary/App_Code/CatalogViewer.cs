using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProject_MediaLibrary.App_Code
{
	/**
     * Authors:            Jesse Uchytil
     * Date of creation:   3/9/18
     * Last Edit:          3/9/18
     * Title:              CatalogViewer.cs
     * 
     * Description:  This object keeps track of what portion of the catalog the user is viewing.  Eventually, it could 
     * hold search criteria and more. 
     */

	public class CatalogViewer
    {
        public CatalogViewer() { }
        public int pageNumber { get; set; }
    }
}