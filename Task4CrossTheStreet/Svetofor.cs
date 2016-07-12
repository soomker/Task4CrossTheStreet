using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Task4CrossTheStreet
{



    class Svetofor
    {
        Timer timer = new Timer(2000);
        
        public event EventHandler<SvetoforEvenAgs> OnLightChanged;
        //public event EventHandler<SvetoforEvenAgs> OnRedLight;
        //public event EventHandler<SvetoforEvenAgs> OnYellowLight;
        //public event EventHandler<SvetoforEvenAgs> OnGreenLight;
        public VideoCam VideoCamera
        {
            get;
            protected set;
        }

        public Svetofor()
        {
            VideoCamera = new VideoCam();
        }

        enum Light
        {
            None,
            Red,
            Yellow,
            Green
        }

        Light light = Light.None;

        public void StartSvetofor()
        {
            timer.Elapsed += ChangeLight;
            timer.Start();
        }

        public void StopSvetofor()
        {
            timer.Stop();
        }

        private void ChangeLight(object sender, ElapsedEventArgs e)
        {
            switch (light)
            {
                case Light.None:
                    light = Light.Red;
                    OnLightChanged(this, new SvetoforEvenAgs(light.ToString()));
                    break;

                case Light.Red:
                    light = Light.Yellow;
                    OnLightChanged(this, new SvetoforEvenAgs(light.ToString()));
                    break;

                case Light.Yellow:
                    light = Light.Green;
                    OnLightChanged(this, new SvetoforEvenAgs(light.ToString()));
                    break;
                case Light.Green:
                    light = Light.None;
                    break;

            }
            
        }

       
    }

}
