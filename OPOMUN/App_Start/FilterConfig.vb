Imports System.Web
Imports System.Web.Mvc

Public Module FilterConfig
	Public Sub RegisterGlobalFilters(ByVal filters As GlobalFilterCollection)
		filters.Add(New ErrorHandler.AiHandleErrorAttribute())
	End Sub
End Module