﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IReflectionService.cs" company="Orcomp development team">
//   Copyright (c) 2008 - 2014 Orcomp development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.FilterBuilder.Services
{
    using System;
    using Orc.FilterBuilder.Models;

    public interface IReflectionService
    {
        IPropertyCollection GetInstanceProperties(Type targetType);

        void ClearCache();
    }
}