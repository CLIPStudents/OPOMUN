@Code
	Layout = Nothing
End Code

<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	<meta http-equiv="x-ua-compatible" content="ie=edge">

	<link href="https://fonts.googleapis.com/css?family=Merriweather:400,400italic,700,700italic" rel="stylesheet" type="text/css">

	<title>OPOMUN</title>
	<link rel="shortcut icon" href="/favicon.png" />

	@Styles.Render("~/Bundles/MainStyle")
	@Scripts.Render("~/Bundles/jQuery")
	@Scripts.Render("~/Content/Scripts/AppInsights.js")
</head>
<body class="body-landing">
	<div class="body-content">
		<header class="opomun-header">
			<div class="text-center">
				<img src="~/Content/Images/OPOMUN Logo.svg" />
				<h1>OPOMUN</h1>
				<h2>Dare to make the difference</h2>
				<div class="container timestamp">
					<hr class="top-hr" />

					February
					<time datetime="2017-02-23">23</time>,
					<time datetime="2017-02-24">24</time> and
					<time datetime="2017-02-25">25</time>

					<hr class="bottom-hr" />
				</div>
				<div class="button-row" role="group" aria-label="options">
					<a class="btn btn-lg" href="@Url.Action("About", "Home")">The Conference</a>
					<a class="btn btn-lg" href="http://goo.gl/forms/1HI8VgMOhwK74ck23">Register Now</a>
				</div>
			</div>
		</header>
	</div>

	@Scripts.Render("~/Bundles/MainScript")
</body>
</html>