using GildedRoseKata.ItemUpdaters.Interfaces;

namespace GildedRoseKata.ItemUpdaters
{
    public class AgedBrieUpdater : IItemUpdater
    {
        public void UpdateItem(Item item)
        {
            item.SellIn -= 1;
            if (item.Quality < 50)
            {
                item.Quality += item.SellIn < 0 ? 2 : 1;
            }
        }
    }
}
