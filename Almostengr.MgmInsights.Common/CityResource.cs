using Almostengr.Common.DomainServices.Resources;

namespace Almostengr.MgmInsights.Common;

public sealed class CityResource : Resource
{
    public string StateProvince { get; set; }
    public string Name { get; set; }
}