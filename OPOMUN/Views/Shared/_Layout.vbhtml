<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	<meta http-equiv="x-ua-compatible" content="ie=edge">

	<title>OPOMUN @ViewBag.Title</title>
	@Styles.Render("~/Bundles/MainStyle")
	@Scripts.Render("~/Bundles/jQuery")
</head>
<body>
	<nav class="navbar navbar-default navbar-fixed-top">
		<div class="container">
			<div class="navbar-header">
				<button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
					<span class="icon-bar"></span>
					<span class="icon-bar"></span>
					<span class="icon-bar"></span>
				</button>
				<a class="navbar-brand" href="@Url.Action("Index", "Home")"><img class="img-responsive" src="~/Content/Images/OPOMUN Logo.png"/></a>
			</div>
			<div class="navbar-collapse collapse">
				<ul class="nav navbar-nav">
					<li>@Html.ActionLink("Home", "Index", "Home")</li>
					<li>@Html.ActionLink("About", "About", "Home")</li>
					<li>@Html.ActionLink("Contact", "Contact", "Home")</li>
				</ul>
				<ul class="nav navbar-nav navbar-right">
					@Html.Partial("_LoginPartial")
				</ul>
			</div>
		</div>
	</nav>
	<div class="container body-content">
		@RenderBody()
		<hr />
		<footer>
			<p>&copy; @DateTime.Now.Year - Oporto Model United Nations</p>
		</footer>
	</div>

	@Scripts.Render("~/Bundles/MainScript")
	@RenderSection("scripts", required:=False)
</body>
</html>
