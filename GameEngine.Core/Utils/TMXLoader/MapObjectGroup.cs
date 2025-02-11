﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Core.Utils.TMXLoader
{
    public class MapObjectGroup
    {
        public int Id {  get; set; }
        public string Name { get; set; }

        public List<MapObject> Objects { get; set; }

        public MapObjectGroup(int id, string name, List<MapObject> objects)
        {
            Id = id;
            Name = name;
            Objects = new List<MapObject>();
            Objects.AddRange(objects);
        }
    }
}
