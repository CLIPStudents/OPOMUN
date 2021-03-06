﻿Imports System.IO

Public Class HomeController
	Inherits System.Web.Mvc.Controller

	Function Index() As ActionResult
		Return RedirectToAction("Landing")
	End Function

	Function Landing() As ActionResult
		Return View()
	End Function

	Function Committees() As ActionResult
		Return RedirectToActionPermanent("Committee", "Home")
	End Function

	Function Committee(ByVal Id As String) As ActionResult
		Dim Model As New MasterPage
		Dim SubpageContainerPath = "~/Views/Home/CommitteePartials/"
		Dim SubpagePartials = Directory.GetFiles(Server.MapPath(SubpageContainerPath))
		Dim IsFirst = True

		For Each SubpagePartial In SubpagePartials
			Dim IsActive = False
			If Id IsNot Nothing And IO.File.Exists(Server.MapPath(SubpageContainerPath & Id & ".vbhtml")) Then
				If Id = Path.GetFileNameWithoutExtension(SubpagePartial) Then
					IsActive = True
				End If
			ElseIf IsFirst Then
				IsActive = True
			End If
			IsFirst = False

			If IsActive Then
				Model.PartialToLoad = SubpageContainerPath & Path.GetFileName(SubpagePartial)
			End If

			Model.Subpages.Add(New NavSubpage With {
				.Name = Path.GetFileNameWithoutExtension(SubpagePartial),
				.IsActive = IsActive
			})
		Next

		Return View(Model)
	End Function

	Function About(ByVal Id As String) As ActionResult
		Dim Model As New MasterPage
		Dim SubpageContainerPath = "~/Views/Home/AboutPartials/"
		Dim SubpagePartials = Directory.GetFiles(Server.MapPath(SubpageContainerPath))
		Dim IsFirst = True

		For Each SubpagePartial In SubpagePartials
			Dim IsActive = False
			If Id IsNot Nothing And IO.File.Exists(Server.MapPath(SubpageContainerPath & Id & ".vbhtml")) Then
				If Id = Path.GetFileNameWithoutExtension(SubpagePartial) Then
					IsActive = True
				End If
			ElseIf IsFirst Then
				IsActive = True
			End If
			IsFirst = False

			If IsActive Then
				Model.PartialToLoad = SubpageContainerPath & Path.GetFileName(SubpagePartial)
			End If

			Model.Subpages.Add(New NavSubpage With {
				.Name = Path.GetFileNameWithoutExtension(SubpagePartial),
				.IsActive = IsActive
			})
		Next

		Return View(Model)
	End Function

	Function Contact() As ActionResult
		Return View()
	End Function
End Class
