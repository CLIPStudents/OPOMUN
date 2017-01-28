Public Class NavSubpage
	Public Property Name As String
	Public Property IsActive As Boolean
End Class

Public Class MasterPage
	Public Property Subpages As New List(Of NavSubpage)
	Public Property PartialToLoad As String
End Class