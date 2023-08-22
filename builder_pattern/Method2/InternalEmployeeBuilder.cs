namespace builder_pattern.Method2;

public class InternalEmployeeBuilder : EmployeeBuilderM2
{
    public override void SetEmail(string email)
    {
        //ends with @company.com
        var arr = email.Split('@');
        Employee.EmailAddress = $"{arr[0]}@company.com";
    }

    public override void SetFullName(string fullName)
    {
        var arr = fullName.Split(new char[] {' ', '_', '.'});
        Employee.FirstName = arr[0];
        Employee.LastName = arr[1];
    }

    public override void SetUserName(string userName)
    {
        throw new NotImplementedException();
    }
}
