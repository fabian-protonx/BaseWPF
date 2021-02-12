using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_GUI_04.Controls
{
    /// <summary>
    /// Interaktionslogik für MenuButton.xaml
    /// </summary>
    public partial class MenuButton : UserControl
    {
        public MenuButton()
        {
            InitializeComponent();
        }

        // DefaultImage="/WPF-GUI-04;component/Resources/hamburger01.svg"
        // Source="{Binding DefaultImage, ElementName=menuBtnControl}"

        //public override void OnApplyTemplate()
        //{
        //    Binding defaultImageBinding = new Binding
        //    {
        //        Path = new PropertyPath(DefaultImage),
        //        Source = this
        //    };

        //    this.btnPower.SetBinding(Source, defaultImageBinding);


        //    base.OnApplyTemplate();
        //}

        #region DependencyProperty MenuTitle

        /// <summary>
        /// Registers a dependency property as backing store for the DefaultImage property
        /// </summary>
        public static readonly DependencyProperty MenuTitleProperty =
            DependencyProperty.Register("MenuTitle", typeof(string), typeof(MenuButton), new PropertyMetadata(string.Empty));

        /// <summary>
        /// Gets or sets the DefaultImage.
        /// </summary>
        /// <value>The DefaultImage.</value>
        public string MenuTitle
        {
            get { return (string)GetValue(MenuButton.MenuTitleProperty); }
            set { SetValue(MenuButton.MenuTitleProperty, value); }
        }

        #endregion

        #region DependencyProperty DefaultImage

        /// <summary>
        /// Registers a dependency property as backing store for the DefaultImage property
        /// </summary>
        public static readonly DependencyProperty DefaultImageProperty =
            DependencyProperty.Register("DefaultImage", typeof(string), typeof(MenuButton), new PropertyMetadata(string.Empty));

        /// <summary>
        /// Gets or sets the DefaultImage.
        /// </summary>
        /// <value>The DefaultImage.</value>
        public string DefaultImage
        {
            get { return (string) GetValue(MenuButton.DefaultImageProperty); }
            set { SetValue(MenuButton.DefaultImageProperty, value); }
        }

        #endregion

        #region DependencyProperty HoverImage

        /// <summary>
        /// Registers a dependency property as backing store for the HoverImage property
        /// </summary>
        public static readonly DependencyProperty HoverImageProperty =
            DependencyProperty.Register("HoverImage", typeof(string), typeof(MenuButton), new PropertyMetadata(string.Empty));

        /// <summary>
        /// Gets or sets the DefaultImage.
        /// </summary>
        /// <value>The DefaultImage.</value>
        public string HoverImage
        {
            get { return (string)GetValue(MenuButton.HoverImageProperty); }
            set { SetValue(MenuButton.HoverImageProperty, value); }
        }

        #endregion

        #region DependencyProperty PathGeometrie

        /// <summary>
        /// Registers a dependency property as backing store for the HoverImage property
        /// </summary>
        public static readonly DependencyProperty PathGeometrieProperty =
            DependencyProperty.Register("PathGeometrie", typeof(string), typeof(MenuButton), new PropertyMetadata(string.Empty));

        /// <summary>
        /// Gets or sets the DefaultImage.
        /// </summary>
        /// <value>The DefaultImage.</value>
        public string PathGeometrie
        {
            get { return (string)GetValue(MenuButton.PathGeometrieProperty); }
            set { SetValue(MenuButton.PathGeometrieProperty, value); }
        }

        #endregion
    }
}