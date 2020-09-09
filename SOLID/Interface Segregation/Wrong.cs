namespace SOLID.Interface_Segregation
{
    // https://medium.com/backticks-tildes/the-s-o-l-i-d-principles-in-pictures-b34ce2f1e898

    // Interface Segregation

    // Clients should not be forced to depend on methods that they do not use.

    // When a Class is required to perform actions that are not useful, it is wasteful and may
    // produce unexpected bugs if the Class does not have the ability to perform those actions.

    // A Class should perform only actions that are needed to fulfil its role.Any other action
    // should be removed completely or moved somewhere else if it might be used by another Class
    // in the future.

    // Goal
    // This principle aims at splitting a set of actions into smaller sets so that a Class executes ONLY the set of actions it requires.

    public class Wrong
    {
    }
}
