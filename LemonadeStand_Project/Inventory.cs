using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Inventory
    {
        public List<Lemon> inventoryLemon = new List<Lemon>();
        public int inventoryLemonCount;

        public List<Sugar> inventorySugar = new List<Sugar>();
        public int inventorySugarCount;

        public List<Ice> inventoryIce = new List<Ice>();
        public int inventoryIceCount;

        public List<Cups> inventoryCups = new List<Cups>();
        public int inventoryCupsCount;

        int lemonsInPitcher = 1;
        int sugarInPitcher = 1;
        int iceInPitcher = 3;
        int cupsInPitcher = 6;

        public Inventory()
        {
            this.inventoryLemonCount = 0;
            this.inventorySugarCount = 0;
            this.inventoryIceCount = 0;
            this.inventoryCupsCount = 0;
        }
        public int GetLemonCount()
        {
            return inventoryLemonCount = inventoryLemon.Count;
        }
        public int GetSugarCount()
        {
            return inventorySugarCount = inventorySugar.Count;
        }
        public int GetIceCount()
        {
            return inventoryIceCount = inventoryIce.Count;
        }
        public int GetCupsCount()
        {
            return inventoryCupsCount = inventoryCups.Count;
        }
        public void UpdateInventory()
        {
            inventoryLemonCount -= 1;
            inventorySugarCount -= 1;
            inventoryIceCount -= 3;
            inventoryCupsCount -= 6;
            RemoveItemsFromList();
        }
        public void RemoveItemsFromList()
        {
            for (int i = 0; i < lemonsInPitcher; i++)
            {
                inventoryLemon.RemoveAt(0);
            }
            for (int i = 0; i < sugarInPitcher; i++)
            {
                inventorySugar.RemoveAt(0);
            }
            for (int i = 0; i < iceInPitcher; i++)
            {
                inventoryIce.RemoveAt(0);
            }
            for (int i = 0; i < cupsInPitcher; i++)
            {
                inventoryCups.RemoveAt(0);
            }
        }
    }
}
