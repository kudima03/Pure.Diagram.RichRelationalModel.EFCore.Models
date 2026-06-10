# Pure.Diagram.RichRelationalModel.EFCore.Models

EF Core entity record implementations of the diagram rich relational model for the **Pure** ecosystem.

[![.NET build & test](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.EFCore.Models/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.EFCore.Models/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.EFCore.Models/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.EFCore.Models/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Diagram.RichRelationalModel.EFCore.Models)](https://www.nuget.org/packages/Pure.Diagram.RichRelationalModel.EFCore.Models)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`Pure.Diagram.RichRelationalModel.EFCore.Models` provides `sealed record` types that implement the interfaces from [`Pure.Diagram.RichRelationalModel.Abstractions`](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.Abstractions) and are designed to be used as EF Core entity types.

Each model exposes both a strongly-typed navigation property that EF Core can bind to, and an abstract interface property that delegates to the navigation property — allowing callers to program against the abstraction while EF Core works with the concrete type.

## Models

| Class | Implements | Properties |
|---|---|---|
| `DiagramEFCoreModel` | `IDiagramRichRelationalModel` | `Id`, `Title`, `Description`, `TypeId`, `TypeNavigation`/`Type`, `SeriesNavigation`/`Series` |
| `DiagramTypeEFCoreModel` | `IDiagramTypeRichRelationalModel` | `Id`, `Name` |
| `DiagramSeriesEFCoreModel` | `IDiagramSeriesRichRelationalModel` | `Id`, `DiagramId`, `Label`, `Source` |

## Design Principles

- **Immutable** — all properties are get-only; values are set via constructor only.
- **Dual surface** — typed navigation properties satisfy EF Core; interface properties satisfy calling code.

## Dependencies

- [`Pure.Diagram.RichRelationalModel.Abstractions`](https://github.com/kudima03/Pure.Diagram.RichRelationalModel.Abstractions) — rich relational diagram interfaces
