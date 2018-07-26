using Microsoft.Win32;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;
using NetFwTypeLib;
using PCRemote_Control.Properties;
using System.Drawing;

namespace PCRemote_Control
{
    public partial class Form1 : Form
    {

        public bool starter = false;
        public bool should_work = false;
        public int port = 38745;
        public static string data = null;
        public bool passed = false;
        public bool InternetListening = false;
        TcpListener tcpListener = null;
        Socket s = null;


        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        

        public Form1()
        {
            InitializeComponent();
            should_work = true;
            starter = true;
            SystemEvents.SessionSwitch += SystemEvents_SessionSwitch;
            localIP.Text = "Your local IP: " + GetLocalIPAddress();
            onStartWindows.Checked = IsStartupItem();
            minimiedWindow.Checked = IsToMinimizeItem();
            //setUpFirewall();
            setupNetwork();
            button11.Text = "Stop LAN server";
            connection_state.Text = "Disconnected\n";

            if (IsToMinimizeItem())
            {
                this.WindowState = FormWindowState.Minimized;
                Hide();
                notifyIcon1.Visible = true;
                //this.ShowIcon = false;
                this.ShowInTaskbar = false;
            }
        }

        private void setupNetwork()
        {
            (new Thread(() =>
            {
                setUp();
            })).Start();
        }

        private void startUpoff()
        {
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (IsStartupItem())
                rkApp.DeleteValue("PCRemote Control", false);
        }

        private void startUpOn() {

            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (!IsStartupItem())
                rkApp.SetValue("PCRemote Control", Application.ExecutablePath.ToString());
        }

        private bool IsStartupItem()
        {
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (rkApp.GetValue("PCRemote Control") == null)
                return false;
            else
                return true;
        }

        private void setUpFirewall()
        {
            INetFwMgr icfMgr = null;
            try
            {
                Type TicfMgr = Type.GetTypeFromProgID("HNetCfg.FwMgr");
                icfMgr = (INetFwMgr)Activator.CreateInstance(TicfMgr);
            }
            catch (Exception ex)
            {
                ex.GetType();
                return;
            }

            try
            {
                INetFwProfile profile;
                INetFwOpenPort portClass;
                Type TportClass = Type.GetTypeFromProgID("HNetCfg.FWOpenPort");
                portClass = (INetFwOpenPort)Activator.CreateInstance(TportClass);

                // Get the current profile
                profile = icfMgr.LocalPolicy.CurrentProfile;

                // Set the port properties
                portClass.Scope = NetFwTypeLib.NET_FW_SCOPE_.NET_FW_SCOPE_ALL;
                portClass.Enabled = true;
                portClass.Protocol = NetFwTypeLib.NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_ANY;
                portClass.Name = "Permissions for PC Remote";
                portClass.Port = port;

                // Add the port to the ICF Permissions List
                profile.GloballyOpenPorts.Add(portClass);
                return;
            }
            catch (Exception ex)
            {
                ex.GetType();
            }
        }


