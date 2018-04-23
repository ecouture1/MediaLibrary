<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="GroupProject_MediaLibrary.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log In</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="css/main.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/site.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</head>
<body class="bodyBack">
    <form id="form1" runat="server">
        <header>
            <div class="container">
                <nav class="navbar navbar-inverse">
                    <div class="container-fluid">
                        <div class="navbar-header">
                            <a class="navbar-brand" href="index.aspx">Media Library</a>
                        </div>
                        <ul class="nav navbar-nav">
                            <li><a href="login.aspx">Login</a></li>
                            <li><a href="catalog.aspx">Catalog</a></li>
                        </ul>
                    </div>
                </nav>
            </div>
        </header>

        <h3>New Users: </h3>
        <form>
            <div class="form-group">
                <label for="fName">First Name</label>
                <input type="email" class="form-control" id="fName" />
            </div>
            <div class="form-group">
                <label for="lName">Last Name</label>
                <input type="email" class="form-control" id="lName" />
            </div>
            <div class="form-group">
                <label for="userEmail">Email address</label>
                <input type="email" class="form-control" id="userEmail" aria-describedby="emailHelp" placeholder="Enter email" />
            </div>
            <div class="form-group">
                <label for="userPw">Password</label>
                <input type="password" class="form-control" id="userPw" placeholder="Password" />
            </div>
            <div class="form-group col-md-4">
                <label for="security">Security Question</label>
                <select id="inSecurityQ" class="form-control">
                    <option selected>Choose...</option>
                    <option>Example question</option>
                    <option>Example question</option>
                    <option>Example question</option>
                    <option>Example question</option>
                </select>
            </div>

            <button type="submit" class="btn btn-primary">Create Account</button>
        </form>
        <form>
            <h3>Returning Users: </h3>
            <div class="form-group">
                <label for="userEmail">Email address</label>
                <input type="email" class="form-control" id="userEmail" aria-describedby="emailHelp" placeholder="Enter email" />
                <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
            </div>
            <div class="form-group">
                <label for="userPw">Password</label>
                <input type="password" class="form-control" id="userPW" placeholder="Password" />
            </div>
            <div class="form-check">
                <input type="checkbox" class="form-check-input" id="exampleCheck1" />
                <label class="form-check-label" for="exampleCheck1">Remember Me</label>
            </div>
            <button type="submit" class="btn btn-primary">Submit</button>
        </form>
        <footer>
            <div class="container-fluid" style="text-align: center">
                <p>&copy;2018 Brandon Patrick, Karen O’Loughlin, Eli Conture , Jesse Uchytil, Stephan Scott </p>
            </div>
        </footer>
</body>
</html>