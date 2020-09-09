namespace SOLID.Single_Responsibility
{
    // https://medium.com/backticks-tildes/the-s-o-l-i-d-principles-in-pictures-b34ce2f1e898

    // Single Responsibility

    // A class should have a single responsibility

    //If a Class has many responsibilities, it increases the possibility of bugs
    // because making changes to one of its responsibilities, could affect the 
    //other ones without you knowing.

    //Goal
    //This principle aims to separate behaviours so that if bugs arise as a 
    //result of your change, it won’t affect other unrelated behaviours.

    public class Order
    {
        public void CalculateTotalSum() { }
        public void GetItems() { }
        public void GetItemCount() { }
        public void AddItem() { }
        public void DeleteItem() { }
    }

    public class OrderViewer
    {
        public void PrintOrder() { }
        public void ShowOrder() { }
    }

    public class OrderRepository
    {
        public void Load() { }
        public void Save() { }
        public void Update() { }
        public void Delete() { }
    }

}
