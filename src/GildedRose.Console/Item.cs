﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Console
{
    public class Item
    {

        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }

        public IList<Item> Items;
        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].Quality > 0 && Items[i].Name != "Sulfuras, Hand of Ragnaros")
                    {
                        Items[i].Quality--;
                    }
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality++;

                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].SellIn < 11 && Items[i].Quality < 50)
                            {
                                Items[i].Quality++;
                            }

                            if (Items[i].SellIn < 6 && Items[i].Quality < 50)
                            {
                                Items[i].Quality++;
                            }
                        }
                    }
                }

                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn--;
                }

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != "Aged Brie")
                    {
                        if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].Quality > 0 && Items[i].Name != "Sulfuras, Hand of Ragnaros")
                            {
                                Items[i].Quality--;
                            }
                        }
                        else
                        {
                            Items[i].Quality -= Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality++;
                        }
                    }
                }
            }
        }
        public IList<Item> GetItem()
        {


            Items = new List<Item>
                                          {
                                              new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                                              new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                                              new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                                              new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                                              new Item {Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 15, Quality = 20 },
                                              new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                                          };
            return Items;
        }
    }
}

