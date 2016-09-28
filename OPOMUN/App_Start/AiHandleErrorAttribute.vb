Imports Microsoft.ApplicationInsights

Namespace ErrorHandler
    <AttributeUsage(AttributeTargets.[Class] Or AttributeTargets.Method, Inherited:=True, AllowMultiple:=True)>
    Public Class AiHandleErrorAttribute
        Inherits HandleErrorAttribute
        Public Overrides Sub OnException(filterContext As ExceptionContext)
            If filterContext IsNot Nothing AndAlso filterContext.HttpContext IsNot Nothing AndAlso filterContext.Exception IsNot Nothing Then
                If filterContext.HttpContext.IsCustomErrorEnabled Then
                    Dim ai = New TelemetryClient()
                    ai.TrackException(filterContext.Exception)
                End If
            End If
            MyBase.OnException(filterContext)
        End Sub
    End Class
End Namespace