Imports BusinessLogic.Services.Interfaces
Imports BusinessObjects.Helpers
Namespace BusinessLogic.Services.Implementations
    Public Class PersonService
        Implements IPersonService

        Public Function GetAllPeople() As IQueryable(Of Person) Implements IPersonService.GetAllPeople
            Return DataContext.DBEntities.People
        End Function
    End Class
End Namespace