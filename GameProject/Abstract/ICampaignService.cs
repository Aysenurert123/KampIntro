using GameProject.Entities.Concrete.Campaign;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract.ICampaignService
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
