using System.Text;
using System.Windows.Forms;

namespace ClipCommand
{
   public class ClipboardAdapter : IClipboard
   {
      public void Write( byte[] data )
      {
         Clipboard.SetText( Encoding.UTF8.GetString( data ) );
      }
   }
}