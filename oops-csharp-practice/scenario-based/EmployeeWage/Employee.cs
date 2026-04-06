namespace EmployeeWage;
using System;

public class Employee
{
  //employee id,name
    private int EmployeeId { get; set; }
    private string EmployeeName { get; set; }
   
    public int TotalWorkingDays { get; set; }
    public int TotalWorkingHours { get; set; }
    public int TotalWage { get; set; }
      public Employee(int employeeId,string empName)
    {
        EmployeeId = employeeId;
        EmployeeName=empName;
    }

    public override string ToString()
    {
        return $"Employee Id: {EmployeeId}, Employee Name: {EmployeeName}, Total Working Days: {TotalWorkingDays}, Total Working Hours: {TotalWorkingHours}, Total Wage: {TotalWage}";
    }
}




   

