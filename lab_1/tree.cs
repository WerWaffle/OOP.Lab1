using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab_1
{
    public class tree
    {
        private string data { get; set; }
        public List<tree> son = new List<tree>();

        public tree(string data)
        {
            this.data = data;
        }
        public void Add(tree tree)
        {
            son.Add(tree);
        }
        public List<string> output()
        {
            var list = new List<string>();

            list.Add(data);

            if (son.Count == 0)
            {
                return list;
            }

            foreach (var item in son)
            {
                list.AddRange(item.output());
            }

            return list;
        }
    }
}

