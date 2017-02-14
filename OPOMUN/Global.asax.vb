Imports System.Web.Optimization

Public Class MvcApplication
	Inherits System.Web.HttpApplication

	Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        RouteConfig.RegisterRoutes(RouteTable.Routes)
		BundleConfig.RegisterBundles(BundleTable.Bundles)
	End Sub
End Class
