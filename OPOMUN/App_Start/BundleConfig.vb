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
			New StyleBundle("~/Bundles/MainStyle").Include(
				"~/Content/CSS"
			)
		)
	End Sub
End Module
