﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinNorthwind
{
    public enum PeriodType { Day1, Day3, Week1, Month1, Month3, Month6 }

    public partial class PeriodDateTime : UserControl
    {
        public string dtFrom { 
            get { return dateTimePicker1.Value.ToString("yyyy-MM-dd"); }
            set { dateTimePicker1.Value = Convert.ToDateTime(value);   }
        }

        public string dtTo
        {
            get { return dateTimePicker2.Value.AddDays(1).ToString("yyyy-MM-dd"); }
            set { dateTimePicker2.Value = Convert.ToDateTime(value); }
        }

        public PeriodType Period
        {
            set { 
                comboBox1.Text = value.ToString();
                comboBox1_SelectedIndexChanged(null, null);
            }
        }

        public PeriodDateTime()
        {
            InitializeComponent();
        }

        private void PeriodDateTime_Load(object sender, EventArgs e)
        {
            //comboBox1.Items.Add(PeriodType.Day1);
            //comboBox1.Items.Add(PeriodType.Day3);
            //comboBox1.Items.Add(PeriodType.Week1);
            //comboBox1.Items.Add(PeriodType.Month1);
            //comboBox1.Items.Add(PeriodType.Month3);
            //comboBox1.Items.Add(PeriodType.Month6);

            foreach (PeriodType item in Enum.GetValues(typeof(PeriodType)))
            {
                comboBox1.Items.Add(item);
            }

           // comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Day1": dateTimePicker1.Value = dateTimePicker2.Value; break;
                case "Day3": dateTimePicker1.Value = dateTimePicker2.Value.AddDays(-3); break;
                case "Week1": dateTimePicker1.Value = dateTimePicker2.Value.AddDays(-7); break;
                case "Month1": dateTimePicker1.Value = dateTimePicker2.Value.AddMonths(-1); break;
                case "Month3": dateTimePicker1.Value = dateTimePicker2.Value.AddMonths(-3); break;
                case "Month6": dateTimePicker1.Value = dateTimePicker2.Value.AddMonths(-6); break;
            }
        }
    }
}