        private void setUp()
        {
            try
            { 

                tcpListener = new TcpListener(IPAddress.Any, port);
                tcpListener.Start();
                s = tcpListener.AcceptSocket();
                IPEndPoint ipend = s.RemoteEndPoint as IPEndPoint;
                Console.WriteLine("Connection accepted from " + ipend.Address.ToString());
                connection_state.Invoke(new MethodInvoker(delegate () {
                    connection_state.Text="Connected\n";
                    connection_state.ForeColor = Color.Green;
                }));
                    BinaryReader reader = new BinaryReader(new NetworkStream(s));
                string msg;
                InputSimulator input = new InputSimulator();
                while ((msg = reader.ReadString()) != null)
                {
                    switch (msg)
                    {
                        case "0x19":
                            input.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE);
                            //lan_box.Invoke(new MethodInvoker(delegate () { lan_box.AppendText("Paused\n"); }));
                            break;
                        case "0x20":
                            input.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE);
                            //lan_box.Invoke(new MethodInvoker(delegate () { lan_box.AppendText("Played\n"); }));
                            break;
                        case "0x21":
                            input.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.MEDIA_STOP);
                            //lan_box.Invoke(new MethodInvoker(delegate () { lan_box.AppendText("Stopped\n"); }));
                            break;
                        case "0x22":
                            input.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK);
                            //lan_box.Invoke(new MethodInvoker(delegate () { lan_box.AppendText("Previous track\n"); }));
                            break;
                        case "0x23":
                            input.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.MEDIA_NEXT_TRACK);
                            //lan_box.Invoke(new MethodInvoker(delegate () { lan_box.AppendText("Track skipped\n"); }));
                            break;
                        case "0x24":
                            SetMonitorInState(MonitorState.MonitorStateOff);
                            //lan_box.Invoke(new MethodInvoker(delegate () { lan_box.AppendText("Monitor is off\n"); }));
                            break;
                        case "0x25":
                            SetMonitorInState(MonitorState.MonitorStateOn);
                            //lan_box.Invoke(new MethodInvoker(delegate () { lan_box.AppendText("Monitor is on\n"); }));
                            break;
                        case "0x27":
                            System.Diagnostics.Process.Start("shutdown.exe", "-s -t 0");
                            //lan_box.Invoke(new MethodInvoker(delegate () { lan_box.AppendText("Trying to shutdown\n"); }));
                            break;
                        case "0x28":
                            System.Diagnostics.Process.Start("shutdown.exe", "-r -t 0");
                            //lan_box.Invoke(new MethodInvoker(delegate () { lan_box.AppendText("Trying to restart\n"); }));
                            break;
                        case "0x29":
                            System.Diagnostics.Process.Start("shutdown.exe", "-h");
                            //lan_box.Invoke(new MethodInvoker(delegate () { lan_box.AppendText("Trying to sleep\n"); }));
                            break;
                        case "0x30":
                            Invoke(new MethodInvoker(delegate () { Mute(); }));
                            break;
                        case "0x31":
                            System.Diagnostics.Process.Start("shutdown.exe", "-a");
                            //lan_box.Invoke(new MethodInvoker(delegate () { lan_box.AppendText("Cancel\n"); }));
                            break;
                        case "0x32":
                            Invoke(new MethodInvoker(delegate () { VolUp(); }));
                            break;
                        case "0x33":
                            Invoke(new MethodInvoker(delegate () { VolDown(); }));
                            break;
                        default:
                            if (msg.Contains("0x26"))
                            {
                                string[] multirequest = msg.Split(';');
                                if (multirequest[2] == "0x27") System.Diagnostics.Process.Start("shutdown.exe", "-s -t " + multirequest[1]);
                                else if (multirequest[2] == "0x28") System.Diagnostics.Process.Start("shutdown.exe", "-r -t " + multirequest[1]);
                                else if (multirequest[2] == "0x29") System.Diagnostics.Process.Start("shutdown.exe", "-h");
                            }
                            break;
                    }
                }
                /*  CODSET
                    0x19 - pause
                    0x20 - play
                    0x21 - stop
                    0x22 - prev
                    0x23 - next
                    0x24 - screenOff
                    0x25 - screenOn
                    0x26 - timed
                    0x27 - shutdown
                    0x28 - restart
                    0x29 - stand by
                    0x30 - mute
                    0x31 - cancel
                    0x32 - vol up
                    0x33 - vol down
                    END CODSET
                */

            }
            catch (EndOfStreamException e)
            {
                e.GetType();
                connection_state.Invoke(new MethodInvoker(delegate () {
                    connection_state.Text = "Disconnected";
                    connection_state.ForeColor = Color.Red;
                }));
                if (tcpListener != null) tcpListener.Stop();
                if (s != null) s.Close();
                if (should_work)
                    setUp();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString());
                try
                {
                    connection_state.Invoke(new MethodInvoker(delegate () {
                        connection_state.Text = "Disconnected";
                        connection_state.ForeColor = Color.Red;
                    }));
                    if (tcpListener != null) tcpListener.Stop();
                    if (s != null) s.Close();
                    if (should_work)
                        setUp();
                }catch(Exception e) { }
            }
        }

        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);
        
        //VOLUME
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);


        private void Mute()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        private void VolDown()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        private void VolUp()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_UP);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Mute();
        }

        private void volume_down_Click(object sender, EventArgs e)
        {
            VolDown();
        }

        private void volume_up_Click(object sender, EventArgs e)
        {
            VolUp();
        }
        //END VOLUME

        //MONITOR
        public enum MonitorState
        {
            MonitorStateOn = -1,
            MonitorStateOff = 2,
            MonitorStateStandBy = 1
        }


        void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            SetMonitorInState(MonitorState.MonitorStateOff);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetMonitorInState(MonitorState.MonitorStateOff);
        }

        private void SetMonitorInState(MonitorState state)
        {
            SendMessage(0xFFFF, 0x112, 0xF170, (int)state);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetMonitorInState(MonitorState.MonitorStateOn);

        }
        //END MONITOR

        private void shutdown_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown.exe", "-s -t " + numericUpDown1.Value + "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown.exe", "-r -t " + numericUpDown1.Value + "");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown.exe", "-h");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown.exe", "-a");
        }


        

        //MEDIA

        private void button6_Click(object sender, EventArgs e)
        {
            InputSimulator input = new InputSimulator();
            input.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.MEDIA_PLAY_PAUSE);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InputSimulator input = new InputSimulator();
            input.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.MEDIA_STOP);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InputSimulator input = new InputSimulator();
            input.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.MEDIA_NEXT_TRACK);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InputSimulator input = new InputSimulator();
            input.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.MEDIA_PREV_TRACK);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
                if (!starter)
                {
                    setUp();
                    starter = true;
                    should_work = true;
                    button11.Text = "Stop LAN server";
                }
                else
                {
                    button11.Text = "Start LAN server";
                    starter = false;
                    should_work = false;
                }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            should_work = false;
            if (tcpListener != null) tcpListener.Stop();
            if (s != null) s.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!InternetListening)
            {
                new Login(this).ShowDialog();
                if (passed)
                {
                    internet_box.Text = "Listening\n";
                    InternetListening = true;
                }
            }
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "¯\\_(ツ)_ /¯";
        }

        private void onStartWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (!onStartWindows.Checked)
                startUpoff();
            else
                startUpOn();
        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
            this.ShowInTaskbar = true;
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
                this.ShowInTaskbar = false;
            }
        }

        private void minimiedWindow_CheckedChanged(object sender, EventArgs e)
        {
            if (!minimiedWindow.Checked)
                minimizedOff();
            else
                minimizedOn();
        }

        private void minimizedOff()
        {
            Settings.Default["Minimized"] = false;
            Settings.Default.Save();
        }

        private void minimizedOn()
        {
            Settings.Default["Minimized"] = true;
            Settings.Default.Save();
        }

        private bool IsToMinimizeItem()
        {
            return (bool)Settings.Default["Minimized"];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon("..\\..\\images\\logo_UQQ_icon.ico");
        }
    }
}
