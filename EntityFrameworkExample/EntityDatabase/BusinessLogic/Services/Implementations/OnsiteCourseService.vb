Imports BusinessLogic.Services.Interfaces
Imports BusinessObjects.Helpers
Namespace BusinessLogic.Services.Implementations
    Public Class OnsiteCourseService
        Implements IOnsiteCourse
        Public Function GetAllOnsiteCourses() As IQueryable(Of OnsiteCourseService) Implements IOnsiteCourse.GetAllOnsiteCourses
            Return DataContext.DBEntities.OnsiteCourses
        End Function
    End Class
End Namespace

