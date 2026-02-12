using Pure.Diagram.RichRelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.RichRelationalModel.EFCore.Models;

public sealed record SeriesEFCoreModel : ISeriesRichRelationalModel
{
    public SeriesEFCoreModel(IGuid id, IString label, IString source, IGuid diagramId)
    {
        Id = id;
        Label = label;
        Source = source;
        DiagramId = diagramId;
    }

    public IGuid Id { get; }

    public IString Label { get; }

    public IString Source { get; }

    public IGuid DiagramId { get; }
}
