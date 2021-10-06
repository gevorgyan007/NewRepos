using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfShered.EventModels;

namespace WpfShered.Events
{
    public class MessageEvent : PubSubEvent<MessageSub>
    {
    }
}
