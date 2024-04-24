using System;
using System.Collections.Generic;
using System.Text;

namespace TrafficSimulator{

    class sTimer
    {
        private static System.Timers.Timer aTimer;
        //private GUI gui;
        private static Simulation sim;
        private static Map map;
        private static CharMatrix cm;
        private static IPrintDriver cp;
        private static int max_num_runs = 30;
        private static int run_count = 0;
        private static int interval = 1;

        public sTimer(double duration, Simulation in_sim, Map in_map, CharMatrix in_cm, IPrintDriver in_cp, int time_running) {
            aTimer = new System.Timers.Timer(1000);
            sim = in_sim;
            map = in_map;
            cm = in_cm;
            cp = in_cp;
            max_num_runs = time_running;
        }

        public void runSimulation() {
            map.Print(cp, cm);
            for (int i = 0; i < Constants.CharMapSize; i++)
            {
                string s = new string(cm.map[i]);
                Console.WriteLine(s);
            }
            aTimer.Elapsed += timer_elapsed;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            aTimer.Start();
            Console.ReadKey();
        }

        private static void timer_elapsed(Object o, System.Timers.ElapsedEventArgs e) {
            run_count++;
            Console.Clear();
            sim.Update(interval);
            map.Print(cp,cm);
            for (int i = 0; i < Constants.CharMapSize; i++)
            {
                string s = new string(cm.map[i]);
                Console.WriteLine(s);
            }
            if (run_count >= max_num_runs) {
                aTimer.Stop();
                Console.WriteLine("Press any key to end the program.");
            }
        }
    }
}