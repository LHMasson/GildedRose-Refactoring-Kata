namespace GildedRoseKata.Utils
{
    internal class QualityHelper
    {
        public static void CheckQualityBounds(Item item)
        {
            if (ItemTypeHelper.IsLegendary(item))
            {
                return;
            }
            if (item.Quality < 0)
            {
                item.Quality = 0;
            }
            else if (item.Quality > 50)
            {
                item.Quality = 50;
            }
        }
    }
}
