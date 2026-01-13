using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Structure
{
    public enum Building
    { 
        FRAM, LUMBERCAMP, QUARRY, MINE, LABORATORY, ARMY, CASTLE, EXPEDITION, MARKET
    }

    public Structure()
    {
        Init();
    }

    // 나 무  석 재  금 화  인 력
    public List<(int, int, int, int)> list = new List<(int, int, int, int)>();
    public List<(int)> structure = new List<(int, )> ();

    WareHouse warehouse  = new WareHouse();
    public int fram { get; private set; }
    public int lumberCamp { get; private set; }
    public int quarry { get; private set; }
    public int mine {get; private set;}
    public int laboratory { get; private set; }
    public int army { get; private set; }
    public int castle { get; private set; }
    public int expedition { get; private set; }
    public int market { get; private set; }

    public void Init()
    {
        list.Add((5, 0, 5, 5)); // 농장
        list.Add((5, 0, 10, 5)); // 벌목장
        list.Add((10, 0, 10, 10)); // 채석장
        list.Add((10, 5, 10, 10)); // 광산
        list.Add((5, 5, 5, 5)); // 시장
        list.Add((10, 10, 30, 5)); // 연구소
        list.Add((15, 15, 20, 10)); // 군부대
        list.Add((10, 10, 30, 5)); // 성
        list.Add((30, 30, 30, 5)); // 탐험대
    }

    public void totale()
    {
        
    }
    
    public void Construction(Building building)
    {
        switch(building)
        { 
            case Building.FRAM:
                if (isConstruction((int)Building.FRAM)) fram++;
                break;
            case Building.LUMBERCAMP:
                if (isConstruction((int)Building.LUMBERCAMP)) lumberCamp++;
                break;
            case Building.QUARRY:
                if (isConstruction((int)Building.QUARRY)) quarry++;
                break;
            case Building.MINE:
                if (isConstruction((int)Building.MINE)) mine++;
                break;
            case Building.LABORATORY:
                if (isConstruction((int)Building.LABORATORY)) laboratory++;
                break;
            case Building.ARMY:
                if (isConstruction((int)Building.ARMY)) army++;
                break;
            case Building.CASTLE:
                if (isConstruction((int)Building.CASTLE)) castle++;
                break;
            case Building.EXPEDITION:
                if (isConstruction((int)Building.EXPEDITION)) expedition++;
                break;
            case Building.MARKET:
                if (isConstruction((int)Building.MARKET)) market++;
                break;
        }
    }

    bool isConstruction(int index)
    {
        if (warehouse.TryUseResource(WareHouse.Resource.WOOD, list[index].Item1) &&
            warehouse.TryUseResource(WareHouse.Resource.STONE, list[index].Item2) &&
            warehouse.TryUseResource(WareHouse.Resource.GOLD, list[index].Item3) &&
            warehouse.TryUseResource(WareHouse.Resource.HUMANRESOURCES, list[index].Item4))
            return false;
        return true;
    }

}
