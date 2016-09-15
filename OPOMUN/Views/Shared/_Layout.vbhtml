<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	<meta http-equiv="x-ua-compatible" content="ie=edge">

	<title>@ViewBag.Title - OPOMUN</title>

	@Styles.Render("~/Content/Bundles/CoreStyle")
	@RenderSection("Styles", False)
	@Scripts.Render("~/Content/Bundles/jQuery")
</head>
<body>
	<div class="navbar navbar-inverse navbar-fixed-top">
		<div class="container">
			<div class="navbar-header">
				<button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
					<span class="icon-bar"></span>
					<span class="icon-bar"></span>
					<span class="icon-bar"></span>
				</button>
				@Html.ActionLink("Application name", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
			</div>
			<div class="navbar-collapse collapse">
				<ul class="nav navbar-nav">
					<li>@Html.ActionLink("Home", "Index", "Home")</li>
					<li>@Html.ActionLink("About", "About", "Home")</li>
					<li>@Html.ActionLink("Contact", "Contact", "Home")</li>
				</ul>
			</div>
		</div>
	</div>
	<div class="container body-content">
		@RenderBody()
		<hr />
		<footer>
			<p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
		</footer>
	</div>

	@Scripts.Render("~/Content/Bundles/CoreStyle")
	@RenderSection("scripts", required:=False)
</body>
</html>
