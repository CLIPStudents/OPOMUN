Public Class HomeController
	Inherits System.Web.Mvc.Controller

	Function Index() As ActionResult
		Return RedirectToAction("Landing")
	End Function

	Function Landing() As ActionResult
		Return View()
	End Function
End Class
