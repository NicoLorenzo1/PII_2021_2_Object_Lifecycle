using System;

namespace ClassLibrary
{
    public class Train
    {
        /// <summary>
        /// Variable de instancia con la que se van a identificar los trenes.
        /// </summary>
        /// <value></value>
        private string train { get; set; }

        //Constructor de la clase Train
        public Train(string train)
        {
            this.train = train;
            count++;
        }

        private static int count = 0;

        /// <summary>
        /// Metodo get y set para obtener o modificarla variable count
        /// </summary>
        /// <value></value>
        public static int Counter
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        //Destructor de objeto 
        ~Train()
        {
            count--;
        }


        /// <summary>
        /// Obtiene un valor que indica si las maquinas del tren han sido encendidas o no.
        /// </summary>
        /// <value><c>true</c> si las máquinas fueron encendidas, <c>false</c> en caso contrario.</value>
        public bool IsEngineStarted { get; private set; }

        /// <summary>
        /// Enciende las máquinas del tren.
        /// </summary>
        /// <returns>
        /// <c>true</c> si las máquinas pueden ser encendidas, <c>false</c> en caso contrario.
        /// </returns>
        public bool StartEngines()
        {
            if (this.IsEngineStarted)
            {
                Console.Write("The engines are already running");
                return false;
            }

            this.IsEngineStarted = true;
            Console.Write("Engines on");
            return true;
        }

        /// <summary>
        /// Detiene las máquinas del tren.
        /// </summary>
        /// <returns>
        /// <c>true</c> si las máquinas pueden ser detenidas, <c>false</c> en caso contrario.
        /// </returns>
        public bool StopEngines()
        {
            if (this.IsEngineStarted)
            {
                this.IsEngineStarted = false;
                Console.Write("Engines off");
                return true;
            }

            Console.Write("The engines are already stopped");
            return this.IsEngineStarted;
        }
    }
}