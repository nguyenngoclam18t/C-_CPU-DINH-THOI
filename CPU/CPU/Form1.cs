using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBoxWriter writer = new TextBoxWriter(Console);
            System.Console.SetOut(writer);
            System.Console.WriteLine("hello");
            label3.BackColor = Color.Transparent;
            DQ.BackColor = Color.Transparent;
            KDQ.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
        }

        private void Console_TextChanged(object sender, EventArgs e)
        {

        }
        //
        public struct Process
        {
            public string id;
            public int arrival_time, burst_time, turnaround_time, exit_time, waiting_time, service_time, priority, remaining_time, i;
        }
        class ProcessInList
        {
            public Process Value { get; set; }
        }
        //
        private void fCFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thuattoan.Text = "FCFS";
            if (dgvdata.Columns["Column4"] != null)
            {
                dgvdata.Columns.Remove("Column4");
            }
        }

        private void sJFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thuattoan.Text = "SJF";
            if (dgvdata.Columns["Column4"] != null)
            {
                dgvdata.Columns.Remove("Column4");
            }
        }

        private void priorityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thuattoan.Text = "Priority";
            if (dgvdata.Columns["Column4"] == null)
            {
                dgvdata.Columns.Add("Column4", "Priority");
            }
        }

        private void roundRobinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thuattoan.Text = "RoundRobin";
            if (dgvdata.Columns["Column4"] != null)
            {
                dgvdata.Columns.Remove("Column4");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            dgvdata.AutoGenerateColumns = false;
            dgvdata.AllowUserToAddRows = false;
            dgvdata.Columns[1].ReadOnly = false;
            if (Thuattoan.Text == "Priority")
            {
                dgvdata.Rows.Insert(dgvdata.Rows.Count, new object[] { "P" + (dgvdata.Rows.Count + 1), dgvdata.Rows.Count, dgvdata.Rows.Count + 1, dgvdata.Rows.Count + 1 });
            }
            else
            {
                dgvdata.Rows.Insert(dgvdata.Rows.Count, new object[] { "P" + (dgvdata.Rows.Count + 1), dgvdata.Rows.Count, dgvdata.Rows.Count + 1 });

            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            dgvdata.AllowUserToAddRows = false;
            if (dgvdata.Rows.Count != 2 && dgvdata.Rows.Count != 0)
            {
                dgvdata.Rows.RemoveAt(dgvdata.Rows.Count - 1);
            }
            else
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process[] process = new Process[100];
            int i = 0;
            int flag = 0;
            Console.Clear();
            Console.Refresh();
            if (dgvdata.RowCount <= 1)
            {
                MessageBox.Show("Vui lòng nhập dữ liệu trước khi chạy!!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                return;
            }
            if (Thuattoan.Text == "SJF")
            {
                if (DQ.Checked == true)
                {
                    flag = 0;
                    System.Console.Write("SJF đoc quyen");
                }
                else
                {
                    flag = 1;
                    System.Console.Write("SJF khong đoc quyen");
                }
            }
            if (Thuattoan.Text == "FCFS")
            {
                flag = 2;
                System.Console.Write("FCFS");
            }
            if (Thuattoan.Text == "Priority")
            {
                if (DQ.Checked == true)
                {
                    flag = 3;
                    System.Console.Write("Priority đoc quyen");
                }
                else
                {
                    flag = 4;
                    System.Console.Write("Priority khong đoc quyn");
                }
            }
            if (Thuattoan.Text == "RoundRobin")
            {
                flag = 5;
                if (Quantum.Value <= 1)
                {
                    MessageBox.Show("Quantum phải lớn hơn 1!!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                    return;
                }
                System.Console.Write("RoundRobin");
            }
            //Take data from GridView
            if (Thuattoan.Text == "Priority")
            {
                for (int row = 0; row < dgvdata.Rows.Count; row++)
                {
                    for (int col = 0; col < dgvdata.Rows[row].Cells.Count; col++)
                    {
                        if (col == 0)
                        {
                            process[i].id = dgvdata.Rows[row].Cells[col].Value.ToString();
                        }
                        if (col == 1)
                        {
                            process[i].arrival_time = int.Parse(dgvdata.Rows[row].Cells[col].Value.ToString());
                        }
                        if (col == 2)
                        {
                            process[i].burst_time = int.Parse(dgvdata.Rows[row].Cells[col].Value.ToString());
                        }
                        if (dgvdata.Rows[row].Cells[col].Value != null)
                        {
                            if (col == 3)
                            {
                                process[i++].priority = int.Parse(dgvdata.Rows[row].Cells[col].Value.ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu đầu vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2, MessageBoxOptions.ServiceNotification);
                            return;
                        }
                    }
                }
            }
            else
            {
                for (int row = 0; row < dgvdata.Rows.Count; row++)
                {
                    for (int col = 0; col < dgvdata.Rows[row].Cells.Count; col++)
                    {
                        if (col == 0)
                        {
                            process[i].id = dgvdata.Rows[row].Cells[col].Value.ToString();
                        }
                        if (col == 1)
                        {
                            process[i].arrival_time = int.Parse(dgvdata.Rows[row].Cells[col].Value.ToString());
                        }
                        if (col == 2)
                        {
                            process[i++].burst_time = int.Parse(dgvdata.Rows[row].Cells[col].Value.ToString());
                        }
                    }
                }
            }
            GanttChart(process, dgvdata.Rows.Count, flag);
        }
        private void GanttChart(Process[] a, int n, int choose)
        {

            switch (choose)
            {
                case 0://SJF
                    SJF(a, n);
                    break;
                case 1://SRTF
                    SRTF(a, n);
                    break;
                case 2://FCFS
                    FCFS(a, n);
                    break;
                case 3://Piority Non-Preemptive
                    Priority_NonPreemptive(a, n);
                    break;
                case 4://Piority Preemptive
                    Priority_Preemptive(a, n);
                    break;
                case 5://RR
                    RoundRobin(a, n);
                    break;
            }
        }
        public static void swap<T>(ref T a, ref T b)
        {
            T tmp = a;
            a = b;
            b = tmp;
        }
        public static void arrangeArrival(Process[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i].arrival_time > a[j].arrival_time)
                    {
                        swap(ref a[i], ref a[j]);
                    }
                }
            }
        }
        public static void completionTime(Process[] a, int n)
        {
            int temp, min_idx = -1;
            //Calculate first process
            a[0].exit_time = a[0].arrival_time + a[0].burst_time;
            a[0].turnaround_time = a[0].exit_time - a[0].arrival_time;
            a[0].waiting_time = a[0].turnaround_time - a[0].burst_time;
            //Calculate all process left
            for (int i = 1; i < n; i++)
            {
                temp = a[i - 1].exit_time;
                int low = a[i].burst_time;
                //Find min
                for (int j = i; j < n; j++)
                {
                    if (temp >= a[j].arrival_time && low >= a[j].burst_time)
                    {
                        low = a[j].burst_time;
                        min_idx = j;
                    }
                }
                //Calculate min process
                a[min_idx].exit_time = temp + a[min_idx].burst_time;
                a[min_idx].turnaround_time = a[min_idx].exit_time - a[min_idx].arrival_time;
                a[min_idx].waiting_time = a[min_idx].turnaround_time - a[min_idx].burst_time;
                //Swap
                swap(ref a[min_idx], ref a[i]);
            }
        }
        public static double averageWaitingTime(Process[] a, int n)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i].waiting_time;
            }
            return sum / n;
        }
        public static void sortPID(Process[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int compare = String.Compare(a[i].id, a[j].id);
                    if (compare > 0)
                    {
                        swap(ref a[i], ref a[j]);
                    }
                }
            }
        }
        public static double sumOfTime(Process[] a, int n)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i].burst_time;
            }
            return sum;
        }
        public void SJF(Process[] a, int n)
        {

            arrangeArrival(a, n);
            completionTime(a, n);
            for (int i = 0; i < n; i++)
            {
                a[i].turnaround_time = a[i].exit_time - a[i].arrival_time;
                a[i].waiting_time = a[i].turnaround_time - a[i].burst_time;
            }
            int count = 0, remain = 0;

            sortPID(a, n);
            Console.AppendText(Environment.NewLine);
            System.Console.Write("Process ID\tWaiting Time\tTurnaround Time\n");
            for (int i = 0; i < n; i++)
            {
                Console.AppendText(Environment.NewLine);
                System.Console.Write("{0}\t\t{1}\t\t{2}", a[i].id, a[i].waiting_time, a[i].turnaround_time); ;
            }
            Console.AppendText(Environment.NewLine);
            System.Console.Write("\nAverage waiting time: {0}", averageWaitingTime(a, n));

        }
        public void SRTF(Process[] a, int n)
        {

            int xx, yy, zz;

            int[] x = new int[100];
            int i, smallest, count = 0, time, end;
            double avg = 0, tt = 0;
            for (i = 0; i < n; i++)
                x[i] = a[i].burst_time;
            //---------------------------
            //Calulating..
            x[9] = 9999; //Declare Max
            for (time = 0; count != n; time++)
            {
                smallest = 9;
                for (i = 0; i < n; i++)
                {
                    if (a[i].arrival_time <= time && x[i] < x[smallest] && x[i] > 0)
                    {
                        smallest = i;
                    }

                }
                x[smallest]--;
                if (x[smallest] == 0)
                {
                    count++;

                    end = time + 1;
                    a[smallest].exit_time = end;
                    a[smallest].turnaround_time = end - a[smallest].arrival_time;
                }
            }

            for (i = 0; i < n; i++)
            {
                a[i].waiting_time = a[i].turnaround_time - a[i].burst_time;
            }

            for (i = 0; i < n; i++)
            {
                avg = avg + a[i].waiting_time;
                tt = tt + a[i].turnaround_time;
            }
            //---------------------------

            //Show result
            Console.AppendText(Environment.NewLine);
            System.Console.Write("Process ID\tWaiting Time\tTurnaround Time\n");
            for (i = 0; i < n; i++)
            {
                Console.AppendText(Environment.NewLine);
                System.Console.Write("{0}\t\t{1}\t\t{2}", a[i].id, a[i].waiting_time, a[i].turnaround_time);
            }
            Console.AppendText(Environment.NewLine);
            System.Console.Write("\nAverage waiting time: {0}", averageWaitingTime(a, n));
        }
        public void FCFS(Process[] a, int n)
        {
            arrangeArrival(a, n);

            // waiting time for first process is 0
            a[0].service_time = a[0].arrival_time;
            a[0].waiting_time = 0;

            // calculating waiting time
            for (int i = 1; i < n; i++)
            {
                a[i].service_time = a[i - 1].service_time + a[i - 1].burst_time;
                a[i].waiting_time = a[i].service_time - a[i].arrival_time;
                if (a[i].waiting_time < 0)
                {
                    a[i].waiting_time = 0;
                }
            }
            // calculating turnaround time 
            for (int i = 0; i < n; i++)
            {
                a[i].turnaround_time = a[i].burst_time + a[i].waiting_time;
            }



            //Show result
            Console.AppendText(Environment.NewLine);
            System.Console.Write("Process ID\tWaiting Time\tTurnaround Time\n");
            for (int i = 0; i < n; i++)
            {
                Console.AppendText(Environment.NewLine);
                System.Console.Write("{0}\t\t{1}\t\t{2}", a[i].id, a[i].waiting_time, a[i].turnaround_time);
            }
            Console.AppendText(Environment.NewLine);
            System.Console.Write("\nAverage waiting time: {0}", averageWaitingTime(a, n));
        }
        public static void arrangePriority(Process[] a, int n)
        {
            for (int i = 1; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i].priority > a[j].priority)
                    {
                        swap(ref a[i], ref a[j]);
                    }
                }
            }
        }
        public void Priority_NonPreemptive(Process[] a, int n)
        {

            int xx, yy, zz, i;

            arrangePriority(a, n);
            // waiting time for first process is 0
            a[0].service_time = a[0].arrival_time;
            a[0].waiting_time = 0;
            // calculating waiting time
            for (i = 1; i < n; i++)
            {
                a[i].service_time = a[i - 1].service_time + a[i - 1].burst_time;
                a[i].waiting_time = a[i].service_time - a[i].arrival_time;
                if (a[i].waiting_time < 0)
                {
                    a[i].waiting_time = 0;
                }
            }
            // calculating turnaround time 
            for (i = 0; i < n; i++)
            {
                a[i].turnaround_time = a[i].burst_time + a[i].waiting_time;
            }

            sortPID(a, n);
            Console.AppendText(Environment.NewLine);
            System.Console.Write("Process ID\tWaiting Time\tTurnaround Time\n");
            for (i = 0; i < n; i++)
            {
                Console.AppendText(Environment.NewLine);
                System.Console.Write("{0}\t\t{1}\t\t{2}", a[i].id, a[i].waiting_time, a[i].turnaround_time); ;
            }
            Console.AppendText(Environment.NewLine);
            System.Console.Write("\nAverage waiting time: {0}", averageWaitingTime(a, n));
        }
        private void Priority_Preemptive(Process[] a, int n)
        {
            int i, smallest, count = 0, time, end;
            int[] x = new int[100];
            int[] y = new int[100];



            for (i = 0; i < n; i++)
            {
                x[i] = a[i].burst_time;
                y[i] = a[i].priority;
            }

            //Define color of Process



            //-------------------------
            //Declare max
            x[9] = 1000;
            y[9] = 10;

            for (time = 0; count != n; time++)
            {
                smallest = 9;

                for (i = 0; i < n; i++)
                {
                    if (a[i].arrival_time <= time && y[i] < y[smallest] && x[i] > 0)
                    {
                        smallest = i;

                    }
                }
                x[smallest]--;
                if (x[smallest] == 0)//Process already done
                {
                    count++;

                    end = time + 1;
                    a[smallest].exit_time = end;
                    a[smallest].turnaround_time = end - a[smallest].arrival_time;
                }

                for (i = 0; i < n; i++)
                {
                    a[i].waiting_time = a[i].turnaround_time - a[i].burst_time;
                }
            }


            //---------------------------

            //Show result
            float S_wait = 0, S_turnarround = 0;
            Console.AppendText(Environment.NewLine);
            System.Console.Write("Process ID\tWaiting Time\tTunarround Time");
            for (i = 0; i < n; i++)
            {
                Console.AppendText(Environment.NewLine);
                //Console.Write("   {0}\t    {1,10}\t\t{2,-10}\t   {3,-20}", a[i].id, a[i].arrival_time, a[i].burst_time, a[i].priority);
                System.Console.Write(" {0}\t\t", a[i].id);
                System.Console.Write(" {0}\t\t{1}", a[i].waiting_time, a[i].turnaround_time);
                S_wait += (float)a[i].waiting_time;
                S_turnarround += (float)a[i].turnaround_time;
            }
            Console.AppendText(Environment.NewLine);
            System.Console.Write("Average waiting time: {0}", S_wait / n);
            Console.AppendText(Environment.NewLine);
            System.Console.Write("Average turnarround time: {0}", S_turnarround / n);
        }
        public int NextArrivalTime(Process[] a, int current, int n)
        {
            for (int i = current + 1; i < n; i++)
            {
                if (a[i].arrival_time > a[current].arrival_time)
                {
                    return i;
                }
            }
            return -1;
        }
        public int totalTime(Process[] a, int n)
        {
            int S = 0;
            for (int i = 0; i < n; i++)
            {
                S += a[i].burst_time;
            }
            return S;
        }

        public void RoundRobin(Process[] a, int n)
        {
            int quantum = (int)Quantum.Value;


            int i, count = 0, time;
            double avg = 0, tt = 0;

            for (i = 0; i < n; i++)
            {
                a[i].i = i;
                a[i].remaining_time = a[i].burst_time;
            }

            //Define color of Process

            //---------------------------
            // sort arrvial time
            arrangeArrival(a, n);
            //---------------------------
            //Calulating..        
            i = 0;
            int current_pos, last_pos = -1;
            a[i].waiting_time = 0;
            current_pos = a[i].arrival_time;
            int next_arrival_pos = NextArrivalTime(a, i, n);

            LinkedList<Process> list = new LinkedList<Process>();//Sử dụng giống Queue :V
            list.AddLast(a[i]);
            for (int tmp = i + 1; tmp < n; tmp++)
            {
                if (a[tmp].arrival_time == a[i].arrival_time)
                {
                    list.AddLast(a[tmp]);
                }
            }

            string seq = "";
            System.Console.Write("");
            while (list.Count() != 0)
            {
                Process current = list.First();//check first position
                last_pos = current.i;//Store last position
                seq += (last_pos + 1) + "->";//Test sequence

                //Store infomations to draw Grantt chart



                list.RemoveFirst();
                next_arrival_pos = NextArrivalTime(a, i, n);//Find next process
                if (next_arrival_pos != -1)
                {
                    if (current.remaining_time <= quantum)
                    {
                        current_pos += current.remaining_time;
                        current.waiting_time = current_pos - current.burst_time - current.arrival_time;
                        current.turnaround_time = current.burst_time + current.waiting_time;

                        i++;
                        if (i >= n)
                        {
                            break;
                        }
                        list.AddLast(a[i]);
                    }
                    else
                    {
                        current_pos += quantum;
                        current.remaining_time -= quantum;
                        if (a[next_arrival_pos].arrival_time == current_pos)
                        {
                            for (int z = 0; z < n; z++)
                            {
                                if (current_pos > a[z].arrival_time && z != next_arrival_pos)
                                {
                                    list.AddLast(a[z]);
                                    i = z;
                                }
                            }
                            list.AddLast(current);
                            list.AddLast(a[next_arrival_pos]);
                            i = next_arrival_pos;
                            for (int z = next_arrival_pos + 1; z < n; z++)
                            {
                                if (a[z].arrival_time == a[next_arrival_pos].arrival_time)
                                {
                                    list.AddLast(a[z]);
                                    i = z;
                                }
                            }
                        }
                        else
                        {
                            if (a[next_arrival_pos].arrival_time < current_pos)
                            {
                                list.AddLast(a[next_arrival_pos]);
                                i = next_arrival_pos;
                                for (int z = next_arrival_pos + 1; z < n; z++)
                                {
                                    if (a[z].arrival_time < current_pos)
                                    {
                                        list.AddLast(a[z]);
                                        i = z;
                                    }
                                }
                                list.AddLast(current);

                            }
                        }
                    }
                }
                else
                {
                    if (current.remaining_time <= quantum)
                    {
                        current_pos += current.remaining_time;
                        current.waiting_time = current_pos - current.burst_time - current.arrival_time;
                        current.turnaround_time = current.burst_time + current.waiting_time;
                    }
                    else
                    {
                        current_pos += quantum;
                        current.remaining_time -= quantum;
                        list.AddLast(current);
                    }
                }

                a[last_pos] = current;
            }
            //Tính toán các thời gian trung bình
            for (i = 0; i < n; i++)
            {
                avg = avg + a[i].waiting_time;
                tt = tt + a[i].turnaround_time;
            }
            //---------------------------

            //Show result
            Console.AppendText(Environment.NewLine);
            System.Console.Write("Process ID\tWaiting Time\tTurnaround Time\n");
            for (i = 0; i < n; i++)
            {
                Console.AppendText(Environment.NewLine);
                System.Console.Write("{0}\t\t{1}\t\t{2}", a[i].id, a[i].waiting_time, a[i].turnaround_time);
            }
            Console.AppendText(Environment.NewLine);
            System.Console.Write("\nAverage waiting time: {0}", averageWaitingTime(a, n));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Clear();
            Console.Refresh();
        }

        private void DQ_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }

}
