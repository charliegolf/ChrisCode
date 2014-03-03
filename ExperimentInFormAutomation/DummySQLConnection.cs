using System;

public class DummyConnection : IsearchForServers
{
    public string findServers()
    {
     string SqlConnection = "Server= localhost, Authentication=Windows Authentication, Database= employeedetails";
        {
            return SqlConnection;
        }
    }
}
