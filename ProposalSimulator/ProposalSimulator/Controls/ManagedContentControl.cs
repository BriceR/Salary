namespace ProposalSimulator.Controls
{
    using System.Windows.Controls;

    public delegate void NeedToChangeContentHandler(object o, NeedToChangeContentEventArg e);

    public class ManagedContentControl : ContentControl
    {
        public event NeedToChangeContentHandler ChangeContent;

        private void OnNeedToChangeContent(object o, NeedToChangeContentEventArg e)
        {
            if (ChangeContent != null)
                ChangeContent(o, e);
        }
    }
}