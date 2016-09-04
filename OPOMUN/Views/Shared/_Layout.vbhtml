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
<body>
	@RenderBody()
</body>
</html>