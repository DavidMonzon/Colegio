Imports BusinessLogic.Helpers
Imports BusinessLogic.Services.Implementations
Imports BusinessLogic.Services.Interfaces
Imports System.Collections.ObjectModel
Namespace Modules.Departments.ViewModels
    Public Class OnlineCoursesViewModel
        Inherits ViewModelBase

        Private _onlinecourses As ObservableCollection(Of Global.OnlineCourse)
        Private dataAccess As IOnlineCourseService

        Public Property OnlineCourse As ObservableCollection(Of Global.OnlineCourse)
            Get
                Return Me._onlinecourses
            End Get
            Set(value As ObservableCollection(Of Global.OnlineCourse))
                Me._onlinecourses = value
                OnPropertyChanged("OnlineCorse")
            End Set
        End Property

        ' Function to get all persons from service
        Private Function GetAllOnlineCourses() As IQueryable(Of Global.OnlineCourse)
            Return Me.dataAccess.GetAllOnlineCourses
        End Function

        Sub New()
            'Initialize property variable of persons
            Me._onlinecourses = New ObservableCollection(Of OnlineCourse)
            ' Register service with ServiceLocator
            ServiceLocator.RegisterService(Of IPersonService)(New PersonService)
            ' Initialize dataAccess from service
            Me.dataAccess = GetService(Of IPersonService)()
            ' Populate persons property variable 
            For Each element In Me.OnlineCourse
                Me._onlinecourses.Add(element)
            Next
        End Sub
    End Class
End Namespace
Class OnlineCourse

End Class