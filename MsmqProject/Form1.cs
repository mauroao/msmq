using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsmqProject
{
    public partial class Form1 : Form
    {
        private System.Messaging.MessageQueue msmq;

        public Form1()
        {
            InitializeComponent();
            // var path = @"FormatName:DIRECT=OS:desktop-6hsukeq\private$\myfirstqueue";
            var path = @"FormatName:DIRECT=TCP:192.168.1.20\private$\myfirstqueue";
            msmq = new System.Messaging.MessageQueue(
                path, 
                false, 
                true, 
                System.Messaging.QueueAccessMode.SendAndReceive
            );
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var labelText = txtLabelSend.Text;
            var bodyText = txtBodySend.Text;

            msmq.Send(bodyText, labelText);

        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            var timeOut = 1000;

            var message = msmq.Receive(new TimeSpan(timeOut));

            message.Formatter = new System.Messaging.XmlMessageFormatter(new Type[] { typeof(String) });

            txtLabelReceive.Text = message.Label;
            txtBodyReceive.Text = (String)message.Body;
        }
    }
}
