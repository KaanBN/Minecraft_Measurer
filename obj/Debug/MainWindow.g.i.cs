﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DB955FFDF6126097050FC3C1D017FEDC2B5F1DA1ACC152AD0FD13EDB224054A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WPFbasics;


namespace WPFbasics {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 60 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border HomeBorder;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HomeButton;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border HistoryBorder;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HistoryButton;
        
        #line default
        #line hidden
        
        
        #line 198 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border CreditBorder;
        
        #line default
        #line hidden
        
        
        #line 223 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreditButton;
        
        #line default
        #line hidden
        
        
        #line 253 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Main;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFbasics;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 28 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.draging_bar);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 35 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.draging_bar);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.HomeBorder = ((System.Windows.Controls.Border)(target));
            
            #line 94 "..\..\MainWindow.xaml"
            this.HomeBorder.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.draging_bar);
            
            #line default
            #line hidden
            return;
            case 5:
            this.HomeButton = ((System.Windows.Controls.Button)(target));
            
            #line 118 "..\..\MainWindow.xaml"
            this.HomeButton.Click += new System.Windows.RoutedEventHandler(this.HomeButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.HistoryBorder = ((System.Windows.Controls.Border)(target));
            
            #line 149 "..\..\MainWindow.xaml"
            this.HistoryBorder.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.draging_bar);
            
            #line default
            #line hidden
            return;
            case 7:
            this.HistoryButton = ((System.Windows.Controls.Button)(target));
            
            #line 173 "..\..\MainWindow.xaml"
            this.HistoryButton.Click += new System.Windows.RoutedEventHandler(this.HistoryButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CreditBorder = ((System.Windows.Controls.Border)(target));
            
            #line 204 "..\..\MainWindow.xaml"
            this.CreditBorder.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.draging_bar);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CreditButton = ((System.Windows.Controls.Button)(target));
            
            #line 228 "..\..\MainWindow.xaml"
            this.CreditButton.Click += new System.Windows.RoutedEventHandler(this.CreditButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Main = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

