using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Markup;
using ProposalSimulator.Entities;

namespace ProposalSimulator.ViewModels
{
    public class SettingsViewModel : BaseObject
    {
        private CultureInfo _currentCultureInfo;

        public SettingsViewModel()
        {
            _currentCultureInfo = Thread.CurrentThread.CurrentCulture;
        }

        public CultureInfo CurrentCultureInfo
        {
            get { return _currentCultureInfo; }
            set
            {
                _currentCultureInfo = value;
                Thread.CurrentThread.CurrentCulture = _currentCultureInfo;
                Thread.CurrentThread.CurrentUICulture = _currentCultureInfo;
                FrameworkElement.LanguageProperty.OverrideMetadata(
                    typeof (FrameworkElement),
                    new FrameworkPropertyMetadata(
                        XmlLanguage.GetLanguage(
                            CultureInfo.CurrentCulture.IetfLanguageTag)));
            }
        }

        public double TauxCadre { get; set; }
        public double TauxNonCadre { get; set; }

        public List<CultureInfo> Cultures
        {
            get { return CultureInfo.GetCultures(CultureTypes.AllCultures).ToList(); }
        }
    }
}