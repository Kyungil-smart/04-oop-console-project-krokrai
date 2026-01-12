using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class IntUtils
{
    public static string TranstoString(this int num1)
    {
        if (num1 == 0)
        {
            return Transer(num1).ToString();
        }
        
        List<int> list = new List<int>();
        
        while (num1 > 0)
        {
            list.Add(num1 % 10);
            num1 /= 10;
        }

        list.Reverse();
        char[] c = new char[list.Count];
        for (int i = 0; i < list.Count; i++)
        {
            c[i] = Transer(list[i]);
        }
        string s = new string(c);
        return s;
    }

    static char Transer(int num1)
    {
        switch(num1)
        {
            case 0:
                return '０';
            case 1:
                return '１';
            case 2:
                return '２';
            case 3:
                return '３';
            case 4:
                return '４';
            case 5:
                return '５';
            case 6:
                return '６';
            case 7:
                return '７';
            case 8:
                return '８';
            case 9:
                return '９';
            default:
                Debug.AddLog("0~9가 아닌 수가 들어왔습니다. IntUtils.cs",true);
                return '　';
        }
    }
}
