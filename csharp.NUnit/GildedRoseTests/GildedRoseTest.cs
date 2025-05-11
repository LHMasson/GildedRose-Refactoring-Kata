using System;
using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseKata.ItemUpdaters;
using NUnit.Framework;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Test]
    public void Foo()
    {
        var items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
        var app = new GildedRose(items, new ItemUpdaterFactory(Program.GetServiceProvider(items)));
        app.UpdateQuality();
        Assert.That(items[0].Name, Is.EqualTo("foo"));
    }
}