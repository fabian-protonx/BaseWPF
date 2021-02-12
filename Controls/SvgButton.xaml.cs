using System.Windows;
using System.Windows.Controls;

namespace WPF_GUI_04.Controls
{
    /// <summary>
    /// Interaktionslogik für MenuButton.xaml
    /// </summary>
    public partial class SvgButton : UserControl
    {
        public SvgButton()
        {
            InitializeComponent();
        }

        #region DependencyProperty BackgroundColor

        /// <summary>
        /// Registers a dependency property as backing store for the BackgroundColor property
        /// </summary>
        public static readonly DependencyProperty BackgroundColorProperty =
            DependencyProperty.Register("BackgroundColor", typeof(string), typeof(SvgButton), new PropertyMetadata(string.Empty));

        /// <summary>
        /// Gets or sets the BackgroundColor.
        /// </summary>
        /// <value>The BackgroundColor.</value>
        public string BackgroundColor
        {
            get { return (string)GetValue(SvgButton.BackgroundColorProperty); }
            set { SetValue(SvgButton.BackgroundColorProperty, value); }
        }

        #endregion

        #region DependencyProperty BackgroundHoverColor

        /// <summary>
        /// Registers a dependency property as backing store for the BackgroundHoverColor property
        /// </summary>
        public static readonly DependencyProperty BackgroundHoverColorProperty =
            DependencyProperty.Register("BackgroundHoverColor", typeof(string), typeof(SvgButton), new PropertyMetadata(string.Empty));

        /// <summary>
        /// Gets or sets the BackgroundHoverColor.
        /// </summary>
        /// <value>The BackgroundHoverColor.</value>
        public string BackgroundHoverColor
        {
            get { return (string)GetValue(SvgButton.BackgroundHoverColorProperty); }
            set { SetValue(SvgButton.BackgroundHoverColorProperty, value); }
        }

        #endregion

        #region DependencyProperty ForegroundColor

        /// <summary>
        /// Registers a dependency property as backing store for the ForegroundColor property
        /// </summary>
        public static readonly DependencyProperty ForegroundColorProperty =
            DependencyProperty.Register("ForegroundColor", typeof(string), typeof(SvgButton), new PropertyMetadata(string.Empty));

        /// <summary>
        /// Gets or sets the ForegroundColor.
        /// </summary>
        /// <value>The ForegroundColor.</value>
        public string ForegroundColor
        {
            get { return (string)GetValue(SvgButton.ForegroundColorProperty); }
            set { SetValue(SvgButton.ForegroundColorProperty, value); }
        }

        #endregion

        #region DependencyProperty ForegroundHoverColor

        /// <summary>
        /// Registers a dependency property as backing store for the ForegroundColor property
        /// </summary>
        public static readonly DependencyProperty ForegroundHoverColorProperty =
            DependencyProperty.Register("ForegroundHoverColor", typeof(string), typeof(SvgButton), new PropertyMetadata(string.Empty));

        /// <summary>
        /// Gets or sets the ForegroundHoverColor.
        /// </summary>
        /// <value>The ForegroundHoverColor.</value>
        public string ForegroundHoverColor
        {
            get { return (string)GetValue(SvgButton.ForegroundHoverColorProperty); }
            set { SetValue(SvgButton.ForegroundHoverColorProperty, value); }
        }

        #endregion

        #region DependencyProperty DefaultImage

        /// <summary>
        /// Registers a dependency property as backing store for the DefaultImage property
        /// </summary>
        public static readonly DependencyProperty DefaultImageProperty =
            DependencyProperty.Register("DefaultImage", typeof(string), typeof(SvgButton), new PropertyMetadata(string.Empty));

        /// <summary>
        /// Gets or sets the DefaultImage.
        /// </summary>
        /// <value>The DefaultImage.</value>
        public string DefaultImage
        {
            get { return (string) GetValue(SvgButton.DefaultImageProperty); }
            set { SetValue(SvgButton.DefaultImageProperty, value); }
        }

        #endregion

        #region DependencyProperty HoverImage

        /// <summary>
        /// Registers a dependency property as backing store for the HoverImage property
        /// </summary>
        public static readonly DependencyProperty HoverImageProperty =
            DependencyProperty.Register("HoverImage", typeof(string), typeof(SvgButton), new PropertyMetadata(string.Empty));

        /// <summary>
        /// Gets or sets the HoverImage.
        /// </summary>
        /// <value>The HoverImage.</value>
        public string HoverImage
        {
            get { return (string)GetValue(SvgButton.HoverImageProperty); }
            set { SetValue(SvgButton.HoverImageProperty, value); }
        }

        #endregion

        #region DependencyProperty PathGeometrie

        /// <summary>
        /// Registers a dependency property as backing store for the HoverImage property
        /// </summary>
        public static readonly DependencyProperty PathGeometrieProperty =
            DependencyProperty.Register("PathGeometrie", typeof(string), typeof(SvgButton), new PropertyMetadata(string.Empty));

        /// <summary>
        /// Gets or sets the PathGeometrie.
        /// </summary>
        /// <value>The PathGeometrie.</value>
        public string PathGeometrie
        {
            get { return (string)GetValue(SvgButton.PathGeometrieProperty); }
            set { SetValue(SvgButton.PathGeometrieProperty, value); }
        }

        #endregion
    }
}