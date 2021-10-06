using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfShered.EventModels;
using WpfShered.Events;

namespace SecondModuleW.ViewModels
{
    public class SecondViewModel
    {
        private readonly IEventAggregator eventAggregate;

        public SecondViewModel(IEventAggregator eventAggregate)
        {
            CommandSend = new DelegateCommand<string>(OnSender);
            Messages = new ObservableCollection<string>();
            this.eventAggregate = eventAggregate;
            this.eventAggregate.GetEvent<MessageEvent>().Subscribe(OnGetMessage);
        }

        private void OnGetMessage(MessageSub obj)
        {
            Messages.Add(obj.Message);
        }

        private void OnSender(string obj)
        {
            eventAggregate.GetEvent<MessageEvent>().Publish(new MessageSub()
            {
                Sender = "Second Module",
                Message = obj
            }); 
        }

        public ICommand CommandSend { get; set; }

        public ObservableCollection<string> Messages { get; set; }
    }
}
