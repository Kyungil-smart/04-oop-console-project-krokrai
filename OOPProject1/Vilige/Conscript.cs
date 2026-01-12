using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Conscript : Unit
{
    public Conscript(string name, int combatRate, int unitCount, int modify, int useHumanResource, int useOre) : base(name,combatRate,unitCount,modify,useHumanResource,useOre)
    {

    }
    public override void Produce(int num)
    {
        if(warehouse.TryUseResource(WareHouse.Resource.HUMANRESOURCES, num * 1) && warehouse.TryUseResource(WareHouse.Resource.ORE, num * 2))
        {
            warehouse.UseResource(WareHouse.Resource.HUMANRESOURCES, num * 1);
            warehouse.UseResource(WareHouse.Resource.HUMANRESOURCES, num * 2);
            unitCount = num * modify;
        }
    }
}
