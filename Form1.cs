using System;
using System.Threading;
using System.Windows.Forms;
using LibreHardwareMonitor.Hardware;

namespace CpuLoadApp
{
    public partial class Form1 : Form
    {
        private Computer computer;
        private Thread loadThread;
        private bool isRunning = false;
        private System.Windows.Forms.Timer timer;

        public Form1()
        {
            InitializeComponent();
            InitHardwareMonitor();
            InitTimer();
        }

        private void InitHardwareMonitor()
        {
            computer = new Computer
            {
                IsCpuEnabled = true,
                IsMotherboardEnabled = true,
                IsMemoryEnabled = true,
                IsGpuEnabled = true
            };
            computer.Open();
        }

        private void InitTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 second interval
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float cpuTemp = GetCpuTemperature();
            lblTemp.Text = cpuTemp >= 0 ? $"CPU Temp: {cpuTemp:F1} °C" : "CPU Temp: Not available";

            float cpuLoad = GetCpuLoadPercentage();
            lblCpuLoad.Text = cpuLoad >= 0 ? $"CPU Load: {cpuLoad:F1} %" : "CPU Load: Not available";
        }

        private float GetCpuTemperature()
        {
            float maxTemp = -1f;

            foreach (IHardware hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.Cpu)
                {
                    hardware.Update();

                    foreach (ISensor sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature &&
                            (sensor.Name.ToLower().Contains("core") ||
                             sensor.Name.ToLower().Contains("package")))
                        {
                            if (sensor.Value.HasValue)
                            {
                                maxTemp = Math.Max(maxTemp, sensor.Value.Value);
                            }
                        }
                    }
                }
            }

            return maxTemp;
        }


        private float GetCpuLoadPercentage()
        {
            float totalLoad = -1f;
            foreach (var hardware in computer.Hardware)
            {
                if (hardware.HardwareType == HardwareType.Cpu)
                {
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load &&
                            sensor.Name.Equals("CPU Total", StringComparison.OrdinalIgnoreCase))
                        {
                            if (sensor.Value.HasValue)
                            {
                                totalLoad = sensor.Value.Value;
                                break;
                            }
                        }
                    }
                }
            }
            return totalLoad;
        }


        private void SimulateLoad(int loadPercent, int durationSeconds)
        {
            int coreCount = Environment.ProcessorCount;
            int sleepTime = 100 - loadPercent;
            int busyTime = loadPercent;

            DateTime? endTime = durationSeconds > 0 ? DateTime.Now.AddSeconds(durationSeconds) : (DateTime?)null;

            for (int i = 0; i < coreCount; i++)
            {
                Thread t = new Thread(() =>
                {
                    while (isRunning && (!endTime.HasValue || DateTime.Now < endTime.Value))
                    {
                        var sw = System.Diagnostics.Stopwatch.StartNew();
                        while (sw.ElapsedMilliseconds < busyTime)
                        {
                            double dummy = Math.Sqrt(DateTime.Now.Ticks); // simulate load
                        }
                        Thread.Sleep(sleepTime);
                    }
                });

                t.IsBackground = true;
                t.Start();
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                isRunning = true;
                btnStartStop.Text = "Stop Load";

                int load = (int)numLoadPercentage.Value;
                int duration = chkIndefinite.Checked ? -1 : (int)numDurationSeconds.Value;

                loadThread = new Thread(() => SimulateLoad(load, duration));
                loadThread.IsBackground = true;
                loadThread.Start();
            }
            else
            {
                isRunning = false;
                btnStartStop.Text = "Start Load";
            }
        }



    }
}
