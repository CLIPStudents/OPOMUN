Public Class ErrorController
	Inherits Controller

	Function Index() As ActionResult
		Return RedirectToAction("Index", "Home")
	End Function

	Function WIP() As ActionResult
		Return View()
	End Function
End Class