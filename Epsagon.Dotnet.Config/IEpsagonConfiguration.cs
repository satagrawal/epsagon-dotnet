using System;
namespace Epsagon.Dotnet.Config
{
    public interface IEpsagonConfiguration
    {
        string Token { get; }

        string AppName { get; }
        
        bool MetadataOnly { get; }

        bool UseSSL { get; }

        string TraceCollectorURL { get; }
    
        bool IsEpsagonDisabled { get; }
    }
}
