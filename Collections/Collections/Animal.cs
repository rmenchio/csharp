namespace Collections
{
	public class Animal
	{
        public string Name { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }

		override
		public string ToString()
		{
			return string.Format("Nome: {0}, Idade: {1}, Peso: {2}", Name, Age, Weight);
		}
	}
}