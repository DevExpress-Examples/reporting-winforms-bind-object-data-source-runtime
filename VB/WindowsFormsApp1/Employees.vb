Imports DevExpress.DataAccess.ObjectBinding
Imports System.Collections.Generic
Imports System.ComponentModel
' ...
Public Class Employee
	Public Property EmployeeName() As String
	Public Property EmployeePosition() As String
End Class

<DisplayName("Employees"), HighlightedClass>
Public Class EmployeeDataSource
	Private department As String
	Private management As New List(Of Employee)() From {
		New Employee() With {
			.EmployeeName = "Ana Trujillo",
			.EmployeePosition = "CEO"
		},
		New Employee() With {
			.EmployeeName = "Andrew Fuller",
			.EmployeePosition = "Vice President, Sales"
		}
	}
	Private financial As New List(Of Employee)() From {
		New Employee() With {
			.EmployeeName = "Nancy Davolio",
			.EmployeePosition = "Accountant"
		},
		New Employee() With {
			.EmployeeName = "Maria Anders",
			.EmployeePosition = "Accountant"
		}
	}
	Private sales As New List(Of Employee)() From {
		New Employee() With {
			.EmployeeName = "Antonio Moreno",
			.EmployeePosition = "Sales Representative"
		},
		New Employee() With {
			.EmployeeName = "Thomas Hardy",
			.EmployeePosition = "Sales Representative"
		},
		New Employee() With {
			.EmployeeName = "Christina Berglund",
			.EmployeePosition = "Order Administrator"
		},
		New Employee() With {
			.EmployeeName = "Frédérique Citeaux",
			.EmployeePosition = "Marketing Manager"
		},
		New Employee() With {
			.EmployeeName = "Hanna Moos",
			.EmployeePosition = "Sales Representative"
		}
	}
	Public Sub New()
		Me.department = "Management"
	End Sub

	<HighlightedMember>
	Public Sub New(ByVal department As String)
		Me.department = department
	End Sub

	<HighlightedMember>
	Public Iterator Function GetEmployeeList(ByVal recordCount As Integer) As IEnumerable(Of Employee)
		Dim employees As New List(Of Employee)()
		If Me.department = "Management" Then
			employees = Me.management
		End If
		If Me.department = "Financial" Then
			employees = Me.financial
		End If
		If Me.department = "Sales" Then
			employees = Me.sales
		End If
		For Each employee In employees
			Dim tempVar As Boolean = recordCount > 0
			recordCount -= 1
			If tempVar Then
				Yield employee
			End If
		Next employee
	End Function
End Class
