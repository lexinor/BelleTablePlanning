﻿#pragma checksum "..\..\Incidents.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2090DA356124CD69BBA825363F8B69359AE857A6"
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
    /// Incidents
    /// </summary>
    public partial class Incidents : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Incidents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox objetIncident;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Incidents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox messageIncident;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Incidents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton critiqueButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Incidents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton urgentButton;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Incidents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton normalButton;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Incidents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image LogoImg;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Incidents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Retour;
        
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
            System.Uri resourceLocater = new System.Uri("/BelleTablePlanning;component/incidents.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Incidents.xaml"
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
            this.objetIncident = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\Incidents.xaml"
            this.objetIncident.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.messageIncident = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\Incidents.xaml"
            this.messageIncident.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.critiqueButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 17 "..\..\Incidents.xaml"
            this.critiqueButton.Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.urgentButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 18 "..\..\Incidents.xaml"
            this.urgentButton.Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.normalButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 19 "..\..\Incidents.xaml"
            this.normalButton.Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked_2);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 20 "..\..\Incidents.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LogoImg = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.btn_Retour = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Incidents.xaml"
            this.btn_Retour.Click += new System.Windows.RoutedEventHandler(this.btn_Retour_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

