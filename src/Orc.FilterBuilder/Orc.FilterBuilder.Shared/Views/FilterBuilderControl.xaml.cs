﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FilterBuilderControl.xaml.cs" company="Orcomp development team">
//   Copyright (c) 2008 - 2014 Orcomp development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.FilterBuilder.Views
{
    using System;
    using System.Collections;
    using System.Windows;
    using Catel.MVVM.Views;

    public partial class FilterBuilderControl
    {
        #region Constructors
        static FilterBuilderControl()
        {
            typeof(FilterBuilderControl).AutoDetectViewPropertiesToSubscribe();
        }

        public FilterBuilderControl()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        [ViewToViewModel(MappingType = ViewToViewModelMappingType.ViewToViewModel)]
        public IEnumerable RawCollection
        {
            get { return (IEnumerable)GetValue(RawCollectionProperty); }
            set { SetValue(RawCollectionProperty, value); }
        }

        public static readonly DependencyProperty RawCollectionProperty = DependencyProperty.Register("RawCollection", typeof(IEnumerable),
            typeof(FilterBuilderControl));


        [ViewToViewModel(MappingType = ViewToViewModelMappingType.ViewToViewModel)]
        public FilterBuilderMode Mode
        {
            get { return (FilterBuilderMode) GetValue(ModeProperty); }
            set { SetValue(ModeProperty, value); }
        }

        public static readonly DependencyProperty ModeProperty = DependencyProperty.Register("Mode", typeof(FilterBuilderMode), 
            typeof(FilterBuilderControl), new PropertyMetadata(default(FilterBuilderMode)));


        [ViewToViewModel(MappingType = ViewToViewModelMappingType.ViewToViewModel)]
        public Func<object,bool> FilteringFunc
        {
            get { return (Func<object,bool>) GetValue(FilteringFuncProperty); }
            set { SetValue(FilteringFuncProperty, value); }
        }

        public static readonly DependencyProperty FilteringFuncProperty = DependencyProperty.Register("FilteringFunc", typeof (Func<object,bool>), 
            typeof (FilterBuilderControl), new PropertyMetadata(default(Func<object,bool>)));


        [ViewToViewModel(MappingType = ViewToViewModelMappingType.ViewToViewModel)]
        public IList FilteredCollection
        {
            get { return (IList)GetValue(FilteredCollectionProperty); }
            set { SetValue(FilteredCollectionProperty, value); }
        }

        public static readonly DependencyProperty FilteredCollectionProperty = DependencyProperty.Register("FilteredCollection", typeof(IList),
                    typeof(FilterBuilderControl));


        [ViewToViewModel(MappingType = ViewToViewModelMappingType.ViewToViewModel)]
        public bool AutoApplyFilter
        {
            get { return (bool)GetValue(AutoApplyFilterProperty); }
            set { SetValue(AutoApplyFilterProperty, value); }
        }

        public static readonly DependencyProperty AutoApplyFilterProperty = DependencyProperty.Register("AutoApplyFilter", typeof(bool), 
            typeof(FilterBuilderControl), new PropertyMetadata(true));


        [ViewToViewModel(MappingType = ViewToViewModelMappingType.ViewToViewModel)]
        public bool AllowLivePreview
        {
            get { return (bool)GetValue(AllowLivePreviewProperty); }
            set { SetValue(AllowLivePreviewProperty, value); }
        }

        public static readonly DependencyProperty AllowLivePreviewProperty =
            DependencyProperty.Register("AllowLivePreview", typeof(bool), typeof(FilterBuilderControl), new PropertyMetadata(true));


        [ViewToViewModel(MappingType = ViewToViewModelMappingType.ViewToViewModel)]
        public bool EnableAutoCompletion
        {
            get { return (bool)GetValue(EnableAutoCompletionProperty); }
            set { SetValue(EnableAutoCompletionProperty, value); }
        }

        public static readonly DependencyProperty EnableAutoCompletionProperty =
            DependencyProperty.Register("EnableAutoCompletion", typeof(bool), typeof(FilterBuilderControl), new PropertyMetadata(true));


        [ViewToViewModel(MappingType = ViewToViewModelMappingType.ViewToViewModel)]
        public bool AllowReset
        {
            get { return (bool)GetValue(AllowResetProperty); }
            set { SetValue(AllowResetProperty, value); }
        }

        public static readonly DependencyProperty AllowResetProperty =
            DependencyProperty.Register("AllowReset", typeof(bool), typeof(FilterBuilderControl), new PropertyMetadata(true));


        [ViewToViewModel(MappingType = ViewToViewModelMappingType.ViewToViewModel)]
        public bool AllowDelete
        {
            get { return (bool)GetValue(AllowDeleteProperty); }
            set { SetValue(AllowDeleteProperty, value); }
        }

        public static readonly DependencyProperty AllowDeleteProperty = DependencyProperty.Register("AllowDelete", typeof(bool), 
            typeof(FilterBuilderControl), new PropertyMetadata(true));
        #endregion
    }
}