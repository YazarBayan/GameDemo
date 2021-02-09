using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class Campaign:ICampaign
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public double CampaignDiscount { get; set; }
        public string CampaignDate { get; set; }
    }
}
