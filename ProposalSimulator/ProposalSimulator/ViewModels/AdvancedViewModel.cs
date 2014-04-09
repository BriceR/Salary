namespace ProposalSimulator.ViewModels
{
    using ProposalSimulator.Controls;

    public class AdvancedViewModel
    {
        public static event NeedToChangeContentHandler NeedToChangeContent;

        private void ChangeContentEvent(object o, NeedToChangeContentEventArg e)
        {
            if (NeedToChangeContent != null)
                NeedToChangeContent(o, e);
        }

        public void GoBack()
        {
            var evt = new NeedToChangeContentEventArg("SimpleView");
            ChangeContentEvent(this, evt);
        }
    }
}