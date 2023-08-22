namespace builder_pattern.Method2;


public interface IEmployeeBuilderM2
{
    void SetFullName(string fullName);
    void SetEmail(string email);
    void SetUserName(string userName);
    EmployeeM2 Build();
}


public abstract class EmployeeBuilderM2: IEmployeeBuilderM2 {
    protected EmployeeM2 Employee {get; set;}

    public EmployeeBuilderM2() => Employee = new EmployeeM2();

    public abstract void SetFullName(string fullName);
    public abstract void SetEmail(string email);
    public abstract void SetUserName(string userName);

    public EmployeeM2 Build() => Employee;

}
