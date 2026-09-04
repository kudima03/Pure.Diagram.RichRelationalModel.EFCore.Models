# Changelog

All notable changes to Pure.Diagram.RichRelationalModel.EFCore.Models are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [0.1.0-preview.2.0.0] — 2026-04-20

### Changed

- **Breaking:** `SeriesEFCoreModel` renamed to `DiagramSeriesEFCoreModel`, now
  implementing `IDiagramSeriesRichRelationalModel` (was
  `ISeriesRichRelationalModel`).
- **Breaking:** `DiagramEFCoreModel.SeriesNavigation` changed from
  `ICollection<SeriesEFCoreModel>` to `ICollection<DiagramSeriesEFCoreModel>`,
  and the constructor parameter changed accordingly.
- **Breaking:** `DiagramEFCoreModel.Series` now returns
  `IEnumerable<IDiagramSeries>` (was `IEnumerable<ISeries>`).
- Updated the `Pure.Diagram.RichRelationalModel.Abstractions` dependency to
  `0.1.0-preview.1.0.0`.

## [0.1.0-preview.1.0.0] — 2026-02-18

### Changed

- **`DiagramEFCoreModel.SeriesNavigation`** changed from
  `IEnumerable<SeriesEFCoreModel>` to `ICollection<SeriesEFCoreModel>`, and the
  constructor parameter changed accordingly, enabling EF Core change tracking
  on the collection navigation property.

## [0.1.0-preview.0.2.0] — 2026-02-18

### Added

- **`DiagramEFCoreModel`** — added a secondary constructor
  `(id, title, description, typeId)` for materializing instances without
  navigation properties.

## [0.1.0-preview.0.1.0] — 2026-02-12

Initial release: EF Core-compatible model implementations for
`Pure.Diagram.RichRelationalModel.Abstractions`.

### Added

- **`DiagramTypeEFCoreModel`** — implementation of
  `IDiagramTypeRichRelationalModel` with `Id` and `Name`.
- **`SeriesEFCoreModel`** — implementation of `ISeriesRichRelationalModel`
  with `Id`, `Label`, `Source`, and `DiagramId`.
- **`DiagramEFCoreModel`** — implementation of `IDiagramRichRelationalModel`
  with `Id`, `Title`, `Description`, `TypeId`, exposing `TypeNavigation` and
  `SeriesNavigation` navigation properties backing the `Type` and `Series`
  interface members.
