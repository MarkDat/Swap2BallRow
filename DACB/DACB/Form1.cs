using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace DACB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button[] arrButton;
        int[] arr;
        void swapButton(Button left, Button right, int a, int b){
            int num1 = left.Location.X;
            int num2 = right.Location.X;

            int num3 = left.Location.Y+40;
            int num4 = right.Location.Y-40;
            int thread = 5;
            //Dịch lên
            while (left.Location.Y > num4 || right.Location.Y < num3){
                left.Location = new Point(left.Location.X, left.Location.Y-1);
                right.Location = new Point(right.Location.X, right.Location.Y + 1);
                Application.DoEvents();
                Thread.Sleep(thread);
            }
            
            //Dịch ngang
            while(left.Location.X<num2 || right.Location.X>num1){
                left.Location = new Point(left.Location.X + 1, left.Location.Y);
                right.Location = new Point(right.Location.X - 1, right.Location.Y);
                Application.DoEvents();
                Thread.Sleep(thread);
            }

            //Dịch xuống
            while (left.Location.Y < num4+40 || right.Location.Y > num3-40)
            {
                left.Location = new Point(left.Location.X, left.Location.Y + 1);
                right.Location = new Point(right.Location.X, right.Location.Y - 1);
                Application.DoEvents();
                Thread.Sleep(thread);
            }

            Button temp = arrButton[a];
            arrButton[a] = arrButton[b];
            arrButton[b] = temp;

            int tempInt = arr[a];
            arr[a] = arr[b];
            arr[b] = tempInt;

            Thread.Sleep(500);
        }

        void createButton() {
            grbMP.Controls.Clear();
            int numIn;//Tao bien luu so tu textBox

            //Kiem tra nha nhap
            try{
                numIn = int.Parse(txtNhap.Text.Trim());
                if (numIn < 1 || numIn > 5) { MessageBox.Show("Giới hạn diện tích là 5 bi !"); return; }
             }catch (Exception e){
                 {MessageBox.Show("Nhập số đi kìa !"); return;}
            }
            //

            int widthMid = grbMP.Width / 2 -40;
            int height = grbMP.Height / 2 -40;
           
            
            //Tao mang
          
                int numBalls =  numIn* 2 + 1;
                arrButton = new Button[numBalls];
           
           
            
            //Tao nut trong groupBox
          
                int dis = (grbMP.Width / 2) - numIn * 55;
                int disW = -30;
                int leng = arrButton.Length;
                
                for (int i = 0; i < leng; i++)
                {
                    Button btn = new Button();
                    btn.Width = btn.Height = 40;
                    if (i < leng / 2)
                    {
                        btn.BackColor = Color.Red;
                        btn.Location = new Point(dis + disW, height);

                    }
                    else if (i > leng / 2){
                   
                        btn.BackColor = Color.Black;
                        btn.Location = new Point(dis + disW, height);

                    }
                    else{
                        btn.BackColor = Color.White;
                        btn.Location = new Point(dis + disW, height);
                    }
                    grbMP.Controls.Add(btn);
                    arrButton[i] = btn;
                    disW += 56;
                }
            }
        void createArr(){ //Song song với nút
            int numIn;
            try{
                numIn = int.Parse(txtNhap.Text.Trim());
                if (numIn < 1 || numIn > 5) { MessageBox.Show("Giới hạn diện tích là 5 bi !"); return; }
             }catch (Exception e){
                 {MessageBox.Show("Nhập số đi kìa !"); return;}
            }
            arr = new int[numIn * 2 + 1];
            int leng = arr.Length;
            for (int i = 0; i < leng; i++){
                if (i < leng / 2){
                    arr[i] = 1;
                }
                else if (i > leng / 2){
                    arr[i] = 3;
                }
                else
                {
                    arr[i]=2;
                }
            }
        }
        Boolean checkGiamDan() {
            int leng = arr.Length;
            for (int i = 0; i < leng-1; i++)
                if (arr[i] < arr[i + 1]) return false;
            return true;
        }
        int findIndexPoiter(){
            int i = 0;
            while (arr[i] != 2) { i++;}
            return i;
        }

        void testIn()
        {
            int lengArr = arr.Length;
            for (int i = 0; i < lengArr; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        Boolean checkIndexIsBigestR(int index)
        {
             int lengArr = arr.Length;
             for (int i = index; i < lengArr; i++)
                 if (arr[index] < arr[i]) return false;
             return true;
             
        }
        Boolean checkIndexIsSmallL(int index)
        {
            int lengArr = arr.Length;
            for (int i = index; i >=0; i--)
                if (arr[index] > arr[i]) return false;
            return true;

        }
        void moPhong1(){


            int lengArr = arr.Length;
            int poiter = findIndexPoiter();
            bool checkL = true;
            bool checkR = false;
             testIn();
             int step = 0;
             lbStep.Text = step.ToString();
             while(!checkGiamDan()){
                 poiter = findIndexPoiter();
                 if (poiter == 0) { checkL = false; checkR = true; } //Khi o dau mang
                 if (poiter == lengArr - 1) { checkL = true; checkR = false; } //Khi o cuoi mang

                 if (checkL && checkR == false) { //Chay ve trai 
                     for (int i = poiter; i >= 0; i--)
                     {
                         poiter = findIndexPoiter();
                         if (checkIndexIsSmallL(poiter)) { checkL = false; checkR = true; break; };
                         if (poiter == 0) { checkL = false; checkR = true; break; }
                         
                         if (poiter - 2 < 0 && arr[poiter] > arr[poiter-1]) {
                             swapButton(arrButton[poiter - 1], arrButton[poiter], poiter - 1, poiter); step++; 
                             lbStep.Text = step.ToString();
                             checkL = false; checkR = true;
                             break;
                         }
                         else
                         {
                             if (poiter - 2 < 0 && arr[poiter] < arr[poiter - 1]) {
                                 checkL = false; checkR = true;
                                 break;
                             }
                         }
                        
                         
                         
                         if (arr[poiter - 1] == arr[poiter - 2]) { 
                                swapButton(arrButton[poiter-1], arrButton[poiter], poiter-1, poiter);
                                poiter = findIndexPoiter();
                                checkL = false; checkR = true;
                                step++;
                                lbStep.Text = step.ToString();
                                break;
                         }
                         if (arr[poiter] > arr[i])
                         {
                             swapButton(arrButton[i], arrButton[poiter], i, poiter); step++;
                             lbStep.Text = step.ToString();
                         }
                     }
                 }

                 if (checkL == false && checkR){//Chay ve phai
                     for (int i = poiter; i < lengArr; i++)
                     {
                        poiter = findIndexPoiter();
                        if (checkIndexIsBigestR(poiter)) { checkL = true; checkR = false; break; };
                         if (poiter == lengArr - 1) { checkL = true; checkR = false; break; }
                         
                         if (poiter + 2 == lengArr && arr[poiter] < arr[poiter+1])
                         {
                             swapButton(arrButton[poiter], arrButton[poiter+1], poiter, poiter+1); step++;
                             lbStep.Text = step.ToString();
                             checkL = true; checkR = false;
                             break;
                         }
                         else
                         {
                             if (poiter + 2 == lengArr && arr[poiter] > arr[poiter + 1])
                             {
                                 checkL = true; checkR = false;
                                 break;
                             }  
                         }


                         if (arr[poiter + 1] == arr[poiter + 2])
                         {
                             swapButton(arrButton[poiter], arrButton[poiter + 1], poiter, poiter + 1); step++;
                             lbStep.Text = step.ToString();
                             poiter = findIndexPoiter();
                             checkL = true; checkR = false;
                             break;
                         }
                         if (arr[poiter] < arr[i])
                         {
                             swapButton(arrButton[poiter], arrButton[i], poiter, i); step++;
                             lbStep.Text = step.ToString();
                         }
                     }
                        
                 }
             }
             MessageBox.Show("So buoc da thuc hien: " + step);
        }
        private void btnChuyen_Click(object sender, EventArgs e)
        {
            moPhong1();
        }

        private void btnXN_Click(object sender, EventArgs e)
        {
            createArr();
            createButton();
        }

    
    }
}
