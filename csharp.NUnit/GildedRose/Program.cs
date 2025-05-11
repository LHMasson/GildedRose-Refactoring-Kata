﻿using GildedRoseKata.ItemUpdaters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace GildedRoseKata;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        IList<Item> items = new List<Item>
        {
            new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
            new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
            new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
            new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 15,
                Quality = 20
            },
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 10,
                Quality = 49
            },
            new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 5,
                Quality = 49
            },
            // this conjured item does not work properly yet
            new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
        };

        var serviceProvider = new ServiceCollection()
           .AddSingleton(items)
           .AddTransient<GildedRose>()
           .AddTransient<AgedBrieUpdater>()
           .AddTransient<BackstagePassesUpdater>()
           .AddTransient<NormalItemUpdater>()
           .AddTransient<ConjuredItemUpdater>()
           .AddTransient<LegendaryItemUpdater>()
           .AddSingleton<IItemUpdaterFactory, ItemUpdaterFactory>()
           .BuildServiceProvider();

        var app = serviceProvider.GetRequiredService<GildedRose>();

        int days = 2;
        if (args.Length > 0)
        {
            days = int.Parse(args[0]) + 1;
        }

        for (var i = 0; i < days; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
            for (var j = 0; j < items.Count; j++)
            {
                Console.WriteLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
            }
            Console.WriteLine("");
            app.UpdateQuality();
        }
    }

    public static IServiceProvider GetServiceProvider(List<Item> items)
    {
        return new ServiceCollection()
            .AddSingleton(items)
            .AddTransient<GildedRose>()
            .AddTransient<AgedBrieUpdater>()
            .AddTransient<BackstagePassesUpdater>()
            .AddTransient<NormalItemUpdater>()
            .AddTransient<ConjuredItemUpdater>()
            .AddSingleton<IItemUpdaterFactory, ItemUpdaterFactory>()
            .BuildServiceProvider();
    }
}