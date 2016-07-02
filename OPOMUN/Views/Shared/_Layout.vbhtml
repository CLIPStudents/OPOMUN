<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	<meta http-equiv="x-ua-compatible" content="ie=edge">

	<title>OPOMUN @ViewBag.Title</title>
	<link rel="shortcut icon" href="/favicon.png" />

	@Styles.Render("~/Bundles/MainStyle")
	@Scripts.Render("~/Bundles/jQuery")
	@Scripts.Render("~/Content/Scripts/AppInsights.js")
</head>
<body class="@String.Concat("body-", ViewBag.BodyType)">
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
					<li>@Html.ActionLink("About", "About", "Home")</li>
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
		<div class="container footer">
			<hr />
			<footer>
				<small>Made by <a href="http://devsparkle.me">Ricardo Loureiro</a>. &copy; @DateTime.Now.Year - OPOMUN</small>
			</footer>
		</div>
	</div>

	@Scripts.Render("~/Bundles/MainScript")
	@RenderSection("scripts", required:=False)
</body>
</html>
