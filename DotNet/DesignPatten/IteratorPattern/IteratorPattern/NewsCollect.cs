using System.Collections.Generic;

namespace IteratorPattern
{
    public sealed class NewsCollect : Iterator<NewsCollect>
    {
        private int _current;
        private readonly List<NewsCollect> _items = new List<NewsCollect>();

        public string Content { get; set; }

        public NewsCollect this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }

        public override NewsCollect First()
        {
            return _items[0];
        }

        public override NewsCollect Next()
        {
            if (_current < _items.Count)
                _current++;

            if (_current == _items.Count)
                return null;

            return _items[_current];
        }

        public override bool IsDone()
        {
            return _current >= _items.Count;
        }

        public override NewsCollect Current()
        {
            return _items[_current];
        }
    }
}