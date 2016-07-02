@Code
	ViewData("Title") = "Home Page"
	ViewData("BodyType") = "landing"
End Code

<header class="opomun-header">
	<div class="text-center">
		<img src="~/Content/Images/OPOMUN Logo.svg"/>
		<h1>OPOMUN</h1>
		<h2>Dare to make the difference</h2>
		<div class="container timestamp">
			February
			<time datetime="2017-02-23">23</time>,
			<time datetime="2017-02-24">24</time> and
			<time datetime="2017-02-25">25</time>
		</div>
		<div class="button-row">
			<a class="btn btn-lg" href="@Url.Action("About", "Home")">The Conference</a>
			<a class="btn btn-lg" href="http://goo.gl/forms/1HI8VgMOhwK74ck23">Register Now</a>
		</div>
	</div>
</header>
