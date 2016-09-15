<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	<meta http-equiv="x-ua-compatible" content="ie=edge">

	<title>@ViewBag.Title - OPOMUN</title>

	<meta name="keywords" content="OPOMUN, Oporto Model United Nations, Model UN, Model United Nations, MUNer, Debate, Students" />
	<meta name="description" content="The official website of the Oporto Model United Nations. Dare to make the difference." />
	<meta name="subject" content="The Oporto Model United Nations official website, providing you all the information you need to be a sucessfull MUNer.">
	<meta name="copyright" content="Ricardo Loureiro for CLIP - The Oporto International School, All rights reserved.">
	<meta name="language" content="EN">
	<meta name="robots" content="index, follow" />

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
