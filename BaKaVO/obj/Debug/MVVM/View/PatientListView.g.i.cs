﻿#pragma checksum "..\..\..\..\MVVM\View\PatientListView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "85293A65A7C00BD6EA219587BB6D17CE78CA9242FF025909157917C805AC6158"
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
        
        
        #line 12 "..\..\..\..\MVVM\View\PatientListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid PatientListDataGrid;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\MVVM\View\PatientListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn IDPat;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\MVVM\View\PatientListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn NamePat;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\MVVM\View\PatientListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn PhonePat;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\MVVM\View\PatientListView.xaml"
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
            this.PatientListDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 24 "..\..\..\..\MVVM\View\PatientListView.xaml"
            this.PatientListDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PatientListDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            
            #line 25 "..\..\..\..\MVVM\View\PatientListView.xaml"
            this.PatientListDataGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.PatientListDataGrid_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.IDPat = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.NamePat = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.PhonePat = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.FillingPat = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
