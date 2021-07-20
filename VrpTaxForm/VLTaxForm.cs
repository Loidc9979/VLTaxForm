using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VrpTaxForm
{
    public partial class VLTaxForm : Form
    {
        public VLTaxForm()
        {
            InitializeComponent();
        }

        private void VLTaxForm_Load(object sender, EventArgs e)
        {
            Init();
        }
        private void rbYear_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            dtpStart.Visible = false;
            label5.Visible = false;
            dtpEnd.Visible = false;
            dtpStart.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpEnd.Value = new DateTime(DateTime.Now.Year, 12, 31);
        }

        private void rbPeriod_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            dtpStart.Visible = true;
            label5.Visible = true;
            dtpEnd.Visible = true;
        }

        private void cbxCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCar.Text == "機車")
            {
                cbxMotorHorsePower.Items.Clear();
                cbxMotorHorsePower.Items.Add("150以下 / 12HP以下(12.2PS以下)");
                cbxMotorHorsePower.Items.Add("151-250 / 12.1-20HP(12.3-20.3PS)");
                cbxMotorHorsePower.Items.Add("251-500 / 20.1HP以上(20.4PS以上)");
                cbxMotorHorsePower.Items.Add("501-600");
                cbxMotorHorsePower.Items.Add("601-1200");
                cbxMotorHorsePower.Items.Add("1201-1800");
                cbxMotorHorsePower.Items.Add("1801或以上");
                cbxMotorHorsePower.SelectedIndex = 0;
            }
            else if (cbxCar.Text == "貨車")
            {
                cbxMotorHorsePower.Items.Clear();
                cbxMotorHorsePower.Items.Add("500以下");
                cbxMotorHorsePower.Items.Add("501-600");
                cbxMotorHorsePower.Items.Add("601-1200");
                cbxMotorHorsePower.Items.Add("1201-1800");
                cbxMotorHorsePower.Items.Add("1801-2400");
                cbxMotorHorsePower.Items.Add("2401-3000 / 138HP以下(140.1PS以下)");
                cbxMotorHorsePower.Items.Add("3001-3600");
                cbxMotorHorsePower.Items.Add("3601-4200 / 138.1-200HP(140.2-203.0PS)");
                cbxMotorHorsePower.Items.Add("4201-4800");
                cbxMotorHorsePower.Items.Add("4801-5400 / 200.1-247HP(203.1-250.7PS)");
                cbxMotorHorsePower.Items.Add("5401-6000");
                cbxMotorHorsePower.Items.Add("6001-6600 / 247.1-286HP(250.8-290.3PS)");
                cbxMotorHorsePower.Items.Add("6601-7200");
                cbxMotorHorsePower.Items.Add("7201-7800 / 286.1-336HP(290.4-341.0PS)");
                cbxMotorHorsePower.Items.Add("7801-8400");
                cbxMotorHorsePower.Items.Add("8401-9000 / 336.1-361HP(341.1-366.4PS)");
                cbxMotorHorsePower.Items.Add("9001-9600");
                cbxMotorHorsePower.Items.Add("9601-10200 / 361.1HP以上(366.5PS以上)");
                cbxMotorHorsePower.Items.Add("10201以上");
                cbxMotorHorsePower.SelectedIndex = 0;
            }
            else if (cbxCar.Text == "大客車")
            {
                cbxMotorHorsePower.Items.Clear();
                cbxMotorHorsePower.Items.Add("600以下");
                cbxMotorHorsePower.Items.Add("601-1200");
                cbxMotorHorsePower.Items.Add("1201-1800");
                cbxMotorHorsePower.Items.Add("1801-2400");
                cbxMotorHorsePower.Items.Add("2401-3000 / 138HP以下(140.1PS以下)");
                cbxMotorHorsePower.Items.Add("3001-3600");
                cbxMotorHorsePower.Items.Add("3601-4200 / 138.1-200HP(140.2-203.0PS)");
                cbxMotorHorsePower.Items.Add("4201-4800");
                cbxMotorHorsePower.Items.Add("4801-5400 / 200.1-247HP(203.1-250.7PS)");
                cbxMotorHorsePower.Items.Add("5401-6000");
                cbxMotorHorsePower.Items.Add("6001-6600 / 247.1-286HP(250.8-290.3PS)");
                cbxMotorHorsePower.Items.Add("6601-7200");
                cbxMotorHorsePower.Items.Add("7201-7800 / 286.1-336HP(290.4-341.0PS)");
                cbxMotorHorsePower.Items.Add("7801-8400");
                cbxMotorHorsePower.Items.Add("8401-9000 / 336.1-361HP(341.1-366.4PS)");
                cbxMotorHorsePower.Items.Add("9001-9600");
                cbxMotorHorsePower.Items.Add("9601-10200 / 361.1HP以上(366.5PS以上)");
                cbxMotorHorsePower.Items.Add("10201以上");
                cbxMotorHorsePower.SelectedIndex = 0;
            }
            else if (cbxCar.Text == "自用小客車")
            {
                cbxMotorHorsePower.Items.Clear();
                cbxMotorHorsePower.Items.Add("500以下 / 38HP以下(38.6PS以下)");
                cbxMotorHorsePower.Items.Add("501~600 / 38.1-56HP(38.7-56.8PS)");
                cbxMotorHorsePower.Items.Add("601~1200 / 56.1-83HP(56.9-84.2PS)");
                cbxMotorHorsePower.Items.Add("1201~1800 / 83.1-182HP(84.3-184.7PS)");
                cbxMotorHorsePower.Items.Add("1801~2400 / 182.1-262HP(184.8-265.9PS)");
                cbxMotorHorsePower.Items.Add("2401~3000 / 262.1-322HP(266-326.8PS)");
                cbxMotorHorsePower.Items.Add("3001-4200 / 322.1-414HP(326.9-420.2PS");
                cbxMotorHorsePower.Items.Add("4201-5400 / 414.1-469HP(420.3-476.0PS)");
                cbxMotorHorsePower.Items.Add("5401-6600 / 469.1-509HP(476.1-516.6PS)");
                cbxMotorHorsePower.Items.Add("6601-7800 / 509.1HP以上(516.7PS以上)");
                cbxMotorHorsePower.Items.Add("7801以上");
                cbxMotorHorsePower.SelectedIndex = 0;
            }
            else if (cbxCar.Text == "營業用小客車")
            {
                cbxMotorHorsePower.Items.Clear();
                cbxMotorHorsePower.Items.Add("500以下 / 38HP以下(38.6PS以下)");
                cbxMotorHorsePower.Items.Add("501~600 / 38.1-56HP(38.7-56.8PS)");
                cbxMotorHorsePower.Items.Add("601~1200 / 56.1-83HP(56.9-84.2PS)");
                cbxMotorHorsePower.Items.Add("1201~1800 / 83.1-182HP(84.3-184.7PS)");
                cbxMotorHorsePower.Items.Add("1801~2400 / 182.1-262HP(184.8-265.9PS)");
                cbxMotorHorsePower.Items.Add("2401~3000 / 262.1-322HP(266-326.8PS)");
                cbxMotorHorsePower.Items.Add("3001-4200 / 322.1-414HP(326.9-420.2PS");
                cbxMotorHorsePower.Items.Add("4201-5400 / 414.1-469HP(420.3-476.0PS)");
                cbxMotorHorsePower.Items.Add("5401-6600 / 469.1-509HP(476.1-516.6PS)");
                cbxMotorHorsePower.Items.Add("6601-7800 / 509.1HP以上(516.7PS以上)");
                cbxMotorHorsePower.Items.Add("7801以上");
                cbxMotorHorsePower.SelectedIndex = 0;
            }
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (dtpStart.Value > dtpEnd.Value)
            {
                MessageBox.Show("起始日不得大於結束日。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int moto = this.Motorcycles();
            int truck = this.Truck();
            int bus = this.Bus();
            int Private = this.Private();
            int Commercia = this.Commercia();
            int perc = 0;
            DateTime start = dtpStart.Value;
            DateTime end = dtpEnd.Value;

            int years = 365;

            if (cbxCar.Text == "機車")
                perc = moto;
            else if (cbxCar.Text == "貨車")
                perc = truck;
            else if (cbxCar.Text == "大客車")
                perc = bus;
            else if (cbxCar.Text == "自用小客車")
                perc = Private;
            else if (cbxCar.Text == "營業用小客車")
                perc = Commercia;

            listAnswer.Items.Clear();
            int m;
            int f;
            int em;
            int ef;
            decimal allmoney = 0;
            for (var i = start.Year; i <= end.Year; i++)
            {
                if (i > start.Year)
                {
                    m = 1;
                    f = 1;
                }
                else
                {
                    m = start.Month;
                    f = start.Day;
                }

                DateTime start2 = new DateTime(i, m, f);
                if (i < end.Year)
                {
                    em = 12;
                    ef = 31;
                }
                else
                {
                    em = end.Month;
                    ef = end.Day;
                }

                DateTime end2 = new DateTime(i, em, ef);

                TimeSpan ts = end2.Subtract(start2);
                int dayCount = ts.Days + 1;
                if (i % 400 == 0)
                    years = 366;
                else if (i % 4 == 0 && i % 100 != 0)
                    years = 366;
                else
                    years = 365;

                decimal money = perc * dayCount / years;
                money = Math.Truncate(money);
                allmoney += money;

                listAnswer.Items.Add($"使用期間: {i}-{m}-{f} ~ {i}-{em}-{ef} ");
                listAnswer.Items.Add($"計算天數: {dayCount}");
                listAnswer.Items.Add($"汽缸CC數: {cbxMotorHorsePower.Text}");
                listAnswer.Items.Add($"用途: {cbxCar.Text}");
                listAnswer.Items.Add($"計算公式: {perc} * {dayCount} / {years} = {money.ToString("#,0")}元");
                listAnswer.Items.Add($"應納稅額: 共 {money.ToString("#,0")} 元");
                listAnswer.Items.Add("---------------------------------");
                listAnswer.Items.Add($"總共稅額加總: 共 {allmoney.ToString("#,0")} 元");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Init();
        }

        #region

        private void Init()
        {
            rbYear.Checked = true;
            dtpStart.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpEnd.Value = new DateTime(DateTime.Now.Year, 12, 31);

            cbxCar.SelectedIndex = 0;
            cbxMotorHorsePower.SelectedIndex = 0;
            listAnswer.Items.Clear();
        }

        #endregion

        #region CarTaxType
        public int Motorcycles()
        {
            string MotoTax = cbxMotorHorsePower.Text;

            switch(MotoTax)
            {
                case "150以下 / 12HP以下(12.2PS以下)":
                    return 0;
                case "151-250 / 12.1-20HP(12.3-20.3PS)":
                    return 800;
                case "251-500 / 20.1HP以上(20.4PS以上)":
                    return 1620;
                case "501-600":
                    return 2160;
                case "601-1200":
                    return 4320;
                case "1201-1800":
                    return 7120;
                case "1801或以上":
                    return 11230;
                default:
                    return 0;
            }
        }

        public int Truck()
        {
            string TruckTax = cbxMotorHorsePower.Text;

            switch (TruckTax)
            {
                case "500以下":
                    return 900;
                case "501-600":
                    return 1080;
                case "601-1200":
                    return 1800;
                case "1201-1800":
                    return 2700;
                case "1801-2400":
                    return 3600;
                case "2401-3000 / 138HP以下(140.1PS以下)":
                    return 4500;
                case "3001-3600":
                    return 5400;
                case "3601-4200 / 138.1-200HP(140.2-203.0PS)":
                    return 6300;
                case "4201-4800":
                    return 7200;
                case "4801-5400 / 200.1-247HP(203.1-250.7PS)":
                    return 8100;
                case "5401-6000":
                    return 9000;
                case "6001-6600 / 247.1-286HP(250.8-290.3PS)":
                    return 9900;
                case "6601-7200":
                    return 10800;
                case "7201-7800 / 286.1-336HP(290.4-341.0PS)":
                    return 11700;
                case "7801-8400":
                    return 12600;
                case "8401-9000 / 336.1-361HP(341.1-366.4PS)":
                    return 13500;
                case "9001-9600":
                    return 14400;
                case "9601-10200 / 361.1HP以上(366.5PS以上)":
                    return 15300;
                case "10201以上":
                    return 16200;
                default:
                    return 0;
            }
        }

        public int Bus()
        {
            string BusTax = cbxMotorHorsePower.Text;

            switch (BusTax)
            {
                case "600以下":
                    return 1080;
                case "601-1200":
                    return 1800;
                case "1201-1800":
                    return 2700;
                case "1801-2400":
                    return 3600;
                case "2401-3000 / 138HP以下(140.1PS以下)":
                    return 4500;
                case "3001-3600":
                    return 5400;
                case "3601-4200 / 138.1-200HP(140.2-203.0PS)":
                    return 6300;
                case "4201-4800":
                    return 7200;
                case "4801-5400 / 200.1-247HP(203.1-250.7PS)":
                    return 8100;
                case "5401-6000":
                    return 9000;
                case "6001-6600 / 247.1-286HP(250.8-290.3PS)":
                    return 9900;
                case "6601-7200":
                    return 10800;
                case "7201-7800 / 286.1-336HP(290.4-341.0PS)":
                    return 11700;
                case "7801-8400":
                    return 12600;
                case "8401-9000 / 336.1-361HP(341.1-366.4PS)":
                    return 13500;
                case "9001-9600":
                    return 14400;
                case "9601-10200 / 361.1HP以上(366.5PS以上)":
                    return 15300;
                case "10201以上":
                    return 16200;
                default:
                    return 0;
            }
        }

        public int Private()
        {
            string PrivateCar = cbxMotorHorsePower.Text;

            switch (PrivateCar)
            {
                case "500以下 / 38HP以下(38.6PS以下)":
                    return 1620;
                case "501~600 / 38.1-56HP(38.7-56.8PS)":
                    return 2160;
                case "601~1200 / 56.1-83HP(56.9-84.2PS)":
                    return 4320;
                case "1201~1800 / 83.1-182HP(84.3-184.7PS)":
                    return 7120;
                case "1801~2400 / 182.1-262HP(184.8-265.9PS)":
                    return 11230;
                case "2401~3000 / 262.1-322HP(266-326.8PS)":
                    return 15210;
                case "3001-4200 / 322.1-414HP(326.9-420.2PS":
                    return 28220;
                case "4201-5400 / 414.1-469HP(420.3-476.0PS)":
                    return 46170;
                case "5401-6600 / 469.1-509HP(476.1-516.6PS)":
                    return 69690;
                case "6601-7800 / 509.1HP以上(516.7PS以上)":
                    return 117000;
                case "7801以上":
                    return 151200;
                default:
                    return 0;
            }
        }

        public int Commercia()
        {
            string CommerciaCar = cbxMotorHorsePower.Text;

            switch (CommerciaCar)
            {
                case "500以下 / 38HP以下(38.6PS以下)":
                    return 900;
                case "501~600 / 38.1-56HP(38.7-56.8PS)":
                    return 1260;
                case "601~1200 / 56.1-83HP(56.9-84.2PS)":
                    return 2160;
                case "1201~1800 / 83.1-182HP(84.3-184.7PS)":
                    return 3060;
                case "1801~2400 / 182.1-262HP(184.8-265.9PS)":
                    return 6480;
                case "2401~3000 / 262.1-322HP(266-326.8PS)":
                    return 9900;
                case "3001-4200 / 322.1-414HP(326.9-420.2PS":
                    return 16380;
                case "4201-5400 / 414.1-469HP(420.3-476.0PS)":
                    return 24300;
                case "5401-6600 / 469.1-509HP(476.1-516.6PS)":
                    return 33660;
                case "6601-7800 / 509.1HP以上(516.7PS以上)":
                    return 44460;
                case "7801以上":
                    return 56700;
                default:
                    return 0;
            }
        }
        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            Process.Start("https://law-out.mof.gov.tw/LawContent.aspx?id=FL006130");
        }
    }
}
