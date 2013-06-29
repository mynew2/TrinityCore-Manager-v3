﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCore_Manager.Database.Enums;

namespace TrinityCore_Manager.Database.Classes
{
    public class TCCharacter
    {

        public int Guid { get; set; }
        public int Account { get; set; }
        public string Name { get; set; }
        public CharacterRace Race { get; set; }
        public CharacterClass Class { get;  set; }

    }
}