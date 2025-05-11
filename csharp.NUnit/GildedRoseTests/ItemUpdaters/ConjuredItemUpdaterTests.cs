using GildedRoseKata.ItemUpdaters;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests.ItemUpdaters
{
    public class NormalItemUpdaterTests
    {
        [Test]
        public void DecreasesQualityByOne_BeforeSellDate()
        {
            var item = new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 10 };
            var updater = new NormalItemUpdater();

            updater.UpdateItem(item);

            Assert.That(item.Quality, Is.EqualTo(9));
        }

        [Test]
        public void DecreasesQualityByTwo_AfterSellDate()
        {
            var item = new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 10 };
            var updater = new NormalItemUpdater();

            updater.UpdateItem(item);

            Assert.That(item.Quality, Is.EqualTo(8));
        }
    }
}
