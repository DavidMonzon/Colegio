Namespace BusinessLogic.Services.Interfaces
    Public Interface IOnlineCourseService
        Function GetAllOnlineCourses() As IQueryable(Of OnlineCourseService)
        Sub CreateOnlineCourse(onlineCourse As OnlineCourseService)
        Sub EditOnlineCourse(onlineCourse As OnlineCourseService)
        Sub DeleteOnlineCourse(onlineCourse As OnlineCourseService)
    End Interface
End Namespace