﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Core.Utils.TMXLoader
{
    public class MapLayer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        public int[] TileIds { get; set; }

        public MapLayer(int id, string name, int width, int height, int[] tileIds)
        {
            Id = id;
            Name = name;
            Width = width;
            Height = height;
            TileIds = tileIds;
        }
    }
}
