using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace HeavenlyAscension.Tiles.Rocks
{
    public class ChalkTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBlockLight[Type] = false;
            drop = mod.ItemType("Chalk");
            AddMapEntry(new Color(237, 237, 237));
            minPick = 30;
        }
    }
}