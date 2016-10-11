using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.UiMaps.UiMapItems.ClockBox
{
    public class ClockBoxWhite : IClockBox
    {
        private readonly TestStack.White.UIItems.TextBox _hoursTextBox;
        private readonly TestStack.White.UIItems.TextBox _minutesTextBox;

        public ClockBoxWhite(TestStack.White.UIItems.TextBox hours, TestStack.White.UIItems.TextBox minutes)
        {
            this._hoursTextBox = hours;
            this._minutesTextBox = minutes;
        }

        private int Extract_Hours_From_Full_Time_String(string time)
        {
            return Convert.ToInt32(time.Split(':')[0]);
        }

        private int Extract_Minutes_From_Full_Time_String(string time)
        {
            return Convert.ToInt32(time.Split(':')[1]);
        }

        private string Join_Hours_And_Minutes_To_Full_Time_String(int hours, int minutes)
        {
            return string.Join(":", hours.ToString(), minutes.ToString());
        }

        private string Time
        {
            get
            {
                return this.Join_Hours_And_Minutes_To_Full_Time_String(int.Parse(this._hoursTextBox.Text), int.Parse(this._minutesTextBox.Text));
            }
            set
            {
                this._hoursTextBox.BulkText = this.Extract_Hours_From_Full_Time_String(value).ToString();
                this._minutesTextBox.BulkText = this.Extract_Minutes_From_Full_Time_String(value).ToString();
            }
        }

        string IClockBox.Time
        {
            get
            {
                return this.Time;
            }
            set
            {
                this.Time = value;
            }
        }
    }
}