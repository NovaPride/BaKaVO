﻿#pragma checksum "..\..\..\Windows\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3B6F9D497F687DC4B74F489F1A26FD013FD54ADE47108DB6BE86F759DC94AE84"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BaKaVO.Windows;
using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace BaKaVO.Windows {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitBut;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MaximizedBut;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MinimizedBut;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PatientWin_ClickBut;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid PatientDataGrid;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn IDPat;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn NamePat;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn PhonePat;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn FillingPat;
        
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
            System.Uri resourceLocater = new System.Uri("/BaKaVO;component/windows/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\MainWindow.xaml"
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
            
            #line 17 "..\..\..\Windows\MainWindow.xaml"
            ((BaKaVO.Windows.MainWindow)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.DragWindow);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ExitBut = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Windows\MainWindow.xaml"
            this.ExitBut.Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MaximizedBut = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Windows\MainWindow.xaml"
            this.MaximizedBut.Click += new System.Windows.RoutedEventHandler(this.Maximized_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MinimizedBut = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Windows\MainWindow.xaml"
            this.MinimizedBut.Click += new System.Windows.RoutedEventHandler(this.Minimized_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PatientWin_ClickBut = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Windows\MainWindow.xaml"
            this.PatientWin_ClickBut.Click += new System.Windows.RoutedEventHandler(this.PatientWin_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PatientDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 49 "..\..\..\Windows\MainWindow.xaml"
            this.PatientDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PatientDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 50 "..\..\..\Windows\MainWindow.xaml"
            this.PatientDataGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.PatientDataGrid_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.IDPat = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 8:
            this.NamePat = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 9:
            this.PhonePat = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 10:
            this.FillingPat = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

