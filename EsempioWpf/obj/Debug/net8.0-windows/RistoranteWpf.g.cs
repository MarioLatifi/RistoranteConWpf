﻿#pragma checksum "..\..\..\RistoranteWpf.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3A1E36259FAD7886BC5B38DA67D336E92B2E325F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using EsempioWpf;
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


namespace EsempioWpf {
    
    
    /// <summary>
    /// RistoranteWpf
    /// </summary>
    public partial class RistoranteWpf : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\RistoranteWpf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblNomeRisto;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\RistoranteWpf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTavoliPrenotati;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\RistoranteWpf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTavoliLiberi;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\RistoranteWpf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCopertiLiberi;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\RistoranteWpf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPrenota;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\RistoranteWpf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNumClienti;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\RistoranteWpf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNomeCliente;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\RistoranteWpf.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblStato;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EsempioWpf;component/ristorantewpf.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RistoranteWpf.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lblNomeRisto = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.lblTavoliPrenotati = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.lblTavoliLiberi = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.lblCopertiLiberi = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.btnPrenota = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\RistoranteWpf.xaml"
            this.btnPrenota.Click += new System.Windows.RoutedEventHandler(this.ClickPrenota);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtNumClienti = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\RistoranteWpf.xaml"
            this.txtNumClienti.GotFocus += new System.Windows.RoutedEventHandler(this.CleanTxt);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtNomeCliente = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\RistoranteWpf.xaml"
            this.txtNomeCliente.GotFocus += new System.Windows.RoutedEventHandler(this.CleanTxt);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lblStato = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

