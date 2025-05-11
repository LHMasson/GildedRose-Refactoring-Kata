using Microsoft.Extensions.DependencyInjection;
using GildedRoseKata;
using GildedRoseKata.ItemUpdaters;
using NUnit.Framework;
using System;

namespace GildedRoseTests
{
    public class ItemUpdaterFactoryTests
    {
        private ItemUpdaterFactory _factory;

        [SetUp]
        public void Setup()
        {
            var services = new ServiceCollection();
            services.AddTransient<AgedBrieUpdater>();
            services.AddTransient<BackstagePassesUpdater>();
            services.AddTransient<NormalItemUpdater>();
            services.AddTransient<ConjuredItemUpdater>();
            services.AddTransient<LegendaryItemUpdater>();
            var provider = services.BuildServiceProvider();

            _factory = new ItemUpdaterFactory(provider);
        }

        [TestCase("Aged Brie", typeof(AgedBrieUpdater))]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", typeof(BackstagePassesUpdater))]
        [TestCase("Conjured Mana Cake", typeof(ConjuredItemUpdater))]
        [TestCase("Sulfuras, Hand of Ragnaros", typeof(LegendaryItemUpdater))]
        [TestCase("Elixir of the Mongoose", typeof(NormalItemUpdater))]
        [TestCase("Some Random Item", typeof(NormalItemUpdater))]
        public void GetUpdater_ReturnsCorrectUpdater(string itemName, Type expectedType)
        {
            var item = new Item { Name = itemName, SellIn = 10, Quality = 20 };
            var updater = _factory.GetUpdater(item);
            Assert.That(updater, Is.InstanceOf(expectedType));
        }
    }
}
