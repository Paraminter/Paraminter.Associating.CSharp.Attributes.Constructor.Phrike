﻿namespace Paraminter.CSharp.Attributes.Constructor.Phrike.Queries;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using System.Collections.Generic;

/// <summary>Represents data used to associate syntactic C# attribute constructor arguments.</summary>
public interface IAssociateSyntacticCSharpAttributeConstructorData
{
    /// <summary>The attribute constructor parameters.</summary>
    public abstract IReadOnlyList<IParameterSymbol> Parameters { get; }

    /// <summary>The syntactic C# attribute constructor arguments, possibly also containing syntactic C# named attribute arguments.</summary>
    public abstract IReadOnlyList<AttributeArgumentSyntax> SyntacticArguments { get; }

    /// <summary>A semantic model describing the syntactic arguments.</summary>
    public abstract SemanticModel SemanticModel { get; }
}
