﻿#pragma checksum "C:\Users\anavarro\Desktop\DI\Visual Studio\07-Canvas\07-Canvas\Pages\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FCD47F073CE49A155748897F89FA8990"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _07_Canvas
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.Canvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 2:
                {
                    this.btnSig = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 19 "..\..\..\Pages\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSig).Click += this.btnSig_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

