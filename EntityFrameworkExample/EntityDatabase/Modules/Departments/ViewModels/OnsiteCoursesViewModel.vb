Imports BusinessLogic.Helpers
Imports BusinessLogic.Services.Implementations
Imports BusinessLogic.Services.Interfaces
Imports System.Collections.ObjectModel
Namespace Modules.Departments.ViewModels
    Public Class OnsiteCoursesViewModel
        Inherits ViewModelBase

        Private _onsitecourses As ObservableCollection(Of IOnsiteCourse)
        Private dataAccess As IPersonService

        Public Property OnsiteCourses As IOnsiteCourse
            Get
                Return Me._onsitecourses
            End Get
            Set(value As IOnsiteCourse)
                Me._onsitecourses = value
                OnPropertyChanged("Departments")
            End Set
        End Property

        ' Function to get all persons from service
        Private Function GetAllPersons() As IQueryable(Of IOnsiteCourse)
            Return Me.dataAccess.GetAllOnsiteCourse
        End Function

        Sub New()
            'Initialize property variable of persons
            Me._onsitecourses = New ObservableCollection(Of IOnsiteCourse)
            ' Register service with ServiceLocator
            ServiceLocator.RegisterService(Of IPersonService)(New PersonService)
            ' Initialize dataAccess from service
            Me.dataAccess = GetService(Of IPersonService)()
            ' Populate persons property variable 
            For Each element In Me.GetAllOnsiteCourse
                Me._onsitecourses.Add(element)
            Next
        End Sub
    End Class
End Namespace