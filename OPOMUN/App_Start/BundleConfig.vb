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
				"~/Content/Scripts/Bootstrap/bootstrap.js"
			)
		)

		bundles.Add(
			New StyleBundle("~/Bundles/MainStyle").Include(
				"~/Content/CSS/bootstrap.css"
			)
		)
	End Sub
End Module
