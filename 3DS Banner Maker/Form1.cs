using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace _3DS_Banner_Maker
{
    public partial class Form1 : Form
    {
        public string bannerFile="";
        public string icon48File="";
        public string icon24File="";
        public string error;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadIcon24Btt_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                icon24File = openFileDialog1.FileName;
                icon24Preview.Image = Image.FromFile(icon24File);
            }
        }

        private void loadBannerBtt_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bannerFile = openFileDialog1.FileName;
                bannerPreview.Image = Image.FromFile(bannerFile);
            }
        }

        private void loadIcon48Btt_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                icon48File = openFileDialog1.FileName;
                icon48Preview.Image = Image.FromFile(icon48File);
            }
        }

        private void exportBannerBtt_Click(object sender, EventArgs e)
        {
            if (bannerFile != "" && icon24File != "" && icon48File != "")
            {
                //--- CLEARING /DATA ---
                ClearData();

                //--- PREPARING APPDATA.TXT ---
                WriteAppData();

                //--- MOVING SELECTED FILES TO DATA FOLDER (TEMP) ---
                PrepareImages();

                //--- BUILDING BANNER AND ICON ---
                if (Build()==0)
                {
                    //--- MOVING EXPORTED FILES ---
                    File.Move("data/banner.bnr", "banner.bin");
                    File.Move("data/icon.icn", "icon.bin");

                    //--- CLEARING /DATA ---
                    ClearData();

                    //--- EXPORTED! ---
                    MessageBox.Show("File exported!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //SOMETHING WENT WRONG!
                    ClearData();
                    MessageBox.Show("Something went wrong during build process. Click OK to see a log.", "FATAL ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(error, "ERROR LOG");
                }            
            }
            else
            {
                MessageBox.Show("You have to load banner and icons images!", "Stop!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void WriteAppData()
        {
            StreamWriter AppDataWriter = new StreamWriter("data/AppData.txt");
            AppDataWriter.WriteLine("longtitle=\"" + textBox1.Text + "\"");
            AppDataWriter.WriteLine("shortitle=\"" + textBox2.Text + "\"");
            AppDataWriter.WriteLine("publisher=\"" + textBox3.Text + "\"");
            AppDataWriter.WriteLine();
            AppDataWriter.WriteLine("visibility    ={0}", Convert.ToInt32(checkBox1.Checked));
            AppDataWriter.WriteLine("autoBoot      ={0}", Convert.ToInt32(checkBox2.Checked));
            AppDataWriter.WriteLine("use3D         ={0}", Convert.ToInt32(checkBox3.Checked));
            AppDataWriter.WriteLine("requireEULA   ={0}", Convert.ToInt32(checkBox4.Checked));
            AppDataWriter.WriteLine("autoSaveOnExit={0}", Convert.ToInt32(checkBox5.Checked));
            AppDataWriter.WriteLine("extendedBanner={0}", Convert.ToInt32(checkBox6.Checked));
            AppDataWriter.WriteLine("gameRatings   ={0}", Convert.ToInt32(checkBox7.Checked));
            AppDataWriter.WriteLine("useSaveData   ={0}", Convert.ToInt32(checkBox8.Checked));
            AppDataWriter.WriteLine("recordAppUsage={0}", Convert.ToInt32(checkBox9.Checked));
            AppDataWriter.WriteLine("disableSaveBU ={0}", Convert.ToInt32(checkBox10.Checked));
            AppDataWriter.Close();
        }

        private void ClearData()
        {
            File.Delete("data/AppData.txt");
            File.Delete("data/cbmd_bannerImage/256x128.png");
            File.Delete("data/ctpk_24x24icon/icon.png");
            File.Delete("data/ctpk_48x48icon/icon.png");
        }

        private void PrepareImages()
        {
            File.Copy(bannerFile, "data/cbmd_bannerImage/256x128.png");
            File.Copy(icon24File, "data/ctpk_24x24icon/icon.png");
            File.Copy(icon48File, "data/ctpk_48x48icon/icon.png");
        }

        public int Build()
        {
            int ExitCode;
            ProcessStartInfo ProcessInfo;
            Process process;

            ProcessInfo = new ProcessStartInfo(Application.StartupPath + "\\data\\BUILD.bat");
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = false;
            ProcessInfo.RedirectStandardError = true;
            process = Process.Start(ProcessInfo);
            process.WaitForExit();
            error = process.StandardError.ReadToEnd();
            ExitCode = process.ExitCode;           
            process.Close();

            return ExitCode;
        }
    }
}
