﻿#pragma checksum "..\..\..\Views\ReceivingScreen.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F6292D31261485EFB151E63C3772FCFB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
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


namespace POS.Retail {
    
    
    /// <summary>
    /// ReceivingScreen
    /// </summary>
    public partial class ReceivingScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\Views\ReceivingScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lsb_po_receive_detail;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\..\Views\ReceivingScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\Views\ReceivingScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_scan_item_code;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\Views\ReceivingScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label4;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\Views\ReceivingScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_qty;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Views\ReceivingScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label5;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Views\ReceivingScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_submit;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Views\ReceivingScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_commit_all;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Views\ReceivingScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_delete_all;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Views\ReceivingScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_exit;
        
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
            System.Uri resourceLocater = new System.Uri("/POS.Retail;component/views/receivingscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ReceivingScreen.xaml"
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
            
            #line 4 "..\..\..\Views\ReceivingScreen.xaml"
            ((POS.Retail.ReceivingScreen)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lsb_po_receive_detail = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txt_scan_item_code = ((System.Windows.Controls.TextBox)(target));
            
            #line 8 "..\..\..\Views\ReceivingScreen.xaml"
            this.txt_scan_item_code.KeyDown += new System.Windows.Input.KeyEventHandler(this.txt_scan_item_code_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.label4 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.txt_qty = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\..\Views\ReceivingScreen.xaml"
            this.txt_qty.KeyDown += new System.Windows.Input.KeyEventHandler(this.txt_qty_KeyDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.label5 = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.btn_submit = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Views\ReceivingScreen.xaml"
            this.btn_submit.Click += new System.Windows.RoutedEventHandler(this.btn_submit_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_commit_all = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Views\ReceivingScreen.xaml"
            this.btn_commit_all.Click += new System.Windows.RoutedEventHandler(this.btn_commit_all_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_delete_all = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Views\ReceivingScreen.xaml"
            this.btn_delete_all.Click += new System.Windows.RoutedEventHandler(this.btn_delete_all_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btn_exit = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\Views\ReceivingScreen.xaml"
            this.btn_exit.Click += new System.Windows.RoutedEventHandler(this.btn_exit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

