﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace FoxManPr
{
    public partial class login : Form
    {
        bool pop = false;

        public static string name = "";
        public static string surn = "";
        public static string type = ""; 
        public static string pass = "";
        public static string post = "";
        public static string clas = "";


        public static string nameForm = "";
        public static string surnForm = "";
        public static string postForm = "";
        public static string passForm = "";
        public static string typeForm = "";
        public static string clasForm = "";
        public static string subidForm= "";
        public static string idForm   = "";
        public static string status   = "";

        const string connect = "SslMode=none;Server=localhost;Database=sgosit;port=3306;Uid=root";
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reg t = new Reg();
            t.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> list =  NetCity.MySelect("SELECT name, surn, type, pass, post, clas, id FROM users");

            /*string[] li = File.ReadAllLines("../../txt/users.txt");
             foreach (string objects in li)
             {
                 string[] word = objects.Split(new string[] { ", " }, StringSplitOptions.None);
                 name = word[0];
                 surn = word[1];
                 type = word[2];
                 pass = word[3];
                 post = word[4];
                 clas = word[5];*/
            for (int i = 0; i < list.Count; i+=7)
            {
                if (t1.Text == list[i+4] && t2.Text == list[i+3] || t1.Text == list[i] && t2.Text == list[i+3])
                {
                    nameForm = list[i];
                    surnForm = list[i+1];
                    postForm = list[i+4];
                    typeForm = list[i+2];
                    clasForm = list[i+5];
                    idForm   = list[i+6];
                    passForm = list[i+3];
                    List<string> list2 = NetCity.MySelect("SELECT idsub FROM teachers WHERE idtag = '" + idForm + "'");

                        if (typeForm == "Учитель")
                        {
                            subidForm = list2[0];
                        }
                    
                    List<string> list3 = NetCity.MySelect("SELECT status FROM admins WHERE tagid = '" + idForm + "'");

                        if (typeForm == "Администратор")
                        {
                            status = list3[0];
                            main.lol = true;
                        }
                    
                }
            }

            
            if (nameForm != "") { MessageBox.Show("ВЫ успешно вошли!", "Программа"); Close();}
            else { MessageBox.Show("Неверный адрес почты или пароль. Или поля пустые. Внимательно посмотрите, не содержат ли поля лишних пробелов или символов. Либо ВЫ не зарегестрированы.", "Программа"); }
            //}
            
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pop == false)
            { pop = true; pictureBox1.Load("../../Pic/eyeopen.png"); t2.PasswordChar = new char(); }
            else if(pop)
            { pop = false; pictureBox1.Load("../../Pic/eyeclosed.png"); t2.PasswordChar = '#'; }
        }
    }
}
