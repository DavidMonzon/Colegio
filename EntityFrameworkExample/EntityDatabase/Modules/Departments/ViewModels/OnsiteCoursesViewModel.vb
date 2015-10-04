Imports BusinessLogic.Helpers
Imports BusinessLogic.Services.Implementations
Imports BusinessLogic.Services.Interfaces
Imports System.Collections.ObjectModel
Namespace Modules.Departments.ViewModels
    Public Class OnsiteCoursesViewModel
        Inherits ViewModelBase

        Private _onsitecourses As ObservableCollection(Of OnsiteCourse)
        Private dataAccess As IPersonService

        Public Property OnsiteCourses As ObservableCollection(Of Global.OnsiteCourse)
            Get
                Return Me._onsitecourses
            End Get
            Set(value As ObservableCollection(Of Global.OnsiteCourse))
                Me._onsitecourses = value
                OnPropertyChanged("Departments")
            End Set
        End Property

        ' Function to get all persons from service
        Private Function GetAllOnsiteCourses() As IQueryable(Of OnsiteCourse)
            Return Me.dataAccess.GetAllPeople
        End Function

        Sub New()
            'Initialize property variable of persons
            Me._onsitecourses = New ObservableCollection(Of OnsiteCourse)
            ' Register service with ServiceLocator
            ServiceLocator.RegisterService(Of IPersonService)(New PersonService)
            ' Initialize dataAccess from service
            Me.dataAccess = GetService(Of OnsiteCourseService)()
            ' Populate persons property variable 
            For Each element In Me.GetAllOnsiteCourse
                Me._onsitecourses.Add(element)
            Next
        End Sub

        Private Function GetAllOnsiteCourse() As Object
            Throw New NotImplementedException
        End Function

    End Class
End Namespace

Class OnsiteCourse

End Class