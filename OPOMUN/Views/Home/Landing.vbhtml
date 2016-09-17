@Code
	ViewData("Title") = "Landing"
End Code

@section Styles
	@Styles.Render("~/Content/CSS/Landing.css")
End Section

<section class="hero is-primary is-fullheight is-bold landing">
	<div class="hero-body">
		<div class="container has-text-centered">
			<div class="columns">
				<div class="column">
					<img class="logo" src="~/Content/Images/OPOMUN Logo.svg" />
				</div>
			</div>
			<div class="columns">
				<div class="column">
					<img class="title" src="~/Content/Images/OPOMUN Title.svg" />
					<h2 class="subtitle">Dare to make the difference</h2>
				</div>
			</div>
			<div class="columns">
				<div class="column timestamp is-half is-offset-one-quarter">
					<hr class="hr-top" />

					February
					<time datetime="2017-02-23">23</time>,
					<time datetime="2017-02-24">24</time> and
					<time datetime="2017-02-25">25</time>

					<hr class="hr-bottom" />
				</div>
			</div>
			<div class="columns button-row">
				<a class="column is-one-quarter is-offset-one-quarter">
					<p class="notification is-info">The Conference</p>
				</a>
				<a class="column is-one-quarter" href="http://goo.gl/forms/1HI8VgMOhwK74ck23">
					<p class="notification is-info">Register Now</p>
				</a>
			</div>
		</div>
	</div>
</section>