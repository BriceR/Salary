namespace ProposalSimulator.Controls
{
    using System;

    public class NeedToChangeContentEventArg : EventArgs
    {
        public readonly string ViewKey;

        public NeedToChangeContentEventArg(string changeToThisView)
        {
            ViewKey = changeToThisView;
        }
    }
}