﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRKS.WF.QQBot
{


    public class WMInfo
    {
        public Payload payload { get; set; }
        public Include include { get; set; }
    }

    public class Payload
    {
        public Order[] orders { get; set; }
    }

    public class Order
    {
        public bool visible { get; set; }
        public int quantity { get; set; }
        public User user { get; set; }
        public int platinum { get; set; }
        public DateTime creation_date { get; set; }
        public string region { get; set; }
        public DateTime last_update { get; set; }
        public string order_type { get; set; }
        public string platform { get; set; }
        public string id { get; set; }
    }

    public class User
    {
        public string ingame_name { get; set; }
        public DateTime? last_seen { get; set; }
        public double reputation_bonus { get; set; }
        public float reputation { get; set; }
        public string region { get; set; }
        public string status { get; set; }
        public string id { get; set; }
        public string avatar { get; set; }
    }

    public class Include
    {
        public Item item { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public Items_In_Set[] items_in_set { get; set; }
    }

    public class Items_In_Set
    {
        public int ducats { get; set; }
        public string icon { get; set; }
        public string[] tags { get; set; }
        public string icon_format { get; set; }
        public Ru ru { get; set; }
        public string id { get; set; }
        public bool set_root { get; set; }
        public Fr fr { get; set; }
        public string sub_icon { get; set; }
        public string thumb { get; set; }
        public string url_name { get; set; }
        public Ko ko { get; set; }
        public En en { get; set; }
        public int trading_tax { get; set; }
    }

    public class Ru
    {
        public string description { get; set; }
        public Drop[] drop { get; set; }
        public string item_name { get; set; }
        public string wiki_link { get; set; }
    }

    public class Drop
    {
        public object link { get; set; }
        public string name { get; set; }
    }

    public class Fr
    {
        public string description { get; set; }
        public Drop1[] drop { get; set; }
        public string item_name { get; set; }
        public string codex { get; set; }
        public string wiki_link { get; set; }
    }

    public class Drop1
    {
        public object link { get; set; }
        public string name { get; set; }
    }

    public class Ko
    {
        public string description { get; set; }
        public Drop2[] drop { get; set; }
        public string item_name { get; set; }
        public string codex { get; set; }
        public string wiki_link { get; set; }
    }

    public class Drop2
    {
        public object link { get; set; }
        public string name { get; set; }
    }

    public class En
    {
        public string description { get; set; }
        public Drop3[] drop { get; set; }
        public string item_name { get; set; }
        public string codex { get; set; }
        public string wiki_link { get; set; }
    }

    public class Drop3
    {
        public object link { get; set; }
        public string name { get; set; }
    }


    public class VoidTrader
    {
        public string id { get; set; }
        public DateTime activation { get; set; }
        public DateTime expiry { get; set; }
        public string character { get; set; }
        public string location { get; set; }
        public Inventory[] inventory { get; set; }
        public string psId { get; set; }
        public bool active { get; set; }
        public string startString { get; set; }
        public string endString { get; set; }
    }

    public class Inventory
    {
        public string item { get; set; }
        public int ducats { get; set; }
        public int credits { get; set; }
    }


    public class WFApi
    {
        public Dict[] Dict { get; set; }
        public Sale[] Sale { get; set; }
        public Alert[] Alert { get; set; }
        public Invasion[] Invasion { get; set; }
        public Riven[] Riven { get; set; }
        public Statuscode[] StatusCode { get; set; }
        public Relic[] Relic { get; set; }
    }

    public class Dict
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Zh { get; set; }
        public string En { get; set; }
    }

    public class Sale
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Search { get; set; }
        public string Zh { get; set; }
        public string En { get; set; }
    }

    public class Alert
    {
        public int Id { get; set; }
        public string Zh { get; set; }
        public string En { get; set; }
    }

    public class Invasion
    {
        public int Id { get; set; }
        public string Zh { get; set; }
        public string En { get; set; }
    }

    public class Riven
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }
        public float Ratio { get; set; }
    }

    public class Statuscode
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Zh { get; set; }
        public string En { get; set; }
    }

    public class Relic
    {
        public int Id { get; set; }
        public string Tier { get; set; }
        public string RelicName { get; set; }
        public string Rewards { get; set; }
        public string Name { get; set; }
    }

    public class Sortie
    {
        public string id { get; set; }
        public DateTime activation { get; set; }
        public DateTime expiry { get; set; }
        public string rewardPool { get; set; }
        public Variant[] variants { get; set; }
        public string boss { get; set; }
        public string faction { get; set; }
        public bool expired { get; set; }
        public string eta { get; set; }
    }

    public class Variant
    {
        public string boss { get; set; }
        public string planet { get; set; }
        public string missionType { get; set; }
        public string modifier { get; set; }
        public string modifierDescription { get; set; }
        public string node { get; set; }
    }
    public class CetusCycle
    {
        public string ID { get; set; }
        public DateTime Expiry { get; set; }
        public bool IsDay { get; set; }
        public string TimeLeft { get; set; }
        public bool IsCetus { get; set; }
        public string ShortString { get; set; }
    }



    /*
    public class WFAlerts // 某个好朋友让我改成大写，好习惯
    {
        public string Id { get; set; }
        public DateTime Activation { get; set; }
        public DateTime Expiry { get; set; }
        public Mission Mission { get; set; }
        public bool Expired { get; set; }
        public string Eta { get; set; }
        public string[] RewardTypes { get; set; }
        public DateTime GetRealTime()
        {
            return Expiry + TimeSpan.FromHours(8);
        }
    }

    public class Mission
    {
        public string Description { get; set; }
        public string Node { get; set; }
        public string Type { get; set; }
        public string Faction { get; set; }
        public Reward Reward { get; set; }
        public int MinEnemyLevel { get; set; }
        public int MaxEnemyLevel { get; set; }
        public bool Nightmare { get; set; }
        public bool ArchwingRequired { get; set; }
        public int MaxWaveNum { get; set; }
    }

    public class Reward
    {
        public string[] Items { get; set; }
        public CountedItem[] CountedItems { get; set; }
        public int Credits { get; set; }
        public string AsString { get; set; }
        public string ItemString { get; set; }
        public string Thumbnail { get; set; }
        public int Color { get; set; }
    }

    public class CountedItem
    {
        public int Count { get; set; }
        public string Type { get; set; }
    }
    */
}
