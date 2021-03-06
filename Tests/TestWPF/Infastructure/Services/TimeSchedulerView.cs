using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMailSender.Infastructure.Services
{
    class TimeSchedulerView
    {
        private DateTime dateTimeSchedulerView1 = new();

        public DateTime dateTimeSchedulerView
        {
            get
            {   if(dateTimeSchedulerView1== null)
                return dateTimeSchedulerView1 = DateTime.Now;

                return dateTimeSchedulerView1;
            }
            set
            {
                dateTimeSchedulerView1 = value;
            }
        }
    }
}
