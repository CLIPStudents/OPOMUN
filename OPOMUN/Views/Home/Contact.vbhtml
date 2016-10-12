@Code
	ViewData("Title") = "Contact"
End Code

@section Scripts
	@Scripts.Render("~/Content/Scripts/gmap-clip.js")
	<script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBGVHBlkxVC2JC8Qbid58eaXAy5wTRdzAk&callback=initMap" async defer></script>
End Section

<section>
	<div class="is-map" id="map"></div>
</section>
<section class="section has-shadow contacts">
	<div class="container">
		<h3>The Oporto International School</h3>
		<div class="columns">
			<div class="column is-one-third">
				<p>
					The Oporto International School is an independent and private school
					dedicated to promote brilliant minds for the future through innovation,
					academic excellence and intellectual resilience.
				</p>
			</div>
			<div class="column is-one-third">
				<div class="contact-section">
					<h4 class="is-uppercase">Address</h4>
					<p>The Oporto International School</p>
					<p>Rua de Vila Nova 1071</p>
					<p>4100 - 506 Porto</p>
					<p>Portugal</p>
				</div>
				<br />
				<div class="contact-section">
					<h4 class="is-uppercase">TEL</h4>
					<p>&#43;351 226 199 160</p>
				</div>
				<div class="contact-section">
					<h4 class="is-uppercase">WEBSITE</h4>
					<a href="http://www.clip.pt">www.clip.pt</a>
				</div>
			</div>
			<div class="column is-one-third">
				<h4 class="is-uppercase">Porto</h4>

			</div>
		</div>
	</div>
</section>