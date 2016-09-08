@ModelType LoginViewModel
@Code
	ViewBag.Title = "Log in"
	ViewBag.BodyTag = ""
End Code

<section class="section">
	<div class="container">
		<h1 class="title">@ViewBag.Title</h1>
		<h2 class="subtitle">Your <abbr title="Oporto Model United Nations">OPOMUN</abbr> account.</h2>
		<hr />
		<div class="card is-fullwidth">
			<div class="card-content">
				<div class="content">
					@Using Html.BeginForm("Login", "Account", New With {.ReturnUrl = ViewBag.ReturnUrl}, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
						@Html.AntiForgeryToken()
						@<text>
						@Html.LabelFor(Function(m) m.Email, New With {.class = "label"})
						<p class="control">
							@Html.TextBoxFor(Function(m) m.Email, New With {.class = "input"})
							@Html.ValidationMessageFor(Function(m) m.Email, "", New With {.class = "help is-danger"})
						</p>
						
						@Html.LabelFor(Function(m) m.Password, New With {.class = "label"})
						<p class="control">
							@Html.PasswordFor(Function(m) m.Password, New With {.class = "input"})
							@Html.ValidationMessageFor(Function(m) m.Password, "", New With {.class = "help is-danger"})
						</p>
						
						<p class="control">
							<label class="checkbox">
								@Html.CheckBoxFor(Function(m) m.RememberMe)
								@Html.LabelFor(Function(m) m.RememberMe)
							</label>
						</p>
						
						<p class="control">
							<input type="submit" value="Log in" class="button is-primary" />
						</p>
						</text>
					End Using
					<br />
					<small>Do <span class="is-italic">not</span> share your credentials.</small>
				</div>
			</div>
		</div>
	</div>
</section>