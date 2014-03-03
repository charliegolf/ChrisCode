using System;

public interface IsearchForServers
{
	public IsearchForServers()
	{
        IEnumerable<string> findServers();
        void SelectServer(server);    
    }
}
