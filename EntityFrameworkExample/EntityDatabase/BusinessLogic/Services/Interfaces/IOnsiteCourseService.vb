Namespace BusinessLogic.Services.Interfaces
    Public Interface IOnsiteCourseServie
        Function GetAllOnsiteCourses() As IQueryable(Of OnsiteCourseService)
        Sub CreateOnsiteCourse(onsiteCourse As OnsiteCourseService)

        Sub DeleteOnsiteCourse(onsiteCourse As OnsiteCourseService)

        Sub EditOnsiteCourse(onsiteCourse As OnsiteCourseService)
    End Interface
End Namespace