﻿#pragma checksum "..\..\..\BusquedaEmpresa.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AAE73CD853695F1306093C5726EB707D63168C83"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.Controls;
using Microsoft.Windows.Controls;
using Microsoft.Windows.Controls.Primitives;
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


namespace BodyEnergy {
    
    
    /// <summary>
    /// BusquedaEmpresa
    /// </summary>
    public partial class BusquedaEmpresa : MahApps.Metro.Controls.MetroWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 3 "..\..\..\BusquedaEmpresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal BodyEnergy.BusquedaEmpresa BEmpresaW;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\BusquedaEmpresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_Empresa;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\BusquedaEmpresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_Empresa;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\BusquedaEmpresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Buscar;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\BusquedaEmpresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Exportar;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\BusquedaEmpresa.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gdv_Empresas;
        
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
            System.Uri resourceLocater = new System.Uri("/BodyEnergy;component/busquedaempresa.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\BusquedaEmpresa.xaml"
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
            this.BEmpresaW = ((BodyEnergy.BusquedaEmpresa)(target));
            
            #line 8 "..\..\..\BusquedaEmpresa.xaml"
            this.BEmpresaW.Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lbl_Empresa = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.txt_Empresa = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btn_Buscar = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\BusquedaEmpresa.xaml"
            this.btn_Buscar.Click += new System.Windows.RoutedEventHandler(this.btn_Buscar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_Exportar = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\BusquedaEmpresa.xaml"
            this.btn_Exportar.Click += new System.Windows.RoutedEventHandler(this.btn_Exportar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.gdv_Empresas = ((System.Windows.Controls.DataGrid)(target));
            
            #line 25 "..\..\..\BusquedaEmpresa.xaml"
            this.gdv_Empresas.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.gdv_Empresas_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
