using System.Reflection.Emit;



using builder_pattern.Applications;
using builder_pattern.Method2;

var eb = new EndPointBuilder("https://localhost");

eb
.Append("api")
.Append("v1")
.Append("user")
.AppendParam("id", "1")
.AppendParam("name", "John");

var url = eb.Build();

var empBuilder = new EmployeeBuilderM1();


var employee = empBuilder
.SetFullName("Hakan GÜL")
.SetUserName("Panzoras")
.SetEmail("hakanngul@icloud.com")
.Build();



IEmployeeBuilderM2 employeeBuilder = new InternalEmployeeBuilder();
employeeBuilder.SetFullName("Hakan GÜL");
employeeBuilder.SetEmail("hakanngul@icloud.com");

var empp = employeeBuilder.Build();

System.Console.WriteLine("Email Address: " + empp.EmailAddress);
