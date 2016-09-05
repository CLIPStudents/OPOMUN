Imports System.Web.Optimization

Public Module BundleConfig
	Public Sub RegisterBundles(ByVal bundles As BundleCollection)

		' Style bundles
		bundles.Add(New StyleBundle("~/Content/Bundles/CoreStyle").Include(
					"~/Content/CSS/bulma.css",
					"~/Content/CSS/MUNStyle.css"))

		' Toggle minification and bundling during Debug
		'BundleTable.EnableOptimizations = True
	End Sub
End Module