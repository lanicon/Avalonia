﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
namespace Avalonia.Controls
{
    public sealed class NavigationViewItemInvokedEventArgs
    {
        public NavigationViewItemInvokedEventArgs()
        {
        }

        public object InvokedItem { get; internal set; }
        public bool IsSettingsInvoked { get; internal set; }

        public NavigationViewItemBase InvokedItemContainer { get; internal set; }
        // TODO
        // public NavigationTransitionInfo RecommendedNavigationTransitionInfo { get; internal set; }
    }
}