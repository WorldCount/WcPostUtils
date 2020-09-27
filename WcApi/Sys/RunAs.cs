using System;
using System.Runtime.InteropServices;
using System.Text;

namespace WcApi.Sys
{
    [Flags]
    public enum CreationFlags
    {
        // ReSharper disable once InconsistentNaming
        CREATE_SUSPENDED = 0x00000004,
        // ReSharper disable once InconsistentNaming
        CREATE_NEW_CONSOLE = 0x00000010,
        // ReSharper disable once InconsistentNaming
        CREATE_NEW_PROCESS_GROUP = 0x00000200,
        // ReSharper disable once InconsistentNaming
        CREATE_UNICODE_ENVIRONMENT = 0x00000400,
        // ReSharper disable once InconsistentNaming
        CREATE_SEPARATE_WOW_VDM = 0x00000800,
        // ReSharper disable once InconsistentNaming
        CREATE_DEFAULT_ERROR_MODE = 0x04000000,
    }

    [Flags]
    public enum LogonFlags
    {
        // ReSharper disable once InconsistentNaming
        LOGON_WITH_PROFILE = 0x00000001,
        // ReSharper disable once InconsistentNaming
        LOGON_NETCREDENTIALS_ONLY = 0x00000002
    }

    public class RunAs
    {
        public const UInt32 Infinite = 0xffffffff;
        // ReSharper disable once InconsistentNaming
        public const Int32 Startf_UseStdHandles = 0x00000100;
        public const Int32 StdOutputHandle = -11;
        public const Int32 StdErrorHandle = -12;

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct StartupInfo
        {
            public int cb;
            public String reserved;
            public String desktop;
            public String title;
            public int x;
            public int y;
            public int xSize;
            public int ySize;
            public int xCountChars;
            public int yCountChars;
            public int fillAttribute;
            public int flags;
            public UInt16 showWindow;
            public UInt16 reserved2;
            public byte reserved3;
            public IntPtr stdInput;
            public IntPtr stdOutput;
            public IntPtr stdError;
        }

        public struct ProcessInformation
        {
            public IntPtr Process;
            public IntPtr Thread;
            public int ProcessId;
            public int ThreadId;
        }

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateProcessWithLogonW(
            String userName,
            String domain,
            String password,
            LogonFlags logonFlags,
            String applicationName,
            String commandLine,
            CreationFlags creationFlags,
            UInt32 environment,
            String currentDirectory,
            ref StartupInfo startupInfo,
            out ProcessInformation processInformation);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool GetExitCodeProcess(IntPtr process, ref UInt32 exitCode);

        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern UInt32 WaitForSingleObject(IntPtr handle, UInt32 milliseconds);

        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr GetStdHandle(IntPtr handle);

        [DllImport("Kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern bool CloseHandle(IntPtr handle);

        [DllImport("kernel32.dll")]
        static extern uint FormatMessage(uint dwFlags, IntPtr lpSource,
            uint dwMessageId, uint dwLanguageId, [Out] StringBuilder
                lpBuffer,
            uint nSize, string[] arguments);

        public RunAs(string proccess, string user, string password, string domain)
        {
            StartupInfo startupInfo = new StartupInfo {reserved = null};
            startupInfo.flags &= Startf_UseStdHandles;
            startupInfo.stdOutput = (IntPtr)StdOutputHandle;
            startupInfo.stdError = (IntPtr)StdErrorHandle;

            UInt32 exitCode = 0;
            ProcessInformation processInfo = new ProcessInformation();
            //String currentDirectory = Directory.GetCurrentDirectory();

            try
            {
                CreateProcessWithLogonW(
                    user,
                    domain,
                    password,
                    LogonFlags.LOGON_WITH_PROFILE,
                    proccess,
                    proccess,
                    CreationFlags.CREATE_NEW_CONSOLE,
                    0,
                    null,
                    ref startupInfo,
                    out processInfo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("Running ...");
            WaitForSingleObject(processInfo.Process, Infinite);
            GetExitCodeProcess(processInfo.Process, ref exitCode);

            Console.WriteLine(ExitMessage(exitCode));

            CloseHandle(processInfo.Process);
            CloseHandle(processInfo.Thread);
        }

        public static string ExitMessage(uint exitCode)
        {
            StringBuilder formattedMessage = new StringBuilder(100);
            FormatMessage(
                0x00001000 | 0x00002000,
                IntPtr.Zero,
                exitCode,
                0, // Default language
                formattedMessage,
                100,
                null);
            return formattedMessage.ToString();
        }
    }
}
