<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	<meta http-equiv="x-ua-compatible" content="ie=edge">

	<link href="https://fonts.googleapis.com/css?family=Merriweather:400,400italic,700,700italic" rel="stylesheet" type="text/css">
	<link href="https://fonts.googleapis.com/css?family=Open+Sans:400,700,600" rel="stylesheet" type="text/css">
	<link href="https://fonts.googleapis.com/css?family=Raleway:400,800" rel="stylesheet" type="text/css">

	<title>OPOMUN @ViewBag.Title</title>
	@Styles.Render("~/Bundles/MainStyle")
	@Scripts.Render("~/Bundles/jQuery")
</head>
<body>
	<nav class="navbar navbar-default navbar-fixed-top navbar-opomun">
		<div class="container">
			<div class="navbar-header">
				<button type="button" class="navbar-toggle" clickBehavior="default" data-toggle="collapse" data-target=".navbar-collapse">
					<span class="icon-bar"></span>
					<span class="icon-bar"></span>
					<span class="icon-bar"></span>
				</button>
				@*<a class="navbar-brand" href="@Url.Action("Index", "Home")"><img class="img-responsive" src="~/Content/Images/OPOMUN Logo.png"/></a>*@
			</div>
			<div class="navbar-collapse collapse">
				<ul class="nav navbar-nav">
					<li>@Html.ActionLink("Home", "Index", "Home")</li>
					<li class="dropdown">
						<a class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="true">
							<span>About</span>
						</a>

						<ul Class="dropdown-menu">
							<li><a href="#">Settings</a></li>
							<li><a href="#">Log off</a></li>
						</ul>
					</li>
					<li>@Html.ActionLink("Contact", "Contact", "Home")</li>
				</ul>
				<ul class="nav navbar-nav navbar-right">
					@*Html.Partial("_LoginPartial")*@
				</ul>
			</div>
		</div>
	</nav>
	<div class="body-content">
		@RenderBody()
		<div class="container">
			<hr />
			<footer>
				<small>&copy; @DateTime.Now.Year - Oporto Model United Nations</small>
			</footer>
		</div>
	</div>

	@Scripts.Render("~/Bundles/MainScript")
	@RenderSection("scripts", required:=False)
</body>
</html>
