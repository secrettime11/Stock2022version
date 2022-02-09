using DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class WaitF : Form
    {
        StockDB db = new StockDB();
        MyFunction myFunction = new MyFunction();
        ParseData parseData = new ParseData();
        public WaitF()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void WaitF_Load(object sender, EventArgs e)
        {

        }

        private void WaitF_Activated(object sender, EventArgs e)
        {
            Thread mission = new Thread(Run);
            mission.Start();
            
        }
        private void Run() 
        {
            ParseAll();
            this.Invoke((MethodInvoker)delegate
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            });
        }
        private void ParseAll()
        {
            List<string> All = myFunction.GetEachTestDates(DateTime.Now.AddDays(1).ToString("yyyy/MM/dd"), "30");
            if (Convert.ToInt32(DateTime.Now.ToString("HH")) < 18)
            {
                All = myFunction.GetEachTestDates(DateTime.Now.ToString("yyyy/MM/dd"), "30");
            }
            foreach (var Date in All)
            {
                var info = db.Listeds.Where(p => p.Date == Date).FirstOrDefault();
                if (info == null)
                {
                    parseData.Excuted(Date, "市");
                    parseData.Excuted(Date, "櫃");

                    parseData.DayTradeExcuted(Date, "市");
                    parseData.DayTradeExcuted(Date, "櫃");

                    parseData.BuySellExcuted(Date, "市");
                    parseData.BuySellExcuted(Date, "櫃");

                    Thread.Sleep(300);
                }
            }
        }
    }
}
