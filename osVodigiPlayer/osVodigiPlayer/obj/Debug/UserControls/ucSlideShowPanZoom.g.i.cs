﻿#pragma checksum "..\..\..\UserControls\ucSlideShowPanZoom.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AD12B053F6E36D2FE33F161FE54C8FE40665E244"
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


namespace osVodigiPlayer.UserControls {
    
    
    /// <summary>
    /// ucSlideShowPanZoom
    /// </summary>
    public partial class ucSlideShowPanZoom : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 63 "..\..\..\UserControls\ucSlideShowPanZoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridMain;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\UserControls\ucSlideShowPanZoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.RectangleGeometry rectClip;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\UserControls\ucSlideShowPanZoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgSlideshow1;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\UserControls\ucSlideShowPanZoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ScaleTransform stImageSlideshow1;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\UserControls\ucSlideShowPanZoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgSlideshow2;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\UserControls\ucSlideShowPanZoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ScaleTransform stImageSlideshow2;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\UserControls\ucSlideShowPanZoom.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement mediaPlayer;
        
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
            System.Uri resourceLocater = new System.Uri("/osVodigiPlayer;component/usercontrols/ucslideshowpanzoom.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\ucSlideShowPanZoom.xaml"
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
            this.gridMain = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.rectClip = ((System.Windows.Media.RectangleGeometry)(target));
            return;
            case 3:
            this.imgSlideshow1 = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.stImageSlideshow1 = ((System.Windows.Media.ScaleTransform)(target));
            return;
            case 5:
            this.imgSlideshow2 = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.stImageSlideshow2 = ((System.Windows.Media.ScaleTransform)(target));
            return;
            case 7:
            this.mediaPlayer = ((System.Windows.Controls.MediaElement)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

