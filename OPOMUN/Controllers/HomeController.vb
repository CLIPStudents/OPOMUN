Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
		Inherits Controller

		' GET: /Home
		Function Index() As ActionResult
			Return RedirectToAction("Landing")
		End Function

		' GET: /Home/Landing
		Function Landing() As ActionResult
			Return View()
		End Function
	End Class
End Namespace