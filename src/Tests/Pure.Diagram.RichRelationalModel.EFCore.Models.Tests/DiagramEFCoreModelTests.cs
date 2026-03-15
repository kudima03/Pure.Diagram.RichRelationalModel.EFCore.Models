using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Guid = Pure.Primitives.Guid.Guid;
using String = Pure.Primitives.String.String;

namespace Pure.Diagram.RichRelationalModel.EFCore.Models.Tests;

public sealed class DiagramEFCoreModelTests
{
    [Fact]
    public void ConstructorWithoutNavigationSetsId()
    {
        IGuid id = new Guid(System.Guid.NewGuid());
        IString title = new String("Title");
        IString description = new String("Description");
        IGuid typeId = new Guid(System.Guid.NewGuid());

        DiagramEFCoreModel model = new DiagramEFCoreModel(id, title, description, typeId);

        Assert.Equal(id.GuidValue, model.Id.GuidValue);
    }

    [Fact]
    public void ConstructorWithoutNavigationSetsTitle()
    {
        IGuid id = new Guid(System.Guid.NewGuid());
        IString title = new String("Title");
        IString description = new String("Description");
        IGuid typeId = new Guid(System.Guid.NewGuid());

        DiagramEFCoreModel model = new DiagramEFCoreModel(id, title, description, typeId);

        Assert.Equal(title.TextValue, model.Title.TextValue);
    }

    [Fact]
    public void ConstructorWithoutNavigationSetsDescription()
    {
        IGuid id = new Guid(System.Guid.NewGuid());
        IString title = new String("Title");
        IString description = new String("Description");
        IGuid typeId = new Guid(System.Guid.NewGuid());

        DiagramEFCoreModel model = new DiagramEFCoreModel(id, title, description, typeId);

        Assert.Equal(description.TextValue, model.Description.TextValue);
    }

    [Fact]
    public void ConstructorWithoutNavigationSetsTypeId()
    {
        IGuid id = new Guid(System.Guid.NewGuid());
        IString title = new String("Title");
        IString description = new String("Description");
        IGuid typeId = new Guid(System.Guid.NewGuid());

        DiagramEFCoreModel model = new DiagramEFCoreModel(id, title, description, typeId);

        Assert.Equal(typeId.GuidValue, model.TypeId.GuidValue);
    }

    [Fact]
    public void ConstructorWithNavigationSetsId()
    {
        IGuid id = new Guid(System.Guid.NewGuid());
        IString title = new String("Title");
        IString description = new String("Description");
        IGuid typeId = new Guid(System.Guid.NewGuid());
        DiagramTypeEFCoreModel typeNavigation = new DiagramTypeEFCoreModel(
            typeId,
            new String("TypeName")
        );

        DiagramEFCoreModel model = new DiagramEFCoreModel(
            id,
            title,
            description,
            typeId,
            typeNavigation,
            []
        );

        Assert.Equal(id.GuidValue, model.Id.GuidValue);
    }

    [Fact]
    public void ConstructorWithNavigationSetsTitle()
    {
        IGuid id = new Guid(System.Guid.NewGuid());
        IString title = new String("Title");
        IString description = new String("Description");
        IGuid typeId = new Guid(System.Guid.NewGuid());
        DiagramTypeEFCoreModel typeNavigation = new DiagramTypeEFCoreModel(
            typeId,
            new String("TypeName")
        );

        DiagramEFCoreModel model = new DiagramEFCoreModel(
            id,
            title,
            description,
            typeId,
            typeNavigation,
            []
        );

        Assert.Equal(title.TextValue, model.Title.TextValue);
    }

    [Fact]
    public void ConstructorWithNavigationSetsDescription()
    {
        IGuid id = new Guid(System.Guid.NewGuid());
        IString title = new String("Title");
        IString description = new String("Description");
        IGuid typeId = new Guid(System.Guid.NewGuid());
        DiagramTypeEFCoreModel typeNavigation = new DiagramTypeEFCoreModel(
            typeId,
            new String("TypeName")
        );

        DiagramEFCoreModel model = new DiagramEFCoreModel(
            id,
            title,
            description,
            typeId,
            typeNavigation,
            []
        );

        Assert.Equal(description.TextValue, model.Description.TextValue);
    }

    [Fact]
    public void ConstructorWithNavigationSetsTypeId()
    {
        IGuid id = new Guid(System.Guid.NewGuid());
        IString title = new String("Title");
        IString description = new String("Description");
        IGuid typeId = new Guid(System.Guid.NewGuid());
        DiagramTypeEFCoreModel typeNavigation = new DiagramTypeEFCoreModel(
            typeId,
            new String("TypeName")
        );

        DiagramEFCoreModel model = new DiagramEFCoreModel(
            id,
            title,
            description,
            typeId,
            typeNavigation,
            []
        );

        Assert.Equal(typeId.GuidValue, model.TypeId.GuidValue);
    }

    [Fact]
    public void ConstructorWithNavigationSetsTypeNavigation()
    {
        IGuid id = new Guid(System.Guid.NewGuid());
        IString title = new String("Title");
        IString description = new String("Description");
        IGuid typeId = new Guid(System.Guid.NewGuid());
        DiagramTypeEFCoreModel typeNavigation = new DiagramTypeEFCoreModel(
            typeId,
            new String("TypeName")
        );

        DiagramEFCoreModel model = new DiagramEFCoreModel(
            id,
            title,
            description,
            typeId,
            typeNavigation,
            []
        );

        Assert.Equal(typeNavigation.Id.GuidValue, model.TypeNavigation.Id.GuidValue);
        Assert.Equal(typeNavigation.Name.TextValue, model.TypeNavigation.Name.TextValue);
    }

    [Fact]
    public void ConstructorWithNavigationSetsSeriesNavigation()
    {
        IGuid id = new Guid(System.Guid.NewGuid());
        IString title = new String("Title");
        IString description = new String("Description");
        IGuid typeId = new Guid(System.Guid.NewGuid());
        DiagramTypeEFCoreModel typeNavigation = new DiagramTypeEFCoreModel(
            typeId,
            new String("TypeName")
        );

        DiagramEFCoreModel model = new DiagramEFCoreModel(
            id,
            title,
            description,
            typeId,
            typeNavigation,
            []
        );

        Assert.Empty(model.SeriesNavigation);
    }

    [Fact]
    public void ConstructorWithNavigationTypeReturnsTypeNavigation()
    {
        IGuid id = new Guid(System.Guid.NewGuid());
        IString title = new String("Title");
        IString description = new String("Description");
        IGuid typeId = new Guid(System.Guid.NewGuid());
        DiagramTypeEFCoreModel typeNavigation = new DiagramTypeEFCoreModel(
            typeId,
            new String("TypeName")
        );

        DiagramEFCoreModel model = new DiagramEFCoreModel(
            id,
            title,
            description,
            typeId,
            typeNavigation,
            []
        );

        Assert.Equal(typeNavigation.Name.TextValue, model.Type.Name.TextValue);
    }

    [Fact]
    public void ConstructorWithNavigationSeriesReturnsSeriesNavigation()
    {
        IGuid id = new Guid(System.Guid.NewGuid());
        IString title = new String("Title");
        IString description = new String("Description");
        IGuid typeId = new Guid(System.Guid.NewGuid());
        DiagramTypeEFCoreModel typeNavigation = new DiagramTypeEFCoreModel(
            typeId,
            new String("TypeName")
        );

        DiagramEFCoreModel model = new DiagramEFCoreModel(
            id,
            title,
            description,
            typeId,
            typeNavigation,
            []
        );

        Assert.Empty(model.Series);
    }
}
