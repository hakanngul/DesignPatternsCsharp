namespace builder_pattern.Method2;

public class ExternalEmployeeBuilder : EmployeeBuilderM2
{
    public override void SetEmail(string email)
    {
        throw new NotImplementedException();
    }

    public override void SetFullName(string fullName)
    {
        throw new NotImplementedException();
    }

    public override void SetUserName(string userName)
    {
        throw new NotImplementedException();
    }
}
