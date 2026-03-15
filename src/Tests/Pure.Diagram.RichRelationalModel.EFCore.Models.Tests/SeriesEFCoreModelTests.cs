using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Guid = Pure.Primitives.Guid.Guid;
using String = Pure.Primitives.String.String;

namespace Pure.Diagram.RichRelationalModel.EFCore.Models.Tests;

public sealed class SeriesEFCoreModelTests
{
    [Fact]
    public void ConstructorSetsId()
    {
        IGuid id = new Guid(System.Guid.NewGuid());
        IString label = new String("Label");
        IString source = new String("Source");
        IGuid diagramId = new Guid(System.Guid.NewGuid());

        SeriesEFCoreModel model = new SeriesEFCoreModel(id, label, source, diagramId);

        Assert.Equal(id.GuidValue, model.Id.GuidValue);
    }

    [Fact]
    public void ConstructorSetsLabel()
    {
        IGuid id = new Guid(System.Guid.NewGuid());
        IString label = new String("Label");
        IString source = new String("Source");
        IGuid diagramId = new Guid(System.Guid.NewGuid());

        SeriesEFCoreModel model = new SeriesEFCoreModel(id, label, source, diagramId);

        Assert.Equal(label.TextValue, model.Label.TextValue);
    }

    [Fact]
    public void ConstructorSetsSource()
    {
        IGuid id = new Guid(System.Guid.NewGuid());
        IString label = new String("Label");
        IString source = new String("Source");
        IGuid diagramId = new Guid(System.Guid.NewGuid());

        SeriesEFCoreModel model = new SeriesEFCoreModel(id, label, source, diagramId);

        Assert.Equal(source.TextValue, model.Source.TextValue);
    }

    [Fact]
    public void ConstructorSetsDiagramId()
    {
        IGuid id = new Guid(System.Guid.NewGuid());
        IString label = new String("Label");
        IString source = new String("Source");
        IGuid diagramId = new Guid(System.Guid.NewGuid());

        SeriesEFCoreModel model = new SeriesEFCoreModel(id, label, source, diagramId);

        Assert.Equal(diagramId.GuidValue, model.DiagramId.GuidValue);
    }
}
