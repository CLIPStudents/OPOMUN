@Imports Microsoft.AspNet.Identity

@If Request.IsAuthenticated Then
	@Using Html.BeginForm("LogOff", "Account", FormMethod.Post, New With {.id = "logoutForm", .class = "navbar-right"})
		@<li Class="dropdown">
			<a Class="dropdown-toggle" href="#" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="true">
				<span Class="glyphicon glyphicon-cog"></span>
			</a>

			<ul Class="dropdown-menu">
				<li><a href="#">Settings</a></li>
				<li><a href="javascript:document.getElementById('logoutForm').submit()">Log off</a></li>
			</ul>
		</li>
	End Using
Else
	@<li><a href="@Url.Action("Register", "Account")"><span Class="glyphicon glyphicon-user"></span> Sign Up</a></li>
	@<li><a href = "@Url.Action("Login", "Account")"><span Class="glyphicon glyphicon-log-in"></span> Login</a></li>
End If
