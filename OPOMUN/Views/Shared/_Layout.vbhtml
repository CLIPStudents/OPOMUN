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

	<link href="/favicon.png" rel="shortcut icon">
	<link href="https://fonts.googleapis.com/css?family=Arimo" rel="stylesheet">
	<link href="https://fonts.googleapis.com/css?family=Merriweather:400,400italic,700,700italic" rel="stylesheet" type="text/css">

	@Styles.Render("~/Content/Bundles/CoreStyle")
	@RenderSection("Styles", False)
	@Scripts.Render("~/Content/Bundles/jQuery")
</head>
<body>
	<section class="hero is-primary is-medium hero-navbar">
		<div class="hero-head">
			<header class="nav">
				<div class="container">
					<div class="nav-left">
						<a class="nav-item" href="@Url.Action("Landing", "Home")">
							<img src="/Content/Images/OPOMUN Title.svg" class="nav-logo" alt="Logo">
						</a>
					</div>
					<span class="nav-toggle" id="nav-toggle">
						<span></span>
						<span></span>
						<span></span>
					</span>
					<div class="nav-right nav-menu" id="nav-menu">
						<a class="nav-item" href="@Url.Action("Landing", "Home")">
							Home
						</a>
						<a class="nav-item" href="@Url.Action("About", "Home")">
							About
						</a>
						<a class="nav-item" href="@Url.Action("Contact", "Home")">
							Contacts
						</a>
						<span class="nav-item is-hidden">
							<a class="button is-primary is-inverted" href="https://github.com/CLIPStudents/OPOMUN">
								<span class="icon">
									<i class="fa fa-github"></i>
								</span>
								<span>Download</span>
							</a>
						</span>
					</div>
				</div>
			</header>
		</div>

		<div class="hero-body">
			<div class="container has-text-centered">
				<h1 class="title">
					@ViewBag.Title
				</h1>
				<h2 class="subtitle">
					Oporto Model United Nations
				</h2>
			</div>
		</div>

		@RenderSection("NavbarFooter", False)
	</section>

	@RenderBody()

	@Scripts.Render("~/Content/Bundles/CoreScripts")
	@RenderSection("Scripts", False)
</body>
</html>
