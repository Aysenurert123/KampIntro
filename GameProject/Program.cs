using GameProject.Concrete.CampaignManager;
using GameProject.Concrete.GamerManager;
using GameProject.Concrete.OrderManager;
using GameProject.Concrete.UserValidationManager;
using GameProject.Entities.Concrete.Campaign;
using GameProject.Entities.Concrete.Gamer;
using GameProject.Entities.Concrete.Product;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer 
            {   Id = 1,
                BirthYear = 2000,
                FirstName="AYŞENUR",
                Lastname="ERTÜRK",
                IdentityNumber= 12345676 
            });

            Console.WriteLine("---------Campaign--------");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign
            {
                CampaignId = 1,
                CampaignName = "Bu ürünü alana ikincisi %20 indirimli",
                CampaignDetail = "Bu Kampanya 2021 Şubat sonuna kadar devam edecektir."
            });
            Console.WriteLine("--------Order-----------");

            OrderManager orderManager = new OrderManager();
            orderManager.Sale(new Product
            {
                ProductId = 1,
                ProductName = "Leauge of Legends",
                UnitPrice = 100,
                Stock = 250
            });

        }
    }
}
