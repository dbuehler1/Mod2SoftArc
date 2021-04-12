using System;
using System.Collections;


public class HrPerson {

    private ArrayList employees = new ArrayList();

    public HrPerson() {

    }

    public void hireEmployee(String firstName, String lastName, String ssn) {
        Employee e = new Employee(firstName, lastName, ssn);
        employees.Add(e);
        orientEmployee(e);
    }

    
    private void orientEmployee(Employee emp) {
        emp.doFirstTimeOrientation("B101");
    }

    public void outputReport(String ssn) {

        foreach (Employee emp in employees) {
            if (emp.getSsn().Equals(ssn)) {
                if (emp.hasMetWithHr() && emp.hasMetDeptStaff()
                        && emp.hasReviewedDeptPolicies() && emp.hasMovedIn()) {
                    emp.printReport();
                }
                break;
            }
        }
    }

}