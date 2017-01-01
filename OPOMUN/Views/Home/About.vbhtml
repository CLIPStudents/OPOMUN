@ModelType OPOMUN.SubnavPage
@Code
	ViewData("Title") = "About"
End Code

@section Scripts
	@Scripts.Render("~/Content/Scripts/gmap-venue.js")
	<script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBGVHBlkxVC2JC8Qbid58eaXAy5wTRdzAk&callback=initMap" async defer></script>
End Section

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