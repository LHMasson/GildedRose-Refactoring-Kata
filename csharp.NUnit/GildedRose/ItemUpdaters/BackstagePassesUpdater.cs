using GildedRoseKata.ItemUpdaters.Interfaces;

namespace GildedRoseKata.ItemUpdaters
{
    public class BackstagePassesUpdater : IItemUpdater
    {
        public void UpdateItem(Item item)
        {
            item.SellIn -= 1;
            if (item.SellIn < 0)
            {
                item.Quality = 0;
                return;
            }

            if (item.SellIn < 5)
            {
                item.Quality += 3;
            }
            else if (item.SellIn < 10)
            {
                item.Quality += 2;
            }
            else
            {
                item.Quality += 1;
            }
        }
    }
}
