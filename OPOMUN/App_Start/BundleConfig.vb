Imports System.Web.Optimization

Public Module BundleConfig
	Public Sub RegisterBundles(ByVal bundles As BundleCollection)
		bundles.Add(
			New ScriptBundle("~/Bundles/jQuery").Include(
				"~/Content/Scripts/jquery-{version}.js"
			)
		)

		bundles.Add(
			New ScriptBundle("~/Bundles/jQueryVal").Include(
				"~/Content/Scripts/jquery.validate*"
			)
		)

		bundles.Add(
			New ScriptBundle("~/Bundles/MainScript").Include(
				"~/Content/Scripts/Bootstrap3/bootstrap.js"
			)
		)

		bundles.Add(
			New StyleBundle("~/Bundles/MainStyle").Include(
				"~/Content/CSS/Bootstrap3/bootstrap.css",
				"~/Content/CSS/MainStyle/MainStyle.css"
			)
		)
	End Sub
End Module
