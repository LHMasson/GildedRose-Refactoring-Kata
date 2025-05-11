using GildedRoseKata;

public static class ItemTypeHelper
{
    public static bool IsLegendary(Item item)
    {
        return item.Name == "Sulfuras, Hand of Ragnaros";
    }

    public static bool IsLegendary(string ItemName)
    {
        return ItemName == "Sulfuras, Hand of Ragnaros";
    }

    public static bool IsConjured(Item item)
    {
        return item.Name.Contains("Conjured");
    }

    public static bool IsConjured(string ItemName)
    {
        return ItemName.Contains("Conjured");
    }

    public static bool IsAgedBrie(Item item)
    {
        return item.Name == "Aged Brie";
    }

    public static bool IsAgedBrie(string ItemName)
    {
        return ItemName == "Aged Brie";
    }

    public static bool IsBackstagePass(Item item)
    {
        return item.Name.Contains("Backstage passes");
    }

    public static bool IsBackstagePass(string ItemName)
    {
        return ItemName.Contains("Backstage passes");
    }

}
