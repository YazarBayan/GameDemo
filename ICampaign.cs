using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public interface ICampaign
    {
        int CampaignId { get; set; }
        string CampaignName { get; set; }
        double CampaignDiscount { get; set; }
        string CampaignDate { get; set; }
    }
}
