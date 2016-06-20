Public Class HomeController
	Inherits System.Web.Mvc.Controller

	Function Landing() As ActionResult
		Return RedirectToAction("Index")
	End Function

	Function Index() As ActionResult
		Return View()
	End Function
End Class
