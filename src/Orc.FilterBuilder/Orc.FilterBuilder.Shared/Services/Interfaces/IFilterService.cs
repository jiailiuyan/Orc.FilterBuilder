﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFilterService.cs" company="Orcomp development team">
//   Copyright (c) 2008 - 2014 Orcomp development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.FilterBuilder.Services
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Models;

    public interface IFilterService
    {
        #region Properties
        FilterScheme SelectedFilter { get; set; }
        #endregion

        #region Methods
        void FilterCollection(FilterScheme filter, IEnumerable rawCollection, IList filteredCollection);
        #endregion

        /// <summary>
        /// Occurs when any of the filters has been updated.
        /// </summary>
        event EventHandler<EventArgs> FiltersUpdated;

        /// <summary>
        /// Occurs when the currently selected filter has changed.
        /// </summary>
        event EventHandler<EventArgs> SelectedFilterChanged;
    }
}