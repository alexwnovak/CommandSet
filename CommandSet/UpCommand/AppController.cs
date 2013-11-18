using System;
using System.IO;
using System.Runtime.InteropServices;

namespace CommandSet.UpCommand
{
   public class AppController
   {
      internal struct INPUT_RECORD
      {
         public ushort Type;
         public KEY_EVENT_RECORD KeyEventRecord;
      }

      internal struct KEY_EVENT_RECORD
      {
         public bool bKeyDown;
         public ushort wRepeatCount;
         public ushort wVirtualKeyCode;
         public ushort wVirtualScanCode;
         public char UnicodeChar;
         uint dwControlKeyState;
      }

      /* Reads data from a console input buffer and removes it from the buffer. */
      [DllImport( "kernel32.dll", EntryPoint = "WriteConsoleInputW", CharSet = CharSet.Unicode, SetLastError = true )]
      internal static extern bool WriteConsoleInput(
          IntPtr hConsoleInput,
          [MarshalAs( UnmanagedType.LPArray ), In] INPUT_RECORD[] lpBuffer,
          uint nLength,
          out uint lpNumberOfEventsWritten );

      [DllImport( "kernel32.dll", SetLastError = true )]
      static extern IntPtr GetStdHandle( int nStdHandle );

      public int Run( string[] arguments )
      {
         Console.WriteLine( "Setting directory" );

         var keyEvent = new KEY_EVENT_RECORD
         {
            bKeyDown = true,
            wRepeatCount = 0,
            UnicodeChar = 'x'
         };

         var inputRecord = new INPUT_RECORD
         {
            Type = 0x0001,
            KeyEventRecord = keyEvent
         };

         var keyEvent2 = new KEY_EVENT_RECORD
         {
            bKeyDown = true,
            wRepeatCount = 0,
            wVirtualKeyCode = 0x0D
         };

         var inputRecord2 = new INPUT_RECORD
         {
            Type = 0x0001,
            KeyEventRecord = keyEvent2
         };

         var records = new[]
         {
            inputRecord,
            inputRecord2
         };

         uint eventsWritten;

         var standardInHandle = GetStdHandle( -10 );
         WriteConsoleInput( standardInHandle, records, (uint) records.Length, out eventsWritten );

         Directory.SetCurrentDirectory( @"C:\" );

         return 0;
      }
   }
}
