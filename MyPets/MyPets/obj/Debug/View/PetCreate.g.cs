﻿#pragma checksum "..\..\..\View\PetCreate.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2C3978F0712C0C0F01E15619ED9C17B7959F2773"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MyPets;
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


namespace MyPets {
    
    
    /// <summary>
    /// PetCreate
    /// </summary>
    public partial class PetCreate : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\View\PetCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton CatRadioButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\View\PetCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton DogRadioButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\View\PetCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTextBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\View\PetCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox KindCB;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\View\PetCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AgeTextBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\View\PetCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxWeight;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\View\PetCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton MaleRadioButton;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\View\PetCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton FemaleRadioButton;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\View\PetCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ValidLabel;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\View\PetCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox PhotoCheckBox;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\View\PetCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtBack;
        
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
            System.Uri resourceLocater = new System.Uri("/MyPets;component/view/petcreate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\PetCreate.xaml"
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
            this.CatRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 25 "..\..\..\View\PetCreate.xaml"
            this.CatRadioButton.Checked += new System.Windows.RoutedEventHandler(this.CatRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DogRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 28 "..\..\..\View\PetCreate.xaml"
            this.DogRadioButton.Checked += new System.Windows.RoutedEventHandler(this.DogRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.KindCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.AgeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TextBoxWeight = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.MaleRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 47 "..\..\..\View\PetCreate.xaml"
            this.MaleRadioButton.Checked += new System.Windows.RoutedEventHandler(this.MaleRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.FemaleRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 50 "..\..\..\View\PetCreate.xaml"
            this.FemaleRadioButton.Checked += new System.Windows.RoutedEventHandler(this.FemaleRadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ValidLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.PhotoCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 11:
            
            #line 60 "..\..\..\View\PetCreate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Creating);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ButtBack = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\View\PetCreate.xaml"
            this.ButtBack.Click += new System.Windows.RoutedEventHandler(this.Button_Click_BACK);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
