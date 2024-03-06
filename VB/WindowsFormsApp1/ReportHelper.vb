Imports DevExpress.ReportServer.ServiceModel.DataContracts
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraReports.UI
Imports System.Drawing
Imports DevExpress.DataAccess.ObjectBinding

Namespace WindowsFormsApp1
    Public Module ReportHelper
        Public Function CreateReport() As XtraReport

            Dim departments = New StaticListLookUpSettings()
            departments.LookUpValues.AddRange({
                                              New LookUpValue("Management", "Management"),
                                              New LookUpValue("Financial", "Financial"),
                                              New LookUpValue("Sales", "Sales")
                                              })
            Dim report = New XtraReport()
            Dim band = New DetailBand() With {.HeightF = 25}
            Dim label1 = New XRLabel() With {
                .Name = "EmployeeName",
                .BoundsF = New RectangleF(0, 0, 200, 25)}
            Dim label2 = New XRLabel() With {
                .Name = "EmployeePosition",
                .BoundsF = New RectangleF(200, 0, 150, 25)}
            label1.ExpressionBindings.Add(New ExpressionBinding("Text", "[EmployeeName]"))
            label2.ExpressionBindings.Add(New ExpressionBinding("Text", "[EmployeePosition]"))
            band.Controls.AddRange(New XRControl() {label1, label2})
            report.Bands.Add(band)
            Dim param1 = New DevExpress.XtraReports.Parameters.Parameter() With {
                .Name = "pDepartment",
                .Type = GetType(System.String),
                .ValueSourceSettings = departments,
                .Description = "Department",
                .Value = "Management"}
            Dim param2 = New DevExpress.XtraReports.Parameters.Parameter() With {
                .Name = "NumberOfRecords",
                .Type = GetType(System.Int32),
                .Value = 2}
            report.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {param1, param2})

            Dim objectDataSource1 As New ObjectDataSource()
            objectDataSource1.Name = "Employees"
            objectDataSource1.DataSource = GetType(EmployeeDataSource)
            objectDataSource1.BeginUpdate()
            objectDataSource1.DataMember = "GetEmployeeList"
            Dim parameterNumberOfRecords = New DevExpress.DataAccess.ObjectBinding.Parameter() With {
                .Name = "recordCount",
                .Type = GetType(DevExpress.DataAccess.Expression),
                .Value = New DevExpress.DataAccess.Expression("?NumberOfRecords", GetType(Integer))}
            objectDataSource1.Parameters.Add(parameterNumberOfRecords)
            Dim parameterDepartment = New DevExpress.DataAccess.ObjectBinding.Parameter() With {
                .Name = "department",
                .Type = GetType(DevExpress.DataAccess.Expression),
                .Value = New DevExpress.DataAccess.Expression("?pDepartment", GetType(String))}
            objectDataSource1.Constructor = New ObjectConstructorInfo(parameterDepartment)
            objectDataSource1.EndUpdate()
            objectDataSource1.Fill()
            report.DataSource = objectDataSource1

            Return report
        End Function
    End Module
End Namespace
