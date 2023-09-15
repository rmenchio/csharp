using Collections;

class Program
{
    public static void Main(string[] args)
    {
        #region Objects

        Animal gato = new() { Name = "Gato", Age = 10, Weight = 15.0f };
        Animal cachorro = new() { Name = "Cachorro", Age = 12, Weight = 25.0f };
        Animal papagaio = new() { Name = "Rodolfo", Age = 32, Weight = 5.0f };

        #endregion

        #region Arrays

        /*
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
        */

        #endregion

        #region Lists
        /*
        List<Animal> listAnimals = new()
        {
            gato,
            cachorro
        };

        foreach (var animal in listAnimals)
        {
            //Console.WriteLine(animal);
        }

        listAnimals.Add(papagaio);

        foreach (var animal in listAnimals)
        {
            //Console.WriteLine(animal);
        }

        //listAnimals.AddRange(new List<Animal>{ gato, gato, cachorro});

        foreach (var animal in listAnimals)
        {
            //Console.WriteLine(animal);
        }

        //Console.WriteLine("Mostrando animal com nome de Rodolfo");

        //Console.WriteLine(listAnimals.FirstOrDefault(a => a.Name.Equals("Rodolfo")));

        //Console.WriteLine("Ordenando...");

        listAnimals = listAnimals.OrderBy(a => a.Name).ToList();

        foreach (var animal in listAnimals)
        {
            //Console.WriteLine(animal);
        }

        //Console.WriteLine("Soma das idades: {0}", listAnimals.Sum(a => a.Age));

        Console.WriteLine("Lista ordenada por nome");

        foreach (var animal in listAnimals)
        {
            Console.WriteLine(animal);
        }

        Console.WriteLine("Ordenando por idade...");

        listAnimals.Sort((x, y) => x.Age.CompareTo(y.Age));

        foreach (var animal in listAnimals)
        {
            Console.WriteLine(animal);
        }

        Console.WriteLine("Ordenando por peso...");

        listAnimals.Sort((x, y) => x.Weight.CompareTo(y.Weight));

        foreach (var animal in listAnimals)
        {
            Console.WriteLine(animal);
        }

        Console.ReadLine();
        */

        #endregion

        #region Sets
        ///*
        // * Propriedades do Set: 
        // *  Não permite duplicidade.
        // *  Não se sabe onde um elemento adicionado irá ser incluido.
        // *  HashSet é mais rápido do que lista.
        // */
        //ISet<Animal> setAnimals = new HashSet<Animal>();

        //setAnimals.Add(gato);
        //setAnimals.Add(cachorro);
        //setAnimals.Add(papagaio);

        //Console.WriteLine("Imprimindo Set");

        //foreach (Animal animal in setAnimals)
        //{
        //    Console.WriteLine(animal);
        //}

        //Console.WriteLine("Adicionando elemento duplicado para observar comportamento do Set");

        //setAnimals.Add(papagaio);

        //foreach (Animal animal in setAnimals)
        //{
        //    Console.WriteLine(animal);
        //}

        //Console.WriteLine("Para ordenar, vamos primeiro transformar para list...");

        //var listByHashset = setAnimals.ToList();

        //listByHashset.Sort((x, y) => x.Name.CompareTo(y.Name));

        //setAnimals = listByHashset.ToHashSet();

        //foreach (Animal animal in setAnimals)
        //{
        //    Console.WriteLine(animal);
        //}

        //Console.ReadLine();
        #endregion

        #region Dictionary

        /* 
         * Dicionários não permitem adicionar com a mesma chave.
         * É melhor adicionar com TryAdd.
         */

        IDictionary<int, Animal> animalsDict = new Dictionary<int, Animal>();

        animalsDict.Add(1, gato);
        animalsDict.TryAdd(1, cachorro);
        animalsDict.TryAdd(2, papagaio);

        foreach(var obj in animalsDict)
        {
            Console.WriteLine("Chave: {0}, Valor: {1}", obj.Key, obj.Value);
        }

        animalsDict.TryAdd(3, cachorro);

        int chave = 2;

        if(animalsDict.TryGetValue(chave, out var animal))
        {
            Console.WriteLine("Na chave {0} está o {1}", chave, animal.Name);
        }

        Console.ReadLine();

        #endregion

        #region Testes aleatórios
        //var lista = new List<Item>
        //{
        //    new Item("aline", 1, 3),
        //    new Item("bruna", 1, 3),
        //    new Item("carol", 1, 3),

        //    new Item("denise", 2, 2),
        //    new Item("irene", 2, 5),
        //    new Item("fatima", 2, 4),

        //    new Item("elisa", 3, 4),
        //    new Item("gabriela", 3, 4),

        //    new Item("hanna", 4, 2)
        //};

        //var nova = lista.GroupBy(i => i.Id);

        //foreach(var i in nova)
        //{
        //    if (i.Count() == i.Where(i => i.Status == 4).Count())
        //    {
        //        Console.WriteLine("está tudo faturado no id {0}", i.Key);
        //    }
        //}

        //Console.ReadLine();
        #endregion
    }

    //public record Item(string Nome, int Id, int Status);
}