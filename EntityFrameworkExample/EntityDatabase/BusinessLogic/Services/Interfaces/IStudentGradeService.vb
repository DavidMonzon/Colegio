﻿Namespace BusinessLogic.Services.Interfaces
    Public Interface IStudentGradeService
        Function GetAllStudentsGrades() As IQueryable(Of StudentGrade)
        Sub CreateStudentGrade(studentGrade As StudentGrade)
        Sub DeleteStudentGrade(studentGrade As StudentGrade)
        Sub EditStudentGrade(studentGrade As StudentGrade)
    End Interface
End Namespace