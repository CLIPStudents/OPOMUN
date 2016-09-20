@Code
	ViewData("Title") = "Landing"
End Code

@section Styles
	@Styles.Render("~/Content/CSS/Landing.css")
End Section

<section class="hero is-primary is-fullheight is-bold landing has-text-centered">
	<div class="hero-body">
		<div class="container">
			<figure class="opomun-logo">
				<img src="/Content/Images/OPOMUN Logo.svg" />
			</figure>

			<figure class="opomun-title">
				<img src="/Content/Images/OPOMUN Title.svg" />
			</figure>

			<h2 class="subtitle">Dare to make the difference</h2>
		</div>
	</div>
</section>