using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing.Printing;

namespace ASE_RFID
{
    public partial class FormMain : Form
    {

        String datapath = Path.GetDirectoryName(Application.UserAppDataPath); //設定檔路徑

        public FormMain()
        {
            InitializeComponent();
            CheckInch();

        }

        void getdate(int a)
        {

            String[] ASE = tapedata.Lines;
            String[] B = venderdata.Lines;
            int i, j, k;

            switch (a)
            {

                case 1:
                    for (i = 0; i < tapedata.Lines.Length; i++)
                    {

                        if (txtTapeType.Text == ASE[i])
                        {
                            txtPartNo.Text = B[i];
                            txtASENo.Text = B[i];
                        }
                    }

                    break;

                case 2:

                    for (j = 0; j < venderdata.Lines.Length; j++)
                    {

                        if (txtPartNo.Text == B[j])
                        {
                            txtTapeType.Text = ASE[j];
                            txtASENo.Text = B[j];
                        }
                    }

                    break;
                case 3:

                    for (k = 0; k < venderdata.Lines.Length; k++)
                    {

                        if (txtASENo.Text == B[k])
                        {
                            txtPartNo.Text = B[k];
                            txtTapeType.Text = ASE[k];
                        }
                    }

                    break;
            }
        }

        public void loadconfig()
        {
            try
            {
                if (radinch_8.Checked)
                {
                    StreamReader sa = File.OpenText(Path.Combine(this.datapath, "unitech_8_tape.cfg"));
                    tapedata.Text = sa.ReadToEnd();
                    sa.Close();

                    StreamReader sb = File.OpenText(Path.Combine(this.datapath, "unitech_8_partno.cfg"));
                    venderdata.Text = sb.ReadToEnd();
                    sb.Close();
                }
                else if (radinch_12.Checked)
                {
                    StreamReader sc = File.OpenText(Path.Combine(this.datapath, "unitech_12_tape.cfg"));
                    tapedata.Text = sc.ReadToEnd();
                    sc.Close();

                    StreamReader sd = File.OpenText(Path.Combine(this.datapath, "unitech_12_partno.cfg"));
                    venderdata.Text = sd.ReadToEnd();
                    sd.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void saveconfig()
        {
            if (radinch_8.Checked)
            {
                StreamWriter sa = File.CreateText(Path.Combine(this.datapath, "unitech_8_tape.cfg")); // 8" tape data
                String tape8datacfg = tapedata.Text;
                sa.Write(tape8datacfg);
                sa.Flush();
                sa.Close();

                StreamWriter sb = File.CreateText(Path.Combine(this.datapath, "unitech_8_partno.cfg")); // 8" partno data
                String partno8datacfg = venderdata.Text;
                sb.Write(partno8datacfg);
                sb.Flush();
                sb.Close();
            }
            else if (radinch_12.Checked)
            {
                StreamWriter sc = File.CreateText(Path.Combine(this.datapath, "unitech_12_tape.cfg")); // 12" tape data
                String tape12datacfg = tapedata.Text;
                sc.Write(tape12datacfg);
                sc.Flush();
                sc.Close();

                StreamWriter sd = File.CreateText(Path.Combine(this.datapath, "unitech_12_partno.cfg")); // 12" partno data
                String partno12datacfg = venderdata.Text;
                sd.Write(partno12datacfg);
                sd.Flush();
                sd.Close();
            }

            MessageBox.Show("save succesed!!");

        }

        private void CheckInch()
        {
            if (radinch_8.Checked)
            {
                labInch.Text = "吋別  :  8  吋";

            }
            if (radinch_12.Checked)
            {
                labInch.Text = "吋別  :  12 吋";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string s = "^XA^LH40,80";
            s = s + "^FO0,20^A0N,25,25^FDTape Type:^FS";
            s = s + "^FO0,50^A0N,25,25^FD" + txtTapeType.Text.TrimEnd() + "^FS";
            s = s + "^FO0,80^A0N,25,25^FDExp Date:" + txtExpDate.Text.TrimEnd() + "^FS";
            s = s + "^FO0,110^A0N,25,25^FDVender Lot:" + txtVenderLot.Text.TrimEnd() + "^FS";
            s = s + "^FO0,140^A0N,25,25^FDPart No:" + txtPartNo.Text.TrimEnd() + "^FS";
            s = s + "^FO0,170^A0N,25,25^FDASE No:" + txtASENo.Text.TrimEnd() + "^FS";
            s = s + "^RS8";
            s = s + "^RFW,H,1,2,1^FDF800^FS"; //change tag to 496bit
            s = s + "^RFW,A,2,62,1^FD" + txtTapeType.Text + "," + txtExpDate.Text + "," + txtVenderLot.Text + "," + txtPartNo.Text + "," + txtASENo.Text + "^FS";
            s = s + "^PQ1^XZ";
            // Allow the user to select a printer.
            //PrintDialog pd = new PrintDialog();
            //pd.PrinterSettings = new PrinterSettings();
            //if (DialogResult.OK == pd.ShowDialog(this))
            //{
            // Send a printer-specific to the printer.
            RawPrinterHelper.SendStringToPrinter("ZDesigner ZT410R-203dpi ZPL", s);
            //}

            this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtTapeType_TextChanged(object sender, EventArgs e)
        {
            getdate(1);
        }

        private void txtPartNo_TextChanged(object sender, EventArgs e)
        {
            getdate(2);
        }

        private void txtASENo_TextChanged(object sender, EventArgs e)
        {
            getdate(3);
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtTapeType.Clear();
            txtExpDate.Clear();
            txtVenderLot.Clear();
            txtPartNo.Clear();
            txtASENo.Clear();
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            saveconfig();
        }

        private void radinch_8_CheckedChanged(object sender, EventArgs e)
        {
            tapedata.Clear();
            venderdata.Clear();
            CheckInch();
            loadconfig();
        }

        private void radinch_12_CheckedChanged(object sender, EventArgs e)
        {
            tapedata.Clear();
            venderdata.Clear();
            CheckInch();
            loadconfig();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            loadconfig();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "0000")
            {
                btn_save.Enabled = true;
            }
        }

        #region TEXTBOX
        private void txtTapeType_Enter(object sender, EventArgs e)
        {
            txtTapeType.BackColor = Color.FromArgb(255, 255, 192);
        }

        private void txtTapeType_Leave(object sender, EventArgs e)
        {
            txtTapeType.BackColor = Color.White;
        }

        private void txtTapeType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtExpDate_Enter(object sender, EventArgs e)
        {
            txtExpDate.BackColor = Color.FromArgb(255, 255, 192);
        }

        private void txtExpDate_Leave(object sender, EventArgs e)
        {
            txtExpDate.BackColor = Color.White;
        }

        private void txtExpDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtVenderLot_Enter(object sender, EventArgs e)
        {
            txtVenderLot.BackColor = Color.FromArgb(255, 255, 192);
        }

        private void txtVenderLot_Leave(object sender, EventArgs e)
        {
            txtVenderLot.BackColor = Color.White;
        }

        private void txtVenderLot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtPartNo_Enter(object sender, EventArgs e)
        {
            txtPartNo.BackColor = Color.FromArgb(255, 255, 192);
        }

        private void txtPartNo_Leave(object sender, EventArgs e)
        {
            txtPartNo.BackColor = Color.White;
        }

        private void txtPartNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtASENo_Enter(object sender, EventArgs e)
        {
            txtASENo.BackColor = Color.FromArgb(255, 255, 192);
        }

        private void txtASENo_Leave(object sender, EventArgs e)
        {
            txtASENo.BackColor = Color.White;
        }

        private void txtASENo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }
        #endregion

    }

    public class RawPrinterHelper
    {
        // Structure and API declarions:
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        // SendBytesToPrinter()
        // When the function is given a printer name and an unmanaged array
        // of bytes, the function sends those bytes to the print queue.
        // Returns true on success, false on failure.
        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
        {
            Int32 dwError = 0, dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            bool bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = "My C#.NET RAW Document";
            di.pDataType = "RAW";

            // Open the printer.
            if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                // Start a document.
                if (StartDocPrinter(hPrinter, 1, di))
                {
                    // Start a page.
                    if (StartPagePrinter(hPrinter))
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            // If you did not succeed, GetLastError may give more information
            // about why not.
            if (bSuccess == false)
            {
                dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }

        public static bool SendFileToPrinter(string szPrinterName, string szFileName)
        {
            // Open the file.
            FileStream fs = new FileStream(szFileName, FileMode.Open);
            // Create a BinaryReader on the file.
            BinaryReader br = new BinaryReader(fs);
            // Dim an array of bytes big enough to hold the file's contents.
            Byte[] bytes = new Byte[fs.Length];
            bool bSuccess = false;
            // Your unmanaged pointer.
            IntPtr pUnmanagedBytes = new IntPtr(0);
            int nLength;

            nLength = Convert.ToInt32(fs.Length);
            // Read the contents of the file into the array.
            bytes = br.ReadBytes(nLength);
            // Allocate some unmanaged memory for those bytes.
            pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength);
            // Copy the managed byte array into the unmanaged array.
            Marshal.Copy(bytes, 0, pUnmanagedBytes, nLength);
            // Send the unmanaged bytes to the printer.
            bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, nLength);
            // Free the unmanaged memory that you allocated earlier.
            Marshal.FreeCoTaskMem(pUnmanagedBytes);
            return bSuccess;
        }
        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            IntPtr pBytes;
            Int32 dwCount;
            // How many characters are in the string?
            dwCount = szString.Length;
            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            return true;
        }
    }

}
