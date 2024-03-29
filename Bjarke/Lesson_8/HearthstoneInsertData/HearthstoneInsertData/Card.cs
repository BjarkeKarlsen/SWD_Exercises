﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HearthstoneInsertData
{
    public class Card
    {
        public int Id { get; set; }
        public String? Name { get; set; }
        public int ClassId { get; set; }
        public int TypeId { get; set; }
        public int SetId { get; set; }
        public int? SpellSchoolId { get; set; }
        public int RarityId { get; set; }
        public int? Health { get; set; }
        public int? Attack { get; set; }
        public int ManaCost { get; set; }
        public String? Artist { get; set; }
        public String? Text { get; set; }
        public String? FlavorText { get; set; }
    }
}
