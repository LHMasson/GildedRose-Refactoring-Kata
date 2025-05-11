using GildedRoseKata.Utils;
using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose(IList<Item> items, IItemUpdaterFactory factory)
{
    public void UpdateQuality()
    {
        foreach (var item in items)
        {
            var updater = factory.GetUpdater(item);
            updater.UpdateItem(item);
            QualityHelper.CheckQualityBounds(item);
        }
    }
}
