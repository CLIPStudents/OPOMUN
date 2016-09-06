@Imports Microsoft.AspNet.Identity

@If Request.IsAuthenticated Then
	@Using Html.BeginForm("LogOff", "Account", FormMethod.Post, New With {.id = "logoutForm", .class = "navbar-right"})
		@Html.AntiForgeryToken()
		@<span class="nav-item">
			<a class="button is-primary is-inverted" href="javascript:document.getElementById('logoutForm').submit()">
				<span class="icon">
					<i class="fa fa-cogs"></i>
				</span>
				<span>Log off</span>
			</a>
		</span>
	End Using
Else
	@<span class="nav-item">
		<a class="button is-primary is-inverted" href="@Url.Action("Login", "Account")">
			<span class="icon">
				<i class="fa fa-cogs"></i>
			</span>
			<span>Log In</span>
		</a>
	</span>
End If