﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRescueAdventure
{
    public class Planet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Distance { get; set; }
        public List<Astronaut> Astronauts { get; set; }

        
    }
}
