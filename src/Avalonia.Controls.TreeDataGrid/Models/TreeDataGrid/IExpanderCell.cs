﻿using System;

namespace Avalonia.Controls.Models.TreeDataGrid
{
    /// <summary>
    /// Represents a cell in a <see cref="HierarchicalTreeDataGridSource{TModel}"/> which displays
    /// an expander to reveal nested data.
    /// </summary>
    public interface IExpanderCell : ICell, IExpander
    {
        /// <summary>
        /// Gets the row that the cell belongs to.
        /// </summary>
        IRow Row { get; }

        /// <summary>
        /// Gets a value indicating whether the expander should be shown.
        /// </summary>
        bool ShowExpander { get; }
    }
}
