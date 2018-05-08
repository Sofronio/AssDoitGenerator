using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssDoitGenerator
{
    public partial class Form1 : Form
    {
        string str_programPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\";
        string str_videoName;
        string[] filesWithPath;
        List<string> myStrList = new List<string>();
        string str_fileName;
        string str_fileExt;
        string str_filePath;
        public Form1()
        {
            InitializeComponent();
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);

        }
        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            myStrList.Clear();
            filesWithPath = (string[])e.Data.GetData(DataFormats.FileDrop);

            using (StreamReader stRead = new StreamReader(filesWithPath[0]))
            {
                while (!stRead.EndOfStream)
                {
                    myStrList.Add(stRead.ReadLine());
                }
            }

            str_fileName = Path.GetFileNameWithoutExtension(filesWithPath[0]);
            str_fileExt = Path.GetExtension(filesWithPath[0]);
            str_filePath = Path.GetDirectoryName(filesWithPath[0]) + @"\";
            textBox1.Text = str_fileName + str_fileExt;
            this.Text = "YouTubeTT loaded!";
        }

        private void writeAvs(string str_videoExt, string str_bitRate)
        {
            //no copyright
            /*
            1, source -> avs
            2, avs -> h264
            3, h264+aac -> mp4
            4, remove h264 tempfile
            */
            List<string> list_avs = new List<string>();
            List<string> list_doit = new List<string>();
            try
            {
                //1, source->avs
                str_videoName = Regex.Replace(str_fileName, @"(\..*)", "");
                str_videoName = Regex.Replace(str_videoName, @"(\d{4})-(\d{2})-(\d{2})", @"$1$2$3");

                string[] strlist_avs = File.ReadAllLines(str_programPath + "Template_avs.txt", Encoding.GetEncoding(936));
                for (int i = 0; i < strlist_avs.Count(); i++)
                {
                    strlist_avs[i] = strlist_avs[i]
                        .Replace("{video_filename}", str_videoName + "." + str_videoExt)
                        .Replace("{subtitle_filename}", str_fileName + ".ass")
                        .Replace("{subtitle}", "")
                        .Replace("{textsubtitle}", "");
                }
                string filePath = str_filePath + @"\";
                File.WriteAllLines(filePath + str_fileName + ".avs", strlist_avs, Encoding.GetEncoding(936));
                //2, avs->h264
                string randomFileName = Path.GetFileNameWithoutExtension(Path.GetRandomFileName());
                list_doit.Add("call NVEncC.exe --avs -i \"" + str_fileName + ".avs\" --vbrhq " + str_bitRate + " -o \"" + randomFileName + ".264\"");
                //3, h264+aac -> mp4
                list_doit.Add("call MP4Box.exe -add \"" + randomFileName + ".264\" \"" + str_fileName + "-muxed.mp4\"");
                list_doit.Add("call MP4Box.exe -add \"" + str_videoName + "." + str_videoExt + "#audio\" \"" + str_fileName + "-muxed.mp4\"");
                //4, remove h264 tempfile
                if (checkBox_delete.Checked)
                {
                    list_doit.Add("call del \"" + randomFileName + ".264\"");
                    list_doit.Add("call del \"" + str_fileName + ".avs\"");
                    list_doit.Add("call del \"" + str_videoName + ".lwi\"");
                    list_doit.Add("call del copyright.ass");
                    list_doit.Add("call del doit.cmd");
                }
                File.WriteAllLines(filePath + "doit.cmd", list_doit.ToArray(), Encoding.GetEncoding(936));
            }
            catch (Exception e)
            {
                this.Text = e.ToString();
            }
        }

        private void writeAvs(string str_videoExt, string str_bitRate, string[] str_copyrights)
        {
            //with copyright
            List<string> list_doItAll = new List<string>();
            foreach (string str_copyright in str_copyrights)
            {
                List<string> list_avs = new List<string>();
                List<string> list_doit = new List<string>();
                list_doItAll.Add("call cd \"" + str_copyright + "\"");
                list_doItAll.Add("call doit.cmd");
                list_doItAll.Add("call cd ..");
                string filePath = str_filePath + @"\" + str_copyright + @"\";
                try
                {
                    //1, source->avs
                    str_videoName = Regex.Replace(str_fileName, @"(\..*)", "");
                    str_videoName = Regex.Replace(str_videoName, @"(\d{4})-(\d{2})-(\d{2})", @"$1$2$3");

                    string[] strlist_avs = File.ReadAllLines(str_programPath + "Template_avs.txt", Encoding.GetEncoding(936));
                    for (int i = 0; i < strlist_avs.Count(); i++)
                    {
                        strlist_avs[i] = strlist_avs[i]
                            .Replace("{video_filename}", @"..\" + str_videoName + "." + str_videoExt)
                            .Replace("{subtitle_filename}", @"..\" + str_fileName + ".ass")
                            .Replace("{subtitle}", "S_str2 = \"copyright.ass\"")
                            .Replace("{textsubtitle}", "TextSub(S_str2)");
                    }
                    (new FileInfo(filePath)).Directory.Create();
                    File.WriteAllLines(filePath + str_fileName + ".avs", strlist_avs, Encoding.GetEncoding(936));
                    //2, avs->h264
                    string randomFileName = Path.GetFileNameWithoutExtension(Path.GetRandomFileName());
                    list_doit.Add("call NVEncC.exe --avs -i \"" + str_fileName + ".avs\" --vbrhq " + str_bitRate + " -o \"" + randomFileName + ".264\"");
                    //3, h264+aac -> mp4
                    list_doit.Add("call MP4Box.exe -add \"" + randomFileName + ".264\" \"" + str_fileName + "-muxed.mp4\"");
                    list_doit.Add("call MP4Box.exe -add \"" + @"..\" + str_videoName + "." + str_videoExt + "#audio\" \"" + str_fileName + "-muxed.mp4\"");
                    //4, remove h264 tempfile
                    if (checkBox_delete.Checked)
                    {
                        list_doit.Add("call del \"" + randomFileName + ".264\"");
                        list_doit.Add("call del \"" + str_fileName + ".avs\"");
                        list_doit.Add("call del copyright.ass");
                        list_doit.Add("call del doit.cmd");
                    }
                    File.WriteAllLines(filePath + "doit.cmd", list_doit.ToArray(), Encoding.GetEncoding(936));
                }
                catch (Exception e)
                {
                    //this.Text = e.ToString();
                    Debug.Print(e.ToString());
                }
                finally
                {
                    if (checkBox_delete.Checked)
                    {
                        list_doit.Add("call del \"" + str_videoName + ".lwi\"");
                        list_doit.Add("call del \"doitall.cmd\"");
                    }
                    string[] str_doItAll = list_doItAll.ToArray();
                    File.WriteAllLines(str_filePath + @"\" + "doitall.cmd", str_doItAll, Encoding.GetEncoding(936));
                    writeCopyright(str_copyright, filePath);
                }
            }
        }

        private void writeAvs4K(string str_videoExt, string str_bitRate, string str_temp4kBitRate)
        {
            //no copyright
            /*
            1, source -> avs
            2, avs -> h264
            3, h264+aac -> mp4
            4, remove h264 tempfile
            */
            List<string> list_avs = new List<string>();
            List<string> list_doit = new List<string>();
            try
            {
                string randomFileName1 = Path.GetFileNameWithoutExtension(Path.GetRandomFileName());
                str_videoName = Regex.Replace(str_fileName, @"(\..*)", "");
                str_videoName = Regex.Replace(str_videoName, @"(\d{4})-(\d{2})-(\d{2})", @"$1$2$3");
                //0, source->hevc
                list_doit.Add("call NVEncC.exe -i \"" + str_videoName + "." + str_videoExt + "\" -c hevc --vbrhq " + str_temp4kBitRate
                    + " --audio-codec aac --audio-bitrate 192 -o \"" + randomFileName1 + ".mp4\"");
                //1, hevc->avs                
                string[] strlist_avs = File.ReadAllLines(str_programPath + "Template_avs.txt", Encoding.GetEncoding(936));
                for (int i = 0; i < strlist_avs.Count(); i++)
                {
                    strlist_avs[i] = strlist_avs[i]
                        .Replace("{video_filename}", randomFileName1 + ".mp4")
                        .Replace("{subtitle_filename}", str_fileName + ".ass")
                        .Replace("{subtitle}", "")
                        .Replace("{textsubtitle}", "");
                }
                string filePath = str_filePath + @"\";

                string randomFileName2 = Path.GetFileNameWithoutExtension(Path.GetRandomFileName());
                File.WriteAllLines(filePath + randomFileName2 + ".avs", strlist_avs, Encoding.GetEncoding(936));
                //2, avs->h264                
                list_doit.Add("call NVEncC.exe --avs -i \"" + randomFileName2 + ".avs\" --vbrhq " + str_bitRate 
                    + " -o \"" + randomFileName2 + ".264\"");
                //3, h264+aac -> mp4
                list_doit.Add("call MP4Box.exe -add \"" + randomFileName2 + ".264\" \"" + str_fileName + "-muxed.mp4\"");
                list_doit.Add("call MP4Box.exe -add \"" + randomFileName1 + ".mp4#audio\" \"" + str_fileName + "-muxed.mp4\"");
                //4, remove h264 tempfile=\
                if (checkBox_delete.Checked)
                {
                    list_doit.Add("call del \"" + randomFileName1 + ".*\"");
                    list_doit.Add("call del \"" + randomFileName2 + ".*\"");                    
                    list_doit.Add("call del \"" + str_videoName + "." + str_videoExt + ".lwi\"");                    
                    list_doit.Add("call del \"doit4k.cmd\"");
                }
                File.WriteAllLines(filePath + "doit4k.cmd", list_doit.ToArray(), Encoding.GetEncoding(936));
            }
            catch (Exception e)
            {
                this.Text = e.ToString();
            }
        }

        private void writeCopyright(string str_copyright, string str_copyrightPath)
        {
            List<string> list_copyright = new List<string>();
            try
            {
                string str_othersite = "秒拍微博优酷头条微信网易百度人人熊猫";
                str_othersite = str_othersite.Replace(str_copyright, "");
                var strlist_header = File.ReadAllLines(str_programPath + "Template_ass_copyright.txt", Encoding.GetEncoding(936));
                for (int i = 0; i < strlist_header.Count(); i++)
                {
                    strlist_header[i] = strlist_header[i].Replace("{uploadsite}", str_copyright).Replace("{othersite}", str_othersite);
                }
                File.WriteAllLines(str_copyrightPath + "copyright.ass", strlist_header, Encoding.UTF8);
            }
            catch (Exception e)
            {
                Debug.Print(e.ToString());
            }
        }

        void doIt()
        {
            string str_videoExt
                = groupBox_videoExt.Controls.OfType<RadioButton>()
                .FirstOrDefault(n => n.Checked)
                .Text;
            string str_bitRate = textBox_bitRate.Text;
            string str_temp4kBitRate = textBox_temp4kBitrate.Text;
            if (checkBox_4k.Checked)
            {
                writeAvs4K(str_videoExt, str_bitRate, str_temp4kBitRate);
            }
            else
            {
                if (radioButton_copyrightOn.Checked)
                {
                    //with copyright
                    List<string> str_copyrights = new List<string>();
                    //get all checked upsite radiobutton text
                    var validData
                        = groupBox_UploadSite.Controls.OfType<RadioButton>()
                        .SelectMany(c => c.Controls.OfType<RadioButton>())
                        .All(radiobutton => !string.IsNullOrWhiteSpace(radiobutton.Text));
                    if (validData)
                    {
                        var checkboxes
                            = groupBox_UploadSite.Controls.OfType<CheckBox>();
                        foreach (var c in checkboxes)
                        {
                            if (c.Checked)
                            {
                                str_copyrights.Add(c.Text);
                            }
                        }
                        str_copyrights.Reverse();
                        writeAvs(str_videoExt, str_bitRate, str_copyrights.ToArray());
                    }
                }
                else
                {
                    writeAvs(str_videoExt, str_bitRate);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            doIt();
        }

        private void radioButton_renderHard_CheckedChanged(object sender, EventArgs e)
        {
            //youtube have stores 4k video using webm, so if using the hardway to render,
            //it'll should be using webm videos.
        }

        private void radioButton_copyrightOff_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_copyrightOff.Checked)
            {
                groupBox_UploadSite.Enabled = false;
            }
            else
            {
                groupBox_UploadSite.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_4k_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_4k.Checked)
            {
                textBox_bitRate.Text = "5500";
                radioButton_webm.Checked = true;
            }
        }
    }
}
