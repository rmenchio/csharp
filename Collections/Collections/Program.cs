using Collections;

class Program
{
    public static void Main(string[] args)
    {
        #region Arrays

        Animal gato = new() { Name = "Gato", Age = 10, Weight = 15.0f };
        Animal cachorro = new() { Name = "Cachorro", Age = 12, Weight = 25.0f };
        Animal papagaio = new() { Name = "Papagaio", Age = 32, Weight = 5.0f };

        Animal[] arrayAnimal = new Animal[5]
        {
            gato,
            cachorro,
            papagaio,
            papagaio,
            papagaio
        };

        Console.WriteLine("Array inicial");

        foreach (Animal animal in arrayAnimal)
        {
            Console.WriteLine(animal);
        }

        Console.WriteLine("Índice do primeiro papagaio: {0}", Array.IndexOf(arrayAnimal, papagaio));
        Console.WriteLine("Índice do último papagaio: {0}", Array.LastIndexOf(arrayAnimal, papagaio));


        Console.WriteLine("Array reverso");
        Array.Reverse(arrayAnimal);

        foreach (Animal animal in arrayAnimal)
        {
            Console.WriteLine(animal);
        }

        Console.WriteLine("Índice do primeiro papagaio após reverter array: {0}", Array.IndexOf(arrayAnimal, papagaio));
        Console.WriteLine("Índice do último papagaio após reverter array: {0}", Array.LastIndexOf(arrayAnimal, papagaio));

        Console.WriteLine("Reduzindo array para tamanho 2");
        Array.Reverse(arrayAnimal);
        Array.Resize(ref arrayAnimal, 2);

        Console.WriteLine("Array redimensionado");

        foreach (Animal animal in arrayAnimal)
        {
            Console.WriteLine(animal);
        }

        Console.WriteLine("Ordenando array por nome do animal");
        Array.Sort(arrayAnimal, new AnimalComparer());

        Console.WriteLine("Array ordenado");

        foreach (Animal animal in arrayAnimal)
        {
            Console.WriteLine(animal);
        }

        Animal[] arrayAnimalCopia = new Animal[2];
        Array.Copy(arrayAnimal, 0, arrayAnimalCopia, 0, 2);

        Console.WriteLine("Array copiado");

        foreach (Animal animal in arrayAnimalCopia)
        {
            Console.WriteLine(animal);
        }

        Animal[] arrayAnimalClone = (Animal[])arrayAnimal.Clone();

        Console.WriteLine("Array clonado");

        foreach (Animal animal in arrayAnimalClone)
        {
            Console.WriteLine(animal);
        }

        Array.Clear(arrayAnimalClone);

        Console.WriteLine("Array clonado depois de limpo");

        foreach (Animal animal in arrayAnimalClone)
        {
            Console.WriteLine(animal);
        }

        #endregion
    }
}