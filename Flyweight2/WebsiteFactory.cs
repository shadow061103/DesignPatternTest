using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Flyweight2
{
    class WebsiteFactory
    {
        private Hashtable flyweights = new Hashtable();
        //獲得網站分類
        public Website GetWebsiteCategory(string key)
        {
            if (!flyweights.ContainsKey(key))
                flyweights.Add(key, new ConcreteWebsite(key));
            return (Website)flyweights[key];
        }
        //獲得網站分類總數
        public int GetWebsiteCount()
        {
            return flyweights.Count;
        }
    }
}
