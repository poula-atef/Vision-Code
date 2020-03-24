using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using System.Diagnostics;
using System.IO;
namespace vision
{
    public partial class Form1 : Form
    {
        String s;
        SpeechSynthesizer ss = new SpeechSynthesizer();
        SpeechSynthesizer read = new SpeechSynthesizer();       
        SpeechRecognitionEngine ren = new SpeechRecognitionEngine();
        SpeechRecognitionEngine wake = new SpeechRecognitionEngine();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            ss.Volume = 100;
            ss.Rate = 1;
            Choices ch = new Choices();
            ch.Add(new String[] { "what is your name","open notepad","close notepad",
            "open visual studio","close visual studio","thank you","who are you","enough","stop reading",
            "introduce yourself","how are you","sleep my computer","open control panel",
            "open my computer","who made you","who is your maker","hey vision","what is the time",
            "what is the date","what is the weather","good morning","good afternoon", "what is my name",
            "go to sleep", "write what i say", "open chrome","open google", "open facebook",
            "open yahoo","open telegram","open twitter","open gmail","open keep","open maps",
            "open drive","open instagram","search on google","open youtube","search on youtube",
            "close chrome","translation","read me a file","start","wait","continue","back","stop listening","uninstall program"});
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(ch);
            Grammar g = new Grammar(gb);
            ren.LoadGrammarAsync(g);
            ren.SetInputToDefaultAudioDevice();
            ren.SpeechRecognized += ren_SpeechRecognized;
            ren.RecognizeAsync(RecognizeMode.Multiple);
            wake.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices("wake up"))));
            wake.SetInputToDefaultAudioDevice();
            wake.SpeechRecognized += wake_SpeechRecognized;
            String date = DateTime.Now.ToString("h mm tt");
            if (date.ToLower().Contains('a'))
                ss.SpeakAsync("good morning sir,vision is here, if you want anything just call me");
            else
                ss.SpeakAsync("good afternoon sir,vision is here, if you want anything just call me");
        }

        void wake_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text.Contains("wake up"))
            {
                wake.RecognizeAsyncCancel();
                ss.SpeakAsync("yes sir, i'm here");
                ren.RecognizeAsync(RecognizeMode.Multiple);
            }
        }

        private void ren_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            web(e);

        }

        void web(SpeechRecognizedEventArgs e)
        {

            if (e.Result.Text.Equals("who is your maker") || e.Result.Text.Equals("who made you"))
            {
                ss.SpeakAsync("my maker is poula atef from computer and information science ain shams universty");
            }

            else if (e.Result.Text.Equals("good morning"))
            {
            String date = DateTime.Now.ToString("h mm tt");
            if (date.ToLower().Contains('a'))
                ss.SpeakAsync("good morning sir");
            else
                ss.SpeakAsync("you mean good afternoon because we're in the pm period");
            }

            else if (e.Result.Text.Equals("good afternoon"))
            {
                String date = DateTime.Now.ToString("h mm tt");
                if (date.ToLower().Contains('p'))
                    ss.SpeakAsync("good afternoon sir");
                else
                    ss.SpeakAsync("you mean good morning because we're in the am period");
            }
            else if (e.Result.Text.Equals("what is your name") || e.Result.Text.Equals("who are you"))
            {
                ss.SpeakAsync("my name is vision and i'm your personal assistant");
            }

            else if (e.Result.Text.Equals("introduce yourself"))
            {
                ss.SpeakAsync("my name is vision and i've made to be a desktop assistant");
            }

            else if (e.Result.Text.Equals("thank you"))
            {
                ss.SpeakAsync("you are welcomed");
            }


            else if (e.Result.Text.Equals("how are you"))
            {
                ss.SpeakAsync("i'm working as well as i can");
            }

            else if (e.Result.Text.Contains("go to sleep"))
            {
                close();
            }

            else if (e.Result.Text.Contains("stop"))
            {
                ss.SpeakAsync("okay sir call me if you want anything");
                ren.RecognizeAsyncCancel();
                wake.RecognizeAsync(RecognizeMode.Multiple);
            }

            else if (e.Result.Text.Contains("vision"))
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                ss.SpeakAsync("yes sir");
            }

            else if (e.Result.Text.Contains("uninstall"))
            {
                ss.SpeakAsync("see what you want to remove");
                var cplPath = System.IO.Path.Combine(Environment.SystemDirectory, "control.exe");
                System.Diagnostics.Process.Start(cplPath, "/name Microsoft.ProgramsAndFeatures");
            }

            else if (e.Result.Text.Contains("back"))
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                ss.SpeakAsync("okay sir");
            }

            else if (e.Result.Text == "open google")
            {
                ss.SpeakAsync("opening google");
                System.Diagnostics.Process.Start("www.google.com.eg");
            }

            else if (e.Result.Text == "open facebook")
            {
                ss.SpeakAsync("opening facebook");
                System.Diagnostics.Process.Start("www.facebook.com");
            }

            else if (e.Result.Text == "open yahoo")
            {
                ss.SpeakAsync("opening yahoo");
                System.Diagnostics.Process.Start("www.yahoo.com");
            }

            else if (e.Result.Text == "open twitter")
            {
                ss.SpeakAsync("opening twitter");
                System.Diagnostics.Process.Start("www.twitter.com");
            }

            else if (e.Result.Text == "open telegram")
            {
                ss.SpeakAsync("opening telegram");
                System.Diagnostics.Process.Start("https://web.telegram.org/");
            }

            else if (e.Result.Text == "open instagram")
            {
                ss.SpeakAsync("opening instagram");
                System.Diagnostics.Process.Start("www.instagram.com");
            }

            else if (e.Result.Text == "open gmail")
            {
                ss.SpeakAsync("opening gmail");
                System.Diagnostics.Process.Start("www.gmail.com");
            }

            else if (e.Result.Text == "open maps")
            {
                ss.SpeakAsync("opening maps");
                System.Diagnostics.Process.Start("https://www.google.com/maps");
            }

            else if (e.Result.Text == "open drive")
            {
                ss.SpeakAsync("opening drive");
                System.Diagnostics.Process.Start("https://drive.google.com/drive/my-drive?fbclid=IwAR06SRaJMYMWAN53gJ2o0rmx_glSll7nqmrQXrnAMBsSgd-4lVYq3beoccE");
            }

            else if (e.Result.Text == "open keep")
            {
                ss.SpeakAsync("opening keep");
                System.Diagnostics.Process.Start("https://keep.google.com/");
            }

            else if (e.Result.Text == "open youtube")
            {
                ss.SpeakAsync("opening youtube");
                System.Diagnostics.Process.Start("https://www.youtube.com/?gl=EG");
            }

            else if (e.Result.Text.Contains("open my computer"))
            {
                ss.SpeakAsync("opening my computer");
                Process.Start("::{20d04fe0-3aea-1069-a2d8-08002b30309d}");
            }

            else if (e.Result.Text.Contains("open control panel"))
            {
                ss.SpeakAsync("opening control panel");
                var cplPath = System.IO.Path.Combine(Environment.SystemDirectory, "control.exe");
                System.Diagnostics.Process.Start(cplPath);
            }

            else if (e.Result.Text.Contains("open chrome"))
            {
                ss.SpeakAsync("opening chrome");
                System.Diagnostics.Process.Start(@"chrome.exe");
            }

            else if (e.Result.Text.Contains("close chrome"))
            {
                ss.SpeakAsync("chrome is closed");
                foreach (Process p in Process.GetProcesses())
                {
                    String name = p.ProcessName.ToLower();
                    if (name == "chrome")
                        p.Kill();
                }
            }

            else if (e.Result.Text.Contains("open notepad"))
            {
                ss.SpeakAsync("opening notepad");
                System.Diagnostics.Process.Start(@"notepad.exe");
            }

            else if (e.Result.Text.Contains("close notepad"))
            {
                ss.SpeakAsync("notepad is closed");
                foreach (Process p in Process.GetProcesses())
                {
                    String name = p.ProcessName.ToLower();
                    if (name == "notepad")
                        p.Kill();
                }
            }

            else if (e.Result.Text.Contains("search on youtube"))
            {
                textBox1.Size = new System.Drawing.Size(122, 29);
                this.Size = new System.Drawing.Size(260, 171);
                start.Visible = false;
                wait.Visible = false;
                button2.Visible = false;
                arabic.Visible = false;
                english.Visible = false;
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                textBox1.Text = "";
                ss.SpeakAsync("what video you want to search about");
                label1.Text = "Video target";
            }

            else if (e.Result.Text.Contains("google"))
            {
                textBox1.Size = new System.Drawing.Size(122, 29);
                this.Size = new System.Drawing.Size(260, 171);
                start.Visible = false;
                wait.Visible = false;
                button2.Visible = false;
                arabic.Visible = false;
                english.Visible = false;
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                textBox1.Text = "";
                ss.SpeakAsync("what you want to search about in google");
                label1.Text = "Head line";
            }

            else if (e.Result.Text == "what is the time")
            {
                ss.SpeakAsync("it " + DateTime.Now.ToString("h mm tt"));
            }

            else if (e.Result.Text == "what is the date")
            {
                ss.SpeakAsync("it " + DateTime.Now.ToLongDateString());
            }

            else if (e.Result.Text == "what is the weather")
            {
                ss.SpeakAsync("lets see");
                System.Diagnostics.Process.Start("https://www.timeanddate.com/weather/egypt/cairo/ext");
            }

            else if (e.Result.Text.ToLower().Contains("translation"))
            {
                arabic.Visible = true;
                english.Visible = true;
                textBox1.Size = new System.Drawing.Size(122, 29);
                this.Size = new System.Drawing.Size(260, 171);
                start.Visible = false;
                wait.Visible = false;
                button2.Visible = false;
                label1.Text = "Your words";
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                textBox1.Text = "";
            }

            else if (e.Result.Text.ToLower().Contains("start"))
            {
                read.SpeakAsync(textBox1.Text);
            }

            else if (e.Result.Text.ToLower().Contains("wait"))
            {
                if (read.State == SynthesizerState.Speaking)
                    read.Pause();
            }

            else if (e.Result.Text.ToLower().Contains("continue"))
            {
                if (read.State == SynthesizerState.Paused)
                    read.Resume();
            }
            else if (e.Result.Text.ToLower().Contains("enough") || e.Result.Text.ToLower().Contains("stop reading"))
            {
                ss.SpeakAsync("okay sir i'll stop");
                read.SpeakAsyncCancelAll();                
            }
                

            else if (e.Result.Text.ToLower().Contains("me"))
            {
                start.Visible = true;
                wait.Visible = true;
                button2.Visible = true;
                arabic.Visible = false;
                english.Visible=false;
                textBox1.Height=300;
                textBox1.Width=350;
                read.Volume = 100;
                read.Rate = 1;
                ss.SpeakAsync("okay sir choose the file you want me to read");
                this.Size = new System.Drawing.Size(500, 400);
                OpenFileDialog f = new OpenFileDialog();
                f.Filter = "TXT(*.TXT)|*.txt";
                if (f.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = "";
                    FileStream fs = new FileStream(f.FileName, FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    String readfile;
                    while (sr.Peek() != -1)
                    {
                        readfile = sr.ReadLine();
                        textBox1.Text += readfile + " ";
                    }
                    fs.Close();
                    sr.Close();
                    this.WindowState = FormWindowState.Normal;
                    this.ShowInTaskbar = true;
                }
            }

            else
            {
                ss.SpeakAsync("i don't understand you sir ,please say it again");
            }
        }




        public void close()
        {
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (label1.Text == "Your words")
                {
                    String feta="";
                    if(english.Checked)
                        feta = "https://translate.google.com.eg/?hl=en#view=home&op=translate&sl=en&tl=ar&text=";
                    else if(arabic.Checked)
                        feta = "https://translate.google.com.eg/?hl=en#view=home&op=translate&sl=ar&tl=en&text=";
                    textBox1.Text += " ";
                    String t = textBox1.Text;
                    String st = "";
                    for (int i = 0; i < textBox1.Text.Length; i++)
                    {
                        if (t[i] == ' ')
                        {
                            st += "%20";
                            feta += st;
                            st = "";
                        }
                        else
                            st += t[i];
                    }
                    System.Diagnostics.Process.Start(feta);
                }
                else if (label1.Text == "Video target")
                {
                    String you = "https://www.youtube.com/results?search_query=";
                    textBox1.Text += " ";
                    String t = textBox1.Text;
                    String st = "";
                    for (int i = 0; i < textBox1.Text.Length; i++)
                    {
                        if (t[i] == ' ')
                        {
                            st += "+";
                            you += st;
                            st = "";
                        }
                        else
                            st += t[i];
                    }
                    System.Diagnostics.Process.Start(you);
                }
                else if (label1.Text == "Head line")
                {
                    String goo = "https://www.google.com.eg/search?q=";
                    textBox1.Text += " ";
                    String t = textBox1.Text;
                    String st = "";
                    for (int i = 0; i < textBox1.Text.Length; i++)
                    {
                        if (t[i] == ' ')
                        {
                            st += "+";
                            goo += st;
                            st = "";
                        }
                        else
                            st += t[i];
                    }
                    System.Diagnostics.Process.Start(goo);
                }
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            ss.SpeakAsync(textBox1.Text);

        }

        private void wait_Click(object sender, EventArgs e)
        {
            if (ss.State == SynthesizerState.Speaking)
                ss.Pause();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ss.State == SynthesizerState.Paused)
                ss.Resume();
        }
    }
}
