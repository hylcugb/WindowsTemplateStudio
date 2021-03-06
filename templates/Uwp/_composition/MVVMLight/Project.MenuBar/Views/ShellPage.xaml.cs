﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Param_RootNamespace.Services;
using Param_RootNamespace.ViewModels;

namespace Param_RootNamespace.Views
{
    // TODO WTS: You can edit the text for the menu in String/en-US/Resources.resw
    // You can show pages in different ways (update main view, navigate, right pane, new windows or dialog) using MenuNavigationHelper class.
    // Read more about MenuBar project type here:
    // https://github.com/Microsoft/WindowsTemplateStudio/blob/master/docs/projectTypes/menubar.md
    public sealed partial class ShellPage : Page
    {
        public ShellViewModel ViewModel { get; } = new ShellViewModel();

        public ShellPage()
        {
            InitializeComponent();
            ViewModel.Initialize(shellFrame, splitView, rightFrame);
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            KeyboardAccelerators.Add(ActivationService.BackKeyboardAccelerator);
            KeyboardAccelerators.Add(ActivationService.AltLeftKeyboardAccelerator);
        }
    }
}
