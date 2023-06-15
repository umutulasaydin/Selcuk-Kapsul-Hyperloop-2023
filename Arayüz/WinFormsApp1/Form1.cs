using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Kapsul_Hyperloop : Form
    {
        bool record = false;
        Socket clientSocket;
        bool connected = false;
        bool terminating = false;
        bool test_nav = false;
        string ip;
        Byte[] buffer = new byte[512]; 
        int message = 20;
        double end = 186.0;
        
        List<double> time = new List<double>();

        List<double> x_pos = new List<double>();
        List<double> y_pos = new List<double>();
        List<double> z_pos = new List<double>();

        List<double> vel_x = new List<double>();
        List<double> vel_y = new List<double>();
        List<double> vel_z = new List<double>();

        List<double> acce_x = new List<double>();
        List<double> acce_y = new List<double>();
        List<double> acce_z = new List<double>();

        List<double> ro = new List<double>();
        List<double> ya = new List<double>();
        List<double> pi = new List<double>();

        List<double> t1 = new List<double>();
        List<double> t2 = new List<double>();
        List<double> gt = new List<double>();


        public Kapsul_Hyperloop()
        {
            InitializeComponent();
            timer1.Interval = 500;
            timer1.Enabled = false;
            this.FormClosing += new FormClosingEventHandler(Kapsul_Hyperloop_FormClosing);
            log.AppendText("Ho�geldiniz!\n");
        }

        private void Kapsul_Hyperloop_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (connected)
            {
                byte[] intBytes = BitConverter.GetBytes(4);
                if (BitConverter.IsLittleEndian)
                {
                    Array.Reverse(intBytes);
                }
                clientSocket.Send(intBytes);
                clientSocket.Close();
                timer1.Enabled = false;
            }
            connected = false;
            terminating= true;
            
            Environment.Exit(0);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }





        private void Kapsul_Hyperloop_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            if (username.Text == "kapsul" && password.Text == "kapsul")
            {
                serverIp.Enabled = true;
                connect.Enabled = true;
                username.Enabled = false;
                password.Enabled = false;
                login.Enabled = false;
                log.AppendText("Giri� Ba�ar�l�!\n");
                username.Clear(); 
                password.Clear();
            }    
        }



        private void connect_Click(object sender, EventArgs e)
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ip = serverIp.Text;
            try
            {
                clientSocket.Connect(ip, 1025);
                timer1.Enabled = true;
                frenNoktasi.Enabled= true;
                fren_save.Enabled= true;
                start.Enabled= true;
                stop.Enabled= true;
                emergency.Enabled= true;
                lev_start.Enabled= true;
                lev_stop.Enabled= true; 
          
                motor_go.Enabled= true;
                motor_stop.Enabled= true;
                brake_close.Enabled= true;
                brake_open.Enabled= true;
                button1.Enabled = true;
                button2.Enabled = true;
                ping.ForeColor = Color.Green;
                serverIp.Enabled = false;
                connect.Enabled = false;
                nav_test.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                save_csv.Enabled = true;
                fren_hareketsiz.Enabled = true;
                kumanda.Enabled = true;
                log.AppendText("Ba�lant� Ba�ar�l�! Ba�lan�lan Adress: " +  ip + "\n");
                connected = true;     
                Thread receiveThread = new Thread(Receive);
                receiveThread.Start();

            }
            catch (Exception ex)
            {
                log.AppendText("Ba�lant� Ba�ar�s�z!\n");
                log.AppendText(ex.Message+"\n");
            }
           

        }

        private void Receive()
        {
            while (connected)
            {
                try
                {
                    if (clientSocket.Available > 0)
                    {
                        clientSocket.Receive(buffer);
                        string incomingMessage = Encoding.Default.GetString(buffer);
                        incomingMessage = incomingMessage.TrimEnd();
                        if (incomingMessage.IndexOf('\n') != -1)
                        {
                            incomingMessage = incomingMessage.Substring(0, incomingMessage.IndexOf("\n"));
                        }
                       
                        if (incomingMessage.Length > 0)
                        {
                            log.AppendText("Pod: " + incomingMessage + "\n");
                            string[] data = incomingMessage.Split("/");
                            if (data.Count() == 17)
                            {
                                if (record && Convert.ToDouble(data[0]) != 0.0)
                                {
                                    time.Add(Convert.ToDouble(data[0])/100);
                                    x_pos.Add(Convert.ToDouble(data[1])/100);
                                    vel_x.Add(Convert.ToDouble(data[2]) / 100);
                                    acce_x.Add(Convert.ToDouble(data[3]) / 100);
                                    max_h�z.Text = "Maksimum H�z: " + ((vel_x.Max()) * 3.6).ToString("0.##") + " km/h";
                                    count.Text = time.Count.ToString();
                                    double value = 100.0 * Convert.ToDouble(data[1]) / 100 / end;
                                    progress_bar_value.Text = "%" + value.ToString("0.##");

                                    if (value >= 0 && value <= 100)
                                    {
                                        progressBar1.Value = Convert.ToInt32(value);
                                    }
                                }


                                pos_x.Text = data[1] + " m";
                                pos_y.Text = data[4] + " m";
                                pos_z.Text = data[7] + " m";
                                velo_x.Text = data[2] + " m/s";
                                velo_y.Text = data[5] + " m/s";
                                velo_z.Text = data[8] + " m/s";
                                acc_x.Text = data[3] + " m/s^2"; ;
                                acc_y.Text = data[6] + " m/s^2"; ;
                                acc_z.Text = data[9] + " m/s^2";
                                roll.Text = data[10] + " �";
                                yaw.Text = data[11] + " �";
                                pitch.Text = data[12] + " �";
                                temp1.Text = "S�cakl�k (1): " + data[13] + " �C";
                                temp2.Text = "S�cakl�k (2): " + data[14] + " �C";
                                pow.Text = "G�� T�ketimi: " + data[15] + " kWh";
                                ping.Text = "Ping: " + data[16] + " ms";


                                

                              
                            }
                        }
                    
                        
                       
                    }
                }
                catch (Exception ex)
                {
                    if (!terminating)
                    {
                        
                        log.AppendText("Kaps�l ba�lant�s� kesildi!\n");
                        log.AppendText(ex+"\n");
                        frenNoktasi.Enabled = false;
                        fren_save.Enabled = false;
                        start.Enabled = false;
                        stop.Enabled = false;
                        emergency.Enabled = false;
                        lev_start.Enabled = false;
                        lev_stop.Enabled = false;
                       
                        motor_go.Enabled = false;
                        motor_stop.Enabled = false;
                        brake_close.Enabled = false;
                        brake_open.Enabled = false;
                        ping.ForeColor = Color.Red;
                        timer1.Enabled = false;
                        serverIp.Enabled = true;
                        connect.Enabled = true;
                        button1.Enabled = false;
                        button2.Enabled = false;
                        nav_test.Enabled = false;
                        button3.Enabled = false;
                        button4.Enabled = false;
                        button5.Enabled = false;
                        save_csv.Enabled = false;
                        fren_hareketsiz.Enabled = false;
                        kumanda.Enabled = false;
                    }

                    clientSocket.Close();
                    connected = false;
                    record = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                byte[] intBytes = BitConverter.GetBytes(message);
                if (BitConverter.IsLittleEndian)
                {
                    Array.Reverse(intBytes);
                }
                clientSocket.Send(intBytes);

                if (message != 20)
                {
                    log.AppendText("Kaps�le Yollanan Mesaj: " + message + "\n");
                }

                message = 20;
            }
            catch (Exception ex)
            {
                if (!terminating)
                {

                    log.AppendText("Kaps�l ba�lant�s� kesildi!\n");
                    log.AppendText(ex + "\n");
                    frenNoktasi.Enabled = false;
                    fren_save.Enabled = false;
                    start.Enabled = false;
                    stop.Enabled = false;
                    emergency.Enabled = false;
                    lev_start.Enabled = false;
                    lev_stop.Enabled = false;

                    motor_go.Enabled = false;
                    motor_stop.Enabled = false;
                    brake_close.Enabled = false;
                    brake_open.Enabled = false;
                    ping.ForeColor = Color.Red;
                    timer1.Enabled = false;
                    serverIp.Enabled = true;
                    connect.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    nav_test.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    save_csv.Enabled = false;
                    fren_hareketsiz.Enabled = false;
                    kumanda.Enabled = false;
                }

                clientSocket.Close();
                connected = false;
                record = false;
            }
        }

        private void fren_save_Click(object sender, EventArgs e)
        {
       
        }

        private void start_Click(object sender, EventArgs e)
        {
            message = 3;
            log.AppendText("Ba�lat komutu verildi!\n");
            phase.Text = "Harekete ge�iyor";
            record = true;

        }

        private void stop_Click(object sender, EventArgs e)
        {
            message = 2;
            log.AppendText("Durdur komutu verildi!\n");
            phase.Text = "Durduruluyor";
            record = false;
        }

        private void emergency_Click(object sender, EventArgs e)
        {
            message = 4;
            log.AppendText("Acil durum komutu verildi!\n");
            phase.Text = "Acil Durum";
            record = false;
        }

        private void lev_start_Click(object sender, EventArgs e)
        {
            message = 5;
            log.AppendText("Levitasyon ba�lat�ld�!\n");
            phase.Text = "Test";
        }

        private void lev_stop_Click(object sender, EventArgs e)
        {
            message = 6;
            log.AppendText("Levitasyon durduruldu!\n");
            phase.Text = "Test";
        }



        private void motor_go_Click(object sender, EventArgs e)
        {
            message = 8;
            log.AppendText("Motor �al��t�r�ld�!\n");
            phase.Text = "Test";
        }

        private void motor_stop_Click(object sender, EventArgs e)
        {
            message = 9;
            log.AppendText("Motor durduruldu!\n");
            phase.Text = "Test";
        }

        private void brake_open_Click(object sender, EventArgs e)
        {
            message = 10;
            log.AppendText("Frenler kald�r�ld�!\n");
            phase.Text = "Test";
        }

        private void brake_close_Click(object sender, EventArgs e)
        {
            message = 11;
            log.AppendText("Frenler aktifle�tirildi!\n");
            phase.Text = "Test";
        }


        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            message = 12;
            log.AppendText("Akt�at�r a��ld�!\n");
            phase.Text = "Test";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            message = 13;
            log.AppendText("Akt�at�r kapand�!\n");
            phase.Text = "Test";
        }

        private void nav_test_Click(object sender, EventArgs e)
        {
            if (test_nav)
            {
                message = 15;
                test_nav = false;
                log.AppendText("Test Kapand�!\n");
                test_text.ForeColor = Color.Red;
                end = 186.0;
                
            }
            else
            {
                message = 14;
                test_nav = true;
                log.AppendText("Test A��ld�!\n");
                test_text.ForeColor = Color.Green;
                end = 4.2;
                
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            message = 7;
            log.AppendText("H�zl� test hareketi ba�lad�!\n");
            phase.Text = "Test";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            message = 16;
            log.AppendText("Motor y�n� ileri!\n");
            phase.Text = "Test";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            message = 17;
            log.AppendText("Motor y�n� geri!\n");
            phase.Text = "Test";
        }

        private void save_csv_Click(object sender, EventArgs e)
        {
            record = false;
            String file = @"veri.csv";
            String seperator = ",";
            StringBuilder output = new StringBuilder();
            String[] headings = { "Zaman (sn)", "Ivme", "Hiz", "Konum" };
            output.AppendLine(string.Join(seperator, headings));
            for(int i = 0; i < x_pos.Count; i++)
            {
                String[] newLine = { time[i].ToString("0.##", CultureInfo.InvariantCulture), acce_x[i].ToString("0.##", CultureInfo.InvariantCulture), vel_x[i].ToString("0.##", CultureInfo.InvariantCulture), x_pos[i].ToString("0.##", CultureInfo.InvariantCulture) };
                output.AppendLine(string.Join(seperator, newLine));
            }

            try
            {
                File.AppendAllText(file, output.ToString());
                log.AppendText("Dosya Kaydedildi!\n");
            }
            catch (Exception ex)
            {
                log.AppendText("Dosya Kaydedilemedi!\n");
                log.AppendText(ex.Message+"\n");
            }

        }

        private void kumanda_Click(object sender, EventArgs e)
        {
            message = 20;
            log.AppendText("Kumadaya Ge�i�!\n");
        }

        private void fren_hareketsiz_Click(object sender, EventArgs e)
        {
            message = 18;
            log.AppendText("Fren hareketsiz!\n");
            phase.Text = "Test";
        }
    }
}