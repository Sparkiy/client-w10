﻿using Windows.UI.Xaml;

namespace sparkiy.Controls.Pivot
{
	/// <summary>
	/// Pivot tab header.
	/// </summary>
	public sealed partial class PivotTabHeader
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PivotTabHeader"/> class.
		/// </summary>
		public PivotTabHeader()
		{
			this.InitializeComponent();
			this.DataContext = this;
		}


		/// <summary>
		/// Gets or sets the glyph.
		/// </summary>
		/// <value>
		/// The glyph.
		/// </value>
		public string Glyph
		{
			get { return GetValue(GlyphProperty) as string; }
			set { SetValue(GlyphProperty, value); }
		}

		/// <summary>
		/// The glyph property
		/// </summary>
		public static readonly DependencyProperty GlyphProperty = DependencyProperty.Register("Glyph", typeof(string), typeof(PivotTabHeader), new PropertyMetadata(string.Empty));

		/// <summary>
		/// Gets or sets the label.
		/// </summary>
		/// <value>
		/// The label.
		/// </value>
		public string Label
		{
			get { return GetValue(LabelProperty) as string; }
			set { SetValue(LabelProperty, value); }
		}

		/// <summary>
		/// The label property
		/// </summary>
		public static readonly DependencyProperty LabelProperty = DependencyProperty.Register("Label", typeof(string), typeof(PivotTabHeader), new PropertyMetadata(string.Empty));
	}
}
