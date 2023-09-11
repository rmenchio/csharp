namespace Collections
{
	public class Animal : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }

        public int CompareTo(object obj)
        {
            Animal that = (Animal)obj;

            return Age.CompareTo(that.Age);
        }

        override
		public string ToString()
		{
			return string.Format("Nome: {0}, Idade: {1}, Peso: {2}", Name, Age, Weight);
		}
	}
}