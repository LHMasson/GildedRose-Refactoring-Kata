using GildedRoseKata.ItemUpdaters;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests.ItemUpdaters
{
    public class LegendaryItemUpdaterTests
    {
        [Test]
        public void DoesNotChangeQuality()
        {
            var item = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 };
            var updater = new LegendaryItemUpdater();

            updater.UpdateItem(item);

            Assert.That(item.Quality, Is.EqualTo(80));
        }

        [Test]
        public void DoesNotChangeSellIn()
        {
            var item = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 };
            var updater = new LegendaryItemUpdater();
            updater.UpdateItem(item);
            Assert.That(item.SellIn, Is.EqualTo(0));
        }
    }
}
