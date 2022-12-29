﻿#pragma checksum "..\..\..\WorkWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BDCBA32B60CDBB86029E2A15A1F3B42A148D84EC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CarService_Client;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace CarService_Client {
    
    
    /// <summary>
    /// WorkWindow
    /// </summary>
    public partial class WorkWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\WorkWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxName;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\WorkWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxCarMake;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\WorkWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxLicensePlate;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\WorkWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxYear;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\WorkWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxWorkCategory;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\WorkWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxShortDescription;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\WorkWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxSeverity;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\WorkWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCreate;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\WorkWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonUpdate;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CarService_Client;component/workwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WorkWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TextBoxName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TextBoxCarMake = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TextBoxLicensePlate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TextBoxYear = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ComboBoxWorkCategory = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.TextBoxShortDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TextBoxSeverity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.ButtonCreate = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\WorkWindow.xaml"
            this.ButtonCreate.Click += new System.Windows.RoutedEventHandler(this.HandleButtonCreateClicked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ButtonUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\WorkWindow.xaml"
            this.ButtonUpdate.Click += new System.Windows.RoutedEventHandler(this.HandleButtonUpdateClicked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
