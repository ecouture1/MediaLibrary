<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="catalog2.aspx.cs" Inherits="GroupProject_MediaLibrary.catalog2" %>

<%-- OLoughlin's Playground for experimenting --%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Media Catalog</title>
	<meta name= "viewport" content="width =device-width,initial-scale=1" />
	<link href="CSS/catalog.css" rel="stylesheet" />
	<script src="Scripts/jquery-3.3.1.min.js"></script>
</head>
<body>
	<div class ="container">
	    <form id="form1" runat="server">
		    <asp:GridView ID="GridView1" style="margin-top:20px; margin-bottom:20px;" runat="server" AllowPaging="True" 
			    AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" CellPadding="3" GridLines="Horizontal" HorizontalAlign="Center" CssClass="tableWrapper" BorderColor="Blue" BorderStyle="Solid" BorderWidth="4px">
			    <AlternatingRowStyle BackColor="#6699FF" BorderStyle="None" />
			    <Columns>
				    <asp:BoundField DataField="MediaType" HeaderText="Type" SortExpression="MediaType" ReadOnly="True" >
				    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="2.5%" />
                    </asp:BoundField>
				    <asp:BoundField DataField="BookID" HeaderText="BookID" SortExpression="BookID" ReadOnly="True" >
				    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="2.5%" Wrap="True" />
                    </asp:BoundField>
				    <asp:BoundField DataField="ISBN10" HeaderText="ISBN10" SortExpression="ISBN10" ReadOnly="True" >
				    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="5%" />
                    </asp:BoundField>
				    <asp:BoundField DataField="ISBN13" HeaderText="ISBN13" SortExpression="ISBN13" ReadOnly="True" >
				    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="5%" />
                    </asp:BoundField>
				    <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" ReadOnly="True" >
				    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="15%" />
                    </asp:BoundField>
				    <asp:BoundField DataField="Author" HeaderText="Author" SortExpression="Author" ReadOnly="True" >
				    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="10%" />
                    </asp:BoundField>
				    <asp:BoundField DataField="Publisher" HeaderText="Publisher" SortExpression="Publisher" ReadOnly="True" >
				    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="10%" />
                    </asp:BoundField>
				    <asp:BoundField DataField="Copyright" HeaderText="Copyright" SortExpression="Copyright" ReadOnly="True" >
				    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="5%" />
                    </asp:BoundField>
				    <asp:BoundField DataField="Length" HeaderText="Length" SortExpression="Length" ReadOnly="True" >
				    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="5%" />
                    </asp:BoundField>
				    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" >
				    <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="25%" />
                    </asp:BoundField>
				    <asp:CommandField ShowEditButton="True" />
				    <asp:CommandField ShowDeleteButton="True" />
			    </Columns>
		        <EditRowStyle BackColor="#00CCFF" />
                <HeaderStyle BackColor="#000066" BorderStyle="None" ForeColor="White" />
                <PagerSettings Mode="NumericFirstLast" />
                <PagerStyle BackColor="#000066" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
                <RowStyle BackColor="White" />
		    </asp:GridView>
		    <asp:Label ID="lblError" runat="server" Text=" " ViewStateMode="Enabled"></asp:Label>
		    <asp:ObjectDataSource ID="ObjectDataSource1" 
			    runat="server" 
			    ConflictDetection="CompareAllValues"
			    OldValuesParameterFormatString="original_{0}" 
			    SelectMethod="GetCatalogue" 
			    DataObjectTypeName="GroupProject_MediaLibrary.App_Code.MediaItem"
			    TypeName="GroupProject_MediaLibrary.App_Code.MediaItemDB"
			    UpdateMethod="UpdateMediaItem" DeleteMethod="DeleteCategory" InsertMethod="InsertCategory">
			    <UpdateParameters>
				    <asp:Parameter Name="original_MediaItem" Type="Object" />
				    <asp:Parameter Name="MediaItem" Type="Object" />
			    </UpdateParameters>
		    </asp:ObjectDataSource>
		    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="ObjectDataSource1" Height="50px" Width="125px" BorderColor="Blue" BorderStyle="Solid" BorderWidth="4px" CellPadding="4" DefaultMode="Insert" HorizontalAlign="Left">
			    <AlternatingRowStyle BackColor="#6699FF" />
			    <Fields>
				    <asp:BoundField DataField="MediaType" HeaderText="MediaType" SortExpression="MediaType" />
				    <asp:BoundField DataField="BookID" HeaderText="BookID" SortExpression="BookID" />
				    <asp:BoundField DataField="ISBN10" HeaderText="ISBN10" SortExpression="ISBN10" />
				    <asp:BoundField DataField="ISBN13" HeaderText="ISBN13" SortExpression="ISBN13" />
				    <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
				    <asp:BoundField DataField="Author" HeaderText="Author" SortExpression="Author" />
				    <asp:BoundField DataField="Publisher" HeaderText="Publisher" SortExpression="Publisher" />
				    <asp:BoundField DataField="Copyright" HeaderText="Copyright" SortExpression="Copyright" />
				    <asp:BoundField DataField="Length" HeaderText="Length" SortExpression="Length" />
				    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
				    <asp:CommandField ShowInsertButton="True" />
			    </Fields>
		        <RowStyle BackColor="White" />
		    </asp:DetailsView>
	    </form>
    </div>
</body>
</html>
