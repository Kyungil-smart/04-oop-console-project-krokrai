using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

class ResearchTreeNode
{
    public string name { get; private set; }
    public int level { get; private set; }
    public int researchSpeed { get; private set; }
    public bool isResearched { get; private set; }
    public List<ResearchTreeNode> LowNode { get; private set; }
    public ResearchTreeNode(string _name, int _level, int _researchSpeed)
    {
        name = _name;
        level = _level;
        researchSpeed = _researchSpeed;
        isResearched = false;
        LowNode = new List<ResearchTreeNode>(2);
    }

    public void ResearchComplite()
    {
        isResearched = true;
    }
}