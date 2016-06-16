Imports System.Web.Optimization

Public Module BundleConfig
	' For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
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
