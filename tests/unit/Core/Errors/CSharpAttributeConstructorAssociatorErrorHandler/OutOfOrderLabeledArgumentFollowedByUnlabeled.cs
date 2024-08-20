﻿namespace Paraminter.CSharp.Attributes.Constructor.Phrike.Errors;

using Paraminter.Cqs.Handlers;
using Paraminter.CSharp.Attributes.Constructor.Phrike.Errors.Commands;

using Xunit;

public sealed class OutOfOrderLabeledArgumentFollowedByUnlabeled
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void ReturnsHandler()
    {
        var result = Target();

        Assert.Same(Fixture.OutOfOrderLabeledArgumentFollowedByUnlabeledMock.Object, result);
    }

    private ICommandHandler<IHandleOutOfOrderLabeledArgumentFollowedByUnlabeledCommand> Target() => Fixture.Sut.OutOfOrderLabeledArgumentFollowedByUnlabeled;
}
