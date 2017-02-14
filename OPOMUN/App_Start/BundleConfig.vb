Imports System.Web.Optimization

Public Module BundleConfig
	Public Sub RegisterBundles(ByVal bundles As BundleCollection)
        ' Scripts
        bundles.Add(New ScriptBundle("~/Content/Bundles/jQuery").Include(
					"~/Content/Scripts/jquery-{version}.js"))

		bundles.Add(New ScriptBundle("~/Content/Bundles/CoreScripts").Include(
					"~/Content/Scripts/bulma.js"))

		' Styles
		bundles.Add(New StyleBundle("~/Content/Bundles/CoreStyle").Include(
				  "~/Content/CSS/bulma.css",
				  "~/Content/CSS/font-awesome.css",
				  "~/Content/CSS/CoreStyle.css"))
	End Sub
End Module
