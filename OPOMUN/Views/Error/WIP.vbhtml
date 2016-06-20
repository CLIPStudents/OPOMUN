@Code
	Layout = Nothing
End Code

<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	<meta http-equiv="x-ua-compatible" content="ie=edge">

	<link href="https://fonts.googleapis.com/css?family=Merriweather:400,400italic,700,700italic" rel="stylesheet" type="text/css">
	<link href="https://fonts.googleapis.com/css?family=Open+Sans:400,700,600" rel="stylesheet" type="text/css">
	<link href="https://fonts.googleapis.com/css?family=Raleway:400,800" rel="stylesheet" type="text/css">

	<title>OPOMUN - WIP</title>

	@Styles.Render("~/Bundles/MainStyle")
	@Scripts.Render("~/Bundles/jQuery")
</head>
<body class="vectory-body">
	<style>
		html, body { 
			margin: 0 !important; 
			padding: 0 !important; 
			height: 100% !important; 
		}
		.container-full {
			margin: 0 auto;
			width: 100%;
			min-height: 100% !important;
			height: 100% !important;
			overflow: hidden;
			position: relative;
		}

		.text-center {
			position: absolute;
			top: 50%;
			left: 50%;
			height: 30%;
			width: 50%;
			margin: -15% 0 0 -25%;
		}
	</style>
	<div class="container-full">
		<div class="text-center">
			<h1>Houston, we have a problem.</h1>
			<p>This page is still being worked on. Check back soon!</p>
			<a class="btn" href="@Url.Action("Index", "Home")">Go Home</a>
		</div>
	</div>

	@Scripts.Render("~/Bundles/MainScript")
</body>
</html>