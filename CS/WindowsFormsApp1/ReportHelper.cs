using DevExpress.ReportServer.ServiceModel.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System.Drawing;
using DevExpress.DataAccess.ObjectBinding;

namespace WindowsFormsApp1 {
    public static class ReportHelper {
        public static XtraReport CreateReport() {
            var departments = new StaticListLookUpSettings();
            departments.LookUpValues.AddRange(new[]{
                new LookUpValue("Management", "Management"),
                new LookUpValue("Financial", "Financial"),
                new LookUpValue("Sales", "Sales")});

            XtraReport report = new XtraReport() {
                Parameters = {
                    new DevExpress.XtraReports.Parameters.Parameter() {
                        Name = "pDepartment",
                        Type = typeof(System.String),
                        ValueSourceSettings = departments,
                        Description = "Department",
                        Value = "Management"
                    },
                    new DevExpress.XtraReports.Parameters.Parameter() {
                        Name = "NumberOfRecords",
                        Type = typeof(System.Int32),
                        Value = 2
                    }
                },
                Bands = {
                    new DetailBand(){
                        HeightF = 25,
                        Controls = {
                            new XRLabel() {
                                Name = "EmployeeName",
                                BoundsF = new RectangleF(0, 0, 200, 25),
                                ExpressionBindings =
                                {
                                    new ExpressionBinding("Text", "[Name]")
                                }
                            },
                            new XRLabel() {
                                Name = "EmployeePosition",
                                BoundsF = new RectangleF(200, 0, 150, 25),
                                ExpressionBindings = {
                                    new ExpressionBinding("Text", "[Position]")
                                }
                            }
                        }
                    }
                }
            };
            ObjectDataSource objectDataSource = new ObjectDataSource();
            objectDataSource.Name = "Employees";
            objectDataSource.DataSource = typeof(EmployeeDataSource);
            objectDataSource.BeginUpdate();
            objectDataSource.DataMember = "GetEmployeeList";
            var parameterNumberOfRecords = new DevExpress.DataAccess.ObjectBinding.Parameter() {
                Name = "recordCount",
                Type = typeof(DevExpress.DataAccess.Expression),
                Value = new DevExpress.DataAccess.Expression("?NumberOfRecords", typeof(int))
            };
            objectDataSource.Parameters.Add(parameterNumberOfRecords);
            var parameterDepartment = new DevExpress.DataAccess.ObjectBinding.Parameter() {
                Name = "department",
                Type = typeof(DevExpress.DataAccess.Expression),
                Value = new DevExpress.DataAccess.Expression("?pDepartment", typeof(string))
            };
            objectDataSource.Constructor = new ObjectConstructorInfo(parameterDepartment);
            objectDataSource.EndUpdate();
            objectDataSource.Fill();
            report.DataSource = objectDataSource;

            return report;
        }
    }
}
