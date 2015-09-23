Namespace BusinessLogic.Services.Interfaces
    Public Interface IOnlineCourseService

        Function GetAllOnlineCourses() As IQueryable(Of Implementations.OnlineCourseService)

        Function GetAllOnlineCourses() As IQueryable(Of OnlineCourseService)
    End Interface
End Namespace