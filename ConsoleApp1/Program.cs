using System.ComponentModel;

//Write a generic class that meets the following requirements:
//1)   That constrains a developer to only instantiate the class based on value types
//2)   Contains a private generic collection
//3)   Has a method to add items to the private collection
//4)   Has a method that will return an item from the list (e.g. item 3 or item 4 in the list)
//5)   Has a method that returns a sorted collection with the items in descending order
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