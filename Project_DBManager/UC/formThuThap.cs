using Microsoft.VisualBasic.FileIO;
using Project_DBManager.DAO;
using Project_DBManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Task = System.Threading.Tasks.Task;

namespace Project_DBManager.UC
{
    public partial class formThuThap : Form
    {
        public string googleURL;
        public string desktopPath;
        List<TempBrand> listBrand;
        
        public formThuThap(string googleURL)
        {
            InitializeComponent();
            this.googleURL = googleURL;
            desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/result.csv";
            desktopPath = desktopPath.Replace("\\", "/");
            cb_PhanLoai.SelectedIndex = 0;
            changeUrlAndPath(googleURL, desktopPath);
            thuThap();
            
        }
       
        public void loadListBrand(List<string[]> list)
        {
            List<TempBrand> tempListBrand = new List<TempBrand>();
            foreach(string[] item in list)
            {
                tempListBrand.Add(new TempBrand(item));
            }
            listBrand = tempListBrand;
            dtgv_Staff.DataSource = listBrand;
        }
        public List<string[]> readFile(string path)
        {
            

            List<string[]> dataRows = new List<string[]>();

            using (TextFieldParser parser = new TextFieldParser(path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    dataRows.Add(fields);
                }
            }
            dataRows.RemoveAt(0);
            return dataRows;
            
        }
        public async void thuThap()
        {
            // Specify the path to Node.js and the Node.js script to run
            string nodePath = @"C:\Program Files\nodejs\node.exe"; // Adjust the path accordingly
            string scriptPath = @"C:\Users\Lenovo\Desktop\TDTU\Scraper\scrape.js"; // Adjust the path accordingly

            // Arguments to pass to the Node.js script (if any)
            string arguments = "";

            // Create process start info
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = nodePath,
                Arguments = $"\"{scriptPath}\" {arguments}",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };
            
            // Start the process
            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.OutputDataReceived += (s, eArgs) =>
                {
                    if (!string.IsNullOrEmpty(eArgs.Data))
                    {
                        lb_Progress.Invoke(new MethodInvoker(delegate {
                            string data = eArgs.Data;
                            if (data.Contains("Batch")){
                                data = eArgs.Data.Replace("Batch", "Đã thu thập").Replace("completed", "gói tin");
                            }
                            
                            lb_Progress.Text = ("Quá trình thu thập: " + data);
                        }));
                    }
                };
                process.ErrorDataReceived += (s, eArgs) =>
                {
                    if (!string.IsNullOrEmpty(eArgs.Data))
                    {
                        lb_Progress.Invoke(new MethodInvoker(delegate {
                            lb_Progress.Text = ("Progess: " + eArgs.Data);
                        }));
                    }
                };

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                await System.Threading.Tasks.Task.Run(() => process.WaitForExit());
                lb_Title.Text = "Danh sách thông tin đã thu thập";
                MessageBox.Show("Thu thập hoàn tất");
                readFile(desktopPath);
                loadListBrand(readFile(desktopPath));
            }
        }
        public void changeUrlAndPath(string url, string desktopPath)
        {
            string filePath = @"C:\Users\Lenovo\Desktop\TDTU\Scraper\scrape.js";
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("googleUrl"))
                {
                    // Replace the line with the desired string
                    lines[i] = string.Format("    googleUrl = '{0}';", googleURL);
                    break;
                }
            }
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("newPath"))
                {
                    // Replace the line with the desired string
                    lines[i] = string.Format("    const newPath = '{0}';", desktopPath);
                    break;
                }
            }
            File.WriteAllLines(filePath, lines);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach(TempBrand temp in listBrand)
            {
                temp.Category = cb_PhanLoai.Text;
                if(temp.IsChecked == false) { continue; }
                bool isSucceed = BrandDAO.Instance.insertBrand(temp);
                if (isSucceed == false) { MessageBox.Show("Thêm thất bại thương hiệu: " + temp.BrandName);}
                    else { count++; }
            }
            MessageBox.Show(string.Format("Đã thêm {0} thương hiệu", count));
        }
    }
}
