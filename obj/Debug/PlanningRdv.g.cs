﻿#pragma checksum "..\..\PlanningRdv.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1D0E746F78CAC934696C3A35DE3ECFEEE518B8BB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using BelleTablePlanning;
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


namespace BelleTablePlanning {
    
    
    /// <summary>
    /// PlanningRdv
    /// </summary>
    public partial class PlanningRdv : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\PlanningRdv.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid planningGrid;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\PlanningRdv.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image LogoImg;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\PlanningRdv.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Retour;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\PlanningRdv.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label titre;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\PlanningRdv.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label filtreDate;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\PlanningRdv.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker filtreDatePick;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\PlanningRdv.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnResetFiltre;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\PlanningRdv.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDetailsRdv;
        
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
            System.Uri resourceLocater = new System.Uri("/BelleTablePlanning;component/planningrdv.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PlanningRdv.xaml"
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
            this.planningGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.LogoImg = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.btn_Retour = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\PlanningRdv.xaml"
            this.btn_Retour.Click += new System.Windows.RoutedEventHandler(this.btn_Retour_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.titre = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.filtreDate = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.filtreDatePick = ((System.Windows.Controls.DatePicker)(target));
            
            #line 34 "..\..\PlanningRdv.xaml"
            this.filtreDatePick.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.filtreDatePick_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnResetFiltre = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\PlanningRdv.xaml"
            this.btnResetFiltre.Click += new System.Windows.RoutedEventHandler(this.btnResetFiltre_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnDetailsRdv = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\PlanningRdv.xaml"
            this.btnDetailsRdv.Click += new System.Windows.RoutedEventHandler(this.btnDetailsRdv_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

