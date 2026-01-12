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
                if (gold - num >= 0)
                {
                    gold -= num;
                    Observer.SelecetInvoke("Gold");
                    return true;
                }
                return false;
            case Resource.FOOD:
                if (gold - num >= 0)
                {
                    gold -= num;
                    Observer.SelecetInvoke("Gold");
                    return true;
                }
                return false;
            case Resource.WOOD:

                break;
            case Resource.STONE:

                break;
            case Resource.ORE:

                break;
            case Resource.SPECIALRESOURCE:

                break;
            case Resource.HUMANRESOURCES:

                break;
            default:
                Debug.AddLog("정의되지 않은 enum 값에 접근했습니다.", true);
                return false;
        }
        return false;
    }
}
