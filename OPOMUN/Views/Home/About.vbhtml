@ModelType OPOMUN.SubnavPage
@Code
	ViewData("Title") = "About"
End Code

<nav class="nav has-shadow">
	<div class="container">
		<div class="nav-center">
			@For Each Subpage In Model.Subpages
				@<a class="nav-item is-tab @IIf(Subpage.IsActive, "is-active", "")" href="@Url.Action("About", routeValues:=New With {.id = Subpage.Name})">@Subpage.Name</a>
			Next
		</div>
	</div>
</nav>

@Html.Partial(Model.PartialToLoad)