using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueMax.Model
{
    public class Tile
    {
        #region CONSTANTES
        public const int TILE_SIZE = 16;
        #endregion

        #region ATRIBUTOS
        public Point Slice { get; set; }
        #endregion

        #region CONSTRUCTORES
        public Tile() { }

        public Tile(Point slice)
        {
            Slice = slice;
        }
        #endregion

    }
}
