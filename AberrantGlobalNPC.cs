using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Aberrant
{
    public class AberrantGlobalNPC : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Dryad)
            {
                shop.item[nextSlot].SetDefaults(ItemID.HerbBag);
                shop.item[nextSlot].value = Item.buyPrice(0, 1, 0, 0);
                nextSlot++;
            }
        }
    }
}