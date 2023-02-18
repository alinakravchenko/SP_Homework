using System;
using System.Threading;
using System.Windows.Forms;
namespace SP_HomeworkMOD3
{
    public partial class Form1 : Form
    {
        MyThread primeNumberThread;
        Thread threadState;
        public Form1()
        {
            InitializeComponent();
            primeNumberThread = new MyThread(PrimeNumber);
            threadState = new Thread(checkThreadState);
            threadState.IsBackground = true;
            threadState.Start();
        }

        private void textBoxBeginRange_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)  //цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        private void checkThreadState()
        {
            while (true)
            {
                if (labelPrimeThreadState.InvokeRequired)
                    labelPrimeThreadState.Invoke(new Action(() =>
                    {
                        labelPrimeThreadState.Text = primeNumberThread?.checkStateString();

                    }));
            }
        }

        private void buttonRunPrimeNumber_Click(object sender, EventArgs e) => primeNumberThread.Run();

        private void buttonAbortPrimeNumber_Click(object sender, EventArgs e) => primeNumberThread.Abort();
        [Obsolete]
        private void buttonSuppentPrimeNumber_Click(object sender, EventArgs e) => primeNumberThread?.Suppent();
        [Obsolete]
        private void buttonResumePrimeNumber_Click(object sender, EventArgs e) => primeNumberThread?.Resume();
        private void buttonRestartPrimeNumber_Click(object sender, EventArgs e) => primeNumberThread.Restart();



        private void PrimeNumber()
        {
            bool infinite = false;
            ulong beginRange = 0;
            ulong endRange = 0;
            if (textBoxBeginRange.Text.Length == 0)
                beginRange = 2;
            else
                beginRange = ulong.Parse(textBoxBeginRange.Text);

            if (textBoxEndRange.Text.Length > 0)
                endRange = ulong.Parse(textBoxEndRange.Text);
            else
                infinite = true;
            if (infinite == false)
            {
                if (beginRange > endRange)
                {
                    (beginRange, endRange) = (endRange, beginRange);
                }
            }
            while (infinite == true || beginRange <= endRange)
            {
                if (MyFunctions.checkPrimeNumber(beginRange))
                {
                    Thread.Sleep(1000);
                    Invoke(new Action(() =>
                    {
                        lb_primeNumber.Items.Add(beginRange);
                    }));

                }
                beginRange++;
            }
        }
        public class MyFunctions
        {
            
            // является ли число простым
            public static bool checkPrimeNumber(ulong number)
            {
                if (number < 2)
                   
                for (ulong i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public class MyThread
        {
            private Thread thread;
            private Action del;

            public MyThread(Action del) => this.del += del;
            //Запуск
            public void Run()
            {
                if ((thread == null) || (thread.ThreadState == ThreadState.Aborted)
                    || (thread.ThreadState == ThreadState.Stopped))
                {
                    ThreadStart threadStart = new ThreadStart(del);
                    thread = new Thread(threadStart);
                    thread?.Start();
                }
            }
            //Остановка потока
            public void Abort()
            {
                if (thread?.IsAlive == true && thread?.ThreadState != ThreadState.Suspended)
                    thread?.Abort();
            }

            //Приостановка потока
            
            [Obsolete]
            public void Suppent()
            {
                if (thread?.IsAlive == true)
                    thread?.Suspend();
            }

            //Возобновление работы потока
          
            [Obsolete]
            public void Resume()
            {
                if (thread?.ThreadState == ThreadState.Suspended)
                    thread?.Resume();
            }
            //Рестарт потока
            public void Restart()
            {
                if (thread?.ThreadState != ThreadState.Suspended)
                {
                    Abort();
                    Run();
                }
            }

            public bool checkState() => (thread != null) && (thread?.IsAlive == true);

            public string? checkStateString() => thread?.ThreadState.ToString();


        }
    }
}