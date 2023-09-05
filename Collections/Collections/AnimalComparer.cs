using System.Collections;

namespace Collections
{
	public class AnimalComparer : IComparer
	{
        public int Compare(object? x, object? y)
        {
            return (new CaseInsensitiveComparer()).Compare(((Animal)x).Name, ((Animal)y).Name);
        }
    }
}