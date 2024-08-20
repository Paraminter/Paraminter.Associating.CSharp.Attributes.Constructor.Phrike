﻿namespace Paraminter.CSharp.Attributes.Constructor.Phrike.Errors;

using Paraminter.Cqs.Handlers;
using Paraminter.CSharp.Attributes.Constructor.Phrike.Errors.Commands;

using Xunit;

public sealed class MissingRequiredArgument
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void ReturnsHandler()
    {
        var result = Target();

        Assert.Same(Fixture.MissingRequiredArgumentMock.Object, result);
    }

    private ICommandHandler<IHandleMissingRequiredArgumentCommand> Target() => Fixture.Sut.MissingRequiredArgument;
}
