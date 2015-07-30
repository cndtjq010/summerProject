using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastChess
{
    public partial class Form1 : Form
    {

        Location1 makeLocation1 = new Location1();
        int radio_x, radio_y;
        int button_x, button_y;
        int panel_x = 233;
        int panel_y = 322;
        public void makeLocation()
        {

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        if (k == 0)
                        {
                            makeLocation1.location_save[i, j, k] = 65 + 56 * (i);
                        }
                        else
                        {
                            makeLocation1.location_save[i, j, k] = 98 + 56 * (j);
                        }
                    }
                }
            }

        }
        RadioButton[] radios = new RadioButton[36];
        Button[] N = new Button[16];
        Button[] U = new Button[16];
        public Form1()
        {
            string a;
            InitializeComponent();
            makeLocation();
            U[0] = Pawn_U1;
            U[1] = Pawn_U2;
            U[2] = Pawn_U3;
            U[3] = Pawn_U4;
            U[4] = Pawn_U5;
            U[5] = Pawn_U6;
            U[6] = Pawn_U7;
            U[7] = Pawn_U8;
            U[8] = Roock_U1;
            U[9] = Roock_U2;
            U[10] = Bishop_U1;
            U[11] = Bishop_U2;
            U[12] = Knight_U1;
            U[13] = Knight_U2;
            U[14] = King_U;
            U[15] = Queen_U;
            N[0] = Pawn_N1;
            N[1] = Pawn_N2;
            N[2] = Pawn_N3;
            N[3] = Pawn_N4;
            N[4] = Pawn_N5;
            N[5] = Pawn_N6;
            N[6] = Pawn_N7;
            N[7] = Pawn_N8;
            N[8] = Roock_N1;
            N[9] = Roock_N2;
            N[10] = Bishop_N1;
            N[11] = Bishop_N2;
            N[12] = Knight_N1;
            N[13] = Knight_N2;
            N[14] = King_N;
            N[15] = Queen_N;
            radios[0] = radio20;
            radios[1] = radio2;
            radios[2] = radio3;
            radios[3] = radio4;
            radios[4] = radio5;
            radios[5] = radio6;
            radios[6] = radio7;
            radios[7] = radio8;
            radios[8] = radio9;
            radios[9] = radio10;
            radios[10] = radio11;
            radios[11] = radio12;
            radios[12] = radio13;
            radios[13] = radio14;
            radios[14] = radio15;
            radios[15] = radio16;
            radios[16] = radio17;
            radios[17] = radio18;
            radios[18] = radio19;
            radios[19] = radio20;
            radios[20] = radio21;
            radios[21] = radio22;
            radios[22] = radio23;
            radios[23] = radio24;
            radios[24] = radio25;
            radios[25] = radio26;
            radios[26] = radio27;
            radios[27] = radio28;
            radios[28] = radio29;
            radios[29] = radio30;
            radios[30] = radio31;
            radios[31] = radio32;
            radios[32] = radio33;
            radios[33] = radio34;
            radios[34] = radio35;
            radios[35] = radio36;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }


        //취소버튼
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                radios[i].Visible = false;
                radios[i].Checked = false;
            }
            for (int i = 0; i < 16; i++)
            {
                U[i].Visible = true;
                N[i].Visible = true;
                U[i].Enabled = true;
                N[i].Enabled = true;
            }
        }
        //OK버튼
        public void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 36; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (radios[i].Checked == true && U[j].Enabled == false)
                    {
                        button_x = radios[i].Location.X;
                        button_y = radios[i].Location.Y;
                        button_x -= 16;
                        button_y -= 16;
                        U[j].Location = new Point(button_x, button_y);
                        radio20.Visible = false;
                        radio2.Visible = false;
                        button_x = 0;
                        button_y = 0;
                    }
                }
            }
            //Blocker 위치만들기
            for (int i = 0; i < 36; i++)
                if (radios[i].Checked == true)
                {
                    panel_x = panel1.Location.X;
                    panel_y = panel1.Location.Y;
                    Random r = new Random();
                    int number = r.Next(0, 8);
                    panel_x = 65 + 56 * number;
                    System.Threading.Thread.Sleep(100);
                    panel1.Location = new Point(panel_x, panel_y);
                    break;
                }
            for (int i = 0; i < 16; i++)
            {
                if (panel1.Location == U[i].Location)
                {
                    U[i].Visible = false;
                    U[i].Enabled = false;
                }
                else
                {
                    U[i].Visible = true;
                    U[i].Enabled = true;
                }
            }
            //폰이잡는방식
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (U[j].Location == N[i].Location)
                    {
                        N[i].Location = new Point(-100, -100);
                    }
                    N[i].Visible = true;
                }
            }
            button2.PerformClick();
        }


        private void label15_Click(object sender, EventArgs e)
        {
        }
        //Load 
        private void Form1_Load(object sender, EventArgs e)
        {
            //프로그램 시작 메세지
            MessageBox.Show("Welcome to Fast Chess!");
        }
        private void w(object sender, MouseEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        //Pawn_U4
        public void button1_Click_2(object sender, EventArgs e)
        {
            Location1 location = new Location1();
            //폰1이 움직이는 방식
            for (int i = 0; i < 16; i++)
            {
                U[i].Enabled = true;
            }
            button2.PerformClick();
            Pawn_U4.Enabled = false;
            radio20.Location = Pawn_U4.Location;
            radio_x = radio20.Location.X;
            radio_y = radio20.Location.Y;
            button_y = Pawn_U4.Location.Y;
            radio_x += 16;
            radio_y -= 40;
            radio20.Location = new Point(radio_x, radio_y);
            button_x = Pawn_U4.Location.X;
            button_y = Pawn_U4.Location.Y;
            //대각선에 말이 있을 경우 잡기 or 직진
            for (int i = 0; i < 16; i++)
            {
                if (N[i].Location == new Point(button_x - 56, button_y - 56))
                {
                    N[i].Visible = false;
                    for (int j = 10; j < 36; j++)
                    {
                        radios[j].Visible = true;
                        radios[j].Location = new Point(N[i].Location.X + 16, N[i].Location.Y + 16);
                    }
                }
                else if (N[i].Location == new Point(button_x + 56, button_y - 56))
                {
                    N[i].Visible = false;
                    for (int j = 0; j < 10; j++)
                    {
                        radios[j].Visible = true;
                        radios[j].Location = new Point(N[i].Location.X + 16, N[i].Location.Y + 16);
                    }
                }
            }

            //끝에가면 못움직이게
            if (Pawn_U4.Location.Y == 98)
            {
                radio20.Visible = false;
                radio20.Checked = false;
                radio2.Visible = false;
                radio2.Checked = false;
            }
            else
            {
                radio20.Visible = true;
            }
            radio_x = 0;
            radio_y = 0;
            // 처음에 2칸 갈수 있게 
            if (button_y == 490)
            {
                radio2.Location = Pawn_U4.Location;
                radio_x = radio2.Location.X;
                radio_y = radio2.Location.Y;
                radio_x += 16;
                radio_y -= 96;
                radio2.Location = new Point(radio_x, radio_y);
                radio2.Visible = true;
                radio_x = 0;
                radio_y = 0;
            }
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void button3_Click_1(object sender, EventArgs e)
        {
            //폰1이 움직이는 방식
            for (int i = 0; i < 16; i++)
            {
                U[i].Enabled = true;
            }
            Pawn_U5.Enabled = false;
            radio20.Location = Pawn_U5.Location;
            radio_x = radio20.Location.X;
            radio_y = radio20.Location.Y;
            button_y = Pawn_U5.Location.Y;
            radio_x += 16;
            radio_y -= 40;
            radio20.Location = new Point(radio_x, radio_y);
            button_x = Pawn_U5.Location.X;
            button_y = Pawn_U5.Location.Y;
            //대각선에 말이 있을 경우 잡기 or 직진
            for (int i = 0; i < 16; i++)
            {
                if (N[i].Location == new Point(button_x - 56, button_y - 56))
                {
                    N[i].Visible = false;
                    for (int j = 10; j < 36; j++)
                    {
                        radios[j].Visible = true;
                        radios[j].Location = new Point(N[i].Location.X + 16, N[i].Location.Y + 16);
                    }
                }
                else if (N[i].Location == new Point(button_x + 56, button_y - 56))
                {
                    N[i].Visible = false;
                    for (int j = 0; j < 10; j++)
                    {
                        radios[j].Visible = true;
                        radios[j].Location = new Point(N[i].Location.X + 16, N[i].Location.Y + 16);
                    }
                }
            }

            //끝에가면 못움직이게
            if (Pawn_U5.Location.Y == 98)
            {
                radio20.Visible = false;
                radio20.Checked = false;
                radio2.Visible = false;
                radio2.Checked = false;
            }
            else
            {
                radio20.Visible = true;
            }
            radio_x = 0;
            radio_y = 0;
            // 처음에 2칸 갈수 있게 
            if (button_y == 490)
            {
                radio2.Location = Pawn_U5.Location;
                radio_x = radio2.Location.X;
                radio_y = radio2.Location.Y;
                radio_x += 16;
                radio_y -= 96;
                radio2.Location = new Point(radio_x, radio_y);
                radio2.Visible = true;
                radio_x = 0;
                radio_y = 0;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        public void radio20_CheckedChanged(object sender, EventArgs e)
        {
            radio_x = radio20.Location.X;
            radio_y = radio20.Location.Y;
            radio_x += 16;
            radio_y += 16;
            if (panel_x == radio_x && panel_y == radio_y)
            {
                //Blocker와 Pawn의 움직일 수 있는 위치가 같으면 Pawn 비활성화
                radio20.Visible = false;
                radio20.Checked = false;
                Pawn_U4.Enabled = true;
            }
        }

        public void pawn_G_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Fast Chess..!");
        }
        private void Pawn_U1_Click(object sender, EventArgs e)
        {

            //폰1이 움직이는 방식
            for (int i = 0; i < 16; i++)
            {
                U[i].Enabled = true;
            }
            button2.PerformClick();
            Pawn_U1.Enabled = false;
            radio20.Location = Pawn_U1.Location;
            radio_x = radio20.Location.X;
            radio_y = radio20.Location.Y;
            button_y = Pawn_U1.Location.Y;
            radio_x += 16;
            radio_y -= 40;
            radio20.Location = new Point(radio_x, radio_y);
            radio20.Visible = true;
            button_x = Pawn_U1.Location.X;
            button_y = Pawn_U1.Location.Y;
            //대각선에 말이 있을 경우 잡기 or 직진
            for (int i = 0; i < 16; i++)
            {
                if (N[i].Location == new Point(button_x - 56, button_y - 56))
                {
                    N[i].Visible = false;
                    for (int j = 10; j < 36; j++)
                    {
                        if (radios[j].Visible == false)
                        {
                            radios[j].Visible = true;
                            radios[j].Location = new Point(N[i].Location.X + 16, N[i].Location.Y + 16);
                        }
                    }
                }
                else if (N[i].Location == new Point(button_x + 56, button_y - 56))
                {
                    N[i].Visible = false;
                    for (int j = 0; j < 10; j++)
                    {
                        if (radios[j].Visible == false)
                        {
                            radios[j].Visible = true;
                            radios[j].Location = new Point(N[i].Location.X + 16, N[i].Location.Y + 16);
                        }
                    }
                }
            }

            //끝에가면 못움직이게
            if (Pawn_U1.Location.Y == 98)
            {
                radio20.Visible = false;
                radio20.Checked = false;
                radio2.Visible = false;
                radio2.Checked = false;
            }
            else
            {
                radio20.Visible = true;
            }
            radio_x = 0;
            radio_y = 0;
            // 처음에 2칸 갈수 있게 
            if (button_y == 490)
            {
                radio2.Location = Pawn_U1.Location;
                radio_x = radio2.Location.X;
                radio_y = radio2.Location.Y;
                radio_x += 16;
                radio_y -= 96;
                radio2.Location = new Point(radio_x, radio_y);
                radio2.Visible = true;
                radio_x = 0;
                radio_y = 0;
            }
        }
        private void Pawn_U2_Click(object sender, EventArgs e)
        {

            Location1 location = new Location1();
            //폰1이 움직이는 방식
            for (int i = 0; i < 16; i++)
            {
                U[i].Enabled = true;
            }
            button2.PerformClick();
            Pawn_U2.Enabled = false;
            radio20.Location = Pawn_U2.Location;
            radio_x = radio20.Location.X;
            radio_y = radio20.Location.Y;
            button_y = Pawn_U2.Location.Y;
            radio_x += 16;
            radio_y -= 40;
            radio20.Location = new Point(radio_x, radio_y);
            radio20.Visible = true;
            button_x = Pawn_U2.Location.X;
            button_y = Pawn_U2.Location.Y;
            //대각선에 말이 있을 경우 잡기 or 직진
            for (int i = 0; i < 16; i++)
            {
                if (N[i].Location == new Point(button_x - 56, button_y - 56))
                {
                    N[i].Visible = false;
                    for (int j = 10; j < 20; j++)
                    {
                        if (radios[j].Visible == false)
                        {
                            radios[j].Visible = true;
                            radios[j].Location = new Point(N[i].Location.X + 16, N[i].Location.Y + 16);
                        }
                    }
                }
                else if (N[i].Location == new Point(button_x + 56, button_y - 56))
                {
                    N[i].Visible = false;
                    for (int j = 0; j < 10; j++)
                    {
                        if (radios[j].Visible == false)
                        {
                            radios[j].Visible = true;
                            radios[j].Location = new Point(N[i].Location.X + 16, N[i].Location.Y + 16);
                        }
                    }
                }
            }
            //끝에가면 못움직이게
            if (Pawn_U2.Location.Y == 98)
            {
                radio20.Visible = false;
                radio20.Checked = false;
                radio2.Visible = false;
                radio2.Checked = false;
            }
            else
            {
                radio20.Visible = true;
            }
            radio_x = 0;
            radio_y = 0;
            // 처음에 2칸 갈수 있게 
            if (button_y == 490)
            {
                radio2.Location = Pawn_U2.Location;
                radio_x = radio2.Location.X;
                radio_y = radio2.Location.Y;
                radio_x += 16;
                radio_y -= 96;
                radio2.Location = new Point(radio_x, radio_y);
                radio2.Visible = true;
                radio_x = 0;
                radio_y = 0;
            }
        }
        private void Pawn_U3_Click(object sender, EventArgs e)
        {
            //폰1이 움직이는 방식
            for (int i = 0; i < 16; i++)
            {
                U[i].Enabled = true;
            }
            button2.PerformClick();
            Pawn_U3.Enabled = false;
            radio20.Location = Pawn_U3.Location;
            radio_x = radio20.Location.X;
            radio_y = radio20.Location.Y;
            button_y = Pawn_U3.Location.Y;
            radio_x += 16;
            radio_y -= 40;
            radio20.Location = new Point(radio_x, radio_y);
            radio20.Visible = true;
            button_x = Pawn_U3.Location.X;
            button_y = Pawn_U3.Location.Y;
            //대각선에 말이 있을 경우 잡기 or 직진
            for (int i = 0; i < 16; i++)
            {
                if (N[i].Location == new Point(button_x - 56, button_y - 56))
                {
                    N[i].Visible = false;
                    for (int j = 10; j < 20; j++)
                    {
                        if (radios[j].Visible == false)
                        {
                            radios[j].Visible = true;
                            radios[j].Location = new Point(N[i].Location.X + 16, N[i].Location.Y + 16);
                        }
                    }
                }
                else if (N[i].Location == new Point(button_x + 56, button_y - 56))
                {
                    N[i].Visible = false;
                    for (int j = 0; j < 10; j++)
                    {
                        if (radios[j].Visible == false)
                        {
                            radios[j].Visible = true;
                            radios[j].Location = new Point(N[i].Location.X + 16, N[i].Location.Y + 16);
                        }
                    }
                }
            }

            //끝에가면 못움직이게
            if (Pawn_U3.Location.Y == 98)
            {
                radio20.Visible = false;
                radio20.Checked = false;
                radio2.Visible = false;
                radio2.Checked = false;
            }
            else
            {
                radio20.Visible = true;
            }
            radio_x = 0;
            radio_y = 0;
            // 처음에 2칸 갈수 있게 
            if (button_y == 490)
            {
                radio2.Location = Pawn_U3.Location;
                radio_x = radio2.Location.X;
                radio_y = radio2.Location.Y;
                radio_x += 16;
                radio_y -= 96;
                radio2.Location = new Point(radio_x, radio_y);
                radio2.Visible = true;
                radio_x = 0;
                radio_y = 0;
            }
        }
        private void Pawn_U4_Click(object sender, EventArgs e)
        {
            Location1 location = new Location1();
            //폰1이 움직이는 방식
            for (int i = 0; i < 16; i++)
            {
                U[i].Enabled = true;
            }
            button2.PerformClick();
            Pawn_U4.Enabled = false;
            radio20.Location = Pawn_U4.Location;
            radio_x = radio20.Location.X;
            radio_y = radio20.Location.Y;
            button_y = Pawn_U4.Location.Y;
            radio_x += 16;
            radio_y -= 40;
            radio20.Location = new Point(radio_x, radio_y);
            radio20.Visible = true;
            button_x = Pawn_U4.Location.X;
            button_y = Pawn_U4.Location.Y;
            //대각선에 말이 있을 경우 잡기 or 직진
            for (int i = 0; i < 16; i++)
            {
                if (N[i].Location == new Point(button_x - 56, button_y - 56))
                {
                    N[i].Visible = false;
                    for (int j = 10; j < 20; j++)
                    {
                        if (radios[j].Visible == false)
                        {
                            radios[j].Visible = true;
                            radios[j].Location = new Point(N[i].Location.X + 16, N[i].Location.Y + 16);
                        }
                    }
                }
                else if (N[i].Location == new Point(button_x + 56, button_y - 56))
                {
                    N[i].Visible = false;
                    for (int j = 0; j < 10; j++)
                    {
                        if (radios[j].Visible == false)
                        {
                            radios[j].Visible = true;
                            radios[j].Location = new Point(N[i].Location.X + 16, N[i].Location.Y + 16);
                        }
                    }
                }
            }

            //끝에가면 못움직이게
            if (Pawn_U4.Location.Y == 98)
            {
                radio20.Visible = false;
                radio20.Checked = false;
                radio2.Visible = false;
                radio2.Checked = false;
            }
            else
            {
                radio20.Visible = true;
            }
            radio_x = 0;
            radio_y = 0;
            // 처음에 2칸 갈수 있게 
            if (button_y == 490)
            {
                radio2.Location = Pawn_U4.Location;
                radio_x = radio2.Location.X;
                radio_y = radio2.Location.Y;
                radio_x += 16;
                radio_y -= 96;
                radio2.Location = new Point(radio_x, radio_y);
                radio2.Visible = true;
                radio_x = 0;
                radio_y = 0;
            }
        }
        private void Pawn_U6_Click(object sender, EventArgs e)
        {

            //폰1이 움직이는 방식
            for (int i = 0; i < 16; i++)
            {
                U[i].Enabled = true;
            }
            button2.PerformClick();
            Pawn_U6.Enabled = false;
            radio20.Location = Pawn_U6.Location;
            radio_x = radio20.Location.X;
            radio_y = radio20.Location.Y;
            button_y = Pawn_U6.Location.Y;
            radio_x += 16;
            radio_y -= 40;
            radio20.Location = new Point(radio_x, radio_y);
            radio20.Visible = true;
            button_x = Pawn_U6.Location.X;
            button_y = Pawn_U6.Location.Y;
            //대각선에 말이 있을 경우 잡기 or 직진
            for (int i = 0; i < 16; i++)
            {
                if (N[i].Location == new Point(button_x - 56, button_y - 56))
                {
                    N[i].Visible = false;
                    for (int j = 10; j < 20; j++)
                    {
                        if (radios[j].Visible == false)
                        {
                            radios[j].Visible = true;
                            radios[j].Location = new Point(N[i].Location.X + 16, N[i].Location.Y + 16);
                        }
                    }
                }
                else if (N[i].Location == new Point(button_x + 56, button_y - 56))
                {
                    N[i].Visible = false;
                    for (int j = 0; j < 10; j++)
                    {
                        if (radios[j].Visible == false)
                        {
                            radios[j].Visible = true;
                            radios[j].Location = new Point(N[i].Location.X + 16, N[i].Location.Y + 16);
                        }
                    }
                }
            }

            //끝에가면 못움직이게
            if (Pawn_U6.Location.Y == 98)
            {
                radio20.Visible = false;
                radio20.Checked = false;
                radio2.Visible = false;
                radio2.Checked = false;
            }
            else
            {
                radio20.Visible = true;
            }
            radio_x = 0;
            radio_y = 0;
            // 처음에 2칸 갈수 있게 
            if (button_y == 490)
            {
                radio2.Location = Pawn_U6.Location;
                radio_x = radio2.Location.X;
                radio_y = radio2.Location.Y;
                radio_x += 16;
                radio_y -= 96;
                radio2.Location = new Point(radio_x, radio_y);
                radio2.Visible = true;
                radio_x = 0;
                radio_y = 0;
            }
        }
        private void Pawn_U7_Click(object sender, EventArgs e)
        {
            Location1 location = new Location1();
            //폰1이 움직이는 방식
            for (int i = 0; i < 16; i++)
            {
                U[i].Enabled = true;
                button2.PerformClick();
            }
            Pawn_U7.Enabled = false;
            radio20.Location = Pawn_U7.Location;
            radio_x = radio20.Location.X;
            radio_y = radio20.Location.Y;
            button_y = Pawn_U4.Location.Y;
            radio_x += 16;
            radio_y -= 40;
            radio20.Location = new Point(radio_x, radio_y);
            radio20.Visible = true;
            button_x = Pawn_U7.Location.X;
            button_y = Pawn_U7.Location.Y;
            //대각선에 말이 있을 경우 잡기 or 직진
            for (int i = 0; i < 16; i++)
            {
                if (N[i].Location == new Point(button_x - 56, button_y - 56))
                {
                    N[i].Visible = false;
                    for (int j = 10; j < 20; j++)
                    {
                        if (radios[j].Visible == false)
                        {
                            radios[j].Visible = true;
                            radios[j].Location = new Point(N[i].Location.X + 16, N[i].Location.Y + 16);
                        }
                    }
                }
                else if (N[i].Location == new Point(button_x + 56, button_y - 56))
                {
                    N[i].Visible = false;
                    for (int j = 0; j < 10; j++)
                    {
                        if (radios[j].Visible == false)
                        {
                            radios[j].Visible = true;
                            radios[j].Location = new Point(N[i].Location.X + 16, N[i].Location.Y + 16);
                        }
                    }
                }
            }

            //끝에가면 못움직이게
            if (Pawn_U7.Location.Y == 98)
            {
                radio20.Visible = false;
                radio20.Checked = false;
                radio2.Visible = false;
                radio2.Checked = false;
            }
            else
            {
                radio20.Visible = true;
            }
            radio_x = 0;
            radio_y = 0;
            // 처음에 2칸 갈수 있게 
            if (button_y == 490)
            {
                radio2.Location = Pawn_U7.Location;
                radio_x = radio2.Location.X;
                radio_y = radio2.Location.Y;
                radio_x += 16;
                radio_y -= 96;
                radio2.Location = new Point(radio_x, radio_y);
                radio2.Visible = true;
                radio_x = 0;
                radio_y = 0;
            }
        }
        private void Pawn_U8_Click(object sender, EventArgs e)
        {
            Location1 location = new Location1();
            //폰1이 움직이는 방식
            for (int i = 0; i < 16; i++)
            {
                U[i].Enabled = true;
                button2.PerformClick();
            }
            Pawn_U8.Enabled = false;
            radio20.Location = Pawn_U8.Location;
            radio_x = radio20.Location.X;
            radio_y = radio20.Location.Y;
            button_y = Pawn_U8.Location.Y;
            radio_x += 16;
            radio_y -= 40;
            radio20.Location = new Point(radio_x, radio_y);
            radio20.Visible = true;
            button_x = Pawn_U8.Location.X;
            button_y = Pawn_U8.Location.Y;
            //대각선에 말이 있을 경우 잡기 or 직진
            for (int i = 0; i < 16; i++)
            {
                if (N[i].Location == new Point(button_x - 56, button_y - 56))
                {
                    N[i].Visible = false;
                    for (int j = 10; j < 20; j++)
                    {
                        if (radios[j].Visible == false)
                        {
                            radios[j].Visible = true;
                            radios[j].Location = new Point(N[i].Location.X + 16, N[i].Location.Y + 16);
                        }
                    }
                }
                else if (N[i].Location == new Point(button_x + 56, button_y - 56))
                {
                    N[i].Visible = false;
                    for (int j = 0; j < 10; j++)
                    {
                        if (radios[j].Visible == false)
                        {
                            radios[j].Visible = true;
                            radios[j].Location = new Point(N[i].Location.X + 16, N[i].Location.Y + 16);
                        }
                    }
                }
            }

            //끝에가면 못움직이게
            if (Pawn_U8.Location.Y == 98)
            {
                radio20.Visible = false;
                radio20.Checked = false;
                radio2.Visible = false;
                radio2.Checked = false;
            }
            else
            {
                radio20.Visible = true;
            }
            radio_x = 0;
            radio_y = 0;
            // 처음에 2칸 갈수 있게 
            if (button_y == 490)
            {
                radio2.Location = Pawn_U8.Location;
                radio_x = radio2.Location.X;
                radio_y = radio2.Location.Y;
                radio_x += 16;
                radio_y -= 96;
                radio2.Location = new Point(radio_x, radio_y);
                radio2.Visible = true;
                radio_x = 0;
                radio_y = 0;
            }
        }
        private void Pawn_U5_Click(object sender, EventArgs e)
        {
            //폰1이 움직이는 방식
            for (int i = 0; i < 16; i++)
            {
                U[i].Enabled = true;
            }
            button2.PerformClick();
            Pawn_U5.Enabled = false;
            radio20.Location = Pawn_U5.Location;
            radio_x = radio20.Location.X;
            radio_y = radio20.Location.Y;
            button_y = Pawn_U5.Location.Y;
            radio_x += 16;
            radio_y -= 40;
            radio20.Location = new Point(radio_x, radio_y);
            radio20.Visible = true;
            button_x = Pawn_U5.Location.X;
            button_y = Pawn_U5.Location.Y;
            //대각선에 말이 있을 경우 잡기 or 직진
            for (int i = 0; i < 16; i++)
            {
                if (N[i].Location == new Point(button_x - 56, button_y - 56))
                {
                    N[i].Visible = false;
                    for (int j = 10; j < 20; j++)
                    {
                        if (radios[j].Visible == false)
                        {
                            radios[j].Visible = true;
                            radios[j].Location = new Point(N[i].Location.X + 16, N[i].Location.Y + 16);
                        }
                    }
                }
                else if (N[i].Location == new Point(button_x + 56, button_y - 56))
                {
                    N[i].Visible = false;
                    for (int j = 0; j < 10; j++)
                    {
                        if (radios[j].Visible == false)
                        {
                            radios[j].Visible = true;
                            radios[j].Location = new Point(N[i].Location.X + 16, N[i].Location.Y + 16);
                        }
                    }
                }
            }

            //끝에가면 못움직이게
            if (Pawn_U5.Location.Y == 98)
            {
                radio20.Visible = false;
                radio20.Checked = false;
                radio2.Visible = false;
                radio2.Checked = false;
            }
            else
            {
                radio20.Visible = true;
            }
            radio_x = 0;
            radio_y = 0;
            // 처음에 2칸 갈수 있게 
            if (button_y == 490)
            {
                radio2.Location = Pawn_U5.Location;
                radio_x = radio2.Location.X;
                radio_y = radio2.Location.Y;
                radio_x += 16;
                radio_y -= 96;
                radio2.Location = new Point(radio_x, radio_y);
                radio2.Visible = true;
                radio_x = 0;
                radio_y = 0;
            }
        }

        private void Roock_U1_Click(object sender, EventArgs e)
        {
            int stopcount = 0;
            int button_x2, button_y2;
            for (int i = 0; i < 16; i++)
            {
                U[i].Enabled = true;
            }
            button2.PerformClick();
            Roock_U1.Enabled = false;
            button_x = Roock_U1.Location.X;
            button_x2 = Roock_U1.Location.X;
            button_y = Roock_U1.Location.Y;
            button_y2 = Roock_U1.Location.Y;
            for (int i = 0; i < 9; i++)
            {

                button_y -= 56;
                radios[i].Location = new Point(button_x + 16, button_y + 16);
                radios[i].Visible = true;
                if (radios[i].Location.Y < 80)
                {
                    radios[i].Visible = false;
                    break;
                }
                for (int j = 0; j < 16; j++)
                {
                    if (N[j].Location == new Point(radios[i].Location.X - 16, radios[i].Location.Y - 16))
                    {
                        N[j].Visible = false;
                        stopcount = 1;
                        break;
                    }
                    if (U[j].Location == new Point(radios[i].Location.X - 16, radios[i].Location.Y - 16))
                    {
                        stopcount = 1;
                        break;
                    }
                    if (panel1.Location == new Point(radios[i].Location.X - 16, radios[i].Location.Y - 16))
                    {
                        stopcount = 1;
                        break;
                    }
                }
                if (stopcount == 1)
                {
                    stopcount = 0;
                    break;
                }
            }
            //Y축 위로
            for (int j = 9; j < 18; j++)
            {
                button_y2 += 56;
                radios[j].Location = new Point(button_x2 + 16, button_y2 + 16);
                radios[j].Visible = true;
                if (radios[j].Location.Y > 565)
                {
                    radios[j].Visible = false;
                    break;
                }
                for (int i = 0; i < 16; i++)
                {
                    if (N[i].Location == new Point(radios[j].Location.X - 16, radios[j].Location.Y - 16))
                    {
                        N[j].Visible = false;
                        stopcount = 1;
                        break;
                    }
                    if (U[i].Location == new Point(radios[j].Location.X - 16, radios[j].Location.Y - 16))
                    {
                        stopcount = 1;
                        break;
                    }
                    if (panel1.Location == new Point(radios[j].Location.X - 16, radios[j].Location.Y - 16))
                    {
                        stopcount = 1;
                        break;
                    }
                }
                if (stopcount == 1)
                {
                    stopcount = 0;
                    break;
                }
            }
            //Y축위로
            //합쳐서 Y축이동
            //x축이동
            for (int i = 18; i < 26; i++)
            {

                button_x -= 56;
                radios[i].Location = new Point(button_x + 16, button_y + 16);
                radios[i].Visible = true;
                if (radios[i].Location.X < 45)
                {
                    radios[i].Visible = false;
                    break;
                }
                for (int j = 0; j < 16; j++)
                {
                    if (N[j].Location == new Point(radios[i].Location.X - 16, radios[i].Location.Y - 16))
                    {
                        N[j].Visible = false;
                        stopcount = 1;
                        break;
                    }
                    if (U[j].Location == new Point(radios[i].Location.X - 16, radios[i].Location.Y - 16))
                    {
                        stopcount = 1;
                        break;
                    }
                    if (panel1.Location == new Point(radios[i].Location.X - 16, radios[i].Location.Y - 16))
                    {
                        stopcount = 1;
                        break;
                    }
                }
                if (stopcount == 1)
                {
                    stopcount = 0;
                    break;
                }
            }
            //X축 위로
            for (int j = 26; j < 32; j++)
            {
                button_x2 += 56;
                radios[j].Location = new Point(button_x2 + 16, button_y2 + 16);
                radios[j].Visible = true;
                if (radios[j].Location.X > 480)
                {
                    radios[j].Visible = false;
                    break;
                }
                for (int i = 0; i < 16; i++)
                {
                    if (N[i].Location == new Point(radios[j].Location.X - 16, radios[j].Location.Y - 16))
                    {
                        N[j].Visible = false;
                        stopcount = 1;
                        break;
                    }
                    if (U[i].Location == new Point(radios[j].Location.X - 16, radios[j].Location.Y - 16))
                    {
                        stopcount = 1;
                        break;
                    }
                    if (panel1.Location == new Point(radios[j].Location.X - 16, radios[j].Location.Y - 16))
                    {
                        stopcount = 1;
                        break;
                    }
                }
                if (stopcount == 1)
                {
                    stopcount = 0;
                    break;
                }
            }
           
            //x축이동
        }
    }
}