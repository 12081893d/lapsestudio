
// This file has been generated by the GUI designer. Do not modify.
namespace LapseStudioGtkUI
{
	public partial class MySettingsDialog
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label ThreadLabel;
		private global::Gtk.Fixed fixed3;
		private global::Gtk.SpinButton ThreadSpin;
		private global::Gtk.CheckButton AutothreadChBox;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Label LanguageLabel;
		private global::Gtk.Fixed fixed4;
		private global::Gtk.ComboBox LanguageCoBox;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Label ProgramLabel;
		private global::Gtk.Fixed fixed5;
		private global::Gtk.ComboBox ProgramCoBox;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Fixed fixed2;
		private global::Gtk.VBox vbox3;
		private global::Gtk.CheckButton RunRTChBox;
		private global::Gtk.CheckButton KeepPP3ChBox;
		private global::Gtk.HBox hbox5;
		private global::Gtk.Label RTLabel;
		private global::Gtk.Fixed fixed6;
		private global::Gtk.Entry RTPathBox;
		private global::Gtk.Button RTBrowseButton;
		private global::Gtk.HBox hbox6;
		private global::Gtk.Label FormatLabel;
		private global::Gtk.Fixed fixed7;
		private global::Gtk.ComboBox FormatCoBox;
		private global::Gtk.HBox hbox7;
		private global::Gtk.Label BitDepthLabel;
		private global::Gtk.Fixed fixed8;
		private global::Gtk.ComboBox BitdepthCoBox;
		private global::Gtk.HBox hbox8;
		private global::Gtk.Label JpgQualityLabel;
		private global::Gtk.Fixed fixed9;
		private global::Gtk.HScale JpgQualityScale;
		private global::Gtk.HBox hbox9;
		private global::Gtk.Label CompressionLabel;
		private global::Gtk.Fixed fixed10;
		private global::Gtk.ComboBox CompressionCoBox;
		private global::Gtk.Fixed fixed1;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LapseStudioGtkUI.MySettingsDialog
			this.Name = "LapseStudioGtkUI.MySettingsDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Settings");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-preferences", global::Gtk.IconSize.Menu);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.Resizable = false;
			this.AllowGrow = false;
			// Internal child LapseStudioGtkUI.MySettingsDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.ThreadLabel = new global::Gtk.Label ();
			this.ThreadLabel.Name = "ThreadLabel";
			this.ThreadLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Threads:");
			this.hbox1.Add (this.ThreadLabel);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.ThreadLabel]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.fixed3 = new global::Gtk.Fixed ();
			this.fixed3.Name = "fixed3";
			this.fixed3.HasWindow = false;
			this.hbox1.Add (this.fixed3);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.fixed3]));
			w3.Position = 1;
			// Container child hbox1.Gtk.Box+BoxChild
			this.ThreadSpin = new global::Gtk.SpinButton (1D, 100D, 1D);
			this.ThreadSpin.CanFocus = true;
			this.ThreadSpin.Name = "ThreadSpin";
			this.ThreadSpin.Adjustment.PageIncrement = 1D;
			this.ThreadSpin.ClimbRate = 1D;
			this.ThreadSpin.Numeric = true;
			this.ThreadSpin.Value = 1D;
			this.hbox1.Add (this.ThreadSpin);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.ThreadSpin]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.AutothreadChBox = new global::Gtk.CheckButton ();
			this.AutothreadChBox.CanFocus = true;
			this.AutothreadChBox.Name = "AutothreadChBox";
			this.AutothreadChBox.Label = global::Mono.Unix.Catalog.GetString ("Autothreads");
			this.AutothreadChBox.DrawIndicator = true;
			this.AutothreadChBox.UseUnderline = true;
			this.hbox1.Add (this.AutothreadChBox);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.AutothreadChBox]));
			w5.Position = 3;
			w5.Expand = false;
			w5.Padding = ((uint)(4));
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.LanguageLabel = new global::Gtk.Label ();
			this.LanguageLabel.Name = "LanguageLabel";
			this.LanguageLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Language:");
			this.hbox2.Add (this.LanguageLabel);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.LanguageLabel]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.fixed4 = new global::Gtk.Fixed ();
			this.fixed4.Name = "fixed4";
			this.fixed4.HasWindow = false;
			this.hbox2.Add (this.fixed4);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.fixed4]));
			w8.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.LanguageCoBox = global::Gtk.ComboBox.NewText ();
			this.LanguageCoBox.WidthRequest = 170;
			this.LanguageCoBox.Name = "LanguageCoBox";
			this.hbox2.Add (this.LanguageCoBox);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.LanguageCoBox]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.ProgramLabel = new global::Gtk.Label ();
			this.ProgramLabel.Name = "ProgramLabel";
			this.ProgramLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Used Program:");
			this.hbox3.Add (this.ProgramLabel);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.ProgramLabel]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.fixed5 = new global::Gtk.Fixed ();
			this.fixed5.Name = "fixed5";
			this.fixed5.HasWindow = false;
			this.hbox3.Add (this.fixed5);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.fixed5]));
			w12.Position = 1;
			// Container child hbox3.Gtk.Box+BoxChild
			this.ProgramCoBox = global::Gtk.ComboBox.NewText ();
			this.ProgramCoBox.WidthRequest = 170;
			this.ProgramCoBox.Name = "ProgramCoBox";
			this.hbox3.Add (this.ProgramCoBox);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.ProgramCoBox]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			this.vbox2.Add (this.hbox3);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.fixed2 = new global::Gtk.Fixed ();
			this.fixed2.WidthRequest = 130;
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			this.hbox4.Add (this.fixed2);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.fixed2]));
			w15.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.RunRTChBox = new global::Gtk.CheckButton ();
			this.RunRTChBox.CanFocus = true;
			this.RunRTChBox.Name = "RunRTChBox";
			this.RunRTChBox.Label = global::Mono.Unix.Catalog.GetString ("Run RawTherapee");
			this.RunRTChBox.DrawIndicator = true;
			this.RunRTChBox.UseUnderline = true;
			this.vbox3.Add (this.RunRTChBox);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.RunRTChBox]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.KeepPP3ChBox = new global::Gtk.CheckButton ();
			this.KeepPP3ChBox.CanFocus = true;
			this.KeepPP3ChBox.Name = "KeepPP3ChBox";
			this.KeepPP3ChBox.Label = global::Mono.Unix.Catalog.GetString ("Keep PP3");
			this.KeepPP3ChBox.DrawIndicator = true;
			this.KeepPP3ChBox.UseUnderline = true;
			this.vbox3.Add (this.KeepPP3ChBox);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.KeepPP3ChBox]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.hbox4.Add (this.vbox3);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.vbox3]));
			w18.Position = 1;
			this.vbox2.Add (this.hbox4);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox4]));
			w19.Position = 3;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.RTLabel = new global::Gtk.Label ();
			this.RTLabel.Name = "RTLabel";
			this.RTLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("RawTherapee:");
			this.hbox5.Add (this.RTLabel);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.RTLabel]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.fixed6 = new global::Gtk.Fixed ();
			this.fixed6.Name = "fixed6";
			this.fixed6.HasWindow = false;
			this.hbox5.Add (this.fixed6);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.fixed6]));
			w21.Position = 1;
			// Container child hbox5.Gtk.Box+BoxChild
			this.RTPathBox = new global::Gtk.Entry ();
			this.RTPathBox.CanFocus = true;
			this.RTPathBox.Name = "RTPathBox";
			this.RTPathBox.IsEditable = false;
			this.RTPathBox.InvisibleChar = '●';
			this.hbox5.Add (this.RTPathBox);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.RTPathBox]));
			w22.Position = 2;
			// Container child hbox5.Gtk.Box+BoxChild
			this.RTBrowseButton = new global::Gtk.Button ();
			this.RTBrowseButton.CanFocus = true;
			this.RTBrowseButton.Name = "RTBrowseButton";
			this.RTBrowseButton.Label = global::Mono.Unix.Catalog.GetString ("...");
			this.hbox5.Add (this.RTBrowseButton);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.RTBrowseButton]));
			w23.Position = 3;
			w23.Expand = false;
			w23.Fill = false;
			this.vbox2.Add (this.hbox5);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox5]));
			w24.Position = 4;
			w24.Expand = false;
			w24.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.FormatLabel = new global::Gtk.Label ();
			this.FormatLabel.Name = "FormatLabel";
			this.FormatLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("File Format:");
			this.hbox6.Add (this.FormatLabel);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.FormatLabel]));
			w25.Position = 0;
			w25.Expand = false;
			w25.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.fixed7 = new global::Gtk.Fixed ();
			this.fixed7.Name = "fixed7";
			this.fixed7.HasWindow = false;
			this.hbox6.Add (this.fixed7);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.fixed7]));
			w26.Position = 1;
			// Container child hbox6.Gtk.Box+BoxChild
			this.FormatCoBox = global::Gtk.ComboBox.NewText ();
			this.FormatCoBox.WidthRequest = 100;
			this.FormatCoBox.Name = "FormatCoBox";
			this.hbox6.Add (this.FormatCoBox);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.FormatCoBox]));
			w27.Position = 2;
			w27.Expand = false;
			w27.Fill = false;
			this.vbox2.Add (this.hbox6);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox6]));
			w28.Position = 5;
			w28.Expand = false;
			w28.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.BitDepthLabel = new global::Gtk.Label ();
			this.BitDepthLabel.Name = "BitDepthLabel";
			this.BitDepthLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Bit Depth:");
			this.hbox7.Add (this.BitDepthLabel);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.BitDepthLabel]));
			w29.Position = 0;
			w29.Expand = false;
			w29.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.fixed8 = new global::Gtk.Fixed ();
			this.fixed8.Name = "fixed8";
			this.fixed8.HasWindow = false;
			this.hbox7.Add (this.fixed8);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.fixed8]));
			w30.Position = 1;
			// Container child hbox7.Gtk.Box+BoxChild
			this.BitdepthCoBox = global::Gtk.ComboBox.NewText ();
			this.BitdepthCoBox.WidthRequest = 100;
			this.BitdepthCoBox.Name = "BitdepthCoBox";
			this.hbox7.Add (this.BitdepthCoBox);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.BitdepthCoBox]));
			w31.Position = 2;
			w31.Expand = false;
			w31.Fill = false;
			this.vbox2.Add (this.hbox7);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox7]));
			w32.Position = 6;
			w32.Expand = false;
			w32.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.JpgQualityLabel = new global::Gtk.Label ();
			this.JpgQualityLabel.Name = "JpgQualityLabel";
			this.JpgQualityLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Jpg Quality:");
			this.hbox8.Add (this.JpgQualityLabel);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.JpgQualityLabel]));
			w33.Position = 0;
			w33.Expand = false;
			w33.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.fixed9 = new global::Gtk.Fixed ();
			this.fixed9.Name = "fixed9";
			this.fixed9.HasWindow = false;
			this.hbox8.Add (this.fixed9);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.fixed9]));
			w34.Position = 1;
			// Container child hbox8.Gtk.Box+BoxChild
			this.JpgQualityScale = new global::Gtk.HScale (null);
			this.JpgQualityScale.WidthRequest = 100;
			this.JpgQualityScale.CanFocus = true;
			this.JpgQualityScale.Name = "JpgQualityScale";
			this.JpgQualityScale.Adjustment.Lower = 1D;
			this.JpgQualityScale.Adjustment.Upper = 100D;
			this.JpgQualityScale.Adjustment.PageIncrement = 10D;
			this.JpgQualityScale.Adjustment.StepIncrement = 10D;
			this.JpgQualityScale.Adjustment.Value = 100D;
			this.JpgQualityScale.DrawValue = true;
			this.JpgQualityScale.Digits = 0;
			this.JpgQualityScale.ValuePos = ((global::Gtk.PositionType)(0));
			this.hbox8.Add (this.JpgQualityScale);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.JpgQualityScale]));
			w35.Position = 2;
			this.vbox2.Add (this.hbox8);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox8]));
			w36.Position = 7;
			w36.Expand = false;
			w36.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox ();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.CompressionLabel = new global::Gtk.Label ();
			this.CompressionLabel.Name = "CompressionLabel";
			this.CompressionLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Tiff Compression:");
			this.hbox9.Add (this.CompressionLabel);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.CompressionLabel]));
			w37.Position = 0;
			w37.Expand = false;
			w37.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.fixed10 = new global::Gtk.Fixed ();
			this.fixed10.Name = "fixed10";
			this.fixed10.HasWindow = false;
			this.hbox9.Add (this.fixed10);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.fixed10]));
			w38.Position = 1;
			// Container child hbox9.Gtk.Box+BoxChild
			this.CompressionCoBox = global::Gtk.ComboBox.NewText ();
			this.CompressionCoBox.WidthRequest = 100;
			this.CompressionCoBox.Name = "CompressionCoBox";
			this.hbox9.Add (this.CompressionCoBox);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.CompressionCoBox]));
			w39.Position = 2;
			w39.Expand = false;
			w39.Fill = false;
			this.vbox2.Add (this.hbox9);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox9]));
			w40.Position = 8;
			w40.Expand = false;
			w40.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.vbox2.Add (this.fixed1);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.fixed1]));
			w41.Position = 9;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w42.Position = 0;
			w42.Expand = false;
			w42.Fill = false;
			// Internal child LapseStudioGtkUI.MySettingsDialog.ActionArea
			global::Gtk.HButtonBox w43 = this.ActionArea;
			w43.Name = "dialog1_ActionArea";
			w43.Spacing = 10;
			w43.BorderWidth = ((uint)(5));
			w43.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w44 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w43 [this.buttonCancel]));
			w44.Expand = false;
			w44.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w45 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w43 [this.buttonOk]));
			w45.Position = 1;
			w45.Expand = false;
			w45.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 328;
			this.DefaultHeight = 406;
			this.Show ();
			this.AutothreadChBox.Toggled += new global::System.EventHandler (this.OnAutothreadChBoxToggled);
			this.LanguageCoBox.Changed += new global::System.EventHandler (this.OnLanguageCoBoxChanged);
			this.ProgramCoBox.Changed += new global::System.EventHandler (this.OnProgramCoBoxChanged);
			this.RunRTChBox.Toggled += new global::System.EventHandler (this.OnRunRTChBoxToggled);
			this.RTBrowseButton.Clicked += new global::System.EventHandler (this.OnRTBrowseButtonClicked);
			this.FormatCoBox.Changed += new global::System.EventHandler (this.OnFormatCoBoxChanged);
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}