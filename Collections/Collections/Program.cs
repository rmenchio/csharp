using System.Collections;
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

        Animal[] arrayAnimal = new Animal[5]
        {
            gato,
            cachorro,
            papagaio,
            papagaio,
            papagaio
        };

        Console.WriteLine("Array inicial");

        Print<Animal[]>.Imprimir(arrayAnimal);

        Console.WriteLine("Índice do primeiro papagaio: {0}", Array.IndexOf(arrayAnimal, papagaio));
        Console.WriteLine("Índice do último papagaio: {0}", Array.LastIndexOf(arrayAnimal, papagaio));


        Console.WriteLine("Array reverso");
        Array.Reverse(arrayAnimal);

        Print<Animal[]>.Imprimir(arrayAnimal);

        Console.WriteLine("Índice do primeiro papagaio após reverter array: {0}", Array.IndexOf(arrayAnimal, papagaio));
        Console.WriteLine("Índice do último papagaio após reverter array: {0}", Array.LastIndexOf(arrayAnimal, papagaio));

        Console.WriteLine("Reduzindo array para tamanho 2");
        Array.Reverse(arrayAnimal);
        Array.Resize(ref arrayAnimal, 2);

        Console.WriteLine("Array redimensionado");

        Print<Animal[]>.Imprimir(arrayAnimal);

        Console.WriteLine("Ordenando array por nome do animal");
        Array.Sort(arrayAnimal, new AnimalComparer());

        Console.WriteLine("Array ordenado");

        Print<Animal[]>.Imprimir(arrayAnimal);

        Animal[] arrayAnimalCopia = new Animal[2];
        Array.Copy(arrayAnimal, 0, arrayAnimalCopia, 0, 2);

        Console.WriteLine("Array copiado");

        Print<Animal[]>.Imprimir(arrayAnimal);

        Animal[] arrayAnimalClone = (Animal[])arrayAnimal.Clone();

        Console.WriteLine("Array clonado");

        Print<Animal[]>.Imprimir(arrayAnimal);

        Array.Clear(arrayAnimalClone);

        Console.WriteLine("Array clonado depois de limpo");

        Print<Animal[]>.Imprimir(arrayAnimal);

        #endregion

        #region Lists

        List<Animal> listAnimals = new()
        {
            gato,
            cachorro
        };

        Print<List<Animal>>.Imprimir(listAnimals);

        listAnimals.Add(papagaio);

        Print<List<Animal>>.Imprimir(listAnimals);

        listAnimals.AddRange(new List<Animal>{ gato, gato, cachorro});

        Print<List<Animal>>.Imprimir(listAnimals);

        Console.WriteLine("Mostrando animal com nome de Rodolfo");

        Console.WriteLine(listAnimals.FirstOrDefault(a => a.Name.Equals("Rodolfo")));

        Console.WriteLine("Ordenando...");

        listAnimals = listAnimals.OrderBy(a => a.Name).ToList();

        Print<List<Animal>>.Imprimir(listAnimals);

        Console.WriteLine("Soma das idades: {0}", listAnimals.Sum(a => a.Age));

        Console.WriteLine("Lista ordenada por nome");

        Print<List<Animal>>.Imprimir(listAnimals);

        Console.WriteLine("Ordenando por idade...");

        listAnimals.Sort((x, y) => x.Age.CompareTo(y.Age));

        Print<List<Animal>>.Imprimir(listAnimals);

        Console.WriteLine("Ordenando por peso...");

        listAnimals.Sort((x, y) => x.Weight.CompareTo(y.Weight));

        Print<List<Animal>>.Imprimir(listAnimals);

        #endregion

        #region HashSets

        /*
         * Propriedades do Set: 
         *  Não permite duplicidade.
         *  Não se sabe onde um elemento adicionado irá ser incluido.
         *  HashSet é mais rápido do que lista.
         */

        ISet<Animal> setAnimals = new HashSet<Animal>();

        setAnimals.Add(gato);
        setAnimals.Add(cachorro);
        setAnimals.Add(papagaio);

        Console.WriteLine("Imprimindo Set");

        Print<ISet<Animal>>.Imprimir(setAnimals);

        Console.WriteLine("Adicionando elemento duplicado para observar comportamento do Set");

        setAnimals.Add(papagaio);

        Print<ISet<Animal>>.Imprimir(setAnimals);

        Console.WriteLine("Para ordenar, vamos primeiro transformar para list...");

        var listByHashset = setAnimals.ToList();

        listByHashset.Sort((x, y) => x.Name.CompareTo(y.Name));

        setAnimals = listByHashset.ToHashSet();

        Print<ISet<Animal>>.Imprimir(setAnimals);

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

        foreach (var obj in animalsDict)
        {
            Console.WriteLine("Chave: {0}, Valor: {1}", obj.Key, obj.Value);
        }

        animalsDict.TryAdd(3, cachorro);

        int chave = 2;

        if (animalsDict.TryGetValue(chave, out var animal))
        {
            Console.WriteLine("Na chave {0} está o {1}", chave, animal.Name);
        }

        #endregion

        #region LinkedList

        /*
         * Características: 
         *  Não precisa ter elementos em sequência na memória.
         *  Referência de anterior e próximo para cada elemento
         *  Cada nó tem um valor.
         *  
         *  Tem desvantagens pois precisa de um nó para inserção e não da pra usar indice, somente find.
         */

        LinkedList<Animal> linkedAnimals = new();

        var primeiro = linkedAnimals.AddFirst(gato);
        var p = linkedAnimals.AddBefore(primeiro, papagaio);
        linkedAnimals.AddAfter(p, cachorro);

        Print<LinkedList<Animal>>.Imprimir(linkedAnimals);

        #endregion

        #region Stack

        /*
         * A pilha insere elementos literalmente como uma pilha.
         * O primeiro elemento fica no fundo e o último fica no topo
         * 
         * Para adicionar utilizamos o push e para pegar o último elemento utilizamos o pop.
         */

        Stack<Animal> stackAnimals = new();

        stackAnimals.Push(gato);
        stackAnimals.Push(cachorro);

        Print<Stack<Animal>>.Imprimir(stackAnimals);

        Console.WriteLine("Removendo elemento do topo: " + stackAnimals.Pop());

        Console.WriteLine("imprimindo....");

        Print<Stack<Animal>>.Imprimir(stackAnimals);
        #endregion

        #region Queue

        /*
         * Fila: o primeiro a chegar é o primeiro a sair.
         * 
         * Podemos pegar o próximo elemento, sem retira-lo da lista.
         */

        Queue<Animal> queueAnimals = new();

        queueAnimals.Enqueue(gato);
        queueAnimals.Enqueue(cachorro);

        Print<Queue<Animal>>.Imprimir(queueAnimals);

        Console.WriteLine("O primeiro elemento a entrar na fila é o primeiro a sair.");
        Console.WriteLine("Removemos da fila: " + queueAnimals.Dequeue());

        queueAnimals.Enqueue(cachorro);
        queueAnimals.Enqueue(papagaio);

        Console.WriteLine("Podemos pegar o próximo elemento da fila sem retira-lo da fila");
        Console.WriteLine("Neste momento, o próximo é: " + queueAnimals.Peek());

        Print<Queue<Animal>>.Imprimir(queueAnimals);

        Console.ReadLine();

        #endregion
    }

    public class Print<T>
    {
        public static void Imprimir(T collection)
        {
            if (typeof(T).Equals(typeof(ISet<Animal>)))
            {
                foreach (var elemento in (ISet<Animal>)collection)
                {
                    Console.WriteLine(elemento);
                }

                return;
            }

            foreach (var elemento in (ICollection)collection)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}