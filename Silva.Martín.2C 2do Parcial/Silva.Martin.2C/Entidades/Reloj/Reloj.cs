namespace Entidades
{
    public delegate void ClockDelegado();
    public class Reloj
    {
        private int interval;
        private bool isCorriendo;
        public event ClockDelegado ClockEvn;

        public Reloj(int interval)
        {
            this.isCorriendo = false;
            this.interval = interval;
        }

        public void Run()
        {
            this.isCorriendo = true;
            do
            {
                System.Threading.Thread.Sleep(this.interval);
                this.ClockEvn();
            } while (this.isCorriendo);
        }

    }
}
