using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueMax.Model
{
    public enum GroundType
    {
        Void,
        Dust,
        Soil,
        Cement,
        Wood,
        Stone
    }

    public class Ground : Tile
    {
        #region ATRIBUTOS
        public int Friction { get; set; } = 1;

        public bool IsBlocked { get; set; } = false;
        #endregion

        #region CONSTRUCTORES
        public Ground(GroundType type)
        {
            Slice = new Point(0, (int)type * TILE_SIZE);
        }
        #endregion

    }
}
