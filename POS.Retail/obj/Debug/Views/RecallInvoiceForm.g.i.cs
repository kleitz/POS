﻿#pragma checksum "..\..\..\Views\RecallInvoiceForm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "759A4DB494E789512B6D42179940ACB1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
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
    /// RecallInvoiceForm
    /// </summary>
    public partial class RecallInvoiceForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\Views\RecallInvoiceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_scroll_down;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\..\Views\RecallInvoiceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_scroll_up;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\Views\RecallInvoiceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_cancel;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\RecallInvoiceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_select;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Views\RecallInvoiceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_type_in;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\RecallInvoiceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_type_holdid;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Views\RecallInvoiceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Views\RecallInvoiceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg_recall_invoices;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\RecallInvoiceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;
        
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
            System.Uri resourceLocater = new System.Uri("/POS.Retail;component/views/recallinvoiceform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\RecallInvoiceForm.xaml"
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
            
            #line 4 "..\..\..\Views\RecallInvoiceForm.xaml"
            ((POS.Retail.RecallInvoiceForm)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_scroll_down = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.btn_scroll_up = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.btn_cancel = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.btn_select = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.btn_type_in = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Views\RecallInvoiceForm.xaml"
            this.btn_type_in.Click += new System.Windows.RoutedEventHandler(this.btn_type_in_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txt_type_holdid = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\Views\RecallInvoiceForm.xaml"
            this.txt_type_holdid.KeyDown += new System.Windows.Input.KeyEventHandler(this.txt_type_holdid_KeyDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.dg_recall_invoices = ((System.Windows.Controls.DataGrid)(target));
            
            #line 28 "..\..\..\Views\RecallInvoiceForm.xaml"
            this.dg_recall_invoices.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dg_recall_invoices_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

