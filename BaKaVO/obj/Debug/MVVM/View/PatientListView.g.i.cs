﻿#pragma checksum "..\..\..\..\MVVM\View\PatientListView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "067D02490C7DB6C80507860872A251F0078E1467F27E86BB94DEA943293E5FEB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BaKaVO.MVVM.View;
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


namespace BaKaVO.MVVM.View {
    
    
    /// <summary>
    /// PatientListView
    /// </summary>
    public partial class PatientListView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\MVVM\View\PatientListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ColumnDefinition SearchColumn;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\MVVM\View\PatientListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\MVVM\View\PatientListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Search_button;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\MVVM\View\PatientListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FirstPage_button;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\MVVM\View\PatientListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PreviousPage_button;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\MVVM\View\PatientListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PageSelectBlock;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\MVVM\View\PatientListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextPage_button;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\MVVM\View\PatientListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LastPage_button;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\MVVM\View\PatientListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid PatientListDataGrid;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\MVVM\View\PatientListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn IDPat;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\MVVM\View\PatientListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn NamePat;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\MVVM\View\PatientListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn PhonePat;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\MVVM\View\PatientListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn FillingPat;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\MVVM\View\PatientListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn CommentPat;
        
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
            System.Uri resourceLocater = new System.Uri("/BaKaVO;component/mvvm/view/patientlistview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MVVM\View\PatientListView.xaml"
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
            
            #line 9 "..\..\..\..\MVVM\View\PatientListView.xaml"
            ((BaKaVO.MVVM.View.PatientListView)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.PatientListView_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchColumn = ((System.Windows.Controls.ColumnDefinition)(target));
            return;
            case 3:
            this.SearchBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Search_button = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.FirstPage_button = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\MVVM\View\PatientListView.xaml"
            this.FirstPage_button.Click += new System.Windows.RoutedEventHandler(this.FirstPage_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PreviousPage_button = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\..\MVVM\View\PatientListView.xaml"
            this.PreviousPage_button.Click += new System.Windows.RoutedEventHandler(this.PreviousPage_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PageSelectBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.NextPage_button = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\..\MVVM\View\PatientListView.xaml"
            this.NextPage_button.Click += new System.Windows.RoutedEventHandler(this.NextPage_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.LastPage_button = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\..\MVVM\View\PatientListView.xaml"
            this.LastPage_button.Click += new System.Windows.RoutedEventHandler(this.LastPage_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.PatientListDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 96 "..\..\..\..\MVVM\View\PatientListView.xaml"
            this.PatientListDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PatientListDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 97 "..\..\..\..\MVVM\View\PatientListView.xaml"
            this.PatientListDataGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.PatientListDataGrid_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.IDPat = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 12:
            this.NamePat = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 13:
            this.PhonePat = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 14:
            this.FillingPat = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 15:
            this.CommentPat = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

