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
	@RenderBody()

	@Scripts.Render("~/Content/Bundles/CoreStyle")
	@RenderSection("Scripts", False)
</body>
</html>
