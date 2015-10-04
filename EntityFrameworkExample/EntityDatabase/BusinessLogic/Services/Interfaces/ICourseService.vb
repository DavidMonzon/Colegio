Namespace BusinessLogic.Services.Interfaces
    Public Interface ICourseService
        Function GetAllCourses() As IQueryable(Of Course)
        Sub CreateCourse(course As Course)
        Sub DeleteCourse(course As Course)
        Sub EditCourse(course As Course)
    End Interface

End Namespace
