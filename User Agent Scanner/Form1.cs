using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace User_Agent_Scanner
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            LoadOS();
            LoadMobileDevices();
            CheckLicense();
        }

        private void CheckLicense()
        {
            var license = LicenseInfoController.Instance.GetLicense();
            switch (license.Type)
            {
                case LicenseType.Invalid:
                    {
                        var frm = new License_Checking() { Text = "User Agent Key Invalid" };
                        frm.ShowDialog();
                        this.Close();
                        break;
                    }
                case LicenseType.Valid:
                    break;
                case LicenseType.Expired:
                    {
                        var frm = new License_Checking() { Text = "User Agent Key has Expired" };
                        frm.ShowDialog();
                        this.Close();
                        break;
                    }
                default:
                    break;
            }
        }

        public bool isStopping = false;
        public UAScanner Scanner = new UAScanner();
        private void Form1_Load(object sender, EventArgs e)
        {
            Scanner.ItemAdded += Scanner_ItemAdded;
            Scanner.ItemCount += Scanner_ItemCount;
        }
        private void Scanner_ItemCount(object sender, UAScanner.ItemCounteventArg e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                if (isStopping == true)
                {
                    lblStatus.Text = $"Generating {e.ItemCount} Useragents...";
                }
                else
                {
                    lblStatus.Text = $"Generated {e.ItemCount} Useragents...";
                }
            }));
        }

        public List<UserAgent> listUA = new List<UserAgent>();
        private void Scanner_ItemAdded(object sender, ItemAddedEventArg e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                mmAddItems.Text += e.Item.UA + Environment.NewLine;
                mmAddItems.SelectionStart = mmAddItems.Text.Length;
                mmAddItems.ScrollToCaret();
                listUA.Add(e.Item);
            }));
        }

        public List<KeyValuePair<string, string>> os = Static.OS;
        private void LoadOS()
        {
            os = Static.OS;
            leOS.Properties.DataSource = os;
            leOS.Properties.DisplayMember = "Key";
            leOS.Properties.ValueMember = "Value";
            leOS.EditValue = os[0].Value;
            leOS.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Key", "Explore by"));
        }

        private void LoadMobileDevices()
        {
            var mobileDevices = Static.MobileDevices;
            leMobileDevices.Properties.DataSource = mobileDevices;
            leMobileDevices.Properties.DisplayMember = "Key";
            leMobileDevices.Properties.ValueMember = "Value";
            leMobileDevices.EditValue = mobileDevices[0].Value;
            leMobileDevices.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Key", "Mobile Devices"));
        }

        private void LoadOsVersion(string osId)
        {
            var osVersion = Static.OsVersion.Where(s => s.Id == osId).ToList();
            leOsVersion.Properties.DataSource = osVersion;
            leOsVersion.Properties.Columns.Clear();
            leOsVersion.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "OS Version"));
            leOsVersion.Properties.DisplayMember = "Name";
            leOsVersion.Properties.ValueMember = "Value";
            leOsVersion.EditValue = osVersion[0].Value;
        }

        private void LoadType(string typeId)
        {
            var type = Static.Devices.Where(d => d.Id == typeId).ToList();
            leDevices.Properties.DataSource = type;
            leDevices.Properties.Columns.Clear();
            leDevices.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Explore Type"));
            leDevices.Properties.DisplayMember = "Name";
            leDevices.Properties.ValueMember = "Value";
            leDevices.EditValue = type[0].Value;
            leDevices.Enabled = type[0].Value != "0";
        }

        private void leOS_EditValueChanged(object sender, EventArgs e)
        {
            LoadType(leOS.EditValue.ToString());
        }

        private void ceUADevices_CheckedChanged(object sender, EventArgs e)
        {
            leOS.EditValue = os[0].Value;
            leOS.Enabled = ceUADevices.Checked != true;
            leDevices.Enabled = false;
            leMobileDevices.Enabled = leOsVersion.Enabled = ceUADevices.Checked != false;
        }

        private void leMobileDevices_EditValueChanged(object sender, EventArgs e)
        {
            LoadOsVersion(leMobileDevices.EditValue.ToString());
        }

        private void sbGenerator_Click(object sender, EventArgs e)
        {

            if (leOS.EditValue.ToString() == "0" && !ceUADevices.Checked)
            {
                XtraMessageBox.Show("select one 'Explore by' and try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (isStopping == false)
            {
                ceUADevices.Enabled = leMobileDevices.Enabled = leOsVersion.Enabled = sbExport.Enabled = false;
                sbGenerator.ImageOptions.Image = Properties.Resources.Stop_red_icon;
                sbGenerator.Text = "Scanning";
                Scanner.IsStopScan = isStopping;
                sbClear.Enabled = false;

                if (!ceUADevices.Checked)
                {
                    if (leOS.EditValue.ToString() == "1")
                    {
                        new Thread(() =>
                        {
                            Scanner.ScanAndWriteToFile(new ScanInfo()
                            {
                                ExploreBy = "operating_system_name",
                                Type = leDevices.EditValue.ToString(),
                            });
                        })
                        { IsBackground = true }.Start();
                    }
                    else if (leOS.EditValue.ToString() == "2")
                    {
                        new Thread(() =>
                        {
                            Scanner.ScanAndWriteToFile(new ScanInfo()
                            {
                                ExploreBy = "software_name",
                                Type = leDevices.EditValue.ToString(),
                            });
                        })
                        { IsBackground = true }.Start();
                    }
                    else if (leOS.EditValue.ToString() == "3")
                    {
                        new Thread(() =>
                        {
                            Scanner.ScanAndWriteToFile(new ScanInfo()
                            {
                                ExploreBy = "hardware_type_specific",
                                Type = leDevices.EditValue.ToString(),
                            });
                        })
                        { IsBackground = true }.Start();
                    }
                    else if (leOS.EditValue.ToString() == "4")
                    {
                        new Thread(() =>
                        {
                            Scanner.ScanAndWriteToFile(new ScanInfo()
                            {
                                ExploreBy = "software_type_specific",
                                Type = leDevices.EditValue.ToString(),
                            });
                        })
                        { IsBackground = true }.Start();
                    }
                    else if (leOS.EditValue.ToString() == "5")
                    {
                        new Thread(() =>
                        {
                            Scanner.ScanAndWriteToFile(new ScanInfo()
                            {
                                ExploreBy = "layout_engine_name",
                                Type = leDevices.EditValue.ToString(),
                            });
                        })
                        { IsBackground = true }.Start();
                    }
                }
                else
                {
                    if (leMobileDevices.EditValue.ToString() == "1")
                    {
                        new Thread(() =>
                        {
                            Scanner.ScanAndWriteToFile(new ScanInfo()
                            {
                                ExploreBy = "operating_system_name",
                                Type = "ios",
                                DeviceName = leMobileDevices.Text,
                                OSVersion = leOsVersion.EditValue.ToString()
                            });
                        })
                        { IsBackground = true }.Start();
                    }
                    else if (leMobileDevices.EditValue.ToString() == "2")
                    {
                        new Thread(() =>
                        {
                            Scanner.ScanAndWriteToFile(new ScanInfo()
                            {
                                ExploreBy = "operating_system_name",
                                Type = "ios",
                                DeviceName = leMobileDevices.Text,
                                OSVersion = leOsVersion.EditValue.ToString()
                            });
                        })
                        { IsBackground = true }.Start();
                    }
                    else if (leMobileDevices.EditValue.ToString() == "3")
                    {
                        new Thread(() =>
                        {
                            Scanner.ScanAndWriteToFile(new ScanInfo()
                            {
                                ExploreBy = "operating_system_name",
                                Type = "android",
                                DeviceName = leMobileDevices.Text,
                                OSVersion = leOsVersion.EditValue.ToString()
                            });
                        })
                        { IsBackground = true }.Start();
                    }
                    else if (leMobileDevices.EditValue.ToString() == "4")
                    {
                        new Thread(() =>
                        {
                            Scanner.ScanAndWriteToFile(new ScanInfo()
                            {
                                ExploreBy = "operating_system_name",
                                Type = "android",
                                DeviceName = leMobileDevices.Text,
                                OSVersion = leOsVersion.EditValue.ToString()
                            });
                        })
                        { IsBackground = true }.Start();
                    }
                    else if (leMobileDevices.EditValue.ToString() == "5")
                    {
                        new Thread(() =>
                        {
                            Scanner.ScanAndWriteToFile(new ScanInfo()
                            {
                                ExploreBy = "operating_system_name",
                                Type = "android",
                                DeviceName = leMobileDevices.Text,
                                OSVersion = leOsVersion.EditValue.ToString()
                            });
                        })
                        { IsBackground = true }.Start();
                    }
                }
            }
            else
            {
                sbGenerator.Text = "Stopping...";
                sbGenerator.Enabled = false;
                Thread.Sleep(4000);
                sbGenerator.Text = "Scan";
                sbGenerator.ImageOptions.Image = Properties.Resources.Start_icon_x24;
                sbGenerator.Enabled = true;
                Scanner.IsStopScan = isStopping;
                sbClear.Enabled = true;
                ceUADevices.Enabled = true;
                sbExport.Enabled = true;
                if (ceUADevices.Checked)
                {
                    leMobileDevices.Enabled = leOsVersion.Enabled = true;
                }
                else
                {
                    leMobileDevices.Enabled = leOsVersion.Enabled = false;
                }
            }
            isStopping = !isStopping;
        }

        private void sbClear_Click(object sender, EventArgs e)
        {
            mmAddItems.Text = string.Empty;
            listUA.Clear();
            lblStatus.Text = "Status...";
        }


        private void sbExport_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            if (radText.Checked)
            {
                sfd.Title = "File Text";
                sfd.Filter = "File text|*.txt";

                var saveComfirm = XtraMessageBox.Show("Save Text format ??", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (saveComfirm == DialogResult.OK)
                {
                    DialogResult saveFile = sfd.ShowDialog();
                    StringBuilder builder = new StringBuilder();

                    foreach (UserAgent item in listUA)
                    {
                        builder.AppendLine(item.UA);
                    }
                    File.WriteAllText(sfd.FileName, builder.ToString());
                    DialogResult moFile = XtraMessageBox.Show($"Save Success. Open file ??", "Mesage", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (moFile == DialogResult.Cancel) return;
                    Process.Start(sfd.FileName);
                }
            }
            if (radExcel.Checked)
            {
                try
                {
                    sfd.Title = "Excel file";
                    sfd.Filter = "Excel file|*.csv";
                    var saveComfirm = XtraMessageBox.Show("Save Text format ??", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (saveComfirm == DialogResult.OK)
                    {
                        if (sfd.ShowDialog() == DialogResult.Cancel) return;
                        var builder = new StringBuilder();
                        builder.AppendLine("USER AGENT RESULTS");

                        foreach (var item in listUA)
                        {
                            builder.AppendLine(item.UA);
                        }
                        File.WriteAllText(sfd.FileName, builder.ToString());
                        var openFile = XtraMessageBox.Show("Save Success. Open File??", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (openFile == DialogResult.Cancel) return;

                        Process.Start(sfd.FileName);
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        //private void Form1_Shown(object sender, EventArgs e)
        //{
        //    CheckLicense();
        //}
    }
}
