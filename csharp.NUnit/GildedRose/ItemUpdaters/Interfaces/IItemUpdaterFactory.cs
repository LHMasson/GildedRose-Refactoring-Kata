using GildedRoseKata;
using GildedRoseKata.ItemUpdaters.Interfaces;

public interface IItemUpdaterFactory
{
    IItemUpdater GetUpdater(Item item);
}