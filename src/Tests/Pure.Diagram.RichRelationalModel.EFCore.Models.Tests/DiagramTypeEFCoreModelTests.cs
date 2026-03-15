using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Guid = Pure.Primitives.Guid.Guid;
using String = Pure.Primitives.String.String;

namespace Pure.Diagram.RichRelationalModel.EFCore.Models.Tests;

public sealed class DiagramTypeEFCoreModelTests
{
    [Fact]
    public void ConstructorSetsId()
    {
        IGuid id = new Guid(System.Guid.NewGuid());
        IString name = new String("TestType");

        DiagramTypeEFCoreModel model = new DiagramTypeEFCoreModel(id, name);

        Assert.Equal(id.GuidValue, model.Id.GuidValue);
    }

    [Fact]
    public void ConstructorSetsName()
    {
        IGuid id = new Guid(System.Guid.NewGuid());
        IString name = new String("TestType");

        DiagramTypeEFCoreModel model = new DiagramTypeEFCoreModel(id, name);

        Assert.Equal(name.TextValue, model.Name.TextValue);
    }
}
