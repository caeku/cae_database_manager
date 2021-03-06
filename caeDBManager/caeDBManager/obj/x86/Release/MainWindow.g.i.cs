﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48A19FB377C732918C861380C98F43AB3BC99F3E"
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
using System.Windows.Forms.Integration;
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
using caeDBManager;


namespace caeDBManager {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel TopPanel;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel cae_tutor;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel BrowserControl;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button homebbtn;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button refreshbttn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backbttn;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button forwardbttn;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel browser_Stack;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel advanced_options;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBttn;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteBttn;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SeeAllBttn;
        
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
            System.Uri resourceLocater = new System.Uri("/caeDBManager;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
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
            
            #line 8 "..\..\..\MainWindow.xaml"
            ((caeDBManager.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.MainWindow_OnLoaded);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\MainWindow.xaml"
            ((caeDBManager.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TopPanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 3:
            
            #line 17 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MainWindows_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 19 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Advanced_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 21 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Settings_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 23 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Help_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cae_tutor = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.BrowserControl = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 9:
            this.homebbtn = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\MainWindow.xaml"
            this.homebbtn.Click += new System.Windows.RoutedEventHandler(this.homebbtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.refreshbttn = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\MainWindow.xaml"
            this.refreshbttn.Click += new System.Windows.RoutedEventHandler(this.refreshbttn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.backbttn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\MainWindow.xaml"
            this.backbttn.Click += new System.Windows.RoutedEventHandler(this.backbttn_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.forwardbttn = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\MainWindow.xaml"
            this.forwardbttn.Click += new System.Windows.RoutedEventHandler(this.forwardbttn_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.browser_Stack = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 14:
            this.advanced_options = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 15:
            this.AddBttn = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\MainWindow.xaml"
            this.AddBttn.Click += new System.Windows.RoutedEventHandler(this.AddBttn_OnClick);
            
            #line default
            #line hidden
            return;
            case 16:
            this.DeleteBttn = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\MainWindow.xaml"
            this.DeleteBttn.Click += new System.Windows.RoutedEventHandler(this.DeleteBttn_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.SeeAllBttn = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\MainWindow.xaml"
            this.SeeAllBttn.Click += new System.Windows.RoutedEventHandler(this.SeeAllBttn_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

