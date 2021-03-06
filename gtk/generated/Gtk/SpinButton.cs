// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class SpinButton : Gtk.Entry {

		public SpinButton (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_spin_button_new(IntPtr adjustment, double climb_rate, uint digits);

		public SpinButton (Gtk.Adjustment adjustment, double climb_rate, uint digits) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (SpinButton)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				if (adjustment != null) {
					names.Add ("adjustment");
					vals.Add (new GLib.Value (adjustment));
				}
				names.Add ("climb_rate");
				vals.Add (new GLib.Value (climb_rate));
				names.Add ("digits");
				vals.Add (new GLib.Value (digits));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_spin_button_new(adjustment == null ? IntPtr.Zero : adjustment.Handle, climb_rate, digits);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_spin_button_get_adjustment(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_spin_button_set_adjustment(IntPtr raw, IntPtr adjustment);

		[GLib.Property ("adjustment")]
		public Gtk.Adjustment Adjustment {
			get  {
				IntPtr raw_ret = gtk_spin_button_get_adjustment(Handle);
				Gtk.Adjustment ret = GLib.Object.GetObject(raw_ret) as Gtk.Adjustment;
				return ret;
			}
			set  {
				gtk_spin_button_set_adjustment(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[GLib.Property ("climb-rate")]
		public double ClimbRate {
			get {
				GLib.Value val = GetProperty ("climb-rate");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("climb-rate", val);
				val.Dispose ();
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gtk_spin_button_get_digits(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_spin_button_set_digits(IntPtr raw, uint digits);

		[GLib.Property ("digits")]
		public uint Digits {
			get  {
				uint raw_ret = gtk_spin_button_get_digits(Handle);
				uint ret = raw_ret;
				return ret;
			}
			set  {
				gtk_spin_button_set_digits(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_spin_button_get_snap_to_ticks(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_spin_button_set_snap_to_ticks(IntPtr raw, bool snap_to_ticks);

		[GLib.Property ("snap-to-ticks")]
		public bool SnapToTicks {
			get  {
				bool raw_ret = gtk_spin_button_get_snap_to_ticks(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_spin_button_set_snap_to_ticks(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_spin_button_get_numeric(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_spin_button_set_numeric(IntPtr raw, bool numeric);

		[GLib.Property ("numeric")]
		public bool Numeric {
			get  {
				bool raw_ret = gtk_spin_button_get_numeric(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_spin_button_set_numeric(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_spin_button_get_wrap(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_spin_button_set_wrap(IntPtr raw, bool wrap);

		[GLib.Property ("wrap")]
		public bool Wrap {
			get  {
				bool raw_ret = gtk_spin_button_get_wrap(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_spin_button_set_wrap(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_spin_button_get_update_policy(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_spin_button_set_update_policy(IntPtr raw, int policy);

		[GLib.Property ("update-policy")]
		public Gtk.SpinButtonUpdatePolicy UpdatePolicy {
			get  {
				int raw_ret = gtk_spin_button_get_update_policy(Handle);
				Gtk.SpinButtonUpdatePolicy ret = (Gtk.SpinButtonUpdatePolicy) raw_ret;
				return ret;
			}
			set  {
				gtk_spin_button_set_update_policy(Handle, (int) value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double gtk_spin_button_get_value(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_spin_button_set_value(IntPtr raw, double value);

		[GLib.Property ("value")]
		public double Value {
			get  {
				double raw_ret = gtk_spin_button_get_value(Handle);
				double ret = raw_ret;
				return ret;
			}
			set  {
				gtk_spin_button_set_value(Handle, value);
			}
		}

		[GLib.Signal("change-value")]
		public event Gtk.ChangeValueHandler ChangeValue {
			add {
				this.AddSignalHandler ("change-value", value, typeof (Gtk.ChangeValueArgs));
			}
			remove {
				this.RemoveSignalHandler ("change-value", value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int InputSignalDelegate (IntPtr inst, out double arg0, IntPtr gch);

		static int InputSignalCallback (IntPtr inst, out double arg0, IntPtr gch)
		{
			Gtk.InputArgs args = new Gtk.InputArgs ();
			try {
				GLib.Signal sig = ((GCHandle) gch).Target as GLib.Signal;
				if (sig == null)
					throw new Exception("Unknown signal GC handle received " + gch);

				args.Args = new object[1];
				Gtk.InputHandler handler = (Gtk.InputHandler) sig.Handler;
				handler (GLib.Object.GetObject (inst), args);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}

			try {
				arg0 = ((double)args.Args[0]);
				return ((int) args.RetVal);
			} catch (Exception) {
				Exception ex = new Exception ("args.RetVal or 'out' property unset or set to incorrect type in Gtk.InputHandler callback");
				GLib.ExceptionManager.RaiseUnhandledException (ex, true);
				// NOTREACHED: above call doesn't return.
				throw ex;
			}
		}

		[GLib.Signal("input")]
		public event Gtk.InputHandler Input {
			add {
				this.AddSignalHandler ("input", value, new InputSignalDelegate(InputSignalCallback));
			}
			remove {
				this.RemoveSignalHandler ("input", value);
			}
		}

		[GLib.Signal("value-changed")]
		public event System.EventHandler ValueChanged {
			add {
				this.AddSignalHandler ("value-changed", value);
			}
			remove {
				this.RemoveSignalHandler ("value-changed", value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int OutputSignalDelegate (IntPtr inst, IntPtr gch);

		static int OutputSignalCallback (IntPtr inst, IntPtr gch)
		{
			Gtk.OutputArgs args = new Gtk.OutputArgs ();
			try {
				GLib.Signal sig = ((GCHandle) gch).Target as GLib.Signal;
				if (sig == null)
					throw new Exception("Unknown signal GC handle received " + gch);

				Gtk.OutputHandler handler = (Gtk.OutputHandler) sig.Handler;
				handler (GLib.Object.GetObject (inst), args);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}

			try {
				return ((int) args.RetVal);
			} catch (Exception) {
				Exception ex = new Exception ("args.RetVal or 'out' property unset or set to incorrect type in Gtk.OutputHandler callback");
				GLib.ExceptionManager.RaiseUnhandledException (ex, true);
				// NOTREACHED: above call doesn't return.
				throw ex;
			}
		}

		[GLib.Signal("output")]
		public event Gtk.OutputHandler Output {
			add {
				this.AddSignalHandler ("output", value, new OutputSignalDelegate(OutputSignalCallback));
			}
			remove {
				this.RemoveSignalHandler ("output", value);
			}
		}

		[GLib.Signal("wrapped")]
		public event System.EventHandler Wrapped {
			add {
				this.AddSignalHandler ("wrapped", value);
			}
			remove {
				this.RemoveSignalHandler ("wrapped", value);
			}
		}

		static InputNativeDelegate Input_cb_delegate;
		static InputNativeDelegate InputVMCallback {
			get {
				if (Input_cb_delegate == null)
					Input_cb_delegate = new InputNativeDelegate (Input_cb);
				return Input_cb_delegate;
			}
		}

		static void OverrideInput (GLib.GType gtype)
		{
			OverrideInput (gtype, InputVMCallback);
		}

		static void OverrideInput (GLib.GType gtype, InputNativeDelegate callback)
		{
			GtkSpinButtonClass class_iface = GetClassStruct (gtype, false);
			class_iface.Input = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int InputNativeDelegate (IntPtr inst, out double new_value);

		static int Input_cb (IntPtr inst, out double new_value)
		{
			try {
				SpinButton __obj = GLib.Object.GetObject (inst, false) as SpinButton;
				int __result;
				__result = __obj.OnInput (out new_value);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.SpinButton), ConnectionMethod="OverrideInput")]
		protected virtual int OnInput (out double new_value)
		{
			return InternalInput (out new_value);
		}

		private int InternalInput (out double new_value)
		{
			InputNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Input;
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			int __result = unmanaged (this.Handle, out new_value);
			return __result;
		}

		static OutputNativeDelegate Output_cb_delegate;
		static OutputNativeDelegate OutputVMCallback {
			get {
				if (Output_cb_delegate == null)
					Output_cb_delegate = new OutputNativeDelegate (Output_cb);
				return Output_cb_delegate;
			}
		}

		static void OverrideOutput (GLib.GType gtype)
		{
			OverrideOutput (gtype, OutputVMCallback);
		}

		static void OverrideOutput (GLib.GType gtype, OutputNativeDelegate callback)
		{
			GtkSpinButtonClass class_iface = GetClassStruct (gtype, false);
			class_iface.Output = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int OutputNativeDelegate (IntPtr inst);

		static int Output_cb (IntPtr inst)
		{
			try {
				SpinButton __obj = GLib.Object.GetObject (inst, false) as SpinButton;
				int __result;
				__result = __obj.OnOutput ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.SpinButton), ConnectionMethod="OverrideOutput")]
		protected virtual int OnOutput ()
		{
			return InternalOutput ();
		}

		private int InternalOutput ()
		{
			OutputNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Output;
			if (unmanaged == null) return 0;

			int __result = unmanaged (this.Handle);
			return __result;
		}

		static ValueChangedNativeDelegate ValueChanged_cb_delegate;
		static ValueChangedNativeDelegate ValueChangedVMCallback {
			get {
				if (ValueChanged_cb_delegate == null)
					ValueChanged_cb_delegate = new ValueChangedNativeDelegate (ValueChanged_cb);
				return ValueChanged_cb_delegate;
			}
		}

		static void OverrideValueChanged (GLib.GType gtype)
		{
			OverrideValueChanged (gtype, ValueChangedVMCallback);
		}

		static void OverrideValueChanged (GLib.GType gtype, ValueChangedNativeDelegate callback)
		{
			GtkSpinButtonClass class_iface = GetClassStruct (gtype, false);
			class_iface.ValueChanged = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ValueChangedNativeDelegate (IntPtr inst);

		static void ValueChanged_cb (IntPtr inst)
		{
			try {
				SpinButton __obj = GLib.Object.GetObject (inst, false) as SpinButton;
				__obj.OnValueChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.SpinButton), ConnectionMethod="OverrideValueChanged")]
		protected virtual void OnValueChanged ()
		{
			InternalValueChanged ();
		}

		private void InternalValueChanged ()
		{
			ValueChangedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ValueChanged;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static ChangeValueNativeDelegate ChangeValue_cb_delegate;
		static ChangeValueNativeDelegate ChangeValueVMCallback {
			get {
				if (ChangeValue_cb_delegate == null)
					ChangeValue_cb_delegate = new ChangeValueNativeDelegate (ChangeValue_cb);
				return ChangeValue_cb_delegate;
			}
		}

		static void OverrideChangeValue (GLib.GType gtype)
		{
			OverrideChangeValue (gtype, ChangeValueVMCallback);
		}

		static void OverrideChangeValue (GLib.GType gtype, ChangeValueNativeDelegate callback)
		{
			GtkSpinButtonClass class_iface = GetClassStruct (gtype, false);
			class_iface.ChangeValue = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChangeValueNativeDelegate (IntPtr inst, int scroll);

		static void ChangeValue_cb (IntPtr inst, int scroll)
		{
			try {
				SpinButton __obj = GLib.Object.GetObject (inst, false) as SpinButton;
				__obj.OnChangeValue ((Gtk.ScrollType) scroll);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.SpinButton), ConnectionMethod="OverrideChangeValue")]
		protected virtual void OnChangeValue (Gtk.ScrollType scroll)
		{
			InternalChangeValue (scroll);
		}

		private void InternalChangeValue (Gtk.ScrollType scroll)
		{
			ChangeValueNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).ChangeValue;
			if (unmanaged == null) return;

			unmanaged (this.Handle, (int) scroll);
		}

		static WrappedNativeDelegate Wrapped_cb_delegate;
		static WrappedNativeDelegate WrappedVMCallback {
			get {
				if (Wrapped_cb_delegate == null)
					Wrapped_cb_delegate = new WrappedNativeDelegate (Wrapped_cb);
				return Wrapped_cb_delegate;
			}
		}

		static void OverrideWrapped (GLib.GType gtype)
		{
			OverrideWrapped (gtype, WrappedVMCallback);
		}

		static void OverrideWrapped (GLib.GType gtype, WrappedNativeDelegate callback)
		{
			GtkSpinButtonClass class_iface = GetClassStruct (gtype, false);
			class_iface.Wrapped = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void WrappedNativeDelegate (IntPtr inst);

		static void Wrapped_cb (IntPtr inst)
		{
			try {
				SpinButton __obj = GLib.Object.GetObject (inst, false) as SpinButton;
				__obj.OnWrapped ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.SpinButton), ConnectionMethod="OverrideWrapped")]
		protected virtual void OnWrapped ()
		{
			InternalWrapped ();
		}

		private void InternalWrapped ()
		{
			WrappedNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Wrapped;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkSpinButtonClass {
			public InputNativeDelegate Input;
			public OutputNativeDelegate Output;
			public ValueChangedNativeDelegate ValueChanged;
			public ChangeValueNativeDelegate ChangeValue;
			public WrappedNativeDelegate Wrapped;
			IntPtr GtkReserved1;
			IntPtr GtkReserved2;
			IntPtr GtkReserved3;
			IntPtr GtkReserved4;
		}

		static uint class_offset = ((GLib.GType) typeof (Gtk.Entry)).GetClassSize ();
		static Dictionary<GLib.GType, GtkSpinButtonClass> class_structs;

		static GtkSpinButtonClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkSpinButtonClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkSpinButtonClass class_struct = (GtkSpinButtonClass) Marshal.PtrToStructure (class_ptr, typeof (GtkSpinButtonClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkSpinButtonClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_spin_button_configure(IntPtr raw, IntPtr adjustment, double climb_rate, uint digits);

		public void Configure(Gtk.Adjustment adjustment, double climb_rate, uint digits) {
			gtk_spin_button_configure(Handle, adjustment == null ? IntPtr.Zero : adjustment.Handle, climb_rate, digits);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_spin_button_get_increments(IntPtr raw, out double step, out double page);

		public void GetIncrements(out double step, out double page) {
			gtk_spin_button_get_increments(Handle, out step, out page);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_spin_button_get_range(IntPtr raw, out double min, out double max);

		public void GetRange(out double min, out double max) {
			gtk_spin_button_get_range(Handle, out min, out max);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_spin_button_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_spin_button_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_spin_button_get_value_as_int(IntPtr raw);

		public int ValueAsInt { 
			get {
				int raw_ret = gtk_spin_button_get_value_as_int(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_spin_button_set_increments(IntPtr raw, double step, double page);

		public void SetIncrements(double step, double page) {
			gtk_spin_button_set_increments(Handle, step, page);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_spin_button_set_range(IntPtr raw, double min, double max);

		public void SetRange(double min, double max) {
			gtk_spin_button_set_range(Handle, min, max);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_spin_button_spin(IntPtr raw, int direction, double increment);

		public void Spin(Gtk.SpinType direction, double increment) {
			gtk_spin_button_spin(Handle, (int) direction, increment);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_spin_button_update(IntPtr raw);

		public void Update() {
			gtk_spin_button_update(Handle);
		}

#endregion
	}
}
