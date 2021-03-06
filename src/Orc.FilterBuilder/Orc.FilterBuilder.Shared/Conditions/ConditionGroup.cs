﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConditionGroup.cs" company="Orcomp development team">
//   Copyright (c) 2008 - 2014 Orcomp development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.FilterBuilder
{
    using System.Linq;

    public class ConditionGroup : ConditionTreeItem
    {
        #region Constructors
        public ConditionGroup()
        {
            Type = ConditionGroupType.And;
        }
        #endregion

        #region Properties
        public ConditionGroupType Type { get; set; }
        #endregion

        #region Methods
        public override bool CalculateResult(object entity)
        {
            if (!Items.Any())
            {
                return true;
            }

            if (Type == ConditionGroupType.And)
            {
                return Items.Aggregate(true, (current, item) => current && item.CalculateResult(entity));
            }
            else
            {
                return Items.Aggregate(false, (current, item) => current || item.CalculateResult(entity));
            }
        }

        public override string ToString()
        {
            return Type.ToString();
        }
        #endregion
    }
}