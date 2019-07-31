﻿using System;
using System.Collections.Generic;

namespace SamuraiApp.Domain
{
    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; } = new List<Quote>();
        // public int BattleId { get; set; }
        public List<SamuraiBattle> SamuraiBattles { get; set; }
        public SecretIdentity SecretIdentity { get; set; }
    }
}
