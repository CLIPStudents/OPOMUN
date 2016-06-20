Public Class AboutController
	Inherits Controller

	Function Index() As ActionResult
		Return RedirectToAction("Index", "Home")
	End Function

	Function Team() As ActionResult
		Return RedirectToAction("WIP", "Error")
	End Function

	Function Venue() As ActionResult
		Return View()
	End Function

	Function Contact() As ActionResult
		Return View()
	End Function
End Class