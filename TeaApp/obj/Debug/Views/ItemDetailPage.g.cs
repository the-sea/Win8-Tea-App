﻿

#pragma checksum "E:\project\tea\TeaApp\Views\ItemDetailPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DC7B900C1C2F9C470EF41CD6E0AE6F7E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeaApp
{
    partial class ItemDetailPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 39 "..\..\Views\ItemDetailPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.ListView_SelectionChanged;
                 #line default
                 #line hidden
                #line 39 "..\..\Views\ItemDetailPage.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.itemsList_Loaded;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


