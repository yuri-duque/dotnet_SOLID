using System;

namespace SOLID.Open_Closed
{
    // https://medium.com/backticks-tildes/the-s-o-l-i-d-principles-in-pictures-b34ce2f1e898

    // Open-Closed

    // Classes should be open for extension, but closed for modification

    // Changing the current behaviour of a Class will affect all the systems 
    // using that Class.
    // If you want the Class to perform more functions, the ideal approach 
    // is to add to the functions that already exist NOT change them.

    // Goal
    // This principle aims to extend a Class’s behaviour without changing the
    // existing behaviour of that Class. This is to avoid causing bugs wherever
    // the Class is being used.

    public interface IContrato { }

    public class ContratoCLTs : IContrato
    {
        public void Salario() { }
    }

    public class Estagios : IContrato
    {
        public void BolsaAuxilio() { }
    }

    public class FolhaDePagamentos
    {
        public double Saldo { get; set; }

        public void Calcular(IContrato contrato)
        {
            if (contrato.GetType().Equals(typeof(ContratoCLT)))
            {
                Saldo = contrato.salario();
            }
            else if (contrato.GetType().Equals(typeof(ContratoCLT)))
            {
                Saldo = contrato.contrato();
            }
        }
    }
}
