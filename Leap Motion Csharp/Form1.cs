using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Drawing.Imaging;
using Leap;

namespace Leap_Motion_Csharp
{
    public partial class Form1 : Form//, ILeapEventDelegate
    {
        private Controller controller;
        private LeapEventListener listener;

        public Form1()
        {
            InitializeComponent();

            this.controller = new Controller();
            this.listener = new LeapEventListener(this);
            NewMethod();
        }

        private void NewMethod()
        {
            controller.AddListener(listener);
        }

        delegate void LeapEventDelegate(string EventName);
        public void LeapEventNotification(string EventName)
        {
            if (!this.InvokeRequired)
            {
                switch (EventName)
                {
                    case "onInit":
                        MessageBox.Show("Initialized");
                        break;

                    case "onConnect":
                        MessageBox.Show("Leap connected");
                        break;

                    case "onFrame":
                        MessageBox.Show("Frame taken");
                        break;
                }
            }
            else
            {
                BeginInvoke(new LeapEventDelegate(LeapEventNotification), new object[] { EventName });
            }
        }
    }

    public class LeapEventListener : ConsoleTraceListener
    {
        public LeapEventListener(Form1 form1) { }

        readonly ILeapEventDelegate eventDelegate;

        public LeapEventListener(ILeapEventDelegate delegateObject) => this.eventDelegate = delegateObject;
        
        public override void OnInit(Controller controller) => this.eventDelegate.LeapEventNotiofination("onInit");

        public override void OnConnect(Controller controller) => this.eventDelegate.LeapEventNotiofination("OnConnect");

        public override void OnFrame(Controller controller) => this.eventDelegate.LeapEventNotiofination("OnFrame");

        public override void OnExit(Controller controller) => this.eventDelegate.LeapEventNotiofination("OnExit");

        public override void OnDisconnect(Controller controller) => this.eventDelegate.LeapEventNotiofination("OnDisconnect");
    }
}

