using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            txtAnswer.Text = null;
        }
        #endregion
    }
}
