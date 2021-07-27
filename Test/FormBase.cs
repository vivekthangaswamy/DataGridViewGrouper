using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    //this base form only contains the layout with the grid and some test data

    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
            dataGridView1.DataSource = createtestdata();
        }

        /// <summary>
        /// returns a collection of random test data (gibberish)
        /// </summary>
        BindingList<TestData> createtestdata()
        {
            var list = new BindingList<TestData>();

            var rnd = new Random();
            var dt = DateTime.Today;

            for (int i = 0; i < 100; i++)
            {
                list.Add(
                    new TestData
                    {
                        AString = new string((char)('A' + rnd.Next(0, 25)), 8),
                        ADate = dt.AddDays(rnd.Next(-100, 100)),
                        AnInt = rnd.Next(0,50)
                    }
                    );
            };
            return list;
        }
    }

    public class TestData:INotifyPropertyChanged
    {
        string str;
        public string AString { get { return str; } set { str = value; NotifyChanged("AString"); } }
        DateTime? dt;
        public DateTime? ADate { get { return dt; } set { dt = value; NotifyChanged("ADate"); } }
        int i;
        public int AnInt { get { return i; } set { i = value; NotifyChanged("AnInt"); } }

        void NotifyChanged(string prop){
            if(PropertyChanged!=null)
                PropertyChanged(this,new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
