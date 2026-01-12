using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ResearchTree
{
    ResearchTreeNode Root;
    ResearchTreeNode atc, util;
    public ResearchTreeNode currentResearchNode { get; private set; }
    bool isRootResearch = true;

    public ResearchTree()
    {
        Root =  new ResearchTreeNode("첫 연구", 0 , 1);
        atc = new ResearchTreeNode("유닛 전투력 증가", 1, 3);
        util = new ResearchTreeNode("생산력 증가", 1, 3);
        Root.LowNode.Add(atc);
        Root.LowNode.Add(util);
    }

    public string[] Researchable()
    {
        if (isRootResearch)
        {
            return new string[1] {Root.name};
        }
        return new string[2] { atc.name, util.name };
    }

    public void AddQueue()
    {
        
    }

    public void RemoveQueue()
    {

    }

    public void ChangeQueue()
    {

    }
}