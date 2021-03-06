﻿@Code
	ViewData("Title") = "Landing"
End Code

@section Styles
	@Styles.Render("~/Content/CSS/Landing.css")
End Section

<section class="hero is-primary is-fullheight is-bold landing has-text-centered">
	<div class="hero-body">
		<div class="container">
			<figure class="opomun-logo">
				<img src="/Content/Images/OPOMUN_Logo.svg" alt="Logo" />
			</figure>

			<figure class="opomun-title">
				<img src="/Content/Images/OPOMUN_Title.svg" alt="Oporto Model United Nations" />
			</figure>

			<h2 class="subtitle">Dare to make the difference</h2>

			<div class="columns">
				<div class="column opomun-date is-half is-offset-one-quarter">
					<hr class="hr-top" />

					<p class="title">
						23 - 25 February / 2017
					</p>

					<hr class="hr-bottom" />
				</div>
			</div>

			<div class="columns button-row">
				<a class="column is-one-quarter is-offset-one-quarter" href="@Url.Action("About", "Home")">
					<p class="notification is-info">The Conference</p>
				</a>
				<a class="column is-one-quarter" href="@Url.Action("About", "Home", New With {.Id = "Issues"})" rel="nofollow">
					<p class="notification is-info">The Issues</p>
				</a>
			</div>
		</div>
	</div>
</section>