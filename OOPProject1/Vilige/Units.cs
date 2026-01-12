using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


abstract class Unit
{
    public string name { get; protected set; }
    public int combatRate { get; protected set; }
    public int unitCount { get; protected set; }
    public int modify { get; protected set; }
    public int useHumanResource{ get; protected set; }
    public int useOre { get; protected set; }

    protected WareHouse warehouse = new WareHouse();

    protected Unit(string _name, int _combatRate, int _unitCount, int _modify, int _useHumanResoutce, int _useOre)
    {
        name = _name;
        combatRate = _combatRate;
        unitCount = _unitCount;
        modify = _modify;
        useHumanResource = _useHumanResoutce;
        useOre = _useOre;
    }

    public abstract void Produce(int num);

}
