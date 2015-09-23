Imports BusinessLogic.Services.Interfaces
Imports BusinessObjects.Helpers
Namespace BusinessLogic.Services.Implementations
    Public Class StudentGradeService
        Implements IStudentGrade

        Public Function GetAllStudentsGrades() As IQueryable(Of StudentGrade) Implements IStudentGrade.GetAllStudentsGrades
            Return DataContext.DBEntities.StudentGrades
        End Function
    End Class
End Namespace