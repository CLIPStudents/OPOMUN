@ModelType OPOMUN.SubnavPage
@Code
	ViewData("Title") = "About"
End Code

@section NavbarFooter
	<div class="hero-foot">
		<nav class="tabs">
			<div class="container">
				<ul>
					@For Each Subpage In Model.Subpages
						@<li class="@IIf(Subpage.IsActive, "is-active", "")"><a href="@Url.Action("About", routeValues:=New With {.id = Subpage.Name})">@Subpage.Name</a></li>
					Next
				</ul>
			</div>
		</nav>
	</div>
End Section

@Html.Partial(Model.PartialToLoad)