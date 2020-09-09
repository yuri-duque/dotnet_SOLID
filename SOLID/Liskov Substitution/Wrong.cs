using System.Runtime.InteropServices.ComTypes;

namespace SOLID.Liskov_Substitution
{
    // https://medium.com/backticks-tildes/the-s-o-l-i-d-principles-in-pictures-b34ce2f1e898

    // Liskov Substitution

    // If S is a subtype of T, then objects of type T in a program may be replaced with
    // objects of type S without altering any of the desirable properties of that program.

    // When a child Class cannot perform the same actions as its parent Class, this can cause bugs.

    // If you have a Class and create another Class from it, it becomes a parent and the new Class
    // becomes a child.The child Class should be able to do everything the parent Class can do. 
    // This process is called Inheritance.


    // The child Class should be able to process the same requests and deliver the same result as
    // the parent Class or it could deliver a result that is of the same type.


    // The picture shows that the parent Class delivers Coffee(it could be any type of coffee).
    // It is acceptable for the child Class to deliver Cappucino because it is a specific type
    // of Coffee, but it is NOT acceptable to deliver Water.

    // If the child Class doesn’t meet these requirements, it means the child Class is changed
    // completely and violates this principle.

    // Goal
    // This principle aims to enforce consistency so that the parent Class or its child Class can
    // be used in the same way without any errors.

    public class Pai_errado
    {
        public Pai_errado(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get; set; }

        public string GetNome()
        {
            return "Meu nome é " + Nome;
        }
    }

    public class Filho_errado : Pai_errado
    {
        public Filho_errado(string nome) : base (nome)
        {
            this.Nome = nome;
        }

        public string Nome { get; set; }

        public string GetNome()
        {
            return "Meu nome é " + Nome;
        }
    }

    public class PedirCafe_errado
    {
        public PedirCafe_errado()
        {
            var resultadoPai = new Pai_errado("Joao").GetNome(); // Joao
            var resultadoFilho = new Filho_errado("Lucas").GetNome(); // Lucas
        }
    }
}
