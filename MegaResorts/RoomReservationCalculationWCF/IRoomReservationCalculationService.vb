Imports System.ServiceModel.Web

<ServiceContract()>
Public Interface IRoomReservationCalculationService
    <OperationContract()>
    <WebGet(UriTemplate:="Calculate/{startDate}/{endDate}/{isCAA}/{bedSize}")>
    Function Calculate(ByVal startDate As String, ByVal endDate As String, ByVal isCAA As String, ByVal bedSize As String) As Decimal
End Interface
