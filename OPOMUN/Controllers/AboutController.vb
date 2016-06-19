Public Class AboutController
	Inherits Controller

	Function Index() As ActionResult
		Return RedirectToAction("Index", "Home")
	End Function

	Function Team() As ActionResult
		Return View()
	End Function
End Class