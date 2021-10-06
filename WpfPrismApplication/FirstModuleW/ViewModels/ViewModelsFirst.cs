using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfShered.Events;

namespace FirstModuleW.ViewModels
{
    public class ViewModelsFirst : BindableBase
    {
        private readonly IEventAggregator eventAggregator;

        public ViewModelsFirst(IEventAggregator eventAggregator)
        {
            CommandSend = new DelegateCommand<string>(OnSenderMessage);
            this.eventAggregator = eventAggregator;
        }

        private void OnSenderMessage(string obj)
        {
            eventAggregator.GetEvent<MessageEvent>().Publish(new WpfShered.EventModels.MessageSub()
            {
                Sender = "First Module",
                Message = obj
            });
        }

        public ICommand CommandSend { get; set; }

    }
}
