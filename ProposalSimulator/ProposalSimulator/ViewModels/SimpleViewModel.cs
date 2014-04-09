namespace ProposalSimulator.ViewModels
{
    using ProposalSimulator.Controls;

    public class SimpleViewModel
    {
        public static event NeedToChangeContentHandler NeedToChangeContent;

        private void ChangeContentEvent(object o, NeedToChangeContentEventArg e)
        {
            if (NeedToChangeContent != null)
                NeedToChangeContent(o, e);
        }

        public void MoveToAdvanced()
        {
            var evt = new NeedToChangeContentEventArg("AdvancedView");
            ChangeContentEvent(this, evt);
        }
    }
}