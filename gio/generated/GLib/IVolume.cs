// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;

#region Autogenerated code
	public partial interface IVolume : GLib.IWrapper {

		event System.EventHandler Changed;
		event System.EventHandler Removed;
		bool CanEject();
		bool CanMount();
		void Eject(GLib.MountUnmountFlags flags, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		bool EjectFinish(GLib.IAsyncResult result);
		void EjectWithOperation(GLib.MountUnmountFlags flags, GLib.MountOperation mount_operation, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		bool EjectWithOperationFinish(GLib.IAsyncResult result);
		string EnumerateIdentifiers();
		GLib.IFile ActivationRoot { 
			get;
		}
		GLib.IDrive Drive { 
			get;
		}
		GLib.IIcon Icon { 
			get;
		}
		string GetIdentifier(string kind);
		GLib.IMount MountInstance { 
			get;
		}
		string Name { 
			get;
		}
		string Uuid { 
			get;
		}
		void Mount(GLib.MountMountFlags flags, GLib.MountOperation mount_operation, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb);
		bool MountFinish(GLib.IAsyncResult result);
		bool ShouldAutomount();
	}
#endregion
}
