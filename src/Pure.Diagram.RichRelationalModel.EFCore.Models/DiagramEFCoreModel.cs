using Pure.Diagram.Model.Abstractions;
using Pure.Diagram.RichRelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.RichRelationalModel.EFCore.Models;

public sealed record DiagramEFCoreModel : IDiagramRichRelationalModel
{
    public DiagramEFCoreModel(
        IGuid id,
        IString title,
        IString description,
        IGuid typeId,
        DiagramTypeEFCoreModel typeNavigation,
        IEnumerable<SeriesEFCoreModel> seriesNavigation
    )
    {
        Id = id;
        Title = title;
        Description = description;
        TypeNavigation = typeNavigation;
        SeriesNavigation = seriesNavigation;
        TypeId = typeId;
    }

    public IGuid Id { get; }

    public IString Title { get; }

    public IString Description { get; }

    public IGuid TypeId { get; }

    public IDiagramType Type => TypeNavigation;

    public DiagramTypeEFCoreModel TypeNavigation { get; }

    public IEnumerable<ISeries> Series => SeriesNavigation;

    public IEnumerable<SeriesEFCoreModel> SeriesNavigation { get; }
}
