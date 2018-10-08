﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_sys_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }
        void init()
        {
            t1_after_last.Clear();
            t2_service.Clear();
            t3_arriving_new.Clear();
            t4_start_service.Clear();
            t5_end_service.Clear();
            t6_waiting.Clear();
            t7_downtime.Clear();
        for (int i = 0;i< users;i++)
            {
                t1_after_last.Add(0);
                t2_service.Add(0);
                t3_arriving_new.Add(0);
                t4_start_service.Add(0);
                t5_end_service.Add(0);
                t6_waiting.Add(0);
                t7_downtime.Add(0); 
            }
        }
        double seed = 0; int position = 0;
        int users = 1;
        mpoint receipt = new mpoint(), wait = new mpoint();

      
        List<int> t1_after_last = new List<int>();
        List<int> t2_service = new List<int>();

        List<double> t3_arriving_new = new List<double>();
        List<double> t4_start_service = new List<double>();
        List<double> t5_end_service = new List<double>();

        List<int> t6_waiting = new List<int>();
        List<int> t7_downtime = new List<int>();
        private void start_Click(object sender, EventArgs e)
        {
            
            parse();
            autosize();
            init();
            dataGridView1.Rows.Clear();
            Random rand = new Random((int)seed);
            int coutn = users;
            for(int i = 0; i < users;i++, position++)
            {
                set_all(rand);
                
                // Convert.ToString()
                dataGridView1.Rows.Add(position+1, t1_after_last[position], t2_service[position],t3_arriving_new[position],
                   t4_start_service[position],t5_end_service[position],t6_waiting[position],t7_downtime[position] );
            }
        }
        void set_all(Random r)
        {
            t2_service[position] = r.Next(wait.min, wait.min);
            if (position == 0)
            {
                t1_after_last[0] = 0;
                t3_arriving_new[0] = 0;
                t4_start_service[0] = 0;
                t5_end_service[0] = to_doble_minutes(t2_service[0]);
                t6_waiting[0] = t2_service[0];
                t7_downtime[0] = 0;
                return;
            } 
            else
                t1_after_last[position] = r.Next(receipt.min, receipt.max);
           
            set_t3();
            set_t4();
            set_t5();
            set_t6();
            set_t7();
        }
        void set_t3()
        {
            if (position == 0)
                t3_arriving_new[position] = 0.00;
            else
            t3_arriving_new[position] = add_minutes(t3_arriving_new[position - 1], to_doble_minutes( t1_after_last[position]));
        }
        void set_t4()
        {
            if (position == 0)
               t4_start_service[position] = 0.00;
            else
            {
                if (t5_end_service[position - 1] > t3_arriving_new[position])
                    t4_start_service[position] = t5_end_service[position - 1];
                else
                    t4_start_service[position] = t3_arriving_new[position];
            }
        }
        void set_t5()
        {
            t5_end_service[position] = t4_start_service[position] + to_doble_minutes(t2_service[position]); 
        }
        void set_t6()
        {
            t6_waiting[position] = to_int_minutes(t4_start_service[position] -   t3_arriving_new[position]); 
        }
        void set_t7()
        {
            if (position == 0 || t3_arriving_new[position] < t5_end_service[position - 1])
            {
                t7_downtime[position] = 0;
            }
            else
                t7_downtime[position] = to_int_minutes(t3_arriving_new[position] - t5_end_service[position - 1]);
        }
        void parse()
        {
            position = 0;
            int myInt;
            bool isNumerical;
            if (isNumerical = int.TryParse(randbox.Text, out myInt)) //
                seed = Convert.ToDouble(randbox.Text);
            else
                seed = 0;
            if (isNumerical = int.TryParse(tUSERS.Text, out myInt)) //
                users = Convert.ToInt32(tUSERS.Text);
            else
                users = 20;

            if (isNumerical = int.TryParse(tRECEIPT_max.Text, out myInt)) //
                receipt.max = Convert.ToInt32(tRECEIPT_max.Text);
            else
                receipt.max = 29;

            if (isNumerical = int.TryParse(tRECEIPT_min.Text, out myInt)) //
                receipt.min = Convert.ToInt32(tRECEIPT_min.Text);
            else
                receipt.min = 1;

            if (isNumerical = int.TryParse(tWAIT_max.Text, out myInt)) //
                wait.max = Convert.ToInt32(tWAIT_max.Text);
            else
                wait.max = 1;
            if (isNumerical = int.TryParse(tWAIT_min.Text, out myInt)) //
                wait.min = Convert.ToInt32(tWAIT_min.Text);
            else
                wait.min = 1;

        }
        void autosize()
        {
            int k = users;
            if (users > 20)
                k = 20;

            this.Height = 161 + k * 22;
            dataGridView1.Height = 40 + k * 22;
           
            
        }
        double to_doble_minutes(int minutes) // from int to double
        {
            int hours = minutes / 60;
            double dminut = (double)(minutes - hours * 60)/100;
            double ret = hours + dminut;
            return ret;
        }
        double add_minutes(double toit, double addit)
        { 
            double res = 0;
            double res1 = toit - Math.Truncate(toit);
            double res2 = addit - Math.Truncate(addit);
            if (res1 + res2 >= 0.6)
                res = toit + addit + 0.4;
            else
                res = toit + addit;
            return res;
        }
        int to_int_minutes(double dminutes) // from double to count of minutes
        {
            dminutes += 0.0000001; // becuz need
            int hours = (int)dminutes;
            int minutes = (int) ((dminutes - Math.Truncate(dminutes )) * 100);
            int ret = hours*60 + minutes ;
            return ret;
        }

        private void randbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public class mpoint {
            
          public  int min;
          public  int max;
            public mpoint(int mn=1,int mx=2)
            {
                if (mn < 1)
                    min = 1;
                else
                  min = mn;
                if (mx < min)
                    max = min + 1;
                else
                     max = mx;
            }
            
        };

    }
}
