using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._0_dsa_exams._1_Summer_2021_A
{
    public class Store
    {
        Tablet[] tablets;
        int[] systems;

        public Store()
        {
            tablets = new Tablet[1000];
            systems = new int[3];
        }
        public bool AddTablet(Tablet tab)
        {
            int i = 0;
            Tablet t = null;
            while(i < tablets.Length && tablets[i] != null)
            {
                if (tablets[i].IsSame(tab))
                    t = tablets[i];
                i++;
            }
            if (i == tablets.Length)
                return false;

            if(t != null)
            {
                t.price = t.price > tab.price ? t.price : tab.price;
                switch (t.system)
                {
                    case 'W':
                        systems[0]++;
                        break;
                    case 'A':
                        systems[1]++;
                        break;
                    case 'I':
                        systems[2]++;
                        break;
                    default:
                        break;
                }
                return true;
            }
            if(t == null)
            {
                tablets[i + 1] = tab;
                systems[tab.system == 'W' ? 0 : tab.system == 'A' ? 1 : 2]++;
            }
            return true;
        }

        public int SortStore()
        {
            int i = 0;
            int j = 0;
            while (i < tablets.Length && tablets[i] != null) ;
            int effectiveSize = i + 1;
            char[] sysMap = { 'I', 'A', 'W' };
            Stack<Tablet> stack = new Stack<Tablet>();
            while(i < sysMap.Length)
            {
                for(j = 0; j < effectiveSize; j++)
                {
                    if(tablets[j].system == sysMap[i])
                    {
                        stack.Push(tablets[j]);
                    }
                }
                i++;
            }
            for(i = 0; i < effectiveSize && stack.Count > 0; i++)
            {
                tablets[i] = stack.Pop();
            }
            return tablets.Length - effectiveSize;
        }
    }
}
