using GildedRoseKata.ItemUpdaters.Interfaces;
using GildedRoseKata.Utils;

namespace GildedRoseKata.ItemUpdaters
{
    public class ConjuredItemUpdater : IItemUpdater
    {
        public void UpdateItem(Item item)
        {
            item.SellIn -= 1;
            item.Quality -= item.SellIn < 0 ? 4 : 2;
        }
    }
}
