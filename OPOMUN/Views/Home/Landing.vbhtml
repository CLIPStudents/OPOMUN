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

			<div class="columns">
				<div class="column opomun-date is-half is-offset-one-quarter">
					<hr class="hr-top" />

					<p class="title">
						23 - 25 February / 2016
					</p>

					<hr class="hr-bottom" />
				</div>
			</div>

			<div class="columns button-row">
				<a class="column is-one-quarter is-offset-one-quarter" href="@Url.Action("About", "Home")">
					<p class="notification is-info">The Conference</p>
				</a>
				<a class="column is-one-quarter" href="http://goo.gl/forms/1HI8VgMOhwK74ck23">
					<p class="notification is-info">Register Now</p>
				</a>
			</div>
		</div>
	</div>
</section>