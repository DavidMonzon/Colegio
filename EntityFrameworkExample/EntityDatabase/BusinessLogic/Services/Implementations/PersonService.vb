﻿Imports BusinessLogic.Services.Interfaces
Imports BusinessObjects.Helpers
Namespace BusinessLogic.Services.Implementations
    Public Class PersonService
        Implements IPersonService

        Public Function GetAllPersons() As IQueryable(Of Person) Implements IPersonService.GetAllPersons
            Return DataContext.DBEntities.Persons
        End Function
    End Class
End Namespace