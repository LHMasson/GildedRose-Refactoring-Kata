using GildedRoseKata.ItemUpdaters;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests.ItemUpdaters
{
    public class AgedBrieUpdaterTests
    {
        [Test]
        public void IncreasesQuality_WhenUpdated()
        {
            var item = new Item { Name = "Aged Brie", SellIn = 5, Quality = 10 };
            var updater = new AgedBrieUpdater();

            updater.UpdateItem(item);

            Assert.That(item.Quality, Is.EqualTo(11));
        }

        [Test]
        public void QualityDoesNotExceedFifty()
        {
            var item = new Item { Name = "Aged Brie", SellIn = 5, Quality = 50 };
            var updater = new AgedBrieUpdater();

            updater.UpdateItem(item);

            Assert.That(item.Quality, Is.EqualTo(50));
        }
    }
}
