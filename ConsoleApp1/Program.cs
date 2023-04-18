public class ValueCollection<T> where T : struct
{
    private List<T> _values;

    public ValueCollection()
    {
        _values = new List<T>();
    }

    public void Add(T value)
    {
        _values.Add(value);
    }

    public T GetItem(int index)
    {
        if (index < 0)
        {
            throw new IndexOutOfRangeException();
        }

        return _values[index];
    }

    public List<T> GetDescending()
    {
        List<T> sortedValues = new List<T>(_values);
        sortedValues.Sort();
        sortedValues.Reverse();
        return sortedValues;
    }
}