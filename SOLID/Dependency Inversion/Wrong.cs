﻿namespace SOLID.Dependency_Inversion
{
    // https://medium.com/backticks-tildes/the-s-o-l-i-d-principles-in-pictures-b34ce2f1e898

    // Dependency Inversion

    // - High-level modules should not depend on low-level modules.Both should depend on the abstraction.
    // - Abstractions should not depend on details. Details should depend on abstractions.

    // Firstly, let’s define the terms used here more simply

    // High-level Module(or Class): Class that executes an action with a tool.

    // Low-level Module (or Class): The tool that is needed to execute the action

    // Abstraction: Represents an interface that connects the two Classes.

    // Details: How the tool works

    // This principle says a Class should not be fused with the tool it uses to execute an action.
    // Rather, it should be fused to the interface that will allow the tool to connect to the
    // Class.

    // It also says that both the Class and the interface should not know how the tool works.
    // However, the tool needs to meet the specification of the interface.

    // Goal
    // This principle aims at reducing the dependency of a high-level Class on the low-level Class
    // by introducing an interface.

    public class Wrong
    {
    }
}
