using System;
public class Employee {

    
    private const String REQUIRED_MSG = " is mandatory ";
    private const String NEWLINE = "\n";

    private String firstName;
    private String lastName;
    private String ssn;
    private bool metWithHr;
    private bool metDeptStaff;
    private bool reviewedDeptPolicies;
    private bool movedIn;
    private String cubeId;
    private DateTime orientationDate;
    private EmployeeReportService reportService = new EmployeeReportService();

    
    public Employee(String firstName, String lastName, String ssn) {
        setFirstName(firstName);
        setLastName(lastName);
        setSsn(ssn);
    }

    
    private String getFormattedDate() {
        
        return orientationDate.ToString("M/d/yy");
        
    }

    
    public void doFirstTimeOrientation(String cubeId) {
        orientationDate = DateTime.Now;
        meetWithHrForBenefitAndSalaryInfo();
        meetDepartmentStaff();
        reviewDeptPolicies();
        moveIntoCubicle(cubeId);
    }

    
    private void meetWithHrForBenefitAndSalaryInfo() {
        metWithHr = true;
        reportService.addData(firstName + " " + lastName + " met with HR on "
                + getFormattedDate() + NEWLINE);
    }

    
    private void meetDepartmentStaff() {
        metDeptStaff = true;
        reportService.addData(firstName + " " + lastName + " met with dept staff on "
                + getFormattedDate() + NEWLINE);
    }

        public void reviewDeptPolicies() {
        reviewedDeptPolicies = true;
        reportService.addData(firstName + " " + lastName + " reviewed dept policies on "
                + getFormattedDate() + NEWLINE);
    }

    
    public void moveIntoCubicle(String cubeId) {
        setCubeId(cubeId);

        this.movedIn = true;
        reportService.addData(firstName + " " + lastName + " moved into cubicle "
                + cubeId + " on " + getFormattedDate() + NEWLINE);
    }

    public String getFirstName() {
        return firstName;
    }

    
    public void setFirstName(String firstName) {
        if (firstName == null || firstName.Equals("")) {
            throw new ArgumentException("first name" + REQUIRED_MSG);
        }
        this.firstName = firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        if (lastName == null || lastName.Equals("")) {
            throw new ArgumentException("last name" + REQUIRED_MSG);
        }
        this.lastName = lastName;
    }

    public String getSsn() {
        return ssn;
    }

    public void setSsn(String ssn) {
        if (ssn == null || ssn.Length < 9 || ssn.Length > 11) {
            throw new ArgumentException("ssn" + REQUIRED_MSG + "and must be between 9 and 11 characters (if hyphens are used)");
        }
        this.ssn = ssn;
    }

    public bool hasMetWithHr() {
        return metWithHr;
    }

    
    public void setMetWithHr(bool metWithHr) {
        this.metWithHr = metWithHr;
    }

    public bool hasMetDeptStaff() {
        return metDeptStaff;
    }

    public void setMetDeptStaff(bool metDeptStaff) {
        this.metDeptStaff = metDeptStaff;
    }

    public bool hasReviewedDeptPolicies() {
        return reviewedDeptPolicies;
    }

    public void setReviewedDeptPolicies(bool reviewedDeptPolicies) {
        this.reviewedDeptPolicies = reviewedDeptPolicies;
    }

    public bool hasMovedIn() {
        return movedIn;
    }

    public void setMovedIn(bool movedIn) {
        this.movedIn = movedIn;
    }

    public String getCubeId() {
        return cubeId;
    }

    public void setCubeId(String cubeId) {
        if (cubeId == null || cubeId.Equals("")) {
            throw new ArgumentException("cube id" + REQUIRED_MSG);
        }
        this.cubeId = cubeId;
    }

    public DateTime getOrientationDate() {
        return orientationDate;
    }

    public void setOrientationDate(DateTime orientationDate) {
        if (orientationDate == null) {
            throw new ArgumentException("orientationDate" + REQUIRED_MSG);
        }
        this.orientationDate = orientationDate;
    }

    public void printReport() {
        reportService.outputReport();
    }

   
    public String toString() {
        return "Employee{" + "firstName=" + firstName + ", lastName=" + lastName + ", ssn=" + ssn + '}';
    }

}