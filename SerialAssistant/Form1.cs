using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace SerialAssistant
{
    public partial class Form1 : Form
    {
        string path = "C:\\洗碗机时序.txt";
        private long received_count = 0; //接收字节计数
        private long send_count = 0;    //发送字节计数
        private StringBuilder sb = new StringBuilder();    //为了避免在接收处理函数中反复调用，依然声明为一个全局变量
        //private DateTime current_time = new DateTime();    //为了避免在接收处理函数中反复调用，依然声明为一个全局变量
        //private string[] commundata = new string[100];
 
        private bool Listening = false;//是否没有执行完invoke相关操作  
        private bool Closing = false;//是否正在关闭串口，执行Application.DoEvents，并阻止再次invoke  
        private List<byte> commundata = new List<byte>(4096);//默认分配1页内存，并始终限制不允许超过  
        private byte[] binary_data_1 = new byte[50];  

        private StringBuilder builder = new StringBuilder();    //避免在事件处理方法中反复创建，定义为全局
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //获取电脑当前可用串口并添加到选项列表中
            comboBox_uart.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    textBox_sheet.Text = sr.ReadToEnd();
                }
            }
            catch (Exception)
            {

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //将可能产生异常的代码放置在try块中
                //根据当前串口属性来判断是否打开
                if (serialPort1.IsOpen)
                {
                    try
                    {
                        //串口已经处于打开状态
                        serialPort1.Close();    //关闭串口
                        open_uart_button.Text = "打开串口";
                        open_uart_button.BackColor = Color.ForestGreen;
                        comboBox_uart.Enabled = true;
                        down_label.Text = "串口已关闭";
                        down_label.ForeColor = Color.Red;
                        seed_button.Enabled = false;        //失能发送按钮
                    }
                    catch (Exception)
                    {

                    }
                }
                else
                {
                    //串口已经处于关闭状态，则设置好串口属性后打开
                    comboBox_uart.Enabled = false;
                    serialPort1.PortName = comboBox_uart.Text;
                    serialPort1.BaudRate = 115200;
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = System.IO.Ports.Parity.None;
                    serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    serialPort1.Open();     //打开串口
                    open_uart_button.Text = "关闭串口";
                    open_uart_button.BackColor = Color.Firebrick;
                    down_label.Text = "串口已打开";
                    down_label.ForeColor = Color.Green;
                    seed_button.Enabled = true;        //使能发送按钮

                    serialPort1.NewLine = "/r/n";
                    serialPort1.RtsEnable = true;//根据实际情况吧。  
                                                 //添加事件注册  
                    //serialPort1.DataReceived += SerialPort1_DataReceived;
                }
            }
            catch (Exception ex)
            {
                //捕获可能发生的异常并进行处理
                //捕获到异常，创建一个新的对象，之前的不可以再用
                serialPort1 = new System.IO.Ports.SerialPort();
                //刷新COM口选项
                comboBox_uart.Items.Clear();
                comboBox_uart.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                //响铃并显示异常给用户
                System.Media.SystemSounds.Beep.Play();
                open_uart_button.Text = "打开串口";
                open_uart_button.BackColor = Color.ForestGreen;
                MessageBox.Show(ex.Message);
                comboBox_uart.Enabled = true;
            }
        }

        private void Send_data(string data)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] temp = new byte[1];
            try
            {
                //首先判断串口是否开启
                if (serialPort1.IsOpen)
                {
                    int num = 0;   //获取本次发送字节数
                    //串口处于开启状态，将发送区文本发送

                    //判断发送模式
                    //以HEX模式发送
                    //首先需要用正则表达式将用户输入字符中的十六进制字符匹配出来
                    string buf = textBox_send.Text;
                    string pattern = @"\s";
                    string replacement = "";
                    Regex rgx = new Regex(pattern);
                    string send_data = rgx.Replace(buf, replacement);

                    //不发送新行
                    num = (send_data.Length - send_data.Length % 2) / 2;
                    for (int i = 0; i < num; i++)
                    {
                        temp[0] = Convert.ToByte(send_data.Substring(i * 2, 2), 16);
                        serialPort1.Write(temp, 0, 1);  //循环发送
                    }
                    //如果用户输入的字符是奇数，则单独处理
                    if (send_data.Length % 2 != 0)
                    {
                        temp[0] = Convert.ToByte(send_data.Substring(textBox_send.Text.Length-1,1), 16);
                        serialPort1.Write(temp, 0, 1);
                        num++;
                    }
                    //判断是否需要发送新行                         
                    send_count += num;      //计数变量累加
                    txcnt_label.Text = "Tx:" + send_count.ToString() + "Bytes";   //刷新界面
                }
            }
            catch (Exception ex)
            {
                serialPort1.Close();
                //捕获到异常，创建一个新的对象，之前的不可以再用
                serialPort1 = new System.IO.Ports.SerialPort();
                //刷新COM口选项
                comboBox_uart.Items.Clear();
                comboBox_uart.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                //响铃并显示异常给用户
                System.Media.SystemSounds.Beep.Play();
                open_uart_button.Text = "打开串口";
                open_uart_button.BackColor = Color.ForestGreen;
                MessageBox.Show(ex.Message);
                comboBox_uart.Enabled = true;
            }
        }

        //串口接收事件处理
        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (Closing) return;//如果正在关闭，忽略操作，直接返回，尽快的完成串口监听线程的一次循环  
            try
            {
                int len = 0;
                int checksum = 0;
                Listening = true;//设置标记，说明我已经开始处理数据，一会儿要使用系统UI的。  
                int n = serialPort1.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致  
                byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据  
                received_count += n;//增加接收计数  
                serialPort1.Read(buf, 0, n);//读取缓冲数据  
                //
                //<协议解析>  
                bool data_1_catched = false;//缓存记录数据是否捕获到  
                                            //1.缓存数据  
                commundata.AddRange(buf);
                //2.完整性判断  
                while (commundata.Count >= 4)//至少要包含头（2字节）+长度（1字节）+校验（1字节）  
                {
                    //请不要担心使用>=，因为>=已经和>,<,=一样，是独立操作符，并不是解析成>和=2个符号  
                    //2.1 查找数据头  
                    if (commundata[0] == 0x55)
                    {
                        //2.2 探测缓存数据是否有一条数据的字节，如果不够，就不用费劲的做其他验证了  
                        //前面已经限定了剩余长度>=4，那我们这里一定能访问到commundata[2]这个长度  
                        len = (commundata[2]<<8)+commundata[1];//数据长度  
                                            //数据完整判断第一步，长度是否足够  
                                            //len是数据段长度,4个字节是while行注释的3部分长度  
                        if (commundata.Count < len + 2) break;//数据不够的时候什么都不做  
                                                          //这里确保数据长度足够，数据头标志找到，我们开始计算校验  
                                                          //2.3 校验数据，确认数据正确  
                                                          //累加和校验
                        checksum = 0;
                        for (int i = 0; i < len + 1; i++)//len+3表示校验之前的位置  
                        {
                            checksum += commundata[i];
                        }
                        checksum %= 256;
                        if (checksum != commundata[len + 1]) //如果数据校验失败，丢弃这一包数据  
                        {
                            //for (int i = 0; i < len + 2; i++)
                            //{
                            //    this.Invoke((EventHandler)(delegate { textBox_sheet.AppendText(commundata[i].ToString("X2")); }));
                            //    //textBox_sheet.AppendText(commundata[i].ToString());
                            //}
                            commundata.RemoveRange(0, len + 2);//从缓存中删除错误数据  
                            continue;//继续下一次循环  
                        }
                        //至此，已经被找到了一条完整数据。我们将数据直接分析，或是缓存起来一起分析  
                        //我们这里采用的办法是缓存一次，好处就是如果你某种原因，数据堆积在缓存commundata中  
                        //已经很多了，那你需要循环的找到最后一组，只分析最新数据，过往数据你已经处理不及时  
                        //了，就不要浪费更多时间了，这也是考虑到系统负载能够降低。  
                        commundata.CopyTo(0, binary_data_1, 0, len + 2);//复制一条完整数据到具体的数据缓存  
                        data_1_catched = true;
                        commundata.RemoveRange(0, len + 2);//正确分析一条数据，从缓存中移除数据。  
                    }
                    else
                    {
                        //这里是很重要的，如果数据开始不是头，则删除数据  
                        commundata.RemoveAt(0);
                    }
                }
                //分析数据  
                if (data_1_catched)
                {
                    //我们的数据都是定好格式的，所以当我们找到分析出的数据1，就知道固定位置一定是这些数据，我们只要显示就可以了 
                    this.Invoke((EventHandler)(delegate {
                        if (binary_data_1[3] == 0x00)
                        {
                            l_M_MainType.Text = "机型信息：" + binary_data_1[4].ToString("X2");
                            l_M_SoftwareVer.Text = "软件版本：" + binary_data_1[5].ToString("X2");
                            l_BLDC_Version.Text = "电机版本：" + binary_data_1[7].ToString("X2");
                            l_W_Load1.Text = "负载状态1：" + binary_data_1[8].ToString("X2");
                            l_W_Load2.Text = "负载状态2：" + binary_data_1[9].ToString("X2");
                            l_W_Load3.Text = "负载状态3：" + binary_data_1[10].ToString("X2");
                            l_WaterPulse.Text = "水量：" + ((binary_data_1[12] << 8) + binary_data_1[13]).ToString();
                            l_Temperature.Text = "水温：" + binary_data_1[14].ToString();
                            l_AverageTurb.Text = "浊度：" + binary_data_1[15].ToString();
                            l_BLDC_RealitySpeed.Text = "电机转速：" + ((binary_data_1[19] << 8) + binary_data_1[20]).ToString();
                            l_BLDC_Power.Text = "电机功率：" + binary_data_1[21].ToString();
                            l_BLDC_ERROR.Text = "电机故障：" + binary_data_1[22].ToString("X2");
                            l_DownTime.Text = "剩余时间：" + binary_data_1[24].ToString();
                            l_RunMaxTime.Text = "总时间：" + binary_data_1[25].ToString();
                            l_Stage.Text = "洗涤阶段：" + binary_data_1[26].ToString();
                            l_StepType.Text = "步骤序号：" + binary_data_1[27].ToString();
                            l_State.Text = "机器状态：" + binary_data_1[29].ToString("X2");
                            l_Program.Text = "洗涤程序：" + binary_data_1[30].ToString();
                            l_Third_Data.Text = "机器信号：" + binary_data_1[31].ToString("X2");
                            l_ErrorCode.Text = "故障代码：" + binary_data_1[32].ToString("X2");
                        }
                        else if (binary_data_1[3] == 0x01)
                        {
                            if (binary_data_1[4] == 0x01)
                            {

                            }
                            else
                            {
                                
                            }
                        }
                        else if (binary_data_1[3] == 0x02)
                        {
                            if (binary_data_1[4] == 0x01)
                            {

                            }
                            else
                            {
                                
                            }
                        } 
                    }));


                    for (int i = 0; i < len+2; i++)//原始串口数据输出
                    {
                        this.Invoke((EventHandler)(delegate { textBox_receive.AppendText(binary_data_1[i].ToString("X2")); }));
                    }
                    this.Invoke((EventHandler)(delegate { l_uart_com.Text = textBox_receive.Text; }));
                    this.Invoke((EventHandler)(delegate { textBox_receive.Clear(); }));
                    //string data = binary_data_1[3].ToString("X2") + " " + binary_data_1[4].ToString("X2") + " " +
                    //    binary_data_1[5].ToString("X2") + " " + binary_data_1[6].ToString("X2") + " " +
                    //    binary_data_1[7].ToString("X2");
                    //更新界面  
                    //this.Invoke((EventHandler)(delegate { label10.Text = binary_data_1[1].ToString("X2"); }));

                }
                //如果需要别的协议，只要扩展这个data_n_catched就可以了。往往我们协议多的情况下，还会包含数据编号，给来的数据进行  
                //编号，协议优化后就是： 头+编号+长度+数据+校验  
                //</协议解析>  
                //
                builder.Clear();//清除字符串构造器的内容  
                                //因为要访问ui资源，所以需要使用invoke方式同步ui。  
                //this.Invoke((EventHandler)(delegate
                //{
                //    //判断是否是显示为16禁止  
                //    if (checkBoxHexView.Checked)
                //    {
                //        //依次的拼接出16进制字符串  
                //        foreach (byte b in buf)
                //        {
                //            builder.Append(b.ToString("X2") + " ");
                //        }
                //    }
                //    else
                //    {
                //        //直接按ASCII规则转换成字符串  
                //        builder.Append(Encoding.ASCII.GetString(buf));
                //    }
                //    //追加的形式添加到文本框末端，并滚动到最后。  
                //    this.txGet.AppendText(builder.ToString());
                //    //修改接收计数  
                //    labelGetCount.Text = "Get:" + received_count.ToString();
                //}));
            }
            finally
            {
                Listening = false;//我用完了，ui可以关闭串口了。  
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox_uart.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            //textBox_receive.Text = "";  //清空接收文本框
            //textBox_send.Text = "";     //清空发送文本框
            //receive_count = 0;          //接收计数清零
            //send_count = 0;             //发送计数
            //label7.Text = "Rx:" + receive_count.ToString() + "Bytes";   //刷新界面
            //label8.Text = "Tx:" + send_count.ToString() + "Bytes";      //刷新界面
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //定时时间到
            // button2_Click(button2, new EventArgs());    //调用发送按钮回调函数
        }
        private void button4_Click(object sender, EventArgs e)
        {
            byte[] temp = new byte[1];
            try
            {
                //首先判断串口是否开启
                if (serialPort1.IsOpen)
                {
                    int num = 0;   //获取本次发送字节数
                    //串口处于开启状态，将发送区文本发送

                    //判断发送模式
                    //以HEX模式发送
                    //首先需要用正则表达式将用户输入字符中的十六进制字符匹配出来
                    string buf = "17010404";
                    string pattern = @"\s";
                    string replacement = "";
                    Regex rgx = new Regex(pattern);
                    string send_data = rgx.Replace(buf, replacement);

                    //不发送新行
                    num = (send_data.Length - send_data.Length % 2) / 2;
                    for (int i = 0; i < num; i++)
                    {
                        temp[0] = Convert.ToByte(send_data.Substring(i * 2, 2), 16);
                        serialPort1.Write(temp, 0, 1);  //循环发送
                    }
                    //如果用户输入的字符是奇数，则单独处理
                    if (send_data.Length % 2 != 0)
                    {
                        temp[0] = Convert.ToByte(send_data.Substring(textBox_send.Text.Length - 1, 1), 16);
                        serialPort1.Write(temp, 0, 1);
                        num++;
                    }
                    //判断是否需要发送新行                         
                    send_count += num;      //计数变量累加
                    txcnt_label.Text = "Tx:" + send_count.ToString() + "Bytes";   //刷新界面
                }
            }
            catch (Exception ex)
            {
                serialPort1.Close();
                //捕获到异常，创建一个新的对象，之前的不可以再用
                serialPort1 = new System.IO.Ports.SerialPort();
                //刷新COM口选项
                comboBox_uart.Items.Clear();
                comboBox_uart.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                //响铃并显示异常给用户
                System.Media.SystemSounds.Beep.Play();
                open_uart_button.Text = "打开串口";
                open_uart_button.BackColor = Color.ForestGreen;
                MessageBox.Show(ex.Message);
                comboBox_uart.Enabled = true;
            }
            panel_info.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_sheet.AppendText(textBox_model.Text + ","+textBox_para.Text + "," +textBox_time.Text + "," + textBox_bldc.Text + "," + textBox_alt.Text + "," + "\r\n");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.Write(textBox_sheet.Text);
            }
        }

        private void textBox_model_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键 
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数 
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符 
                }
            }
        }

        private void textBox_time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键 
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数 
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符 
                }
            }
        }

        private void textBox_alt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键 
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数 
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符 
                }
            }
        }

        private void textBox_bldc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键 
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数 
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符 
                }
            }
        }

        private void textBox_para_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键 
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数 
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符 
                }
            }
        }
    }
}