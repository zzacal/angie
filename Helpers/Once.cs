namespace angie.Helpers
{
    public class Once<T>
    {
        public Once(T output)
        {
            _output = output;
        }
        bool _done = false;
        T _output;
        public T Output()
        {
            if (_done)
            {
                return default;
            }
            _done = true;
            return _output;
        }
    }
}