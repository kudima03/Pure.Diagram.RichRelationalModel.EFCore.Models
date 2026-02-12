using Pure.Diagram.RichRelationalModel.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.RichRelationalModel.EFCore.Models;

public sealed record DiagramTypeEFCoreModel : IDiagramTypeRichRelationalModel
{
    public DiagramTypeEFCoreModel(IGuid id, IString name)
    {
        Id = id;
        Name = name;
    }

    public IGuid Id { get; }

    public IString Name { get; }
}
