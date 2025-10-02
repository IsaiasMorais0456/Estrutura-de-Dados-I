using Arvores;
using Company_Tree;

Tree<int> tree = new Tree<int>();


tree.Root = new TreeNode<int>();
tree.Root.Data = 100;

tree.Root.Children = new List<TreeNode<int>>
{
    new TreeNode<int>() { Data = 50, Parent = tree.Root },
    new TreeNode<int>() { Data = 1, Parent = tree.Root },
    new TreeNode<int>() { Data = 150, Parent = tree.Root }
};

tree.Root.Children[2].Children = new List<TreeNode<int>>
{
    new TreeNode<int>() { Data = 30, Parent = tree.Root.Children[2] },
    new TreeNode<int>() { Data = 175, Parent = tree.Root.Children[2] }
};

Tree<Person> company = new Tree<Person>();
company.Root = new TreeNode<Person>()
{
    Data = new Person(100, "Gabriel Ceron", "CEO"),
    Parent = null
};
company.Root.Children = new List<TreeNode<Person>>()
{
    new TreeNode<Person>()
    {
        Data = new Person(1, "Isaias", "Desenvolvedor Master" ),
        Parent = company.Root
    },
    new TreeNode<Person>()
    {
        Data = new Person(50, "Pedro", "Desenvolvedor Junior" ),
        Parent = company.Root
    },
    new TreeNode<Person>()
    {
        Data = new Person(150, "Ryan", "Desenvolvedor Sênior" ),
        Parent = company.Root
    }
};

company.Root.Children[2].Children = new List<TreeNode<Person>>(){
    new TreeNode<Person>(){
        Data = new Person(30, "Ariel", "Estagiário"),
        Parent = company.Root.Children[2]
    }
};

while (true){
    Console.WriteLine("Funcionarios: ");
    Console.WriteLine("1 - CEO");
    Console.WriteLine("2 - Desenvolvedor Master");
    Console.WriteLine("3 - Desenvolvedor Junior");
    Console.WriteLine("4 - Desenvolvedor Sênior");
    Console.WriteLine("5 - Estagiário");
    Console.WriteLine("6 - Sair");
    int choice = int.Parse(Console.ReadLine());
    switch (choice){
        case 1:
            Console.WriteLine(company.Root.Data.Name);
            break;
        case 2:
            Console.WriteLine(company.Root.Children[0].Data.Name);
            break;
        case 3:
            Console.WriteLine(company.Root.Children[1].Data.Name);
            break;
        case 4:
            Console.WriteLine(company.Root.Children[2].Data.Name);
            break;
        case 5:
            Console.WriteLine(company.Root.Children[2].Children[0].Data.Name);
            break;
        case 6:
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
    break;
}

