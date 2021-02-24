
namespace FastExperience.Tools.Translation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public sealed class MessageContainer
    {
        public MessageContainer(Action<object, EventArgs> showMessage)
            => ShowMessage = showMessage;
        public List<string> Message => _messages;
        public Action<object, EventArgs> ShowMessage;

        //public void ReleaseMessage()
        //    => _releaseMessage();
        public bool StateRelesed => _stateReleased;

        private List<string> _messages;
        private bool _stateReleased;

        public void AddMessages(List<string> messages) 
            => _messages.AddRange(messages);

        public void AddMessages(List<string> messages, bool stateToReleased)
        {
            _messages.AddRange(messages);
                if (stateToReleased)
                 _stateReleased = stateToReleased;
        }
        public void AddMessage(string message)
                => _messages.Add(message);
        public void AddMessage(string message, bool stateToReleased)
        {
            _messages.Add(message);
            if (stateToReleased)
                _stateReleased = stateToReleased;
        }

        public void Initialize()
        {
            _messages = new List<string>();
            _stateReleased = false;
        }

        public void SetReleasemMessageAction(Action<object, EventArgs> releaseMessageAction)
            => ShowMessage =  releaseMessageAction;


        public string GetFormatedMessage()
        {
            var messageBuilder = new StringBuilder();
            foreach (var message in _messages)
                messageBuilder.AppendLine(message);
            return messageBuilder.ToString();
        }

        public void ReleseMessages() 
            => _stateReleased = true;
    }
}