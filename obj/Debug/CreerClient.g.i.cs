﻿#pragma checksum "..\..\CreerClient.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25D26F2A27E286A9197106996FA7A2334497C17F"
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
    /// CreerClient
    /// </summary>
    public partial class CreerClient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\CreerClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image LogoImg;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\CreerClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Retour;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\CreerClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label titre;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\CreerClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nomText;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\CreerClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox prenomText;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\CreerClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mailText;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\CreerClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox adresseText;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\CreerClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox telephoneText;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\CreerClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox structureBox;
        
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
            System.Uri resourceLocater = new System.Uri("/BelleTablePlanning;component/creerclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CreerClient.xaml"
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
            this.LogoImg = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.btn_Retour = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\CreerClient.xaml"
            this.btn_Retour.Click += new System.Windows.RoutedEventHandler(this.btn_Retour_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.titre = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.nomText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.prenomText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.mailText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.adresseText = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 8:
            this.telephoneText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.structureBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            
            #line 36 "..\..\CreerClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
