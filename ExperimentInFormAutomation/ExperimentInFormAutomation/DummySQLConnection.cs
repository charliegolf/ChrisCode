using ExperimentInFormAutomation;
using System;
using System.Collections.Generic;

public class DummyConnection : ISearchForServers
{
    public IEnumerable<string>  findServers()
    {
    IEnumerable<string> dummyData = new string[]{"LocalHost", "Dummy Line 1", "Dummy Line 2"};
    return dummyData;
    }
}
