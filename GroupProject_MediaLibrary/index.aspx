<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="GroupProject_MediaLibrary.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Group Project CIS 174 - Media Library</title>
        <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="css/main.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" /> 
    <link href="Content/site.css" rel="stylesheet" /> 
    <script src="Scripts/jquery-1.9.1.min.js"></script> 
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body runat="server" id="page_body">
    <form id="form1" runat="server">
        <header>
        <div class="container">
            <nav class="navbar navbar-inverse">
                <div class="container-fluid">
                <div class="navbar-header">
                     4<a class="navbar-brand" href="index.aspx">Media Library</a>
                </div>
                    <ul class="nav navbar-nav">
                        <li><a href="login.aspx">Login</a></li>
                        <li><a href="catalog2.aspx">Catalog</a></li>
                    </ul>
                </div>
            </nav>      
        </div>
    </header>

    <section id="showcase">
      <div class="container">
        <h1>Welcome to the Media Library!</h1>
      </div>
    </section>

    <section id="bottom">
      <div class="container">
      </div>
    </section>

    <footer>
      <p>Brandon Patrick, Karen O’Loughlin, Eli Conture , Jesse Uchytil, Stephan Scott &copy;2018</p>
    </footer>

    </form>
</body>
</html>
