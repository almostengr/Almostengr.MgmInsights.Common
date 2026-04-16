using Almostengr.Common.DomainServices.Resources;

namespace Almostengr.MgmInsights.Common;

public sealed class StreetResource : Resource
{
    public string Name { get; set; }
    public int NeighborhoodId { get; set; }
}