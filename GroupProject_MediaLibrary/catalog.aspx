<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="catalog.aspx.cs" Inherits="GroupProject_MediaLibrary.catalogue" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="CSS/catalog.css" />
    
    <!--Authors:            Jesse Uchytil
        Date of creation:   3/8/18
        Last Edit:          3/9/18
        Title:              catalog.aspx

        -->
    <title></title>
</head>
    <!--NOTES on structure of page:

        This page is designed to hold 10 entries of the catalog at any time.  The stucture goes as thus:
        1. a div with class Container wraps around everything inside the main body
        2. Within that container are 3 Asp.net panels with the default setting of 'Visible=False' so that each one can
            be manually changed by the code-behind depending on how many items need displayed.
        3. Finally, within each panel are 5 items:
            1. a label that holds the title, centered and towards the top of the box
            2. an image that will hold an image (default or otherwise) relevant to the catalog item, located in the bottom left
            3. a label for the general info (ISBN, pub date, etc.), located bottom middle
            4. a label for the description of the item, located bottom right.
            5. (NOT IMPLEMENTED) a checkbox that marks an item for manipulation by the rows of buttons.

        Each of these items and subitems are managed and controlled from the code-behind file.

        (NOT IMPLEMENTED) Finally, there are two rows of buttons: One on top and one on bottom. 
        These rows are for manipulating the user's personal list by way of allowing them to 'add to favorites' or 
        'remove from favorites.  Along with these are controls for moving between different pages in the catalog.

        -->
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:Panel ID="catalogitem1" runat="server" CssClass="catalogitem" Visible="False">
                <div class="title">
                    <asp:Label ID="CatalogTitle1" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="left">
                    <p><asp:Image ID="CatalogImage1" runat="server" CssClass="catalogimage" /></p>
                </div>
                <div class="left">
                    <asp:Label ID="CatalogInfo1" runat="server" Text="Label" CssClass="cataloginfo"></asp:Label>
                </div>
                <div class="left">
                    <asp:Label ID="CatalogDescription1" runat="server" Text="Label" CssClass="catalogdescription"></asp:Label>
                </div>
            </asp:Panel>
            <asp:Panel ID="catalogitem2" runat="server" CssClass="catalogitem" Visible="False">
                <div class="title">
                    <asp:Label ID="CatalogTitle2" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="left">
                    <asp:Image ID="CatalogImage2" runat="server" CssClass="catalogimage" />
                </div>
                <div class="left">
                    <asp:Label ID="CatalogInfo2" runat="server" Text="Label" CssClass="cataloginfo"></asp:Label>
                </div>
                <div class="left">
                    <asp:Label ID="CatalogDescription2" runat="server" Text="Label" CssClass="catalogdescription"></asp:Label>
                </div>
            </asp:Panel>
            <asp:Panel ID="catalogitem3" runat="server" CssClass="catalogitem" Visible="False">
                <div class="title">
                    <asp:Label ID="CatalogTitle3" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="left">
                    <asp:Image ID="CatalogImage3" runat="server" CssClass="catalogimage" />
                </div>
                <div class="left">
                    <asp:Label ID="CatalogInfo3" runat="server" Text="Label" CssClass="cataloginfo"></asp:Label>
                </div>
                <div class="left">
                    <asp:Label ID="CatalogDescription3" runat="server" Text="Label" CssClass="catalogdescription"></asp:Label>
                </div>
            </asp:Panel>
            <asp:Panel ID="catalogitem4" runat="server" CssClass="catalogitem" Visible="False">
                <div class="title">
                    <asp:Label ID="CatalogTitle4" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="left">
                    <asp:Image ID="CatalogImage4" runat="server" CssClass="catalogimage" />
                </div>
                <div class="left">
                    <asp:Label ID="CatalogInfo4" runat="server" Text="Label" CssClass="cataloginfo"></asp:Label>
                </div>
                <div class="left">
                    <asp:Label ID="CatalogDescription4" runat="server" Text="Label" CssClass="catalogdescription"></asp:Label>
                </div>
            </asp:Panel>
            <asp:Panel ID="catalogitem5" runat="server" CssClass="catalogitem" Visible="False">
                <div class="title">
                    <asp:Label ID="CatalogTitle5" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="left">
                    <asp:Image ID="CatalogImage5" runat="server" CssClass="catalogimage" />
                </div>
                <div class="left">
                    <asp:Label ID="CatalogInfo5" runat="server" Text="Label" CssClass="cataloginfo"></asp:Label>
                </div>
                <div class="left">
                    <asp:Label ID="CatalogDescription5" runat="server" Text="Label" CssClass="catalogdescription"></asp:Label>
                </div>
            </asp:Panel>
            <asp:Panel ID="catalogitem6" runat="server" CssClass="catalogitem" Visible="False">
                <div class="title">
                    <asp:Label ID="CatalogTitle6" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="left">
                    <asp:Image ID="CatalogImage6" runat="server" CssClass="catalogimage" />
                </div>
                <div class="left">
                    <asp:Label ID="CatalogInfo6" runat="server" Text="Label" CssClass="cataloginfo"></asp:Label>
                </div>
                <div class="left">
                    <asp:Label ID="CatalogDescription6" runat="server" Text="Label" CssClass="catalogdescription"></asp:Label>
                </div>
            </asp:Panel>
            <asp:Panel ID="catalogitem7" runat="server" CssClass="catalogitem" Visible="False">
                <div class="title">
                    <asp:Label ID="CatalogTitle7" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="left">
                    <asp:Image ID="CatalogImage7" runat="server" CssClass="catalogimage" />
                </div>
                <div class="left">
                    <asp:Label ID="CatalogInfo7" runat="server" Text="Label" CssClass="cataloginfo"></asp:Label>
                </div>
                <div class="left">
                    <asp:Label ID="CatalogDescription7" runat="server" Text="Label" CssClass="catalogdescription"></asp:Label>
                </div>
            </asp:Panel>
            <asp:Panel ID="catalogitem8" runat="server" CssClass="catalogitem" Visible="False">
                <div class="title">
                    <asp:Label ID="CatalogTitle8" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="left">
                    <asp:Image ID="CatalogImage8" runat="server" CssClass="catalogimage" />
                </div>
                <div class="left">
                    <asp:Label ID="CatalogInfo8" runat="server" Text="Label" CssClass="cataloginfo"></asp:Label>
                </div>
                <div class="left">
                    <asp:Label ID="CatalogDescription8" runat="server" Text="Label" CssClass="catalogdescription"></asp:Label>
                </div>
            </asp:Panel>
            <asp:Panel ID="catalogitem9" runat="server" CssClass="catalogitem" Visible="False">
                <div class="title">
                    <asp:Label ID="CatalogTitle9" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="left">
                    <asp:Image ID="CatalogImage9" runat="server" CssClass="catalogimage" />
                </div>
                <div class="left">
                    <asp:Label ID="CatalogInfo9" runat="server" Text="Label" CssClass="cataloginfo"></asp:Label>
                </div>
                <div class="left">
                    <asp:Label ID="CatalogDescription9" runat="server" Text="Label" CssClass="catalogdescription"></asp:Label>
                </div>
            </asp:Panel>
            <asp:Panel ID="catalogitem10" runat="server" CssClass="catalogitem" Visible="False">
                <div class="title">
                    <asp:Label ID="CatalogTitle10" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="left">
                    <asp:Image ID="CatalogImage10" runat="server" CssClass="catalogimage" />
                </div>
                <div class="left">
                    <asp:Label ID="CatalogInfo10" runat="server" Text="Label" CssClass="cataloginfo"></asp:Label>
                </div>
                <div class="left">
                    <asp:Label ID="CatalogDescription10" runat="server" Text="Label" CssClass="catalogdescription"></asp:Label>
                </div>
            </asp:Panel>
        </div>
    	<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetCatalogue" TypeName="GroupProject_MediaLibrary.App_Code.MediaItemDB"></asp:ObjectDataSource>
    </form>
</body>
</html>
