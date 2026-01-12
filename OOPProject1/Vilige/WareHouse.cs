using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WareHouse
{
    public enum Resource
    {
        GOLD,FOOD,WOOD,STONE,ORE,SPECIALRESOURCE,HUMANRESOURCES
    }

    public int gold { get; private set; }
    public int food { get; private set; }
    public int wood { get; private set; }
    public int stone { get; private set; }
    public int ore { get; private set; }
    public int specialResources { get; private set; }
    public int humanResources { get; private set; }

    public bool TryUseResource(Resource resource, int num)
    {
        switch(resource)
        {
            case Resource.GOLD:
                return gold - num >= 0 ? true : false;
            case Resource.FOOD:

                return false;
            case Resource.WOOD:

                break;
            case Resource.STONE:

                break;
            case Resource.ORE:
                return ore - num >= 0 ? true : false;
            case Resource.SPECIALRESOURCE:

                break;
            case Resource.HUMANRESOURCES:
                return humanResources - num >= 0 ? true : false;
            default:
                Debug.AddLog("정의되지 않은 enum 값에 접근했습니다.", true);
                return false;
        }
        return false;
    }

    public void UseResource(Resource resource, int num)
    {
        switch (resource)
        {
            case Resource.GOLD:
                gold -= num;
                Observer.SelecetInvoke("Gold");
                break;
            case Resource.FOOD:
                break;
            case Resource.WOOD:

                break;
            case Resource.STONE:

                break;
            case Resource.ORE:
                ore -= num;
                Observer.SelecetInvoke("Ore");
                break;
            case Resource.SPECIALRESOURCE:

                break;
            case Resource.HUMANRESOURCES:
                humanResources -= num;
                Observer.SelecetInvoke("humanResources");
                break;
            default:
                Debug.AddLog("정의되지 않은 enum 값에 접근했습니다.", true);
                break;
        }
    }
}
