using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveWindowsManager
{
    public partial class Form1 : Form
    {
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("USER32.DLL")]
        public static extern bool SetFocus(IntPtr hWnd);

        [System.Runtime.InteropServices.DllImport("User32.dll")]
        public static extern bool ShowWindow(IntPtr handle, int nCmdShow);

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        KeyboardHook hook = new KeyboardHook();
        Boolean record;
        String[] listWindows;
        List<System.Windows.Forms.TextBox> listTextBox = new List<System.Windows.Forms.TextBox>();
        int total=0;
        int current;

        public Form1()
        {
            InitializeComponent();
            record = false;
            this.KeyPreview = true;
            listTextBox.Add(textBox1);
            listTextBox.Add(textBox2);
            listTextBox.Add(textBox3);
            listTextBox.Add(textBox4);
            listTextBox.Add(textBox5);
            listTextBox.Add(textBox6);
            listTextBox.Add(textBox7);
            listTextBox.Add(textBox8);

            textBox1.Text = "Ekay";
            textBox2.Text = "Kaybal"; 
            textBox3.Text = "Enya";


            // register the event that is fired after the key press.
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            if (total != 0)
            {
                if (current == total)
                {
                    current = 0;
                }

                
                IntPtr h = FindWindowByCaption(IntPtr.Zero, listWindows[current]); 
               // ShowWindow(h, 9);
                SetForegroundWindow(h);
                SetFocus(h);
                current++;
                //var prc = Process.GetProcessesByName("notepad");
                //if (prc.Length > 0)
                //{
                //    SetForegroundWindow(prc[0].MainWindowHandle);
                //}
            }
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            record = true;
            Console.WriteLine(record);
            Thread thread = new Thread(new ThreadStart(monThread));
            thread.Start();
            //while (thread.IsAlive) ;
        }
        
        public void monThread()
        {
            System.Windows.Forms.KeyEventHandler keh = new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyDown += keh;
            while (record == true) ;
            this.KeyDown -= keh;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (record == true)
            {
                hook.Dispose();
                ModifierKeys mk;
                if (checkBoxAlt.Checked)
                {
                    if (checkBoxCtrl.Checked)
                    {
                        mk = (ModifierKeys)0x0001 | (ModifierKeys)0x0002;
                    }
                    else
                    {
                        mk = (ModifierKeys)0x0001;
                    }
                }
                else if (checkBoxCtrl.Checked) 
                {
                    mk = (ModifierKeys)0x0002;
                }
                else
                {
                    mk = (ModifierKeys)0x0000;
                }
                hook.RegisterHotKey(mk, e.KeyData);
                setText.Text = e.KeyData.ToString();

                record = false;

            }
        }

        private void validerButton_Click(object sender, EventArgs e)
        {
            total = 0;
            foreach(System.Windows.Forms.TextBox t in listTextBox)
            {
                if (t.Text.Trim() != "")
                {
                    total++;
                }
            }

            if (total != 0)
            {
                listWindows = new String[total];
            }

            int j = 0;

            foreach (System.Windows.Forms.TextBox t in listTextBox)
            {
                if (t.Text.Trim() != "")
                {
                    listWindows[j] = t.Text;
                    j++;
                }
            }
        }

    }
}
