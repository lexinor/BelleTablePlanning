﻿#pragma checksum "..\..\Messagerie.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B6760F1A067ACE6F1311E56C6034C8EBA651A787"
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
    /// Messagerie
    /// </summary>
    public partial class Messagerie : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\Messagerie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal BelleTablePlanning.Messagerie Messagerie1;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Messagerie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label titre;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Messagerie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sendMsg;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Messagerie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid msgGrid;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Messagerie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button lireMsg_btn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Messagerie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button repMsg_btn;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Messagerie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image LogoImg;
        
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
            System.Uri resourceLocater = new System.Uri("/BelleTablePlanning;component/messagerie.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Messagerie.xaml"
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
            this.Messagerie1 = ((BelleTablePlanning.Messagerie)(target));
            return;
            case 2:
            this.titre = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.sendMsg = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Messagerie.xaml"
            this.sendMsg.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.msgGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.lireMsg_btn = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\Messagerie.xaml"
            this.lireMsg_btn.Click += new System.Windows.RoutedEventHandler(this.lireMsg_btn_Click);
            
            #line default
            #line hidden
            
            #line 26 "..\..\Messagerie.xaml"
            this.lireMsg_btn.MouseEnter += new System.Windows.Input.MouseEventHandler(this.lireMsg_btn_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 6:
            this.repMsg_btn = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Messagerie.xaml"
            this.repMsg_btn.Click += new System.Windows.RoutedEventHandler(this.repMsg_btn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LogoImg = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

