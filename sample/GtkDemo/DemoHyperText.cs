//
// Author: John Luke  <john.luke@gmail.com>
// ported from gtk-demo in GTK+
// Demostrates HyperLinks in the TextView
//

using System;
using Gtk;

namespace GtkDemo
{
	public class DemoHyperText : Gtk.Window
	{
		bool hoveringOverLink = false;
		Gdk.Cursor handCursor, regularCursor;
		TextIter lastIter;

		public DemoHyperText () : base ("HyperText")
		{
			this.DeleteEvent += new DeleteEventHandler (OnWindowDelete);
			this.SetDefaultSize (450, 450);
			CreateCursors ();
			this.Add (CreateScrolledWindow ());
			this.ShowAll ();
		}

		void CreateCursors ()
		{
			handCursor = new Gdk.Cursor (Gdk.CursorType.Hand2);
			regularCursor = new Gdk.Cursor (Gdk.CursorType.Xterm);
		}

		ScrolledWindow CreateScrolledWindow ()
		{
			ScrolledWindow sw = new ScrolledWindow ();
			sw.Add (CreateTextView ());
			return sw;
		}

		TextView CreateTextView ()
		{
			TextTagTable ttt = new TextTagTable ();
			TextBuffer buffer = new TextBuffer (ttt);

			TextView view = new TextView ();
			view.WrapMode = WrapMode.Word;
			view.KeyPressEvent += new KeyPressEventHandler (OnKeyPress);
			view.MotionNotifyEvent += new MotionNotifyEventHandler (OnMotionNotify);
			view.VisibilityNotifyEvent += new VisibilityNotifyEventHandler (OnVisibilityNotify);
			view.ButtonReleaseEvent += new ButtonReleaseEventHandler (OnButtonRelease);
			view.Buffer.InsertText += new InsertTextHandler (OnTextInserted);

			ShowPage (view.Buffer, 1);
			return view;
		}

		// Inserts a piece of text into the buffer, giving it the usual
		// appearance of a hyperlink in a web browser: blue and underlined.
		// Additionally, attaches some data on the tag, to make it recognizable
		// as a link.
		void InsertLink (TextBuffer buffer, TextIter iter, string text, int page)
		{
			TextTag tag = new TextTag ("link");
			tag.Foreground = "blue";
			tag.Underline = Pango.Underline.Single;
			tag.Data.Add ("page", page);
			buffer.TagTable.Add (tag);

			buffer.InsertWithTags (iter, text, tag);
		}

		// Fills the buffer with text and interspersed links. In any real
		// hypertext app, this method would parse a file to identify the links.
		void ShowPage (TextBuffer buffer, int page)
		{
			buffer.Text = "";
			TextIter iter = buffer.GetIterAtOffset (0);

			if (page == 1)
			{
				buffer.Insert (iter, "Some text to show that simple ");
				InsertLink (buffer, lastIter, "hypertext", 3);
				buffer.Insert (lastIter, " can easily be realized with ");
				InsertLink (buffer, lastIter, "tags", 2);
				buffer.Insert (lastIter, ".");
			}
			else if (page == 2)
			{
				buffer.Insert (iter, 
				"A tag is an attribute that can be applied to some range of text. " +
				"For example, a tag might be called \"bold\" and make the text inside " +
				"the tag bold. However, the tag concept is more general than that; " +
				"tags don't have to affect appearance. They can instead affect the " +
				"behavior of mouse and key presses, \"lock\" a range of text so the " +
				"user can't edit it, or countless other things.\n");
      				InsertLink (buffer, lastIter, "Go back", 1);
			}
			else if (page == 3)
			{
				TextTag tag = new TextTag ("bold");
				tag.Weight = Pango.Weight.Bold;
				buffer.InsertWithTags (iter, "hypertext:\n", tag);
				buffer.Insert (lastIter,
				"machine-readable text that is not sequential but is organized" + 
				"so that related items of information are connected.\n");
				InsertLink (buffer, lastIter, "Go back", 1);
			}
		}

		// Looks at all tags covering the position of iter in the text view, 
		// and if one of them is a link, follow it by showing the page identified
		// by the data attached to it.
		void FollowIfLink (TextView view, TextIter iter)
		{
			foreach (TextTag tag in iter.Tags)
			{
				int page = (int) tag.Data ["page"];
				if (page != 0)
					ShowPage (view.Buffer, page);
			}
		}

		// Looks at all tags covering the position (x, y) in the text view, 
		// and if one of them is a link, change the cursor to the "hands" cursor
		// typically used by web browsers.
		
		void SetCursorIfAppropriate (TextView view, int x, int y)
		{
			bool hovering = false;
			TextIter iter = view.GetIterAtLocation (x, y);

			foreach (TextTag tag in iter.Tags)
			{
				int page = (int) tag.Data ["page"];
				if (page != 0) {
					hovering = true;
					break;
				}
			}

			if (hovering != hoveringOverLink)
			{
				hoveringOverLink = hovering;
				if (hoveringOverLink)
					view.GdkWindow.Cursor = handCursor;
				else
					view.GdkWindow.Cursor = regularCursor;
			}
		}

		void OnButtonRelease (object sender, ButtonReleaseEventArgs a)
		{
			if (a.Event.Button != 1)
				return; 

			TextView view = sender as TextView;
			TextIter start, end, iter;
			int x, y;

			view.Buffer.GetSelectionBounds (out start, out end);
			if (start.Offset != end.Offset)
				return;

			view.WindowToBufferCoords (TextWindowType.Widget, (int) a.Event.X, (int) a.Event.Y, out x, out y);
			iter = view.GetIterAtLocation (x, y);

			FollowIfLink (view, iter);
		}

		// Links can be activated by pressing Enter.
		void OnKeyPress (object sender, KeyPressEventArgs a)
		{
			TextView view = sender as TextView;

			switch ((Gdk.Key) a.Event.KeyValue) {
				case Gdk.Key.Return:
				case Gdk.Key.KP_Enter:
					TextIter iter = view.Buffer.GetIterAtMark (view.Buffer.InsertMark);
					FollowIfLink (view, iter);
					break;
				default:
					break;
			}
		}

		//Update the cursor image if the pointer moved. 
		void OnMotionNotify (object sender, MotionNotifyEventArgs a)
		{
			TextView view = sender as TextView;
			int x, y;

			view.WindowToBufferCoords (TextWindowType.Widget, (int) a.Event.X, (int) a.Event.Y, out x, out y);
			SetCursorIfAppropriate (view, x, y);
		}

		// When inserting text, iters are invalidated
		// but the default handler provides us the iter
		// at the end of inserted text
		void OnTextInserted (object sender, InsertTextArgs a)
		{
			lastIter = a.Pos;
		}

		// Also update the cursor image if the window becomes visible
		// (e.g. when a window covering it got iconified).
		void OnVisibilityNotify (object sender, VisibilityNotifyEventArgs a)
		{
			TextView view = sender as TextView;
			int wx, wy, bx, by;

			view.GetPointer (out wx, out wy);
			view.WindowToBufferCoords (TextWindowType.Widget, wx, wy, out bx, out by);
			SetCursorIfAppropriate (view, bx, by);
			
		}

		void OnWindowDelete (object sender, DeleteEventArgs a)
		{
			this.Hide ();
			this.Destroy ();
			a.RetVal = true;
		}
	}
}
