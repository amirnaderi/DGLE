
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action FileAction;
	private global::Gtk.Action CloseAction;
	private global::Gtk.Action HelpAction;
	private global::Gtk.Action AboutAction;
	private global::Gtk.Fixed fixed1;
	private global::ColorPicker.ColorSpectrum colorSpectrum;
	private global::Gtk.HScale redScale;
	private global::Gtk.HScale greenScale;
	private global::Gtk.HScale blueScale;
	private global::Gtk.HScale alphaScale;
	private global::Gtk.Label label1;
	private global::Gtk.Label label2;
	private global::Gtk.Label label3;
	private global::Gtk.Label label4;
	private global::Gtk.DrawingArea colorView;
	private global::Gtk.Label label5;
	private global::Gtk.Entry colorCode;
	private global::ColorPicker.ColorSaturation colorSaturation;
	private global::ColorPicker.ColorBrightness colorBrightness;
	private global::ColorPicker.ColorSquare colorSquare;
	private global::Gtk.MenuBar menubar1;
	private global::ColorPicker.AlphaView alphaView;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("LOL");
		w1.Add (this.FileAction, null);
		this.CloseAction = new global::Gtk.Action ("CloseAction", global::Mono.Unix.Catalog.GetString ("Close"), null, null);
		this.CloseAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
		w1.Add (this.CloseAction, null);
		this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
		w1.Add (this.HelpAction, null);
		this.AboutAction = new global::Gtk.Action ("AboutAction", global::Mono.Unix.Catalog.GetString ("About"), null, null);
		this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
		w1.Add (this.AboutAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.colorSpectrum = new global::ColorPicker.ColorSpectrum ();
		this.colorSpectrum.WidthRequest = 256;
		this.colorSpectrum.HeightRequest = 128;
		this.colorSpectrum.Name = "colorSpectrum";
		this.colorSpectrum.Red = ((ushort)(0));
		this.colorSpectrum.Green = ((ushort)(0));
		this.colorSpectrum.Blue = ((ushort)(0));
		this.fixed1.Add (this.colorSpectrum);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.colorSpectrum]));
		w2.X = 210;
		w2.Y = 30;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.redScale = new global::Gtk.HScale (null);
		this.redScale.WidthRequest = 128;
		this.redScale.CanFocus = true;
		this.redScale.Name = "redScale";
		this.redScale.Adjustment.Upper = 255D;
		this.redScale.Adjustment.PageIncrement = 10D;
		this.redScale.Adjustment.StepIncrement = 1D;
		this.redScale.Adjustment.Value = 255D;
		this.redScale.DrawValue = true;
		this.redScale.Digits = 0;
		this.redScale.ValuePos = ((global::Gtk.PositionType)(2));
		this.fixed1.Add (this.redScale);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.redScale]));
		w3.X = 55;
		w3.Y = 186;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.greenScale = new global::Gtk.HScale (null);
		this.greenScale.WidthRequest = 128;
		this.greenScale.CanFocus = true;
		this.greenScale.Name = "greenScale";
		this.greenScale.Adjustment.Upper = 255D;
		this.greenScale.Adjustment.PageIncrement = 10D;
		this.greenScale.Adjustment.StepIncrement = 1D;
		this.greenScale.Adjustment.Value = 255D;
		this.greenScale.DrawValue = true;
		this.greenScale.Digits = 0;
		this.greenScale.ValuePos = ((global::Gtk.PositionType)(2));
		this.fixed1.Add (this.greenScale);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.greenScale]));
		w4.X = 55;
		w4.Y = 232;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.blueScale = new global::Gtk.HScale (null);
		this.blueScale.WidthRequest = 128;
		this.blueScale.CanFocus = true;
		this.blueScale.Name = "blueScale";
		this.blueScale.Adjustment.Upper = 255D;
		this.blueScale.Adjustment.PageIncrement = 10D;
		this.blueScale.Adjustment.StepIncrement = 1D;
		this.blueScale.Adjustment.Value = 255D;
		this.blueScale.DrawValue = true;
		this.blueScale.Digits = 0;
		this.blueScale.ValuePos = ((global::Gtk.PositionType)(2));
		this.fixed1.Add (this.blueScale);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.blueScale]));
		w5.X = 55;
		w5.Y = 281;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.alphaScale = new global::Gtk.HScale (null);
		this.alphaScale.WidthRequest = 128;
		this.alphaScale.CanFocus = true;
		this.alphaScale.Name = "alphaScale";
		this.alphaScale.Adjustment.Upper = 255D;
		this.alphaScale.Adjustment.PageIncrement = 10D;
		this.alphaScale.Adjustment.StepIncrement = 1D;
		this.alphaScale.Adjustment.Value = 255D;
		this.alphaScale.DrawValue = true;
		this.alphaScale.Digits = 0;
		this.alphaScale.ValuePos = ((global::Gtk.PositionType)(2));
		this.fixed1.Add (this.alphaScale);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.alphaScale]));
		w6.X = 55;
		w6.Y = 330;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Red");
		this.fixed1.Add (this.label1);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label1]));
		w7.X = 8;
		w7.Y = 203;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Green");
		this.fixed1.Add (this.label2);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label2]));
		w8.X = 3;
		w8.Y = 248;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Blue");
		this.fixed1.Add (this.label3);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label3]));
		w9.X = 7;
		w9.Y = 299;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Alpha");
		this.fixed1.Add (this.label4);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label4]));
		w10.X = 7;
		w10.Y = 347;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.colorView = new global::Gtk.DrawingArea ();
		this.colorView.WidthRequest = 60;
		this.colorView.HeightRequest = 60;
		this.colorView.Name = "colorView";
		this.fixed1.Add (this.colorView);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.colorView]));
		w11.X = 210;
		w11.Y = 280;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Color");
		this.fixed1.Add (this.label5);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label5]));
		w12.X = 320;
		w12.Y = 294;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.colorCode = new global::Gtk.Entry ();
		this.colorCode.WidthRequest = 70;
		this.colorCode.CanFocus = true;
		this.colorCode.Name = "colorCode";
		this.colorCode.Text = global::Mono.Unix.Catalog.GetString ("#FFFFFF");
		this.colorCode.IsEditable = true;
		this.colorCode.InvisibleChar = '●';
		this.fixed1.Add (this.colorCode);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.colorCode]));
		w13.X = 300;
		w13.Y = 315;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.colorSaturation = new global::ColorPicker.ColorSaturation ();
		this.colorSaturation.WidthRequest = 128;
		this.colorSaturation.HeightRequest = 14;
		this.colorSaturation.Name = "colorSaturation";
		this.fixed1.Add (this.colorSaturation);
		global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.colorSaturation]));
		w14.X = 8;
		w14.Y = 168;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.colorBrightness = new global::ColorPicker.ColorBrightness ();
		this.colorBrightness.WidthRequest = 14;
		this.colorBrightness.HeightRequest = 128;
		this.colorBrightness.Name = "colorBrightness";
		this.fixed1.Add (this.colorBrightness);
		global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.colorBrightness]));
		w15.X = 142;
		w15.Y = 30;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.colorSquare = new global::ColorPicker.ColorSquare ();
		this.colorSquare.WidthRequest = 128;
		this.colorSquare.HeightRequest = 128;
		this.colorSquare.Name = "colorSquare";
		this.fixed1.Add (this.colorSquare);
		global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.colorSquare]));
		w16.X = 8;
		w16.Y = 30;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.UIManager.AddUiFromString ("<ui><menubar name=\'menubar1\'><menu name=\'FileAction\' action=\'FileAction\'><menuite" +
			"m name=\'CloseAction\' action=\'CloseAction\'/></menu><menu name=\'HelpAction\' action" +
			"=\'HelpAction\'><menuitem name=\'AboutAction\' action=\'AboutAction\'/></menu></menuba" +
			"r></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.WidthRequest = 478;
		this.menubar1.Name = "menubar1";
		this.fixed1.Add (this.menubar1);
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.alphaView = new global::ColorPicker.AlphaView ();
		this.alphaView.WidthRequest = 60;
		this.alphaView.HeightRequest = 60;
		this.alphaView.Name = "alphaView";
		this.fixed1.Add (this.alphaView);
		global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.alphaView]));
		w18.X = 210;
		w18.Y = 205;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 493;
		this.DefaultHeight = 416;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.CloseAction.Activated += new global::System.EventHandler (this.OnCloseActionActivated);
		this.AboutAction.Activated += new global::System.EventHandler (this.OnAboutActionActivated);
		this.redScale.ValueChanged += new global::System.EventHandler (this.OnRedScaleValueChanged);
		this.greenScale.ValueChanged += new global::System.EventHandler (this.OnGreenScaleValueChanged);
		this.blueScale.ValueChanged += new global::System.EventHandler (this.OnBlueScaleValueChanged);
		this.alphaScale.ValueChanged += new global::System.EventHandler (this.OnAlphaScaleValueChanged);
		this.colorCode.Changed += new global::System.EventHandler (this.OnColorCodeChanged);
	}
}
