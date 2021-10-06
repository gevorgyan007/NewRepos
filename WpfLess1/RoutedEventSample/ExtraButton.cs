using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RoutedEventSample
{
    class ExtraButton : Button
    {
        public static RoutedEvent MyButtonEventClick;
        

        static ExtraButton() 
        {
            MyButtonEventClick = EventManager.RegisterRoutedEvent("MyButtonEvent",
                                                            RoutingStrategy.Tunnel,
                                                            typeof(RoutedEventHandler),
                                                            typeof(ExtraButton)
                                                            ); 
        }

        public event RoutedEventHandler MyButtonClick
        {
            add { AddHandler(MyButtonEventClick, value); }
            remove { RemoveHandler(MyButtonEventClick, value); }
        }

        protected override void OnClick()
        {
            base.OnClick();
            RoutedEventArgs routedEventArgs = new RoutedEventArgs(ExtraButton.MyButtonEventClick,this);
            RaiseEvent(routedEventArgs);
        }
    }
}
