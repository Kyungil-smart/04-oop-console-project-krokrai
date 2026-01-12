using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Knight : Unit
{
    public Knight(string _name, int _combatRate, int _unitCount, int _modify, int _useHumanResoutce, int _useOre) : base(_name, _combatRate, _unitCount, _modify, _useHumanResoutce, _useOre)
    {
    }

    public override void Produce(int num)
    {
        if (warehouse.TryUseResource(WareHouse.Resource.HUMANRESOURCES, num * useHumanResource) && warehouse.TryUseResource(WareHouse.Resource.ORE, num * useOre))
        {
            warehouse.UseResource(WareHouse.Resource.HUMANRESOURCES, num * useHumanResource);
            warehouse.UseResource(WareHouse.Resource.HUMANRESOURCES, num * useOre);
            unitCount =  num * modify;
        }
    }
}
