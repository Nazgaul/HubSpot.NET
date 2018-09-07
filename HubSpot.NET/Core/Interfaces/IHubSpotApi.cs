﻿using HubSpot.NET.Api.Deal.Dto;

namespace HubSpot.NET.Core.Interfaces
{
    public interface IHubSpotApi
    {
        IHubSpotCompanyApi Company { get; }
        IHubSpotContactApi Contact { get; }
        IHubSpotDealApi<DealHubSpotModel> Deal { get; }
        IHubSpotEngagementApi Engagement { get; }
        IHubSpotCosFileApi File { get; }
        IHubSpotOwnerApi Owner { get; }
        IHubSpotCompanyPropertiesApi CompanyProperties { get; }
        IHubSpotEmailSubscriptionsApi EmailSubscriptions { get; }
    }
}