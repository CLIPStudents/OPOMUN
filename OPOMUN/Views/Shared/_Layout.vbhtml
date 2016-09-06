<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	<meta http-equiv="x-ua-compatible" content="ie=edge">

	<title>OPOMUN - @ViewBag.Title</title>
	<link rel="shortcut icon" href="/favicon.png"/>
	<link href="https://fonts.googleapis.com/css?family=Merriweather:400,400italic,700,700italic" rel="stylesheet" type="text/css">

	@Styles.Render("~/Content/Bundles/CoreStyle")
	@RenderSection("Styles", False)
</head>
<body class="@ViewBag.BodyTag">
	<section class="hero is-primary is-medium navigation-holder">
		<div class="hero-head">
			<header class="nav">
				<div class="container">
					<div class="nav-left">
						<a class="nav-item">
							<img src="/Content/Images/OPOMUN Bird.svg" alt="OPOMUN Bird">
						</a>
					</div>
					<span class="nav-toggle">
						<span></span>
						<span></span>
						<span></span>
					</span>
					<div class="nav-right nav-menu">
						<a class="nav-item is-active">
							About
						</a>
						@Html.Partial("_LoginPartial")
					</div>
				</div>
			</header>
		</div>
	</section>

	@RenderBody()

	<footer>
		<p>
			C:
			<span> @HttpContext.Current.Request.RequestContext.RouteData.GetRequiredString("controller").ToUpper</span>
			A:
			<span> @HttpContext.Current.Request.RequestContext.RouteData.GetRequiredString("action").ToUpper</span>
		</p>
	</footer>

	@RenderSection("Scripts", False)
</body>
</html>