﻿#pragma checksum "..\..\..\..\Admin\WindowAdmin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DE39CEE5B12C46E1FF55FA5A7D97D58A71969419"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FUMiniHotelSystem.Admin;
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


namespace FUMiniHotelSystem.Admin {
    
    
    /// <summary>
    /// WindowAdmin
    /// </summary>
    public partial class WindowAdmin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\Admin\WindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btnRoom;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Admin\WindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem btnBookingReservation;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Admin\WindowAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frAdmin;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FUMiniHotelSystem;component/admin/windowadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Admin\WindowAdmin.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 25 "..\..\..\..\Admin\WindowAdmin.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnRoom = ((System.Windows.Controls.MenuItem)(target));
            
            #line 28 "..\..\..\..\Admin\WindowAdmin.xaml"
            this.btnRoom.Click += new System.Windows.RoutedEventHandler(this.btnRoom_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnBookingReservation = ((System.Windows.Controls.MenuItem)(target));
            
            #line 31 "..\..\..\..\Admin\WindowAdmin.xaml"
            this.btnBookingReservation.Click += new System.Windows.RoutedEventHandler(this.btnBookingReservation_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 37 "..\..\..\..\Admin\WindowAdmin.xaml"
            ((System.Windows.Controls.TabItem)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TabItem_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 49 "..\..\..\..\Admin\WindowAdmin.xaml"
            ((System.Windows.Controls.TabItem)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TabItem_PreviewMouseLeftButtonDown_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.frAdmin = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

