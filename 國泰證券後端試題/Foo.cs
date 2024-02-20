using System.Collections.Generic;

namespace 國泰證券後端試題
{
    class Foo_1
    {
        private Dictionary<string, int> dict = new Dictionary<string, int>
        {
            ["A"] = 123,
            ["B"] = 456
        };

        // 索引器實現
        public int this[string key]
        {
            get { return dict[key]; }
        }
    }
}
