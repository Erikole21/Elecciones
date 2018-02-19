using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Elecciones.Controles
{
    /// <summary>
    /// Class HyperLinkLabel.
    /// </summary>
    public class HyperLinkLabel : Label
    {

        /// <summary>
        /// The subject property
        /// </summary>
        public static readonly BindableProperty SubjectProperty = BindableProperty.Create("Subject", typeof(string),
            typeof(HyperLinkLabel), string.Empty, BindingMode.OneWay, null, null, null, null);
        
        /// <summary>
        /// The navigate URI property
        /// </summary>
        public static readonly BindableProperty NavigateUriProperty = BindableProperty.Create("NavigateUri", typeof(string),
            typeof(HyperLinkLabel), string.Empty, BindingMode.OneWay, null, null, null, null);

        /// <summary>
        /// The navigate command property
        /// </summary>
        public static readonly BindableProperty NavigateCommandProperty = BindableProperty.Create("NavigateCommand", typeof(ICommand),
            typeof(HyperLinkLabel), null, BindingMode.OneWay, null, null, null, null);

        private TapGestureRecognizer _tapGestureRecognizer;


        /// <summary>
        /// Initializes static members of the <see cref="HyperLinkLabel" /> class.
        /// </summary>
        static HyperLinkLabel()
        {

        }

        private string NavigateUriOld = string.Empty;        

        /// <summary>
        /// Initializes a new instance of the <see cref="HyperLinkLabel"/> class.
        /// </summary>
        public HyperLinkLabel()
        {
            NavigateCommand = new Command(() =>
            {
                //Se valida para evitar q en aplicaciones windows abra dos veces el link
                if (NavigateUriOld != NavigateUri)
                {
                    NavigateUriOld = NavigateUri;
                    Device.OpenUri(new Uri(NavigateUri));
                    Task.Factory.StartNew(() => {
                        Thread.Sleep(100);
                        NavigateUriOld = string.Empty;
                    });
                }
                
            });
            _tapGestureRecognizer = new TapGestureRecognizer() { Command = NavigateCommand };
            GestureRecognizers.Add(_tapGestureRecognizer);
        }

        
        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>The subject.</value>
        public string Subject
        {
            get { return (string)base.GetValue(SubjectProperty); }
            set { base.SetValue(SubjectProperty, value); }
        }

        /// <summary>
        /// Gets or sets the navigate URI.
        /// </summary>
        /// <value>The navigate URI.</value>
        public string NavigateUri
        {
            get { return (string)base.GetValue(NavigateUriProperty); }
            set { base.SetValue(NavigateUriProperty, value); }
        }

        /// <summary>
        /// Gets or sets the navigate command.
        /// </summary>
        /// <value>The navigate command.</value>
        public ICommand NavigateCommand
        {
            get { return (ICommand)base.GetValue(NavigateCommandProperty); }
            set { base.SetValue(NavigateCommandProperty, value); }
        }
        #region Overrides of BindableObject



        /// <param name="propertyName">The name of the property that changed.</param>
        /// <summary>
        /// Call this method from a child class to notify that a change happened on a property.
        /// </summary>
        /// <remarks>
        /// <para>
        /// A <see cref="T:Xamarin.Forms.BindableProperty"/> triggers this by itself. An inheritor only needs to call this for properties without <see cref="T:Xamarin.Forms.BindableProperty"/> as the backend store.
        /// </para>
        /// </remarks>
        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == "NavigateCommand")
            {
                this.GestureRecognizers.Remove(_tapGestureRecognizer);
                _tapGestureRecognizer = new TapGestureRecognizer() { Command = NavigateCommand };
                GestureRecognizers.Add(_tapGestureRecognizer);
            }
        }
        #endregion

    }
}
