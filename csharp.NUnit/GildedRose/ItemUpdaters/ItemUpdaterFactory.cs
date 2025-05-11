using GildedRoseKata.ItemUpdaters.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GildedRoseKata.ItemUpdaters
{
    public class ItemUpdaterFactory : IItemUpdaterFactory
    {
        private readonly IServiceProvider _provider;

        public ItemUpdaterFactory(IServiceProvider provider)
        {
            _provider = provider;
        }

        public IItemUpdater GetUpdater(Item item)
        {
            if (ItemTypeHelper.IsConjured(item))
                return _provider.GetRequiredService<ConjuredItemUpdater>();

            if (ItemTypeHelper.IsAgedBrie(item))
                return _provider.GetRequiredService<AgedBrieUpdater>();

            if (ItemTypeHelper.IsBackstagePass(item))
                return _provider.GetRequiredService<BackstagePassesUpdater>();

            if (ItemTypeHelper.IsLegendary(item))
                return _provider.GetRequiredService<LegendaryItemUpdater>();

            return _provider.GetRequiredService<NormalItemUpdater>();
        }
    }
}
