using GildedRoseKata.ItemUpdaters.Interfaces;
using GildedRoseKata.Utils;

namespace GildedRoseKata.ItemUpdaters
{
    public class NormalItemUpdater : IItemUpdater
    {
        public void UpdateItem(Item item)
        {
            item.SellIn -= 1;
            item.Quality -= item.SellIn < 0 ? 2 : 1;
        }
    }
}
