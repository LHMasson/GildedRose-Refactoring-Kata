using GildedRoseKata.ItemUpdaters;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests.ItemUpdaters
{
    public class BackstagePassesUpdaterTests
    {
        [TestCase(11, 10, 11)]
        [TestCase(10, 10, 12)]
        [TestCase(5, 10, 13)]
        [TestCase(0, 10, 0)]
        public void QualityChangesAsExpected(int sellIn, int initialQuality, int expectedQuality)
        {
            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = initialQuality };
            var updater = new BackstagePassesUpdater();

            updater.UpdateItem(item);

            Assert.That(item.Quality, Is.EqualTo(expectedQuality));
        }
    }
}
