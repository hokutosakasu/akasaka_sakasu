﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace akasaka_sakasu
{
    public partial class F_Kaikei : Form
    {
        //初期変数
        //int Int1 = 1,Int2 = 2, Int3 = 3, Int4 = 4, Int5 = 5, Int6 = 6, Int7 = 7, Int8 = 8, Int9 = 9, Int0 = 0, Int00 = 00;
        string StrKekka;
        int IntTxt;
        int Intsum;


        public F_Kaikei()
        {
            InitializeComponent();
        }

        private void F_Kaikei_Load(object sender, EventArgs e)
        {
            //テキストボックス初期値0
            Txt_1.Text = "0";
            //210204-2
        }

        #region ボタン動作

        private void Btn_1_Click(object sender, EventArgs e)
        {
            //テキストボックスに押す前の値+押したボタンの値を加える
            //関数可したい
            //Txt_1.Text = StrKekka + "1";
            // StrKekka = Txt_1.Text;
            Btnkeisan("1");
        }

        private void Btn_2_Click_1(object sender, EventArgs e)
        {
            Btnkeisan("2");
        }

        private void Btn_3_Click_1(object sender, EventArgs e)
        {
            Btnkeisan("3");
        }

        private void Btn_4_Click_1(object sender, EventArgs e)
        {
            Btnkeisan("4");
        }

        private void Btn_5_Click_1(object sender, EventArgs e)
        {
            Btnkeisan("5");
        }

        private void Btn_6_Click_1(object sender, EventArgs e)
        {
            Btnkeisan("6");
        }

        private void Btn_7_Click_1(object sender, EventArgs e)
        {
            Btnkeisan("7");
        }

        private void Btn_8_Click_1(object sender, EventArgs e)
        {
            Btnkeisan("8");
        }

        private void Btn_9_Click_1(object sender, EventArgs e)
        {
            Btnkeisan("9");
        }

        private void Btn_0_Click_1(object sender, EventArgs e)
        {
            //0ならテキストに0を追加しない
            IntTxt = int.Parse(Txt_1.Text);
            if (IntTxt ==0)
            {  }
            else { Btnkeisan("0"); }
        }

        private void Btn_00_Click_1(object sender, EventArgs e)
        {
            //0ならテキストに00を追加しない
            IntTxt = int.Parse(Txt_1.Text);
            if (IntTxt == 0)
            {  }
            else { Btnkeisan("00"); }

        }

        private void Btn_clear_Click_1(object sender, EventArgs e)
        {
            BtnClear();
        }

        private void Btn_Enter_Click(object sender, EventArgs e)
        {
            IntTxt = int.Parse(Txt_1.Text);
            Intsum = Intsum+IntTxt;
            MessageBox.Show($"入力: {IntTxt}", $"入力合計: {Intsum}");
            BtnClear();
        }
        #endregion

        #region 関数

        //関数
        public void Btnkeisan(string strKeisan)
        {
            Txt_1.Text = StrKekka + strKeisan;
            StrKekka = Txt_1.Text;
        }

        public void BtnClear()
        {
            Txt_1.Clear();
            StrKekka = "";
            Txt_1.Text = "0";
        }

        #endregion


    }
}




