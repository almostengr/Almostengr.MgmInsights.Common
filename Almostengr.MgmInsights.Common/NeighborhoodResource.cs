using Almostengr.Common.DomainServices.Resources;

namespace Almostengr.MgmInsights.Common;

public sealed class NeighborhoodResource : Resource
{
    public string Name { get; set; }
    public int CityId { get; set; }
}