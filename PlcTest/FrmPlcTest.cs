using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlcTest
{
    public partial class FrmPlcTest : Form
    {
        string target = "01";//目标站号
        string dcData = "D";//数据代码：数据寄存器DT
        string end = "CR";//结束标志
        string cmdRead = "%{0}#RD{1}{2}{3}"; 
        string cmdWrite = "%{0}#WD{1}{2}{3}{4}";

        public FrmPlcTest()
        {
            InitializeComponent();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            string posStart = txtStart.Text.Trim().PadLeft(5,'0');
            string posEnd = txtEnd.Text.Trim().PadLeft(5, '0');
            string dataWrite = txtData.Text.Trim();

            string cmd = string.Format(cmdRead, target, dcData, posStart, posEnd);
            int bcc = 0;

            for (int i = 0; i < cmd.Length; i++)
            {
                bcc = bcc ^ (short)cmd[i];
            }
            
            rtxtRead.Text = string.Format("{0}{1}{2}", cmd, Convert.ToString(bcc, 16), end);

            cmd = string.Format(cmdWrite, target, dcData, posStart, posEnd, dataWrite);
            bcc = 0;

            for (int i = 0; i < cmd.Length; i++)
            {
                bcc = bcc ^ (short)cmd[i];
            }

            rtxtWrite.Text = string.Format("{0}{1}{2}", cmd, Convert.ToString(bcc, 16), end);
        }
    }
}
